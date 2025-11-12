# Diretrizes do Projeto de Teste — EasyInner Lab

Este projeto foi criado exclusivamente para testar e validar a comunicação com o equipamento Inner Acesso 2 / Prox / NFC utilizando a SDK EasyInner da Topdata.

Ambiente e versões
- **.NET Framework**: 4.8 (WinForms clássica, sem recursos exclusivos de .NET Core / .NET 5+).
- **Versão máxima de C#**: 7.3. Evite sintaxes introduzidas em C# 8 ou superior (ex.: `is not`, `switch` com padrões avançados, `using var`, tipos anuláveis com `?` em referências etc.).
- **MaterialSkin**: 2.2.3.1 (MaterialSkin.dll carregada via packages\MaterialSkin.2.2.3.1\lib\net48).
- **SDK de comunicação**: EasyInner.dll e classes‐wrapper de C#Completo.zip (EasyInner.cs, Enumeradores.cs).


## Estrutura funcional

### Objetivo

O formulário principal (WinForms com MaterialSkin) executa três funções básicas:


| Elemento       | Tipo             | Nome             | Observação                |
| -------------- | ---------------- | ---------------- | ------------------------- |
| Porta          | MaterialTextBox2 | `txtPorta`       | Padrão 3570               |
| Nº do Inner    | MaterialTextBox2 | `txtNumeroInner` | Ex.: 1                    |
| Botão Conectar | MaterialButton   | `btnConectar`    | Executa teste de conexão  |
| Botão Iniciar  | MaterialButton   | `btnIniciar`     | Iniciará leitura online   |
| Botão Parar    | MaterialButton   | `btnParar`       | Interrompe leitura        |
| Botão Limpar   | MaterialButton   | `btnLimpar`      | Limpa logs                |
| Log            | logRichTextBox   | `logRichControle`| Verificação de Logs       |
| informativo    | Label            | `rtbLog`         | Registro textual          |
| Leituras       | DataGridView     | `dgvLeituras`    | Exibição de cartões lidos |
Campo de IP (`txtIpLeitor`) **é apenas informativo** e **não é usado** pela SDK.  
O Inner deve estar configurado via Web Server para conectar-se ao IP da máquina que roda este programa, porta 3570.

## Configurações fixas

Todos os parâmetros de configuração são **pré-definidos no código**, não editáveis em tela: pegar mesmos do exemplo

Não há botões **Incluir na Lista** ou **Remover da Lista**.  
O objetivo é testar operação **online** pura.



## 3 Configuração Inicial e Conectividade

Antes de sua aplicação começar a interagir com as catracas Topdata, é essencial garantir que os equipamentos estejam corretamente configurados na rede e que seu software esteja preparado para estabelecer a comunicação. Este capítulo detalha as configurações de hardware e os primeiros comandos da EasyInner.dll para iniciar a conectividade.

### 3.1 Configuração de Rede da Catraca (Hardware)

Para que sua aplicação possa se comunicar com as catracas, cada equipamento precisa estar corretamente configurado na rede TCP/IP. Esta configuração é geralmente feita diretamente no equipamento, antes de iniciar a aplicação de integração.

#### 3.1.1 Endereçamento IP

Cada catraca (seja Linha 3, Linha 4, Expedidora ou com Urna) deve possuir um endereço IP único na rede local. A escolha entre IP Fixo e DHCP depende da sua infraestrutura e necessidades:

- IP Fixo (Recomendado): Atribua um endereço IP estático e exclusivo para cada catraca. Isso é altamente recomendado para dispositivos de infraestrutura como catracas, pois garante que o endereço IP nunca mude, facilitando a comunicação e o troubleshooting.

- DHCP: A catraca pode obter um endereço IP automaticamente de um servidor DHCP na rede. Se optar por DHCP, é aconselhável configurar uma reserva de IP (DHCP Reservation) no seu servidor DHCP. Isso garante que a catraca sempre receba o mesmo endereço IP, mesmo que ele seja atribuído dinamicamente.


**Máscara de Sub-rede e Gateway:**

Configure a **Máscara de Sub-rede** e o **Gateway Padrão** de cada catraca de acordo com os parâmetros da rede local onde elas estão instaladas. Isso é crucial para que as catracas possam se comunicar dentro da rede e, se necessário, alcançar o servidor onde sua aplicação está rodando (especialmente se estiverem em sub-redes diferentes ou em nuvem via VPN).

#### 3.1.2 IP do Servidor e Porta de Comunicação

Este é um dos pontos mais críticos da configuração:

- IP do Servidor: Em cada catraca, você precisa configurar o endereço IP do servidor onde o seu Software de Integração (que utiliza a SDK Inner Acesso) estará rodando. É para este IP que a catraca tentará se conectar para enviar eventos e receber comandos.
- Porta TCP: Configure também a porta TCP que seu software escutará. O padrão da EasyInner.dll para comunicação com catracas é a porta 3570. Certifique-se de que a porta configurada na catraca seja a mesma que sua aplicação escutará.

#### 3.1.3 Número do Inner

Cada catraca na rede deve ter um **Número do Inner** único. Este número, que pode variar de **1 a 99** , é utilizado pela EasyInner.dll para identificar qual equipamento está se comunicando ou para qual equipamento um comando específico deve ser enviado.

É importante ressaltar que o Número do Inner é **independente da configuração da porta TCP/IP**. Ou seja, você pode ter várias catracas conectadas à mesma porta do seu servidor (ex: 3570), e cada uma será identificada pelo seu Número do Inner exclusivo.

#### 3.1.4 Como Configurar (Menu da Catraca ou WebServer)

Os parâmetros de rede (IP da catraca, Máscara, Gateway, IP do Servidor, Porta TCP, Número do Inner) são configurados de duas maneiras principais:

- Diretamente pelo Menu da Catraca: Todos os modelos de catraca Topdata possuem um menu de configurações acessível pelo display e teclado. Navegue pelas opções de rede para inserir os dados.
- **Via Interface Web (WebServer - Somente Catracas Linha 4):** As catracas da Linha 4 (modelos com placa "Controle Catraca", como Fit 4, Revolution 4, Box 4) possuem um WebServer embarcado. Isso permite acessar e configurar os parâmetros de rede e outras funcionalidades diretamente de um navegador web.
- Para acessar: Digite http://[IP_DA_CATRACA] na barra de endereços do seu navegador.


### 3.2 Configuração de Rede do Servidor (Software)

Além das catracas, o ambiente onde seu Software de Integração está rodando também precisa de configurações de rede adequadas.

#### 3.2.1 Liberação de Portas no Firewall

É fundamental que a porta TCP que sua aplicação estará escutando (padrão 3570) esteja liberada para **conexões de entrada** em qualquer firewall que possa existir entre as catracas e o seu servidor. Isso inclui:

- Firewall do Sistema Operacional (Windows Firewall): No servidor onde sua aplicação está rodando, crie uma regra de entrada para permitir o tráfego na porta 3570 (ou a porta que você escolheu).
- Firewall de Rede (Hardware): Se houver um firewall físico ou um roteador com firewall ativo na sua rede, certifique-se de que a porta 3570 esteja liberada e, se necessário, que haja um redirecionamento de porta (port forwarding) configurado para o IP interno do seu servidor.
- Firewall da Rede da Catraca: O firewall da rede onde o leitor facial (se houver) está localizado também deve permitir a saída de tráfego para o IP público do servidor nessa mesma porta.
### 3.3 Estabelecendo a Conexão via SDK Inner Acesso

Com as catracas configuradas na rede e o ambiente do servidor preparado, o próximo passo é iniciar a comunicação a partir do seu Software de Integração utilizando a EasyInner.dll.

#### 3.3.1 EasyInner.DefinirTipoConexao()

Esta função informa à EasyInner.dll qual o meio de comunicação será utilizado para interagir com os equipamentos. Para a comunicação em rede (TCP/IP), o valor a ser passado é 2 (TCP/IP com Porta Fixa, onde a catraca se conecta ao servidor).

