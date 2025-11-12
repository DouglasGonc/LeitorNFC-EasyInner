using System;
using System.Runtime.InteropServices;
using System.Text;

namespace LeitorNFC_EasyInner.Interop
{
    internal static class EasyInnerInterop
    {
        private const string EasyInnerDll = "EasyInner.dll";

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern int DefinirTipoConexao(int tipo);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern System.IntPtr AbrirPortaComunicacao(int porta);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void FecharPortaComunicacao();

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern System.IntPtr ConfigurarInnerOnLine();

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern int ConfigurarTipoLeitor(int tipoLeitor);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern int DefinirQuantidadeDigitosCartao(int quantidade);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern int PingOnLine(int inner);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        public static extern int ReceberDadosOnLine(
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
        public static extern int EnviarFormasEntradasOnLine(
            int inner,
            int habilitaEntrada,
            int habilitaSaida,
            int tipoTeclado,
            int tempoTeclado,
            int habilitaMudanca);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern int LigarLedVerde(int inner);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern int DesligarLedVerde(int inner);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern int AcionarBipCurto(int inner);

        [DllImport(EasyInnerDll, CallingConvention = CallingConvention.Winapi)]
        public static extern System.IntPtr DefinirPadraoCartao(int padrao);

    }
}
