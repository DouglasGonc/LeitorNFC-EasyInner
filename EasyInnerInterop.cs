using System;
using System.Runtime.InteropServices;
using System.Text;

namespace LeitorNFC_EasyInner.Interop
{
    internal static class EasyInnerInterop
    {
        private const string EasyInnerDll = "EasyInner.dll";

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern byte DefinirTipoConexao(byte tipo);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern byte AbrirPortaComunicacao(int porta);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void FecharPortaComunicacao();

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern byte ConfigurarInnerOnLine();

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern byte ConfigurarTipoLeitor(byte tipoLeitor);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern byte DefinirQuantidadeDigitosCartao(byte quantidade);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern byte PingOnLine(int inner);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern byte ReceberDadosOnLine(
            int inner,
            ref byte origem,
            ref byte complemento,
            StringBuilder cartao,
            ref byte dia,
            ref byte mes,
            ref byte ano,
            ref byte hora,
            ref byte minuto,
            ref byte segundo);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern byte EnviarFormasEntradasOnLine(
            int inner,
            byte habilitaEntrada,
            byte habilitaSaida,
            byte tipoTeclado,
            byte tempoTeclado,
            byte habilitaMudanca);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern byte LigarLedVerde(int inner);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern byte DesligarLedVerde(int inner);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern byte AcionarBipCurto(int inner);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern byte DefinirPadraoCartao(byte padrao);

    }
}