**Sintaxe (C#):**

```cshatp

// Define o tipo de conexão como TCP/IP com Porta Fixa

// (onde a catraca se conecta ao servidor)
int ret = EasyInner.DefinirTipoConexao( 2 );

if (ret != (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
// Tratar erro: não foi possível definir o tipo de conexão
Console.WriteLine("Erro ao definir o tipo de conexão: " + ret);
// Sua máquina de estados deve lidar com este erro
}
```

#### 3.3.2 EasyInner.AbrirPortaComunicacao()

Após definir o tipo de conexão, esta função instrui a EasyInner.dll a começar a "escutar" por tentativas de conexão das catracas na porta TCP especificada. Esta função deve ser chamada **apenas uma vez** no início da sua aplicação, para abrir a porta do servidor.

- Propósito: Abrir a porta de comunicação desejada (TCP/IP, serial, etc.) para que a EasyInner.dll possa enviar e receber dados dos equipamentos.

- **Parâmetros (C#):**
```cshatp
EasyInner.AbrirPortaComunicacao(int Porta); // [Entrada] Número da porta serial ou TCP/IP (padrão 3570 para
TCP/IP)
```

- **Retornos:** Esta função pode retornar os seguintes códigos:
	- 0 ou RET_COMANDO_OK: A porta de comunicação foi aberta com sucesso.
	- 1 ou RET_ERRO: Erro genérico ao tentar abrir a porta.
	- 2: A porta de comunicação não foi aberta (pode indicar um problema específico ao tentar acessar o recurso da porta).
	- 3: A porta de comunicação já está aberta (indica que a função foi chamada novamente sem fechar a porta anteriormente, ou que outro processo já a está utilizando).
	- 8: Erro GPF (General Protection Fault) dentro da DLL. Este erro é crítico e pode ser causado por:
		- EasyInner.dll não registrada corretamente no sistema (embora o instalador da SDK Inner Acesso geralmente faça isso automaticamente).
		- .NET Framework 3.5 (ou compatível) não instalado ou não habilitado corretamente no sistema operacional.
		- Incompatibilidade de versão entre a EasyInner.dll e outras DLLs de suporte da Topdata.
		- Problemas de compatibilidade de arquitetura (aplicação 64 bits tentando carregar DLL 32 bits - ver seção 1.3.3 e 6.6).
- **Exemplo (C#):**

```csharp
// Define a porta TCP que o software irá escutar

int portaEscuta = 3570 ; // Porta padrão da EasyInner.dll para catracas

Console.WriteLine($"Tentando abrir a porta de comunicação {portaEscuta}...");
// Tenta abrir a porta de comunicação
int ret = EasyInner.AbrirPortaComunicacao(portaEscuta);

if (ret == (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
Console.WriteLine($"Porta {portaEscuta} aberta com sucesso.");
// Máquina de estados: Próximo passo (ex: ESTADO_CONECTAR)
}
else
{
Console.WriteLine($"Erro ao abrir a porta de comunicação {portaEscuta}. Código de retorno: {ret}");
// Tratar erro. Verificar códigos 1, 2, 3, 8 e outros.
if (ret == 8 )


##### {

Console.WriteLine("Erro 8 (GPF) - Verificar Framework 3.5, registro da DLL, compatibilidade de
versões/arquitetura.");
}
// Sua máquina de estados deve lidar com este erro, talvez tentando novamente ou notificando o usuário
}
```

- Nota: Se a porta já estiver em uso por outra aplicação ou se houver problemas de _permissão, esta função retornará um erro._

#### 3.3.3 Sugestão de Código para Conexão Inicial (C# - Exemplo Combinado):
Este código combina as etapas iniciais de configuração do tipo de conexão, abertura da porta

e tentativa de conexão para uma catraca específica, simulando o fluxo do estado

ESTADO_CONECTAR.

```csharp
using System;
using System.Threading; // Necessário para Thread.Sleep

// Suponha que esta classe representa uma catraca com suas informações e estado
public class Inner
{
public int Numero { get; set; } // Número do Inner (1 a 99)
public Enumeradores.EstadosInner EstadoAtual { get; set; } // Estado atual na Máquina de Estados
// Adicione outras propriedades relevantes como IP, Porta, etc.

public Inner(int numeroInner)
{
Numero = numeroInner;
EstadoAtual = Enumeradores.EstadosInner.ESTADO_CONECTAR; // Começa no estado de conexão
}
}

// Suponha que EasyInner e Enumeradores são classes/enums estáticos
// acessíveis em seu projeto, referenciando a EasyInner.dll

// Simula as funções da EasyInner.dll para este exemplo (Remova em seu código real)
public static class EasyInner
{
public static int DefinirTipoConexao(byte tipo) { Console.WriteLine($"DLL: DefinirTipoConexao({tipo})");
return 0 ; }
public static int AbrirPortaComunicacao(int porta) { Console.WriteLine($"DLL:
AbrirPortaComunicacao({porta})"); return 0 ; } // Simula sucesso ao abrir
public static void FecharPortaComunicacao() { Console.WriteLine("DLL: FecharPortaComunicacao()"); }


// Simula TestarConexaoInner: Suponha que a catraca 1 conecta após 3 tentativas, a catraca 2 nunca conecta
neste exemplo
private static int _tentativasCatraca1 = 0 ;
public static int TestarConexaoInner(int inner)
{
Console.WriteLine($"DLL: TestarConexaoInner({inner})");
if (inner == 1 )
{
_tentativasCatraca1++;
if (_tentativasCatraca1 >= 3 ) return (int)Enumeradores.Retorno.RET_COMANDO_OK; // Conecta após 3
tentativas
return (int)Enumeradores.Retorno.RET_ERRO; // Simula erro/timeout antes
}
if (inner == 2 )
{
return (int)Enumeradores.Retorno.RET_ERRO; // Simula sempre erro para catraca 2
}
return (int)Enumeradores.Retorno.RET_ERRO; // Default para outros numbers
}

// Outras funções da DLL...
public static int PingOnline(int inner) { Console.WriteLine($"DLL: PingOnline({inner})"); return 0 ; }
// Adicionar outras funções Dummy se necessário para o exemplo compilar
public static int EnviarConfiguracoes(int inner) { Console.WriteLine($"DLL: EnviarConfiguracoes({inner})");
return 0 ; }
}

// Simula enumeradores de exemplo (Remova em seu código real)
public static class Enumeradores
{
public enum Retorno { RET_COMANDO_OK = 0 , RET_ERRO = 1 }
public enum EstadosInner { [*]= 0, ESTADO_CONECTAR, ESTADO_ENVIAR_CFG_ONLINE, ESTADO_POLLING,
ESTADO_RECONECTAR } // Simplificado
// Adicionar outros enums dummy se necessário
public enum PadraoCartao { PADRAO_TOPDATA, PADRAO_LIVRE }
public enum TipoLeitor { CODIGO_DE_BARRAS, MAGNETICO, PROXIMIDADE_ABATRACK2 }
public enum FuncaoAcionamento { NAO_UTILIZADO, ACIONA_REGISTRO_ENTRADA_OU_SAIDA }
public enum Operacao { DESABILITADO, SOMENTE_ENTRADA, SOMENTE_SAIDA, ENTRADA_SAIDA }
}

// --- Método principal que executa a lógica de conexão ---
public class GerenciadorDeCatracas
{
private List<Inner> _catracasParaGerenciar;
private bool _executando = true; // Flag para controlar o loop principal


public GerenciadorDeCatracas()
{
_catracasParaGerenciar = new List<Inner>();
_catracasParaGerenciar.Add(new Inner( 1 )); // Adiciona catraca 1
_catracasParaGerenciar.Add(new Inner( 2 )); // Adiciona catraca 2
}

public void IniciarGerenciamento()
{
Console.WriteLine("Iniciando gerenciamento de catracas...");

// 1. Definir Tipo de Conexão (TCP/IP Porta Fixa)
int retTipo = EasyInner.DefinirTipoConexao( 2 );
if (retTipo != (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
Console.WriteLine("Falha crítica ao definir tipo de conexão. Encerrando.");
_executando = false; // Não pode continuar
}

// 2. Abrir Porta de Comunicação (Porta 3570)
int portaEscuta = 3570 ;
int retPorta = EasyInner.AbrirPortaComunicacao(portaEscuta);
if (retPorta != (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
Console.WriteLine($"Falha crítica ao abrir porta {portaEscuta}. Encerrando.");
_executando = false; // Não pode continuar
}

// 3. Loop Principal da Máquina de Estados
while (_executando)
{
// Processar cada catraca individualmente
foreach (Inner catraca in _catracasParaGerenciar)
{
switch (catraca.EstadoAtual)
{
case Enumeradores.EstadosInner.ESTADO_CONECTAR:
Console.WriteLine($"Processando Catraca {catraca.Numero} no estado ESTADO_CONECTAR");
// Lógica para tentar conectar (chamar TestarConexaoInner)
int retConexao = EasyInner.TestarConexaoInner(catraca.Numero);

if (retConexao == (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
Console.WriteLine($"Catraca {catraca.Numero} conectada com sucesso!");


// Transitar para o próximo estado (ex: enviar configurações)
catraca.EstadoAtual = Enumeradores.EstadosInner.ESTADO_ENVIAR_CFG_ONLINE; // Exemplo: Ir
para Configuração
}
else
{
// Conexão ainda não estabelecida, permanecer neste estado ou ir para reconectar
// Para simplificar, fica tentando neste estado. Uma FSM real teria lógica de timeout e
ESTADO_RECONECTAR.
Console.WriteLine($"Catraca {catraca.Numero}: Aguardando conexão. Retorno
TestarConexaoInner: {retConexao}");
}
break;

case Enumeradores.EstadosInner.ESTADO_ENVIAR_CFG_ONLINE:
Console.WriteLine($"Processando Catraca {catraca.Numero} no estado
ESTADO_ENVIAR_CFG_ONLINE");
// Aqui você chamaria a lógica para enviar configurações (ver seção 4.1)
// E depois mudaria de estado
// catraca.EstadoAtual = Enumeradores.EstadosInner.ESTADO_POLLING; // Ir para polling após
configurar
Console.WriteLine("Simulando envio de configuração...");
EasyInner.EnviarConfiguracoes(catraca.Numero); // Apenas para mostrar chamada
catraca.EstadoAtual = Enumeradores.EstadosInner.ESTADO_POLLING; // Próximo estado simulado
break;

case Enumeradores.EstadosInner.ESTADO_POLLING:
Console.WriteLine($"Processando Catraca {catraca.Numero} no estado ESTADO_POLLING");
// Aqui seria o loop de ReceberDadosOnLine
// Se receber evento, muda de estado (ex: ESTADO_VALIDAR_ACESSO)
// Se não receber evento, envia PingOnline
// Console.WriteLine("Simulando Polling...");
// EasyInner.PingOnline(catraca.Numero); // Exemplo de Ping
// Lógica de ReceberDadosOnLine (não simulada em detalhe aqui)
// Se ReceberDadosOnLine tiver dados, processar e mudar de estado
// Caso contrário, continuar no polling ou PingOnline
break;

// ... outros estados da máquina ...

default:
// Estado desconhecido ou não tratado
Console.WriteLine($"Catraca {catraca.Numero} em estado desconhecido:
{catraca.EstadoAtual}");
// Lidar com estado inválido, talvez retornar para ESTADO_CONECTAR ou logar erro
break;
}


##### }

// Pequena pausa para não sobrecarregar o processador
Thread.Sleep( 100 ); // Espera 100ms antes de verificar novamente as catracas
}

// Ao sair do loop principal (se _executando for false)
Console.WriteLine("Gerenciamento de catracas encerrado.");
EasyInner.FecharPortaComunicacao();
}
}

/*
// --- Como chamar o gerenciador em seu Main() ---
public class Program
{
public static void Main(string[] args)
{
GerenciadorDeCatracas gerenciador = new GerenciadorDeCatracas();
gerenciador.IniciarGerenciamento();

Console.WriteLine("Aplicação finalizada.");
// A aplicação de console pode precisar de um Console.ReadKey() para não fechar imediatamente
// se o gerenciamento rodar em thread separada.
}
}
*/
```

**Explicação do Código:**

1. **Estrutura:** O código demonstra a estrutura básica de um GerenciadorDeCatracas que mantém uma lista de objetos Inner, cada um representando uma catraca específica com seu número e estado atual.
2. **Inicialização:** O construtor do GerenciadorDeCatracas adiciona as catracas a serem gerenciadas e as inicializa no estado ESTADO_CONECTAR. Em um sistema real, a lista de catracas viria de uma configuração ou banco de dados.
3. **IniciarGerenciamento():** Este método contém o loop principal da aplicação. Ele chama DefinirTipoConexao e AbrirPortaComunicacao uma vez. Em seguida, entra em um loop while que continua enquanto _executando for true.
4. **Loop da Máquina de Estados:** Dentro do loop principal, ele itera sobre cada Inner na lista. Para cada catraca, um switch verifica o EstadoAtual e executa a lógica correspondente (simulada de forma básica neste exemplo).
5. **Estado ESTADO_CONECTAR:** Neste estado, ele chama EasyInner.TestarConexaoInner() para a catraca atual.
	- Se o retorno for RET_COMANDO_OK, a conexão foi estabelecida, e o estado da catraca muda para o próximo passo (ESTADO_ENVIAR_CFG_ONLINE neste exemplo).
	- Se o retorno não for RET_COMANDO_OK, a catraca permanece no estado ESTADO_CONECTAR, e a tentativa de conexão será repetida na próxima iteração do loop.
6. **Outros Estados (Simulados):** O código mostra placeholders para outros estados (como ESTADO_ENVIAR_CFG_ONLINE, ESTADO_POLLING), indicando onde você adicionaria a lógica correspondente.
7. **Pausa:** Thread.Sleep(2) é usada para evitar que o loop consuma 100% da CPU. Em uma aplicação real, o tempo de espera pode ser ajustado ou controlado de outras formas.
8. **Encerrar:** A porta é fechada com EasyInner.FecharPortaComunicacao() ao sair do loop principal.

Este exemplo ilustra a estrutura da máquina de estados e o processo inicial de conexão para múltiplas catracas. Ele serve como uma base para construir sua aplicação real, que precisará implementar a lógica completa de cada estado e transição.


## 4 Comandos Essenciais e Gerenciamento de Acesso

Este capítulo aprofunda-se nos comandos mais importantes da EasyInner.dll que sua aplicação utilizará para configurar as catracas e gerenciar o controle de acesso. É aqui que a lógica da sua máquina de estados (Capítulo 2) se conecta diretamente às funcionalidades da DLL.

### 4.1 Enviando Configurações para a Catraca

Após estabelecer a conexão com a catraca (conforme o ESTADO_CONECTAR do Capítulo 3), é fundamental enviar as configurações operacionais para que ela se comporte conforme o esperado pela sua aplicação. Essas configurações são montadas em um "buffer" interno da EasyInner.dll e, em seguida, enviadas em um único pacote para a catraca. Este processo geralmente ocorre nos estados ESTADO_ENVIAR_CFG_OFFLINE e ESTADO_ENVIAR_CFG_ONLINE.

#### 4.1.1 O Processo de Montagem da Configuração

A montagem da configuração para o Inner é um dos pontos mais sensíveis da integração com a EasyInner.dll. Ela envolve chamar uma série de funções que preenchem um buffer interno na DLL com as definições desejadas para o equipamento. **É importante que todas as configurações relevantes para o modo de operação (online ou offline) e para as funcionalidades específicas da catraca sejam definidas neste buffer antes de serem enviadas.**

A ordem em que as funções de configuração são chamadas geralmente não importa, pois elas apenas adicionam informações ao buffer. O que importa é que todas as definições necessárias estejam presentes no buffer antes de chamar a função de envio (EasyInner.EnviarConfiguracoes()).

A lógica para montar a configuração geralmente reside em um método ou função dedicada em seu código (como o MontaConfiguracaoInner no exemplo SDK). Este método receberá as informações sobre a catraca atual e o modo de comunicação desejado, e chamará as funções da DLL para preencher o buffer.

**Funções Comuns Utilizadas na Montagem da Configuração:**

Abaixo estão exemplos de funções que são frequentemente utilizadas para montar o buffer de configuração. A escolha exata das funções e seus parâmetros dependerá do modelo da catraca, dos leitores instalados e do comportamento desejado (modo online/offline, tipo de leitor, acionamentos, etc.).

- **Definição do Padrão e Quantidade de Dígitos do Cartão:**
	- EasyInner.DefinirPadraoCartao(): Define se o padrão é Topdata ou Livre.
	- EasyInner.DefinirQuantidadeDigitosCartao(): Define a quantidade fixa de dígitos (se aplicável).
	- EasyInner.InserirQuantidadeDigitovariavel(): Adiciona quantidades variáveis de dígitos (para leitores compatíveis).

- **Definição do Modo de Operação:**
	- EasyInner.ConfigurarInnerOffLine(): Prepara para modo offline.
	- EasyInner.ConfigurarInnerOnLine(): Prepara para modo online.

- **Configuração de Acionamentos (Relés):**
	- EasyInner.ConfigurarAcionamento1() / EasyInner.ConfigurarAcionamento2(): Definem a função e o tempo dos relés.

- **Configuração de Leitores Físicos:**
	- EasyInner.ConfigurarTipoLeitor(): Define a tecnologia do leitor (Wiegand, Abatrack, QR Code, etc.).
	- EasyInner.ConfigurarLeitor1() / EasyInner.ConfigurarLeitor2(): Definem a operação de cada leitor (entrada, saída, desabilitado).

- **Outras Configurações:**
	- EasyInner.HabilitarTeclado(): Habilita ou desabilita o teclado.
	- EasyInner.RegistrarAcessoNegado(): Configura o registro de acessos negados.
	- EasyInner.DefinirFuncaoDefaultLeitoresProximidade(): Define o tipo de registro padrão para leitores de proximidade.
	- EasyInner.ReceberDataHoraDadosOnLine(): Configura o envio de data/hora nos bilhetes online.
	- EasyInner.DefinirTipoListaAcesso(): Define o tipo de lista de acesso (branca/negra) para modo offline.
	- EasyInner.ConfigurarWiegandDoisLeitores(): Configura leitores Wiegand duplos.
	- EasyInner.SetarBioVariavel() / EasyInner.ConfigurarBioVariavel(): Configurações para biometria variável (se aplicável).
	- Configurações específicas para Inner Acesso 2 (WebServer, Sensor Porta Offline, etc.).

**Exemplo Conceitual de Montagem (Pseudocódigo):**

```csharp
// Método para montar a configuração para uma catraca específica
Funcao MontaConfiguracaoInner(catracaAtual, modoDesejado):
// Definir Padrão do Cartão
Se catracaAtual.PadraoCartao == PADRAO_TOPDATA:
Chamar EasyInner.DefinirPadraoCartao(PADRAO_TOPDATA)
Senão:
Chamar EasyInner.DefinirPadraoCartao(PADRAO_LIVRE)

// Definir Modo de Comunicação
Se modoDesejado == MODO_OFF_LINE:
Chamar EasyInner.ConfigurarInnerOffLine()
Senão:
Chamar EasyInner.ConfigurarInnerOnLine()

// Configurar Acionamentos (Relés) - Exemplo para Coletor
Se catracaAtual.TipoEquipamento == COLETOR:
Chamar EasyInner.ConfigurarAcionamento1(ACIONA_REGISTRO_ENTRADA_OU_SAIDA, 5 )
Chamar EasyInner.ConfigurarAcionamento2(ACIONA_REGISTRO_ENTRADA_OU_SAIDA, 5 )
// Configurar Leitores para Coletor
Se catracaAtual.DoisLeitores:
Chamar EasyInner.ConfigurarLeitor1(SOMENTE_ENTRADA)
Chamar EasyInner.ConfigurarLeitor2(SOMENTE_SAIDA)
Senão:
Chamar EasyInner.ConfigurarLeitor1(SOMENTE_ENTRADA)
Chamar EasyInner.ConfigurarLeitor2(DESATIVADO)
// ... Outros casos para Catraca, Urna, etc.

// Configurar Tipo de Leitor
Chamar ConfigurarTpLeitor(catracaAtual) // Método auxiliar para configurar tipo de leitor e dígitos
variáveis

// Enviar Quantidade de Dígitos (se não for tratado em ConfigurarTpLeitor)
Chamar EasyInner.DefinirQuantidadeDigitosCartao(catracaAtual.QtdDigitos)

// Configurar Dígitos Variáveis (se aplicável e não tratado em ConfigurarTpLeitor)
// Se catracaAtual.TipoLeitor suporta dígitos variáveis:
// Para cada digito em catracaAtual.DigitosVariaveis:


// Chamar EasyInner.InserirQuantidadeDigitoVariavel(digito)

// Configurar Cartão Master, Teclado, Registro Negado, etc.
Se catracaAtual.CartMaster:
Chamar EasyInner.DefinirNumeroCartaoMaster(catracaAtual.Master)
Chamar EasyInner.HabilitarTeclado(catracaAtual.TecladoHabilitado, EcoDisplay)
Chamar EasyInner.RegistrarAcessoNegado(TipoRegistro)

// Configurar Funções Default (como interpretar leitura sem botão de função)
Chamar EasyInner.DefinirFuncaoDefaultLeitoresProximidade(Funcao)
// ... Outras configurações ...

// O buffer da DLL agora está preenchido com todas essas definições.
// O próximo passo é chamar EasyInner.EnviarConfiguracoes(catracaAtual.Numero)
// para enviar tudo para a catraca.

Fim Funcao
```

**Pontos Críticos na Montagem da Configuração:**

- Completude: Certifique-se de que todas as configurações relevantes para o funcionamento desejado da catraca estejam incluídas na montagem. Configurações ausentes podem levar a comportamentos inesperados.
- Ordem de Chamada (Exceções): Embora a ordem da maioria das funções de configuração não importe, DefinirPadraoCartao e DefinirQuantidadeDigitosCartao devem ser chamadas antes de InserirUsuarioListaAcesso. Outras funções podem ter pré-requisitos similares; consulte os exemplos SDK.
- Funções Específicas: Utilize as funções de configuração específicas para o modelo da sua catraca.
- Consulte os Exemplos SDK: Os exemplos de código fornecidos pela Topdata são a melhor referência para ver como a montagem da configuração é feita para diferentes modelos e funcionalidades. Analise o código da função que monta a configuração (geralmente chamada antes de EnviarConfiguracoes) no exemplo que mais se aproxima do seu cenário.
A montagem correta da configuração é um passo fundamental para garantir que a catraca opere de forma confiável e alinhada com a lógica do seu Software de Integração.

#### 4.1.2 EasyInner.DefinirQuantidadeDigitosCartao()

Configura a quantidade de dígitos que a catraca espera ler nos cartões **quando utilizando um padrão de cartão que exige quantidade fixa** (como o padrão Livre com quantidade fixa).

- **Parâmetros:**
	- Quantidade (byte): Número de dígitos (de 4 a 16).

- **Exemplo (C#):**

```csharp
// Define que a catraca lerá cartões com 10 dígitos
EasyInner.DefinirQuantidadeDigitosCartao( 10 );
```

- **Dígitos Variáveis:** Para leitores que podem ler cartões com **quantidades variáveis de dígitos** (como alguns leitores Abatrack II ou QR Code/Barras Serial), em vez de usar DefinirQuantidadeDigitosCartao com um valor fixo, você deve chamar EasyInner.InserirQuantidadeDigitovariavel() para cada quantidade de dígitos que a catraca deve aceitar (ex: chamar para 6, depois para 8, etc.). Esta função será detalhada na seção 5.1.3.
#### 4.1.3 EasyInner.ConfigurarTipoLeitor()

Define o tipo de tecnologia do leitor físico que a catraca irá utilizar para a leitura de cartões. Esta função configura o leitor, seja ele código de barras, magnético ou proximidade.

- **Parâmetros:**
	- Tipo (byte):
		- 0 ou TpLeitor_CODIGO_DE_BARRAS: Leitor de código de barras (padrão).
		- 1 ou TpLeitor_MAGNETICO: Leitor magnético.
		- 2 ou TpLeitor_PROXIMIDADE_ABATRACK2: Leitor de proximidade Abatrack II.
		- 3 ou TpLeitor_WIEGAND: Leitor Wiegand genérico.
		- 4 ou TpLeitor_PROXIMIDADE_SMART_CARD_SERIAL: Leitor de Smart Card Serial.
		- 5 ou TpLeitor_CODIGO_BARRAS_SERIAL: Leitor de código de barras serial (usado também para QR Code via interface serial).
		- 6 ou TpLeitor_WIEGAND_FC_SEM_SEPARADOR: Leitor Wiegand com Facility Code sem separador.
		- 7 ou TpLeitor_TTL_SERIAL_ASCII: Leitores TTL/Serial com leitura de cartão em ASCII (mais compatível com leitores variados, incluindo QR Code serial).

- **Exemplo (C#):**
```csharp
// Configura o leitor para um leitor QR Code serial
EasyInner.ConfigurarTipoLeitor((byte)Enumeradores.TipoLeitor.TTL_SERIAL_ASCII);
```

#### 4.1.4 EasyInner.ConfigurarInnerOnline() / EasyInner.ConfigurarInnerOffLine()

Essas funções definem o modo principal de operação da catraca (online ou offline), conforme explicado na seção 2.2. Essas funções preparam o Inner para trabalhar no respectivo modo, mas a informação só é enviada para o equipamento na chamada de EnviarConfiguracoes.

- EasyInner.ConfigurarInnerOnline(): Prepara a catraca para operar em modo online (decisões de acesso pelo software).
- EasyInner.ConfigurarInnerOffLine(): Prepara a catraca para operar em modo offline (decisões de acesso pela própria catraca).
- **Exemplo (C#):**
```csharp
// Configura a catraca para operar em modo online
EasyInner.ConfigurarInnerOnline();
```

#### 4.1.5 EasyInner.ConfigurarAcionamento1() / EasyInner.ConfigurarAcionamento2() (Relés)

Configuram o comportamento dos relés da catraca (acionamento 1 e 2) e por quanto tempo eles permanecerão acionados após um evento. Essas funções definem como os relés (acionamentos) 1 e 2 do Inner irão funcionar. Estes comandos não devem ser utilizados em catracas se a intenção for acionar o mecanismo de giro. Para a giro de catracas, utilize os comandos EasyInner.LiberarCatraca...().

- **Parâmetros:**
	- Funcao (byte): Define a ação do relé.
	- Tempo (byte): Duração do acionamento em segundos (de 0 a 50). 0 é o valor padrão.

- **Funções Comuns (Funcao):**
	- 0 ou FncAcionamento_NAO_UTILIZADO: Relé não utilizado (padrão).
	- 1 ou FncAcionamento_ACIONA_REGISTRO_ENTRADA_OU_SAIDA: Aciona ao registrar entrada ou saída.
	- 2 ou FncAcionamento_ACIONA_REGISTRO_ENTRADA: Aciona ao registrar entrada.
	- 3 ou FncAcionamento_ACIONA_REGISTRO_SAIDA: Aciona ao registrar saída.
	- 4 ou FncAcionamento_SIRENE: Conectado a uma sirene (ver funções de sirene).
	- 5 ou FncAcionamento_REVISTA: Utilizado para a revista de usuários (ver DefinirPorcentagemRevista).

- **Exemplo (C#):**
```csharp
// Configura o acionamento 1 para acionar ao registrar uma entrada por 2 segundos
EasyInner.ConfigurarAcionamento1((byte)Enumeradores.FuncaoAcionamento.ACIONA_REGISTRO_ENTRADA, 2 );
// Configura o acionamento 2 para não ser utilizado
EasyInner.ConfigurarAcionamento2((byte)Enumeradores.FuncaoAcionamento.NAO_UTILIZADO, 0 );
```

#### 4.1.6 EasyInner.ConfigurarLeitor1() / EasyInner.ConfigurarLeitor2()

Definem a operação de cada leitor físico da catraca (Leitor 1 e Leitor 2). Estas funções configuram as operações que o leitor irá executar.

- **Parâmetros:**
	- Operacao (byte):
		- 0 ou EntradasOff_LEITOR_DESABILITADO: Leitor desabilitado (padrão para Leitor 2).
		- 1 ou EntradasOff_LEITOR_SOMENTE_ENTRADA: Leitor para somente entrada.
		- 2 ou EntradasOff_LEITOR_SOMENTE_SAIDA: Leitor para somente saída.
		- 3 ou EntradasOff_LEITOR_ENTRADA_SAIDA: Leitor para entrada e saída (padrão para Leitor 1).
		- 4 ou EntradasOff_LEITOR_ENTRADA_SAIDA_INVERTIDA: Leitor para entrada e saída invertidas.

- **Exemplo (C#):**
```csharp
// Configura o Leitor 1 para entrada e saída
EasyInner.ConfigurarLeitor1((byte)Enumeradores.Operacao.ENTRADA_SAIDA);
// Configura o Leitor 2 para somente saída
EasyInner.ConfigurarLeitor2((byte)Enumeradores.Operacao.SOMENTE_SAIDA);
```

#### 4.1.7 EasyInner.EnviarConfiguracoes(): Aplicando as Definições

Esta é a função mais importante da etapa de configuração. Após chamar todas as funções EasyInner.Definir...() ou EasyInner.Configurar...() para montar o buffer de configurações na DLL, você deve chamar EasyInner.EnviarConfiguracoes() para enviar esse pacote completo para a catraca. Após o envio, esse buffer interno é limpo, sendo necessário chamar novamente as funções de configuração para reconfigurá-lo. **As configurações só terão efeito no equipamento após a execução desta função.**

- **Parâmetros:**
	- NumeroInner (int): O número de identificação da catraca (1 a 99) para a qual as configurações serão enviadas.
- **Retorno:** 0 (sucesso) ou código de erro.
- **Exemplo (C#):**
```csharp
int numeroCatraca = 1 ; // Exemplo: Catraca com Inner #1
int ret = EasyInner.EnviarConfiguracoes(numeroCatraca);

if (ret == (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
Console.WriteLine($"Configurações enviadas com sucesso para a catraca {numeroCatraca}.");
// Máquina de estados: Transitar para o próximo estado (ex: ESTADO_POLLING)
// Sua máquina de estados deve gerenciar essa transição
}
else
{
Console.WriteLine($"Erro ao enviar configurações para a catraca {numeroCatraca}: {ret}");
// Máquina de estados: Tratar erro, talvez transitar para ESTADO_RECONECTAR
// Sua máquina de estados deve gerenciar essa transição
}
```

#### 4.1.8 Configuração de Mudança Automática Online/Offline

Em ambientes onde a estabilidade da conexão de rede não é garantida, configurar a mudança automática entre os modos online e offline é essencial para a resiliência da sua aplicação. Isso garante que a catraca continue operando (no modo offline) se a comunicação com o software for perdida, e retorne automaticamente ao modo online quando a conexão for restabelecida.

A configuração é feita através da função EasyInner.HabilitarMudancaOnLineOffLine() e enviada com EasyInner.EnviarConfiguracoesMudancaAutomaticaOnLineOffLine().

- EasyInner.HabilitarMudancaOnLineOffLine(): Habilita ou desabilita a mudança automática e define o tempo limite para detecção de falha na comunicação.
	- **Parâmetros:**
		- Habilita (byte):
			- 0: Desabilita a mudança automática (padrão).
			- 1: Habilita a mudança automática.
			- 2: Habilita a mudança automática no modo Online TCP com Ping (a catraca espera receber PingOnline do software).
		- Tempo (byte): Tempo em segundos (de 1 a 50) após a perda da comunicação (ou falta de PingOnline no modo 2) para que a catraca mude para o modo offline por timeout.

- **Exemplo (C#):**
```csharp
// Habilita a mudança automática para offline após 15 segundos sem comunicação
// Utilizando o modo que espera PingOnline
EasyInner.HabilitarMudancaOnLineOffLine( 2 , 15 );
```

- EasyInner.EnviarConfiguracoesMudancaAutomaticaOnLineOffLine(): Envia a configuração de mudança automática para a catraca. Esta função envia um buffer separado das configurações gerais (enviadas por EasyInner.EnviarConfiguracoes()).
	- **Parâmetros:**
		- Inner (int): O número de identificação da catraca (1 a 99).
	- **Retorno:** 0 (sucesso) ou código de erro.
	- **Exemplo (C#):**
```csharp
int numeroCatraca = 1 ;
int ret = EasyInner.EnviarConfiguracoesMudancaAutomaticaOnLineOffLine(numeroCatraca);


if (ret == (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
Console.WriteLine($"Configuração de mudança automática enviada com sucesso para a catraca
{numeroCatraca}.");
// Próximo passo na máquina de estados
}
else
{
Console.WriteLine($"Erro ao enviar configuração de mudança automática para a catraca {numeroCatraca}:
{ret}");
// Tratar erro
}
```

- **Onde Usar:** A função HabilitarMudancaOnLineOffLine() é chamada durante a fase de configuração (antes de EnviarConfiguracoesMudancaAutomaticaOnLineOffLine()). O estado PASSO_ESTADO_ENVIAR_CONFIGMUD_ONLINE_OFFLINE na máquina de estados (Capítulo 2.1.2) é responsável por chamar EnviarConfiguracoesMudancaAutomaticaOnLineOffLine() após montar a configuração. 
 
**Importância do PingOnline():** Se você configurar a mudança automática no modo 2 (HabilitarMudancaOnLineOffLine(2, ...)), sua aplicação no estado ESTADO_POLLING (ou um estado similar para manter o Inner online) deve enviar o comando EasyInner.PingOnline(NumeroInner) regularmente (em um intervalo menor que o Tempo configurado na mudança automática). Isso sinaliza para a catraca que o software está ativo e a conexão está sendo mantida. A falta do PingOnline fará com que a catraca mude para o modo offline.

**Exemplo de Código para Configuração de Mudança Automática (C# - Pseudocódigo):**
```csharp
// Supondo que 'InnerAtual' é um objeto que representa a catraca atual

public void ConfigurarMudancaAutomatica(Inner InnerAtual)
{
// Habilita a mudança automática para offline após 20 segundos sem PingOnline
EasyInner.HabilitarMudancaOnLineOffLine( 2 , 20 );

// ... (Outras configurações de mudança automática, se necessário, como DefinirEntradasMudancaOffLine)

// Envia a configuração de mudança automática para a catraca
int ret = EasyInner.EnviarConfiguracoesMudancaAutomaticaOnLineOffLine(InnerAtual.Numero);

if (ret == (int)Enumeradores.Retorno.RET_COMANDO_OK)
{


Console.WriteLine($"Configuração de mudança automática enviada com sucesso para a catraca
{InnerAtual.Numero}.");
// Máquina de estados: Próximo passo (pode ser ESTADO_POLLING se já enviou configurações gerais)
}
else
{
Console.WriteLine($"Erro ao enviar configuração de mudança automática para a catraca
{InnerAtual.Numero}: {ret}");
// Máquina de estados: Tratar erro
}
}
```

A configuração da mudança automática é uma funcionalidade crucial para garantir a operação contínua da catraca, mesmo em face de interrupções na comunicação de rede.

#### 4.1.9 Tabela de Comandos para Montar a Configuração

**Comando (C#) Parâmetros (Tipos) Propósito / Breve Explicação**

### 4.1.9 Tabela de Comandos para Montar a Configuração

| **Comando (C#)**                                                   | **Parâmetros (Tipos)**                         | **Propósito / Breve Explicação**                                                                                                                  | **Retornos (Comuns)**                                      |
| ------------------------------------------------------------------ | ---------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------- |
| EasyInner.DefinirPadraoCartao(Tipo)                                | byte Tipo (0: Topdata, 1: Livre)               | Define o padrão de leitura dos cartões (Topdata ou Livre). Afeta como os dígitos são interpretados.                                               | 0 (Sucesso), 128 (Padrão inválido)                         |
| EasyInner.DefinirQuantidadeDigitosCartao(Quantidade)               | byte Quantidade (1 a 16)                       | Configura a quantidade fixa de dígitos esperada nos cartões (para padrões que exigem quantidade fixa).                                            | 0 (Sucesso), 128 (Quantidade inválida)                     |
| EasyInner.InserirQuantidadeDigitovariavel(Digito)                  | byte Digito (1 a 16)                           | Adiciona uma quantidade de dígitos à lista de quantidades variáveis que a catraca deve aceitar (para leitores compatíveis com dígitos variáveis). | 0 (Sucesso)                                                |
| EasyInner.ConfigurarInnerOffLine()                                 | (void)                                         | Prepara a catraca para operar no modo offline (decisões locais).                                                                                  | 0 (Sucesso)                                                |
| EasyInner.ConfigurarInnerOnLine()                                  | (void)                                         | Prepara a catraca para operar no modo online (decisões pelo software).                                                                            | 0 (Sucesso)                                                |
| EasyInner.ConfigurarAcionamento1(Funcao, Tempo)                    | byte Funcao, byte Tempo (0 a 50)               | Configura a função e o tempo de acionamento do Relé 1.                                                                                            | 0 (Sucesso), 128 (Função inválida), 129 (Tempo inválido)   |
| EasyInner.ConfigurarAcionamento2(Funcao, Tempo)                    | byte Funcao, byte Tempo (0 a 50)               | Configura a função e o tempo de acionamento do Relé 2.                                                                                            | 0 (Sucesso), 128 (Função inválida), 129 (Tempo inválido)   |
| EasyInner.ConfigurarTipoLeitor(Tipo)                               | byte Tipo (0 a 7)                              | Define a tecnologia do leitor físico (Barras, Magnético, Proximidade, etc.).                                                                      | 0 (Sucesso), 128 (Tipo de leitor inválido)                 |
| EasyInner.ConfigurarLeitor1(Operacao)                              | byte Operacao (0 a 4)                          | Define a operação do Leitor 1 (Desabilitado, Somente Entrada, Somente Saída, Entrada/Saída, Entrada/Saída Invertida).                             | 0 (Sucesso), 128 (Operação inválida)                       |
| EasyInner.ConfigurarLeitor2(Operacao)                              | byte Operacao (0 a 4)                          | Define a operação do Leitor 2 (Desabilitado, Somente Entrada, Somente Saída, Entrada/Saída, Entrada/Saída Invertida).                             | 0 (Sucesso), 129 (Operação inválida)                       |
| EasyInner.HabilitarTeclado(Habilita, Ecoar)                        | byte Habilita (0/1), byte Ecoar (0/1/2)        | Habilita/desabilita o teclado e configura o eco no display.                                                                                       | 0 (Sucesso), 128 (Habilita inválido), 129 (Ecoar inválido) |
| EasyInner.RegistrarAcessoNegado(TipoRegistro)                      | byte TipoRegistro (0 a 3)                      | Configura o registro de tentativas de acesso negado no modo offline.                                                                              | 0 (Sucesso), 128 (Tipo de registro inválido)               |
| EasyInner.DefinirFuncaoDefaultLeitoresProximidade(Funcao)          | byte Funcao (0 a 12)                           | Define o tipo de registro padrão para leitores de proximidade sem pressionar tecla de função.                                                     | 0 (Sucesso), 128 (Função de leitor inválida)               |
| EasyInner.DefinirNumeroCartaoMaster(Master)                        | string Master (até 14 dígitos)                 | Configura o número do cartão master (para liberar acesso a cartões bloqueados pela lista offline). Válido para padrão Livre.                      | 0 (Sucesso), 128 (Número do master inválido)               |
| EasyInner.ConfigurarWiegandDoisLeitores(Habilita, ExibirMensagem)  | byte Habilita (0/1), byte ExibirMensagem (0/1) | Configura leitores Wiegand duplos (habilita o segundo leitor Wiegand e exibe mensagens no segundo leitor).                                        | 0 (Sucesso)                                                |
| EasyInner.SetarBioVariavel(Variavel)                               | byte Variavel (0/1)                            | Define se o Inner Bio utilizado é o modelo Variável (até 16 dígitos) ou 1000/4000.                                                                | 0 (Sucesso)                                                |
| EasyInner.ConfigurarBioVariavel(Variavel)                          | byte Variavel (0/1)                            | Configura a biometria variável (habilita/desabilita).                                                                                             | 0 (Sucesso)                                                |
| EasyInner.ReceberDataHoraDadosOnLine(Recebe)                       | byte Recebe (0/1)                              | Configura se a catraca envia data/hora nos bilhetes online.                                                                                       | 0 (Sucesso)                                                |
| EasyInner.DefinirTipoListaAcesso(Tipo)                             | byte Tipo (0 a 2)                              | Define o tipo de lista de acesso (Não usar, Branca, Negra) para modo offline.                                                                     | 0 (Sucesso), 128 (Tipo da lista inválido)                  |
| EasyInner.HabilitarMudancaOnLineOffLine(Habilita, Tempo)           | byte Habilita (0/1/2), byte Tempo (1 a 50)     | Habilita/desabilita a mudança automática online/offline e define o tempo limite.                                                                  | 0 (Sucesso), 128 (Habilita inválido), 129 (Tempo inválido) |
| EasyInner.EnviarConfiguracoesMudancaAutomaticaOnLineOffLine(Inner) | int Inner                                      | Envia a configuração de mudança automática online/offline para a catraca.                                                                         | 0 (Sucesso), 1 (Erro)                                      |
| **EasyInner.EnviarConfiguracoes(Inner)**                           | **int Inner**                                  | **Envia todas as configurações montadas no buffer da DLL para a catraca. Limpa o buffer após o envio.**                                           | **0 (Sucesso), 1 (Erro)**                                  |


**Observações:**
- Esta tabela lista os comandos mais comuns para montar a configuração. Outras funções de configuração podem existir dependendo da versão da DLL e do modelo da catraca.
- Os retornos listados são os mais comuns para sucesso e falha. Outros códigos de erro específicos podem ser retornados; consulte os exemplos SDK e o futuro documento de Erros Detalhados.
- As funções que montam o buffer (Definir..., Configurar..., Inserir...) geralmente retornam 0 para sucesso na adição ao buffer, mas o sucesso real da configuração no equipamento só é confirmado pelo retorno de EnviarConfiguracoes() ou EnviarConfiguracoesMudancaAutomaticaOnLineOffLine().

Esta tabela consolida as informações sobre os comandos de configuração, servindo como uma referência rápida durante o desenvolvimento.

### 4.2 Gerenciamento de Usuários (Modo Offline)

No modo offline, a catraca armazena uma lista de usuários permitidos (ou bloqueados) diretamente em sua memória. Isso permite que ela tome decisões de acesso de forma autônoma, sem depender de uma conexão contínua com o software. Sua aplicação será responsável por montar e enviar essa lista para a catraca.

#### 4.2.1 EasyInner.DefinirTipoListaAcesso() (Lista Branca/Negra)

Esta função define como a catraca interpretará a lista de usuários que será enviada. De acordo com as informações da DLL, ela define qual tipo de lista(controle) de acesso o Inner vai utilizar. Após habilitar a lista de acesso é necessário preencher a lista e os horários de acesso.

- **Parâmetros:**
	- Tipo (byte):
		- 0: Não utilizar a lista de acesso (todos liberados ou todos bloqueados, dependendo de outras configurações).
		- 1: Utilizar lista branca (somente cartões presentes na lista terão acesso permitido; cartões fora da lista terão acesso negado).
		- 2: Utilizar lista negra (cartões presentes na lista terão acesso negado; cartões fora da lista terão acesso permitido).
- **Exemplo (C#):**
```csharp
// Configura a catraca para usar uma lista branca
EasyInner.DefinirTipoListaAcesso( 1 );
```

#### 4.2.2 EasyInner.InserirUsuarioListaAcesso() (Cartão, Horário)

Esta função adiciona um usuário (identificado pelo número do cartão) e associa-o a um horário de acesso específico no buffer da EasyInner.dll. Você chamará esta função para cada usuário que deseja incluir na lista. Os horários já deverão ter sido cadastrados através das funções InserirHorarioAcesso e enviados através da função EnviarHorariosAcesso para a lista ter o efeito correto.

 **Parâmetros:**

- Cartao (string): O número do cartão do usuário. O formato e a quantidade de dígitos devem estar de acordo com o que foi definido em EasyInner.DefinirPadraoCartao() e EasyInner.DefinirQuantidadeDigitosCartao() (ou InserirQuantidadeDigitovariavel()).
- Horario (byte): O número do horário de acesso associado a este usuário.
	- 1 a 100: Corresponde a um número de horário previamente cadastrado na catraca.
	- 101: Acesso sempre liberado para este usuário, independentemente do horário.
	- 102: Acesso sempre negado para este usuário, independentemente do horário.

- **Exemplo (C#):**
```csharp
// Insere usuários na lista de acesso com diferentes horários/permissões
EasyInner.InserirUsuarioListaAcesso("12345", 101 ); // Cartão 12345, acesso sempre liberado
EasyInner.InserirUsuarioListaAcesso("67890", 1 ); // Cartão 67890, associado ao Horário #1
EasyInner.InserirUsuarioListaAcesso("11223", 102 ); // Cartão 11223, acesso sempre negado
```

#### 4.2.3 EasyInner.EnviarListaAcesso()

Após adicionar todos os usuários desejados ao buffer da DLL com EasyInner.InserirUsuarioListaAcesso(), esta função envia a lista completa para a catraca. Após executar esta função, o buffer com os usuários da lista é limpo automaticamente pela DLL.

- **Parâmetros:**
	- NumeroInner (int): O número de identificação da catraca (1 a 99) para a qual a lista será enviada.
- **Retorno:** 0 (sucesso) ou código de erro.

- **Exemplo (C#):**
```csharp
int numeroCatraca = 1 ;
int ret = EasyInner.EnviarListaAcesso(numeroCatraca);

if (ret == (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
Console.WriteLine($"Lista de acesso enviada com sucesso para a catraca {numeroCatraca}.");
// Transitar para o próximo estado
}


else
{
Console.WriteLine($"Erro ao enviar lista de acesso para a catraca {numeroCatraca}: {ret}");
// Tratar erro
}
```

- Atualização da Lista: Para alterar ou excluir um usuário no modo offline, você deve reenviar a lista completa de usuários, com as alterações aplicadas (o usuário alterado com o novo horário, ou o usuário excluído simplesmente não sendo incluído na nova lista). A catraca sobrescreverá a lista existente com a nova lista enviada.
#### 4.2.4 EasyInner.ApagarListaAcesso()

Esta função limpa o buffer da lista de acesso na EasyInner.dll. De acordo com a descrição da DLL, ela limpa o buffer com a lista de usuários cadastrados e envia automaticamente para o Inner (embora a descrição de "envia automaticamente" deva ser validada com o comportamento real, o propósito principal é limpar o buffer na DLL). É uma boa prática chamá-la antes de começar a montar uma nova lista de usuários para garantir que não haja dados residuais de envios anteriores.

- **Parâmetros:**
	- Inner (int): O número de identificação da catraca (1 a 99). (Verificar nos exemplos se este parâmetro é realmente usado ou se limpa o buffer global).

- **Exemplo (C#):**

```csharp
// Limpa o buffer da lista de acesso na DLL (verificar se o parâmetro Inner é necessário)
EasyInner.ApagarListaAcesso(); // Ou EasyInner.ApagarListaAcesso(numeroCatraca);
```

**Exemplo de Código para Gerenciamento de Lista Offline (C# - Pseudocódigo):**

```csharp
// Supondo que 'InnerAtual' é um objeto que representa a catraca atual
// e que 'listaDeUsuariosDoSeuSistema' é uma coleção de usuários a serem enviados

public void EnviarListaDeAcessoOffline(Inner InnerAtual, List<Usuario> listaDeUsuariosDoSeuSistema)
{
// 1. Limpar o buffer da lista na DLL antes de montar uma nova
EasyInner.ApagarListaAcesso(); // Verificar se precisa passar InnerAtual.Numero

// 2. Definir o tipo de lista (ex: lista branca)
EasyInner.DefinirTipoListaAcesso( 1 ); // 1 = Lista Branca


// 3. Definir padrão e quantidade de dígitos do cartão (se ainda não configurado)
// Essas funções devem ser chamadas ANTES de InserirUsuarioListaAcesso,
// conforme a descrição da DLL (página 90).
EasyInner.DefinirPadraoCartao((byte)Enumeradores.PadraoCartao.PADRAO_LIVRE);
EasyInner.DefinirQuantidadeDigitosCartao( 14 ); // Exemplo: 14 dígitos fixos
// OU usar InserirQuantidadeDigitovariavel(digito) para padrões variáveis

// 4. Inserir cada usuário na lista da DLL
// Os horários (1-100) devem ser previamente cadastrados e enviados com EnviarHorariosAcesso (página 89).
foreach (Usuario user in listaDeUsuariosDoSeuSistema)
{
// user.CartaoId deve ser o número do cartão (string)
// user.HorarioAcesso deve ser 1-100, 101 (liberado) ou 102 (negado)
EasyInner.InserirUsuarioListaAcesso(user.CartaoId, (byte)user.HorarioAcesso);
}

// 5. Enviar a lista completa para a catraca
int ret = EasyInner.EnviarListaAcesso(InnerAtual.Numero);

if (ret == (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
Console.WriteLine($"Lista de acesso enviada com sucesso para a catraca {InnerAtual.Numero}.");
// Máquina de estados: Mudar o estado ou registrar sucesso
}
else
{
Console.WriteLine($"Erro ao enviar lista de acesso para a catraca {InnerAtual.Numero}: {ret}");
// Máquina de estados: Tratar erro
}
}
```

**Observação sobre Horários de Acesso:** Para utilizar os horários de 1 a 100 associados aos usuários, é necessário configurar esses horários previamente na catraca. Isso é feito através das funções EasyInner.InserirHorarioAcesso() (insere um horário no buffer da DLL) e EasyInner.EnviarHorariosAcesso() (envia os horários para a catraca). Essas funções são semelhantes ao processo de envio da lista de usuários. 

**Importante:** O gerenciamento de biometrias digitais ou faciais no modo offline é feito através de comandos específicos que interagem com os módulos biométricos da catraca. Para biometria digital, a EasyInner.dll possui funções como EasyInner.EnviarDigitalUsuarioBio(). Para biometria facial, uma SDK separada é utilizada (veja seção 5.4).

### 4.3 Recebendo Eventos em Tempo Real (Modo Online)

No modo online, a catraca atua como um terminal que envia eventos para o seu Software de Integração. Para que sua aplicação possa reagir a esses eventos (como a leitura de um cartão, um giro da catraca, ou um acesso negado), ela precisa estar continuamente "escutando" e processando os dados que vêm do equipamento. Isso é feito principalmente através da função EasyInner.ReceberDadosOnLine().

#### 4.3.1 EasyInner.ReceberDadosOnLine(): Capturando Acessos e Eventos

Esta é a função central para a comunicação em tempo real no modo online. **É uma função bloqueante.** Sua aplicação deve chamá-la repetidamente em um loop (geralmente dentro do ESTADO_POLLING da sua máquina de estados, em uma thread dedicada à comunicação) para verificar se há novos eventos vindos da catraca específica.

- **Propósito:** Receber dados de eventos gerados pela catraca, como a leitura de um cartão, o acionamento de um teclado, o giro da catraca, ou mensagens de status.
- **Comportamento:** A função EasyInner.ReceberDadosOnLine() **pausa a execução da thread que a chama** até que:
	- Um evento seja recebido da catraca (neste caso, retorna 0 - sucesso - e preenche os parâmetros de saída).
	- Ocorra um timeout na espera por um evento (retorna um código indicando "sem eventos").
	- Ocorra um erro na comunicação (retorna um código de erro).
- **Importância da Thread Dedicada:** Devido a ser bloqueante, **esta função NUNCA deve ser chamada na thread principal da interface gráfica (UI)** , pois isso travaria a aplicação. Ela deve ser executada em uma thread separada, gerenciada pela lógica da sua máquina de estados.

- **Parâmetros (C#):**

```csharp
// Exemplo de parâmetros para a função ReceberDadosOnLine
// Note que muitos parâmetros são passados por referência (ref) para serem preenchidos pela DLL
EasyInner.ReceberDadosOnLine(
int NumeroInner, // [Entrada] Número da catraca (Inner) que está sendo monitorada
ref byte Origem, // [Saída] Tipo de evento ocorrido (ex: leitor 1, teclado, biometria)
ref byte Complemento, // [Saída] Informação adicional sobre a origem (ex: sentido do giro)
StringBuilder Cartao, // [Saída] Número do cartão lido (ou QR Code, senha, etc.)


ref byte Dia, // [Saída] Dia do evento
ref byte Mes, // [Saída] Mês do evento
ref byte Ano, // [Saída] Ano do evento
ref byte Hora, // [Saída] Hora do evento
ref byte Minuto, // [Saída] Minuto do evento
ref byte Segundo // [Saída] Segundo do evento
);
```

- **NumeroInner:** O número de identificação da catraca que você está monitorando.
- Origem: Este é um parâmetro crucial que indica o tipo de evento que ocorreu (detalhado na seção 4.3.2).
- Complemento: Fornece informações adicionais sobre a Origem. Por exemplo, para eventos de giro, pode indicar o sentido.
- Cartao: Uma StringBuilder (ou tipo equivalente na sua linguagem) que será preenchida com o número do cartão, QR Code, senha digitada, ou ID biométrico lido. É importante inicializar este StringBuilder com um tamanho suficiente para o maior número de cartão esperado (ex: 16 ou 20 caracteres).
- Dia, Mes, Ano, Hora, Minuto, Segundo: Data e hora exatas em que o evento ocorreu na catraca.

- **Exemplo de Uso (C# - dentro do ESTADO_POLLING na thread de comunicação):**

```csharp
// Este código é parte do loop da Máquina de Estados que roda em UMA thread dedicada.
// Ele itera por cada catraca gerenciada.

// Supondo que 'catraca' é o objeto Inner atual no loop
// Supondo que 'sbCartao' é um StringBuilder inicializado antes do loop principal da FSM

if (catraca.EstadoAtual == Enumeradores.EstadosInner.ESTADO_POLLING)
{
byte origem = 0 ;
byte complemento = 0 ;
byte dia = 0 , mes = 0 , ano = 0 , hora = 0 , minuto = 0 , segundo = 0 ;
sbCartao.Clear(); // Limpar o StringBuilder antes de cada chamada

// Tenta receber dados da catraca (esta chamada é BLOQUEANTE)
int ret = EasyInner.ReceberDadosOnLine(
catraca.Numero,
ref origem,
ref complemento,
sbCartao,


ref dia, ref mes, ref ano, ref hora, ref minuto, ref segundo
);

if (ret == (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
// Evento recebido com sucesso! A thread foi desbloqueada por um evento.
Console.WriteLine($"Evento da catraca {catraca.Numero}: Origem={origem}, Cartão={sbCartao.ToString()},
Hora={hora}:{minuto}");

// Mudar o estado desta catraca para processar o evento
// (ex: ESTADO_VALIDAR_ACESSO).
catraca.EstadoAtual = Enumeradores.EstadosInner.ESTADO_VALIDAR_ACESSO;
catraca.UltimoEvento = new EventoCatraca(origem, complemento, sbCartao.ToString(), dia, mes, ano, hora,
minuto, segundo);

// A thread continuará no loop principal e passará a verificar a próxima catraca.
}
// Verificar outros retornos possíveis de ReceberDadosOnLine (consultar exemplos/documentação)
else if (ret == (int)Enumeradores.Retorno.RET_SEM_EVENTOS) // Exemplo: Se DLL retornar um código para "sem
eventos"
{
// NENHUM evento ocorreu para esta catraca neste ciclo de polling.
// A thread continua para a próxima catraca.
// Pode ser necessário enviar um PingOnline periodicamente aqui para manter a catraca online (se
configurado).
EasyInner.PingOnline(catraca.Numero);
}
else
{
// Erro na comunicação com esta catraca.
Console.WriteLine($"Erro ao receber dados da catraca {catraca.Numero}: {ret}");
// Mudar o estado desta catraca para ESTADO_RECONECTAR
catraca.EstadoAtual = Enumeradores.EstadosInner.ESTADO_RECONECTAR;

// A thread continuará no loop principal e passará a verificar a próxima catraca.
}
} // Fim do 'if' que verifica o estado ESTADO_POLLING
```

A função EasyInner.ReceberDadosOnLine() é a base para a inteligência do seu sistema no modo online. Sua natureza bloqueante requer execução em thread separada, e a Máquina de Estados gerencia a alternância entre as catracas nessa thread.

#### 4.3.2 Tabela de Origens de Eventos

O parâmetro Origem retornado pela função EasyInner.ReceberDadosOnLine() (ou similar na sua linguagem) é fundamental para identificar o tipo de evento que ocorreu na catraca e determinar a ação que sua aplicação deve tomar. Abaixo estão as principais origens e seus significados, conforme informações da DLL e histórico de chat:

| **Valor da Origem** | **Nome (Comum nos Exemplos/SDK)** | **Significado** | **Notas** |
|----------------------|------------------------------------|-----------------|------------|
| 1 | ORIGEM_TECLADO | Dados digitados no teclado da catraca. O parâmetro `Cartao` conterá a sequência numérica digitada. | Pode ser usado para acesso via senha ou para menus no teclado. |
| 2 | ORIGEM_LEITOR1 | Leitura realizada pelo **Leitor 1** da catraca. O parâmetro `Cartao` conterá o número do cartão (RFID, código de barras, etc.). | O tipo de leitor físico associado ao Leitor 1 é configurado via `EasyInner.ConfigurarLeitor1()`. |
| 3 | ORIGEM_LEITOR2 | Leitura realizada pelo **Leitor 2** da catraca. O parâmetro `Cartao` conterá o número do cartão. | O tipo de leitor físico associado ao Leitor 2 é configurado via `EasyInner.ConfigurarLeitor2()`. |
| 4 | ORIGEM_SENSOR_CATRACA | Evento do sensor de giro da catraca (obsoleto em modelos mais recentes, o giro é geralmente indicado pela Origem 6). | Raramente usado em implementações modernas. |
| 5 | ORIGEM_FIM_TEMPO_ACIONAMENTO | O tempo configurado para um acionamento (relé) expirou. | Usado para saber se um giro não ocorreu dentro do tempo liberado ou se um relé desligou. |
| 6 | ORIGEM_GIRO_CATRACA_TOPDATA | Confirmação de que o giro da catraca foi concluído. Este evento é gerado pelo sensor óptico após uma liberação bem-sucedida. | Crucial para registrar acessos efetivos após uma liberação. |
| 7 | ORIGEM_CARTAO_RECOLHIDO_URNA | Um cartão foi detectado e recolhido pela urna coletora. | Específico para catracas com urna. Usado no fluxo de saída com coleta de cartão. |
| 8 | ORIGEM_EVENTO_SENSOR1 | Um evento ocorreu no Sensor 1 (geralmente associado a botões ou sensores externos configurados). | A configuração do Sensor 1 é feita com comandos específicos (ex: `DefinirEventoSensor`). |
| 9 | ORIGEM_EVENTO_SENSOR2 | Um evento ocorreu no Sensor 2 (geralmente associado a botões ou sensores externos configurados). | A configuração do Sensor 2 é feita com comandos específicos (ex: `DefinirEventoSensor`). |
| 10 | ORIGEM_EVENTO_SENSOR3 | Um evento ocorreu no Sensor 3 (geralmente associado a botões ou sensores externos configurados). | A configuração do Sensor 3 é feita com comandos específicos (ex: `DefinirEventoSensor`). |
| 12 | ORIGEM_SENSOR_BIOMETRICO | Leitura realizada pelo sensor biométrico (impressão digital, identificação ou verificação). O parâmetro `Cartao` pode conter o ID do usuário associado à biometria. | Específico para catracas com leitor biométrico digital. |
| 13 | ORIGEM_RESPOSTA_REQUISICAO_BIO | Resposta a uma requisição interna da catraca ao módulo biométrico. Não é uma resposta direta ao envio de biometria pelo software. | Geralmente gerado pela catraca para sua própria lógica interna com a biometria. |
| 18 | ORIGEM_TEMPLATE | Recebimento ou envio de dados de template biométrico (impressão digital). | Usado em processos de cadastro ou transferência de digitais. |
| 20 | ORIGEM_URNA_CHEIA | A urna coletora de cartões está cheia. | Específico para catracas com urna. |
| 21 | ORIGEM_QRCODE | Leitura realizada por um leitor de QR Code. O parâmetro `Cartao` conterá a sequência lida do QR Code. | Específico para catracas com leitor de QR Code. |

**Como Usar as Origens na sua Aplicação:**

Dentro do loop que chama EasyInner.ReceberDadosOnLine(), sua máquina de estados (ou a lógica do estado ESTADO_POLLING) deve ter um switch ou estrutura condicional para verificar o valor do parâmetro Origem e executar a ação apropriada.

**Exemplo (C# - Dentro do Estado ESTADO_POLLING):**
```csharp
// ... (código para chamar EasyInner.ReceberDadosOnLine, como na seção 4.3.1)


if (ret == (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
// Evento recebido!
switch (origem)
{
case (byte)Enumeradores.Origem.ORIGEM_LEITOR1:
// Evento de leitura pelo Leitor 1
Console.WriteLine($"Cartão {sbCartao.ToString()} lido no Leitor 1 da catraca {InnerAtual.Numero}.");
// Mudar o estado para validar o acesso (ESTADO_VALIDAR_ACESSO)
InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_VALIDAR_ACESSO;
InnerAtual.UltimoEvento = new EventoCatraca(origem, complemento, sbCartao.ToString(), dia, mes, ano,
hora, minuto, segundo);
break;

case (byte)Enumeradores.Origem.ORIGEM_TECLADO:
// Evento de digitação no teclado
Console.WriteLine($"Senha/Código {sbCartao.ToString()} digitado na catraca {InnerAtual.Numero}.");
// Mudar o estado para validar a senha
InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_VALIDAR_ACESSO;
InnerAtual.UltimoEvento = new EventoCatraca(origem, complemento, sbCartao.ToString(), dia, mes, ano,
hora, minuto, segundo);
break;

case (byte)Enumeradores.Origem.ORIGEM_GIRO_CATRACA_TOPDATA:
// Evento de giro da catraca
Console.WriteLine($"Giro confirmado na catraca {InnerAtual.Numero}.");
// Registrar o acesso efetivo
// Mudar o estado de volta para POLLING ou outro estado apropriado
InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_POLLING;
InnerAtual.UltimoEvento = new EventoCatraca(origem, complemento, sbCartao.ToString(), dia, mes, ano,
hora, minuto, segundo);
break;

case (byte)Enumeradores.Origem.ORIGEM_CARTAO_RECOLHIDO_URNA:
// Evento de cartão recolhido pela urna
Console.WriteLine($"Cartão {sbCartao.ToString()} recolhido pela urna da catraca {InnerAtual.Numero}.");
// Mudar o estado para processar o cartão recolhido
InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_VALIDAR_ACESSO_URNA; // Exemplo de novo estado
InnerAtual.UltimoEvento = new EventoCatraca(origem, complemento, sbCartao.ToString(), dia, mes, ano,
hora, minuto, segundo);
break;

case (byte)Enumeradores.Origem.ORIGEM_URNA_CHEIA:
// Evento de urna cheia
Console.WriteLine($"Urna da catraca {InnerAtual.Numero} está cheia.");
// Notificar o operador, impedir novos depósitos, etc.


// Permanecer no estado POLLING
InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_POLLING;
InnerAtual.UltimoEvento = new EventoCatraca(origem, complemento, sbCartao.ToString(), dia, mes, ano,
hora, minuto, segundo);
break;

case (byte)Enumeradores.Origem.ORIGEM_QRCODE:
// Evento de leitura QR Code
Console.WriteLine($"QR Code {sbCartao.ToString()} lido na catraca {InnerAtual.Numero}.");
// Mudar o estado para validar o QR Code
InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_VALIDAR_ACESSO; // Ou um estado específico
para QR Code
InnerAtual.UltimoEvento = new EventoCatraca(origem, complemento, sbCartao.ToString(), dia, mes, ano,
hora, minuto, segundo);
break;

// ... outros casos de origem ...

default:
// Outras origens ou origens não tratadas
Console.WriteLine($"Evento desconhecido da catraca {InnerAtual.Numero}. Origem: {origem}, Complemento:
{complemento}");
// Permanecer no estado POLLING ou tratar conforme a lógica
InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_POLLING;
InnerAtual.UltimoEvento = new EventoCatraca(origem, complemento, sbCartao.ToString(), dia, mes, ano,
hora, minuto, segundo);
break;
}
}
// ... (restante do loop de polling para sem eventos, erros, etc.)
```

Entender as origens de evento permite que sua aplicação no modo online saiba exatamente o que está acontecendo na catraca e reaja a cada interação do usuário ou do equipamento. 

Você está certíssimo! A coleta de bilhetes (EasyInner.ColetarBilhete()) é uma funcionalidade crucial não apenas para a Catraca Expedidora, mas para **qualquer catraca ou coletor que opere em modo offline** em algum momento. Essa coleta é o meio pelo qual o Software de Integração recupera o histórico de acessos registrados localmente no equipamento durante períodos de desconexão.

### 4.4 Coleta de Bilhetes Offline

Qualquer catraca ou coletor configurado para operar no modo offline (totalmente ou em momentos de desconexão automática) registra os eventos de acesso em sua memória interna como **bilhetes**. Esses bilhetes representam o histórico de quem acessou, quando e como. Sua aplicação deve coletar esses bilhetes para manter seu banco de dados centralizado atualizado. Este processo é geralmente executado após a catraca estabelecer ou restabelecer a conexão online.

#### 4.4.1 EasyInner.ColetarBilhete(): Recuperando Registros Offline

Esta função é utilizada para coletar os bilhetes armazenados na memória de um equipamento que operou em modo offline. Ela coleta um bilhete Offline que está armazenado na memória do Inner.

- Propósito: Recuperar um registro de evento de acesso armazenado localmente no equipamento.

- Comportamento: Sua aplicação deve chamar EasyInner.ColetarBilhete() repetidamente para uma catraca específica (no estado ESTADO_COLETAR_BILHETES ou similar). A cada chamada bem-sucedida que retorna 0 (sucesso), a função preenche os parâmetros de saída com os dados de um bilhete e o remove da memória do equipamento. Se não houver mais bilhetes pendentes, ela retornará um código indicando "sem bilhetes".

- **Parâmetros (C#):**
```csharp
// Exemplo de parâmetros para a função ColetarBilhete
// Os dados do bilhete são retornados por referência ou via PChar/StringBuilder
EasyInner.ColetarBilhete(
int NumeroInner, // [Entrada] Número da catraca
ref byte Tipo, // [Saída] Tipo do bilhete (acesso, negação, etc.)
ref byte Dia, // [Saída] Dia do evento
ref byte Mes, // [Saída] Mês do evento
ref byte Ano, // [Saída] Ano do evento
ref byte Hora, // [Saída] Hora do evento
ref byte Minuto, // [Saída] Minuto do evento
StringBuilder Cartao // [Saída] Número do cartão do usuário (ou informação relevante)
);
```

- NumeroInner: O número de identificação da catraca que está coletando os bilhetes.
- Tipo: Indica o tipo específico do bilhete coletado (semelhante às origens, mas para registros offline). Alguns tipos comuns: 10 (Entrada pelo cartão), 11 (Saída pelo cartão), 12 (Tentativa de entrada negada), 13 (Tentativa de saída negada), 110 (Entrada pelo teclado), etc. O valor 128 indica bilhete repetido recebido do Inner (página 102).
- **Dia, Mes, Ano, Hora, Minuto:** Data e hora do evento registrado.
- **Cartao:** Contém o número do cartão do usuário associado ao bilhete.

- **Exemplo de Uso (C# - dentro de um estado ESTADO_COLETAR_BILHETES):**
```csharp
// Supondo que 'InnerAtual' representa a catraca que operou offline
// e que 'sbCartao' é um StringBuilder inicializado

byte tipoBilhete = 0 ;
byte dia = 0 , mes = 0 , ano = 0 , hora = 0 , minuto = 0 ;
StringBuilder sbCartao = new StringBuilder( 20 );

Console.WriteLine($"Iniciando coleta de bilhetes offline da catraca {InnerAtual.Numero}...");

// Loop para coletar todos os bilhetes pendentes
while (true)
{
// Tenta coletar um bilhete
int ret = EasyInner.ColetarBilhete(
InnerAtual.Numero,
ref tipoBilhete,
ref dia, ref mes, ref ano, ref hora, ref minuto,
sbCartao
);

if (ret == (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
// Bilhete coletado com sucesso!
Console.WriteLine($"Bilhete coletado: Tipo={tipoBilhete}, Cartão={sbCartao.ToString()},
Data/Hora={dia}/{mes}/{ano} {hora}:{minuto}");

// Processar o tipo de bilhete (ver tipos comuns) e registrar no seu sistema central
// O loop continua para coletar o próximo bilhete
}
else if (ret == (int)Enumeradores.Retorno.RET_SEM_BILHETES) // Exemplo de retorno para "sem bilhetes"
{
// Não há mais bilhetes pendentes nesta catraca
Console.WriteLine($"Catraca {InnerAtual.Numero}: Coleta de bilhetes offline finalizada.");
// Máquina de estados: Transitar para o próximo estado (ex: ESTADO_POLLING)
InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_POLLING;
break; // Sai do loop de coleta
}
else
{

// Erro na comunicação durante a coleta
Console.WriteLine($"Erro ao coletar bilhete da catraca {InnerAtual.Numero}: {ret}");
// Máquina de estados: Tratar erro, talvez transitar para ESTADO_RECONECTAR
InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_RECONECTAR;
break; // Sai do loop de coleta
}
}
```

- Fluxo na Máquina de Estados: O estado ESTADO_COLETAR_BILHETES (ou um estado similar no seu design da FSM) deve ser alcançado sempre que uma catraca que pode operar offline se conecta ou reconecta. Dentro desse estado, o loop de ColetarBilhete deve ser executado até que todos os bilhetes sejam recuperados (retorno indicando sem bilhetes). Em seguida, a catraca pode transitar para o modo online (ESTADO_POLLING) se essa for a configuração padrão, ou permanecer offline, dependendo do seu sistema.

Esta funcionalidade é vital para sistemas que não exigem controle online 100% do tempo, garantindo que nenhum registro de acesso seja perdido.

### 4.5 Liberando o Acesso da Catraca

No modo online, após seu Software de Integração receber um evento de acesso (como a leitura de um cartão, Origem 2 ou 3) e validar que o acesso é permitido (no estado ESTADO_VALIDAR_ACESSO), o próximo passo é enviar um comando para a catraca liberar o mecanismo de giro. As funções EasyInner.LiberarCatraca...() são utilizadas para este propósito.

- Propósito: Enviar um comando para a catraca destravar o mecanismo de giro, permitindo que o usuário passe.
- Comportamento: Sua aplicação deve chamar a função apropriada (dependendo do sentido desejado) após validar o acesso. A catraca receberá o comando e acionará o relé correspondente pelo tempo configurado nos acionamentos (ConfigurarAcionamento1/2) ou pelo tempo padrão de liberação.
- Onde Usar: Estas funções são tipicamente chamadas no estado ESTADO_LIBERAR_CATRACA da sua máquina de estados, após o ESTADO_VALIDAR_ACESSO confirmar que o acesso é permitido. 
 
Aqui estão as principais funções de liberação:


- **EasyInner.LiberarCatracaEntrada():**
	- **Descrição:** Libera o giro da catraca especificamente para o sentido de **entrada**.
	- **Parâmetros:**
		- Inner (int): O número de identificação da catraca (1 a 99).
	- **Exemplo (C#):**

```csharp
// Libera a catraca para a entrada
EasyInner.LiberarCatracaEntrada(InnerAtual.Numero);
```

- **EasyInner.LiberarCatracaSaida():**
	- **Descrição:** Libera o giro da catraca especificamente para o sentido de **saída**.
	- **Parâmetros:**
		- Inner (int): O número de identificação da catraca (1 a 99).
	- **Exemplo (C#):**

```csharp
// Libera a catraca para a saída
EasyInner.LiberarCatracaSaida(InnerAtual.Numero);
```

- **EasyInner.LiberarCatracaDoisSentidos():**
	- **Descrição:** Libera o giro da catraca em **ambos os sentidos** (entrada e saída).
	- **Parâmetros:**
		- Inner (int): O número de identificação da catraca (1 a 99).
	- **Exemplo (C#):**

```csharp
// Libera a catraca em ambos os sentidos
EasyInner.LiberarCatracaDoisSentidos(InnerAtual.Numero);
```

- **Funções Invertidas (EasyInner.LiberarCatracaEntradaInvertida(), EasyInner.LiberarCatracaSaidaInvertida()):** Algumas instalações podem exigir que o sentido de liberação seja invertido em relação ao padrão. As funções LiberarCatracaEntradaInvertida e LiberarCatracaSaidaInvertida existem para esses casos. Consulte a documentação e os exemplos SDK para determinar a necessidade de uso baseado na orientação física da catraca.

**Tempo de Liberação:** O tempo que a catraca permanece destravada após um comando de liberação é definido nas configurações de acionamento (EasyInner.ConfigurarAcionamento1() / ConfigurarAcionamento2(), seção 4.1.5) ou por um tempo padrão interno do firmware. O "tempo de giro" não é uma configuração separada, mas sim a duração em que o relé de liberação permanece acionado, permitindo o giro.

**Após a Liberação:** Depois de enviar o comando de liberação, sua máquina de estados deve geralmente transitar para um estado para **monitorar se o giro realmente ocorreu** (como ESTADO_MONITORA_GIRO_CATRACA). Isso é feito continuando a chamar EasyInner.ReceberDadosOnLine() e esperando um evento de Origem 6 (ORIGEM_GIRO_CATRACA_TOPDATA), que confirma o giro bem-sucedido. Se um evento Origem 5 (ORIGEM_FIM_TEMPO_ACIONAMENTO) for recebido antes da Origem 6, significa que o tempo de liberação expirou e o giro não ocorreu.

**Exemplo de Código para Liberação (C# - Dentro do Estado ESTADO_VALIDAR_ACESSO ou ESTADO_LIBERAR_CATRACA):**

```csharp
// Supondo que 'InnerAtual' representa a catraca
// Supondo que a lógica de validação no ESTADO_VALIDAR_ACESSO definiu que o acesso é permitido e qual o
sentido

public void ProcessarLiberacao(Inner InnerAtual)
{
// Exemplo: Lógica para liberar baseado no sentido validado anteriormente
int ret = - 1 ;

// Supondo que InnerAtual.SentidoValidado seja 'Entrada' ou 'Saida'
if (InnerAtual.SentidoValidado == "Entrada")
{
Console.WriteLine($"Acesso permitido para entrada na catraca {InnerAtual.Numero}. Liberando giro...");
ret = EasyInner.LiberarCatracaEntrada(InnerAtual.Numero); // Ou LiberarCatracaEntradaInvertida
}
else if (InnerAtual.SentidoValidado == "Saida")
{
Console.WriteLine($"Acesso permitido para saída na catraca {InnerAtual.Numero}. Liberando giro...");
ret = EasyInner.LiberarCatracaSaida(InnerAtual.Numero); // Ou LiberarCatracaSaidaInvertida
}
else // Ex: Acesso liberado para ambos
{
Console.WriteLine($"Acesso permitido para ambos os sentidos na catraca {InnerAtual.Numero}. Liberando
giro...");
ret = EasyInner.LiberarCatracaDoisSentidos(InnerAtual.Numero);
}


if (ret == (int)Enumeradores.Retorno.RET_COMANDO_OK)
{
Console.WriteLine($"Comando de liberação enviado com sucesso para catraca {InnerAtual.Numero}.");
// Máquina de estados: Mudar para monitorar o giro
InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_MONITORA_GIRO_CATRACA;
}
else
{
Console.WriteLine($"Erro ao enviar comando de liberação para catraca {InnerAtual.Numero}: {ret}");
// Máquina de estados: Tratar erro, talvez transitar para ESTADO_POLLING ou ESTADO_RECONECTAR
InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_POLLING; // Exemplo
}
}
```

Liberar o acesso da catraca é um dos comandos mais frequentes no modo online, diretamente vinculado à lógica de validação do seu sistema.

### 4.6 Outros Comandos Úteis

Além dos comandos essenciais para configuração, gerenciamento de usuários offline, recebimento de eventos e liberação de acesso, a EasyInner.dll oferece outras funções úteis para interagir com as catracas.

#### 4.6.1 Comandos de Data/Hora

É fundamental manter a data e hora das catracas sincronizadas para garantir a precisão dos registros de acesso.

- **EasyInner.EnviarRelogio():** Configura a data e hora da catraca.
	- Parâmetros (C#): int Inner, byte Dia, byte Mes, byte Ano, byte Hora, byte Minuto, byte Segundo.
	- **Exemplo:** Enviar a data/hora atual do servidor para a catraca.
- EasyInner.ReceberRelogio(): Solicita a data e hora atualmente configuradas na catraca.
	- Parâmetros (C#): int Inner, ref byte Dia, ref byte Mes, ref byte Ano, ref byte Hora, ref byte Minuto, ref byte Segundo.
	- **Exemplo:** Verificar a data/hora da catraca.
- **EasyInner.EnviarHorarioVerao():** Configura o período de horário de verão na catraca.

#### 4.6.2 Comandos de Sinalização (Bips e LEDs)

Estes comandos permitem interagir com os elementos de sinalização visual e sonora da catraca para fornecer feedback ao usuário.

- **EasyInner.AcionarBipCurto() / EasyInner.AcionarBipLongo():** Fazem a catraca emitir um bip curto ou longo.
	- **Parâmetros (C#):** int Inner.
- **EasyInner.LigarLedVerde() / EasyInner.DesligarLedVerde():** Controlam o LED verde (geralmente indica acesso liberado).
	- **Parâmetros (C#):** int Inner. Função somente para Inner Acesso.
- **EasyInner.LigarLedVermelho() / EasyInner.DesligarLedVermelho():** Controlam o LED vermelho (geralmente indica acesso negado).
	- **Parâmetros (C#):** int Inner. Função somente para Inner Acesso.
- **EasyInner.LigarBackLite() / EasyInner.DesligarBackLite():** Controlam a luz de fundo do display.
	- **Parâmetros (C#):** int Inner.

#### 4.6.3 Comandos de Mensagens no Display

Permitem exibir mensagens personalizadas no display da catraca (no modo online).

- **EasyInner.EnviarMensagemPadraoOnLine():** Envia uma mensagem fixa para ser exibida no display enquanto a catraca está ociosa no modo online.
	- **Parâmetros (C#):** int Inner, byte ExibirData, string Mensagem. ExibirData controla se a data/hora é exibida na linha superior. O tamanho da mensagem é limitado (32 caracteres ou 16 se exibir data/hora).
- **EasyInner.EnviarMensagemTemporariaOnLine():** Envia uma mensagem que será exibida por um tempo determinado.

#### 4.6.4 Outros Comandos

- **EasyInner.PingOnline():** Essencial para manter a catraca em modo online quando configurada para a mudança automática modo 2 (HabilitarMudancaOnLineOffLine(2, ...)). Deve ser enviado periodicamente (intervalo menor que o tempo configurado na mudança automática).
	- **Parâmetros (C#):** int Inner.

- **EasyInner.FecharPortaComunicacao():** Fecha a porta de comunicação aberta por EasyInner.AbrirPortaComunicacao(). Essencial ao finalizar a aplicação.

**Tabela 6: Resumo de Outros Comandos Úteis**

| **Comando (C#)** | **Parâmetros (Tipos)** | **Propósito / Descrição** | **Notas** |
|------------------|------------------------|----------------------------|------------|
| EasyInner.EnviarRelogio(Inner, Dia, Mes, Ano, Hora, Minuto, Segundo) | int, byte, byte, byte, byte, byte, byte | Configura a data e hora da catraca. | Essencial para sincronização. |
| EasyInner.ReceberRelogio(Inner, ref Dia, ref Mes, ref Ano, ref Hora, ref Minuto, ref Segundo) | int, ref byte, ref byte, ref byte, ref byte, ref byte, ref byte | Solicita e recebe a data e hora atual da catraca. | Use para verificar sincronização. |
| EasyInner.EnviarHorarioVerao(Inner, DiaInicio, MesInicio, AnoInicio, HoraInicio, MinutoInicio, DiaFim, MesFim, AnoFim, HoraFim, MinutoFim) | int, byte, byte, byte, byte, byte, byte, byte, byte, byte, byte | Configura o período de horário de verão na catraca (início e fim completos). | Configuração sazonal. |
| EasyInner.AcionarBipCurto(Inner) | int | Faz a catraca emitir um bip curto. | Feedback sonoro (ex: acesso permitido/negado). |
| EasyInner.AcionarBipLongo(Inner) | int | Faz a catraca emitir um bip longo. | Feedback sonoro (ex: atenção, erro). |
| EasyInner.LigarLedVerde(Inner) | int | Acende o **LED verde** no display da catraca. | Sinalização visual (ex: acesso liberado). Somente Inner Acesso. |
| EasyInner.DesligarLedVerde(Inner) | int | Desliga o **LED verde**. | Desliga sinalização. Somente Inner Acesso. |
| EasyInner.LigarLedVermelho(Inner) | int | Acende o **LED vermelho** no display da catraca. | Sinalização visual (ex: acesso negado). Somente Inner Acesso. |
| EasyInner.DesligarLedVermelho(Inner) | int | Desliga o **LED vermelho**. | Desliga sinalização. Somente Inner Acesso. |
| EasyInner.LigarBackLite(Inner) | int | Acende a luz de fundo do display da catraca. | Melhora visibilidade do display. |
| EasyInner.DesligarBackLite(Inner) | int | Desliga a luz de fundo do display. | Desliga iluminação. |
| EasyInner.EnviarMensagemPadraoOnLine(Inner, ExibirData, Mensagem) | int, byte, string | Exibe uma mensagem fixa no display em modo online ocioso. | Útil para mensagens de boas-vindas. Tamanho limitado. |
| EasyInner.EnviarMensagemTemporariaOnLine(Inner, ExibirData, Mensagem, Tempo) | int, byte, string, byte | Exibe uma mensagem por um tempo determinado. | Para mensagens de status temporárias. |
| EasyInner.PingOnline(Inner) *(Comando 26)* | int | Testa a comunicação e mantém a catraca online (se configurada para mudança automática modo 2). | Essencial para estabilidade em modo online com mudança automática. |
| EasyInner.FecharPortaComunicacao() | (void) | Fecha a porta de comunicação aberta por `AbrirPortaComunicacao()`. | Chamar ao encerrar a aplicação. |

Esta tabela resume alguns dos comandos úteis que podem ser integrados à sua aplicação para melhorar a interação com a catraca. Para detalhes completos de parâmetros, retornos e comportamento, consulte os exemplos SDK. Ao integrar esses comandos em sua máquina de estados, você pode criar uma experiência de usuário mais completa e informativa na catraca.