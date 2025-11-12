using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LeitorNFC_EasyInner.Interop;

namespace LeitorNFC_EasyInner
{
    public partial class LeitorNFC : MaterialForm
    {
        private const int RetornoOk = 0;
        private const byte TipoConexaoTcpIpPortaFixa = 2;
        private const byte TipoLeitorProximidadeAbatrack2 = 2;
        private const byte PadraoCartaoLivre = 1;
        private const byte QuantidadeDigitosCartao = 14;
        private const byte HabilitacaoEntradaPadrao = 0;
        private const byte HabilitacaoSaidaPadrao = 0;
        private const byte TipoTecladoPadrao = 2;
        private const byte TempoTecladoPadrao = 10;
        private const byte HabilitaMudancaOnline = 1;
        private const int LimiteLeiturasGrid = 200;

        private bool _portaAberta;
        private bool _innerConectado;
        private bool _monitorando;
        private int _portaAtual;
        private int _innerAtual;

        private readonly List<int> _leitoresAcesso;
        private readonly BindingList<LeituraGrid> _leituras;
        private readonly System.Windows.Forms.Timer _timerLeitura;
        private readonly StringBuilder _bufferCartao;

        public LeitorNFC()
        {
            InitializeComponent();
            btnConectar.Text = "CONECTAR";

            _leitoresAcesso = new List<int>();
            _leituras = new BindingList<LeituraGrid>();
            _timerLeitura = new System.Windows.Forms.Timer { Interval = 75 };
            _timerLeitura.Tick += TimerLeituraTick;
            _bufferCartao = new StringBuilder(32);

            ConfigurarGridLeituras();
        }

        private void ConfigurarGridLeituras()
        {
            dgvLeituras.AutoGenerateColumns = false;
            dgvLeituras.Columns.Clear();

            dgvLeituras.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(LeituraGrid.Inner),
                HeaderText = "Inner",
                Width = 60,
                ReadOnly = true
            });

