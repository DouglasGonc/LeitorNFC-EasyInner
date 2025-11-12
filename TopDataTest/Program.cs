using EasyInnerSDK;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;

public static class Enumeradores
{
    public enum Retorno { RET_COMANDO_OK = 0, RET_ERRO = 1 }
}

public class Inner
{
    public int Numero { get; set; } // Número do Inner (1 a 99)
    public Inner(int numeroInner)
    {
        Numero = numeroInner;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Iniciando integração Topdata - teste leitor 125kHz");

        // 1) Definir tipo de conexão: TCP/IP (2)
        int ret = EasyInner.DefinirTipoConexao(2);
        if (ret != (int)Enumeradores.Retorno.RET_COMANDO_OK)
        {
            Console.WriteLine($"Erro DefinirTipoConexao: {ret}");
            return;
        }

        // 2) Abrir porta de comunicação (padrão 3570)
        int porta = 3570;
        ret = EasyInner.AbrirPortaComunicacao(porta);
        if (ret != (int)Enumeradores.Retorno.RET_COMANDO_OK)
        {
            Console.WriteLine($"Erro AbrirPortaComunicacao({porta}): {ret}");
            return;
        }
        Console.WriteLine($"Porta {porta} aberta com sucesso. Aguardando dispositivos...");

        // 3) Configurar inner em modo online (se aplicável)
        ret = EasyInner.ConfigurarInnerOnLine();
        Console.WriteLine($"ConfigurarInnerOnline -> {ret}");

        // 4) Configurar tipo de leitor para proximidade (valor 2 conforme manual)
        ret = EasyInner.ConfigurarTipoLeitor(2);
        Console.WriteLine($"ConfigurarTipoLeitor(2) -> {ret}");

        // (Opcional) definir quantidade de dígitos
        EasyInner.DefinirQuantidadeDigitosCartao(14);

        Console.WriteLine("Entrando em loop de ReceberDadosOnLine() - pressione Ctrl+C para parar.");

        List<Inner> _leitoresAcesso = new List<Inner>();
        _leitoresAcesso.Add(new Inner(1)); // Adiciona catraca 1
        _leitoresAcesso.Add(new Inner(2)); // Adiciona catraca 2

        var sbCartao = new StringBuilder(20);
        while (true)
        {
            foreach (Inner leitor in _leitoresAcesso)
            {
                try
                {
                    int inner = leitor.Numero;
                    byte origem = 0, compl = 0;
                    byte dia = 0, mes = 0, ano = 0, hora = 0, minuto = 0, segundo = 0;

                    sbCartao.Clear();
                    ret = EasyInner.ReceberDadosOnLine(
                        inner,
                        ref origem,
                        ref compl,
                        sbCartao,
                        ref dia, ref mes, ref ano,
                        ref hora, ref minuto, ref segundo
                    );

                    if (ret == (int)Enumeradores.Retorno.RET_COMANDO_OK)
                    {
                        string cartao = sbCartao.ToString().Trim().Substring(0, 14);
                        Console.WriteLine(
                            $"Leitor {inner} : [{hora:00}:{minuto:00}:{segundo:00}] Origem={origem} Comp={compl} Cartao={cartao}"
                        );

                        EasyInner.LigarLedVerde(inner);
                        EasyInner.AcionarBipCurto(inner);
                        EasyInner.DesligarLedVerde(inner);

                        // Reconfigura formas de entrada após cada evento (recomendação da própria DLL)
                        EasyInner.EnviarFormasEntradasOnLine(inner, 0, 0, 2, 10, 1);
                    }
                    else
                    {
                        // sem evento / timeout / outro código — fazer ping para não perder conexão
                        // se tiver o numeroInner correto, passe-o; aqui usamos 1 como exemplo.
                        EasyInner.PingOnLine(inner);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro no loop: " + ex.Message);
                }
            }
            Thread.Sleep(50);
        }
    }
}