            dgvLeituras.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(LeituraGrid.Horario),
                HeaderText = "Horário",
                Width = 80,
                ReadOnly = true
            });

            dgvLeituras.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(LeituraGrid.Origem),
                HeaderText = "Origem",
                Width = 70,
                ReadOnly = true
            });

            dgvLeituras.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(LeituraGrid.Complemento),
                HeaderText = "Compl.",
                Width = 70,
                ReadOnly = true
            });

            dgvLeituras.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(LeituraGrid.Cartao),
                HeaderText = "Cartão",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });

            dgvLeituras.DataSource = _leituras;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (_innerConectado)
            {
                DesconectarInner();
            }
            else
            {
                ConectarInner();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!_innerConectado)
            {
                LogErro("Conecte ao Inner antes de iniciar a leitura online.");
                return;
            }

            if (_monitorando)
            {
                LogInfo("A leitura online já está ativa.");
                return;
            }

            if (!TryDefinirLeitoresAcesso())
            {
                return;
            }

            _monitorando = true;
            _timerLeitura.Start();

            // habilita leitor/proximidade e timeouts antes da 1ª leitura
            int inner = _leitoresAcesso[0];
            int ret = EasyInnerInterop.EnviarFormasEntradasOnLine(
                inner,
                HabilitacaoEntradaPadrao,   // 0
                HabilitacaoSaidaPadrao,     // 0
                TipoTecladoPadrao,          // 2 (proximidade)
                TempoTecladoPadrao,         // 10 (1s)
                HabilitaMudancaOnline       // 1
            );
            if (ret != 0)
            {
                LogErro("EnviarFormasEntradasOnLine inicial retornou " + ret + ".");
            }

            LogSucesso("Leitura online iniciada para o Inner " + _leitoresAcesso[0] + ".");
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if (!_monitorando)
            {
                LogInfo("Nenhuma leitura online em andamento para interromper.");
                return;
            }

            PararLeitura(false);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            _leituras.Clear();
            logRichControle.Clear();
            LogInfo("Histórico de leituras e logs limpo.");
        }

        private void ConectarInner()
        {
            int numeroInner;
            if (!TryObterNumeroInner(out numeroInner))
            {
                return;
            }

            int porta;
            if (!TryObterPorta(out porta))
            {
                return;
            }

            LogInfo("Iniciando conexão com o Inner " + numeroInner + " na porta " + porta + ".");

            try
            {
                int retorno = EasyInnerInterop.DefinirTipoConexao(TipoConexaoTcpIpPortaFixa);
                if (!ValidarRetorno("DefinirTipoConexao(2)", retorno))
                {
                    return;
                }

                retorno = EasyInnerInterop.AbrirPortaComunicacao(porta);
                if (!ValidarRetorno("AbrirPortaComunicacao(" + porta + ")", retorno))
                {
                    return;
                }
                LogInfo("Porta " + porta + " aberta. Aguardando resposta do Inner...");

                _portaAberta = true;
                _portaAtual = porta;

                retorno = EasyInnerInterop.ConfigurarInnerOnLine();
                if (!ValidarRetorno("ConfigurarInnerOnLine", retorno))
                {
                    FecharPortaInterno();
                    return;
                }

                retorno = EasyInnerInterop.ConfigurarTipoLeitor(TipoLeitorProximidadeAbatrack2);
                if (!ValidarRetorno("ConfigurarTipoLeitor(2)", retorno))
                {
                    FecharPortaInterno();
                    return;
                }

                retorno = EasyInnerInterop.DefinirPadraoCartao(PadraoCartaoLivre);
                if (!ValidarRetorno("DefinirPadraoCartao(" + PadraoCartaoLivre + ")", retorno))
                {
                    FecharPortaInterno();
                    return;
                }

                retorno = EasyInnerInterop.DefinirQuantidadeDigitosCartao(QuantidadeDigitosCartao);
                if (!ValidarRetorno("DefinirQuantidadeDigitosCartao(" + QuantidadeDigitosCartao + ")", retorno))
                {
                    FecharPortaInterno();
                    return;
                }

                retorno = EasyInnerInterop.EnviarFormasEntradasOnLine(
                    numeroInner,
                    HabilitacaoEntradaPadrao,
                    HabilitacaoSaidaPadrao,
                    TipoTecladoPadrao,
                    TempoTecladoPadrao,
                    HabilitaMudancaOnline);
                if (!ValidarRetorno("EnviarFormasEntradasOnLine inicial", retorno))
                {
                    FecharPortaInterno();
                    return;
                }

                if (!AguardarPingDoInner(numeroInner))
                {
                    LogErro("O Inner não respondeu ao Ping após múltiplas tentativas. Verifique cabeamento, alimentação e IP configurado.");
                    FecharPortaInterno();
                    return;
                }

                _innerConectado = true;
                _innerAtual = numeroInner;
                btnConectar.Text = "DESCONECTAR";
                LogSucesso("Inner " + numeroInner + " conectado com sucesso.");
            }
            catch (DllNotFoundException dllEx)
            {
                LogErro("EasyInner.dll não encontrada: " + dllEx.Message);
                FecharPortaInterno();
            }
            catch (Exception ex)
            {
                LogErro("Erro ao conectar: " + ex.Message);
                FecharPortaInterno();
            }
        }

        private void DesconectarInner()
        {
            PararLeitura(true);

            try
            {
                if (_portaAberta)
                {
                    EasyInnerInterop.FecharPortaComunicacao();
                    LogInfo("Porta de comunicação fechada (" + _portaAtual + ").");
                }
            }
            catch (DllNotFoundException dllEx)
            {
                LogErro("EasyInner.dll não encontrada ao desconectar: " + dllEx.Message);
            }
            catch (Exception ex)
            {
                LogErro("Erro ao desconectar: " + ex.Message);
            }
            finally
            {
                _portaAberta = false;
                _innerConectado = false;
                _monitorando = false;
                _portaAtual = 0;
                _innerAtual = 0;
                _leitoresAcesso.Clear();
                btnConectar.Text = "CONECTAR";
                LogInfo("Conexão finalizada.");
            }
        }

        private void TimerLeituraTick(object sender, EventArgs e)
        {
            for (int i = 0; i < _leitoresAcesso.Count; i++)
            {
                int inner = _leitoresAcesso[i];
                byte origem = 0;
                byte complemento = 0;
                byte dia = 0;
                byte mes = 0;
                byte ano = 0;
                byte hora = 0;
                byte minuto = 0;
                byte segundo = 0;

                _bufferCartao.Clear();

                try
                {
                    int retorno = EasyInnerInterop.ReceberDadosOnLine(
                        inner,
                        ref origem,
                        ref complemento,
                        _bufferCartao,
                        ref dia,
                        ref mes,
                        ref ano,
                        ref hora,
                        ref minuto,
                        ref segundo);

                    if (retorno == RetornoOk)
                    {
                        string cartao = NormalizarCartao(_bufferCartao.ToString());
                        RegistrarLeitura(inner, cartao, origem, complemento, hora, minuto, segundo);

                        EasyInnerInterop.LigarLedVerde(inner);
                        EasyInnerInterop.AcionarBipCurto(inner);
                        EasyInnerInterop.DesligarLedVerde(inner);
                        EasyInnerInterop.EnviarFormasEntradasOnLine(
                            inner,
                            HabilitacaoEntradaPadrao,
                            HabilitacaoSaidaPadrao,
                            TipoTecladoPadrao,
                            TempoTecladoPadrao,
                            HabilitaMudancaOnline);
                    }
                    else
                    {
                        EasyInnerInterop.PingOnLine(inner);
                    }
                }
                catch (DllNotFoundException dllEx)
                {
                    LogErro("EasyInner.dll não encontrada durante a leitura: " + dllEx.Message);
                    PararLeitura(true);
                    return;
                }
                catch (Exception ex)
                {
                    LogErro("Erro ao receber dados do Inner " + inner + ": " + ex.Message);
                    PararLeitura(true);
                    return;
                }
            }
        }

        private void PararLeitura(bool silencioso)
        {
            if (!_monitorando)
            {
                return;
            }

            _timerLeitura.Stop();
            _monitorando = false;

            if (!silencioso)
            {
                LogInfo("Leitura online interrompida.");
            }
        }

        private bool TryDefinirLeitoresAcesso()
        {
            int numeroInner;
            if (!TryObterNumeroInner(out numeroInner))
            {
                return false;
            }

            _leitoresAcesso.Clear();
            _leitoresAcesso.Add(numeroInner);
            return true;
        }

        private void RegistrarLeitura(int inner, string cartao, byte origem, byte complemento, byte hora, byte minuto, byte segundo)
        {
            string horario = string.Format("{0:00}:{1:00}:{2:00}", hora, minuto, segundo);
            _leituras.Add(new LeituraGrid
            {
                Inner = inner,
                Horario = horario,
                Origem = origem,
                Complemento = complemento,
                Cartao = cartao
            });

            if (_leituras.Count > LimiteLeiturasGrid)
            {
                _leituras.RemoveAt(0);
            }
        }

        private static string NormalizarCartao(string cartao)
        {
            if (string.IsNullOrWhiteSpace(cartao))
            {
                return string.Empty;
            }

            string resultado = cartao.Trim();
            if (resultado.Length > QuantidadeDigitosCartao)
            {
                return resultado.Substring(0, QuantidadeDigitosCartao);
            }

            return resultado;
        }

        private bool AguardarPingDoInner(int numeroInner)
        {
            const int tentativasMaximas = 20;
            for (int tentativa = 1; tentativa <= tentativasMaximas; tentativa++)
            {
                int retornoPing = EasyInnerInterop.PingOnLine(numeroInner);
                if (retornoPing == RetornoOk)
                {
                    LogInfo("PingOnLine(" + numeroInner + ") OK na tentativa " + tentativa + ".");
                    return true;
                }

                LogInfo("PingOnLine(" + numeroInner + ") tentativa " + tentativa + " retornou " + retornoPing + ".");
                Thread.Sleep(150);
            }

            return false;
        }

        private void FecharPortaInterno()
        {
            PararLeitura(true);

            if (!_portaAberta)
            {
                return;
            }

            try
            {
                EasyInnerInterop.FecharPortaComunicacao();
                LogInfo("Porta de comunicação fechada (" + _portaAtual + ").");
            }
            catch (DllNotFoundException dllEx)
            {
                LogErro("EasyInner.dll não encontrada ao fechar porta: " + dllEx.Message);
            }
            catch (Exception ex)
            {
                LogErro("Erro ao fechar porta: " + ex.Message);
            }
            finally
            {
                _portaAberta = false;
                _portaAtual = 0;
            }
        }

        private bool TryObterNumeroInner(out int numeroInner)
        {
            if (!int.TryParse(txtNumeroInner.Text.Trim(), out numeroInner) || numeroInner < 1 || numeroInner > 99)
            {
                LogErro("Informe um número do Inner válido (1 a 99).");
                numeroInner = 0;
                return false;
            }

            return true;
        }

        private bool TryObterPorta(out int porta)
        {
            if (!int.TryParse(txtPorta.Text.Trim(), out porta) || porta < 1 || porta > 65535)
            {
                LogErro("Informe uma porta TCP/IP válida (1 a 65535).");
                porta = 0;
                return false;
            }

            return true;
        }

        private bool ValidarRetorno(string operacao, int retorno)
        {
            if (retorno == RetornoOk)
            {
                LogInfo(operacao + " retornou 0");
                return true;
            }

            LogErro(operacao + " retornou " + retorno + ".");
            return false;
        }

        private void LogInfo(string mensagem)
        {
            AppendLog(mensagem, Color.RoyalBlue);
        }

        private void LogSucesso(string mensagem)
        {
            AppendLog(mensagem, Color.ForestGreen);
        }

        private void LogErro(string mensagem)
        {
            AppendLog(mensagem, Color.DarkRed);
        }

        private void AppendLog(string mensagem, Color cor)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, Color>(AppendLog), new object[] { mensagem, cor });
                return;
            }

            logRichControle.AppendTextEx(mensagem, cor);
        }

        private sealed class LeituraGrid
        {
            public int Inner { get; set; }

            public string Horario { get; set; }

            public byte Origem { get; set; }

            public byte Complemento { get; set; }

            public string Cartao { get; set; }
        }
    }
}
