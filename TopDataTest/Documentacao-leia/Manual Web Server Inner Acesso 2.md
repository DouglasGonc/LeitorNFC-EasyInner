
## Índice


- Web Server Inner Acesso
- 1. APRESENTAÇÃO ÍNDICE
- 2. INFORMAÇÕES GERAIS
- 2.1 Navegadores compatíveis
- 2.2 Aspectos importantes sobre a utilização do Web Server
- 3. ACESSAR O WEB SERVER
- 3.1 Configurar o computador
- 4. LOGIN
- 5. PRINCIPAL
- 6. LIBERAR ACESSO
- 7. ADMINISTRADOR
- 8. CONFIGURAÇÕES
- 8.1 ACESSO
- 8.1.1 Função de Controle
- 8.1.2 Padrão do Cartão
- 8.1.3 Operação Inner Principal
- 8.1.4 Operação Leitor Externo
- 8.1.5 Configuração Botão de Liberação
- 8.1.6 Tempo de Acesso
- 8.1.7 Habilita Sinalização Sonora
- 8 .2 SEGURANÇA
- 8.2.1 Controle do acesso
- 8.2.2 Sensor de porta aberta
- 8.2.3 Registra acesso negado
- 8.2.4 Registra falha na verificação biométrica
- 8.2.5 Habilita sensor de violação
- 8.3 COMUNICAÇÃO
- 8.3 BIOMETRIA 8.3.1 Configuração de comunicação de rede Erro! Indicador não definido.
- 8.3.2 Habilita Identificação
- 8.3.3 Habilita Verificação
- 8.3. 4 Nível de segurança
- 8.4 RELÓGIO Índice
- 8.4.2 Atualizar relógio
- 8.4. 3 Horário de verão
- 8.5 MASTER
- 8.5.2 Cadastrar cartão do Master
- 8.5.3 Cadastrar biometria do Master
- 8.5.4 Excluir biometria do Master
- 9. LISTA DE ACESSO
- 9.1 Incluir usuário
- 9.2 Cadastro de cartão
- 9.3 Cadastro de biometria
- 9.4 Cadastro de horários
- 9.5 Tabelas de horários
- 9.6 Lista de biometrias
- 10. REGISTROS
- 11. IMPORTAÇÃO E EXPORTAÇÃO NO WEB SERVER
- 11.1 IMPORTAÇÃO E EXPORTAÇÃO DE CONFIGURAÇÕES
- 11.2 IMPORTAÇÃO E EXPORTAÇÃO DE LISTA DE ACESSO
- 11.3 IMPORTAÇÃO E EXPORTAÇÃO DE BIOMETRIAS
- 12. DESABILITAR WEB SERVER
- 12.1 GERENCIADOR DE INNERS
- 12.2 TOPACESSO...........................................................................................................
- 13. DÚVIDAS FREQUENTES
- 14. ESPECIFICAÇÕES TÉCNICAS
- 15. HISTÓRICO DE REVISÕES DESTE MANUAL


## Nota ao Usuário

### NOTA AO USUÁRIO

```
Preparamos este manual para que você possa conhecer cada detalhe do Web Server do Inner
Acesso 2 , assim como utilizá-lo da maneira correta.
```
```
Recomendamos que o leia com atenção, seguindo todas as orientações e recomendações.
```

## 1. APRESENTAÇÃO ÍNDICE

```
Este manual foi desenvolvido para que você possa conhecer os principais detalhes do Web Server
embarcado do Inner Acesso 2.
O Inner Acesso 2 possibilita através do seu Web Server à comunicação com o Inner através de um
navegador Web. O acesso ao Web Server é realizado sem a necessidade de instalação de
software específico.
Através da sua interface Web, permite realizar e alterar configurações, cadastrar usuários,
exportar registros, atualização do relógio e abertura da porta.
O Web Server é através da interface de rede por meio de um navegador Web podendo ser
acessado através de computadores e dispositivos móveis como tablets e celulares. O acesso é
protegido por senha para evitar que pessoas não autorizadas realizem operações indevidas no
equipamento.
```
```
Dentre as principais funções do Web Server do Inner Acesso 2 destacam-se:
```
- Cadastro de usuários por cartão e biometria;
- Cadastro do usuário Master por cartão, QR Code e biometria;
- Alteração e exclusão de usuários;
- Alteração do usuário Master;
- Exportação e Importação de Configurações de acesso, segurança, biometria e master;
- Exportação e Importação de lista de acesso;
- Exportação e Importação de templates biométricos;
- Criação de tabelas para controle de acesso por horário e dias da semana;
- Abertura da porta ou torniquete;
- Alteração de configurações de acesso;
- Alteração de configurações de segurança;
- Alteração de configurações de comunicação de rede;
- Alteração de configurações de biometria;
- Atualização do relógio e configurações do horários de verão;
- Exportação de registros de acessos;
- Informações gerais do Inner;
- Alteração do usuário e senha de acesso ao Web Server;
- Consulta da versão de firmware;


## 2. INFORMAÇÕES GERAIS

## 2.1 Navegadores compatíveis

Navegadores compatíveis com o Web Server Inner Acesso 2:

Navegador Versão

Google Chrome Versão 73 ou superior

Mozilla Firefox Versão 47 ou superior

Edge Versão 41 ou superior

Internet Explorer Versão 11 ou superior

Opera Versão 58 ou superior

## 2.2 Aspectos importantes sobre a utilização do Web Server

 O Web Server pode ser desabilitado através dos softwares Gerenciador de Inners e TopAcesso;
 Não possui tempo de expiração da sessão;
 A Topdata recomenda que seja alterada a senha do usuário ADMIN de acesso ao Web Server;
 A Topdata recomenda a utilização dos navegadores compatíveis para evitar possíveis erros
durante a navegação no Web Server;
 Navegação no Web Server: durante a navegação do Web Server do Inner Acesso 2, clique em
cada menu ou botão e sempre aguarde a resposta do Inner antes de realizar outras operações;
 É recomendado permanecer com o usuário ADMIN conectado em apenas um computador de
cada vez.


## 3. ACESSAR O WEB SERVER

Para acessar o Web Server do Inner Acesso 2 você pode utilizar o navegador compatível de sua
preferência. Por padrão, o Inner Acesso 2 sai de fábrica com o IP 192.168.1.123. Digite este IP na
barra de endereços do seu navegador:

Após iniciar o acesso, será exibida a mensagem “CARREGANDO...” enquanto o Web Server está
sendo carregado:

Obs.: para acessar o Web Server, é necessário que o computador esteja na mesma faixa de IP
que o Inner Acesso 2. Caso a sua rede possua outra faixa de IP, recomendamos a conexão de um
cabo de rede conectado diretamente entre o Inner e o Computador e ajuste o IP do computador
manualmente.


## 3.1 Configurar o computador

A seguir apresentamos um exemplo para ajustar o IP do computador utilizando o sistema
operacional Windows, para o IP padrão do **Servidor** do Inner Acesso 2, que é o 192.168.1.100.

Acesse o Painel de Controle do Windows, e acesse as configurações de **Rede e Internet** :

Depois acesse as configurações da **Central de Rede e Compartilhamento** :


Onde são exibidas as redes ativas, clique na conexão **Ethernet** :

Será exibido o status da conexão. Clique em **Propriedades** para configurar a conexão de rede
com o Inner:


Selecione o **Protocolo TCP/IP Versão 4 (TCP/IPv4)** , e clique em **Propriedades** :

Selecione a opção **Usar o seguinte endereço IP** , e preencha os campos conforme o exemplo a
seguir:

Salve as configurações e tente acessar o Web Server pelo navegador Web novamente.


## 4. LOGIN

Quando o Web Server concluir o carremento das informações para o navegador, será exibida a
tela de login. Insira o Usuário e Senha nos campos do login e clique em **Iniciar Sessão** :

**Usuário e senha padrão:
Usuário:** ADMIN (letras maiúsculas)
**Senha:** Inner@cesso2 (primera letra em maiúsculo)

Por questões de segurança, a Topdata recomenda que o Usuário e Senha padrão do Web Server
sejam alterados. Consulte o tópico “ **Administrador** ” para obter mais detalhes sobre como
realizar esta alteração.


## 5. PRINCIPAL

Após realizar o login, será apresentada a tela Principal do Web Server, que exibe as principais
informações sobre o Inner Acesso 2:

```
 Modelo : modelo do equipamento;
 Número de série : número de série do equipamento;
 Porta do Inner : porta de comunicação utilizada pelos softwares de configuração ou
controle de acesso;
 Endereço IP do Servidor : endereço IP do computador quando for utilizado software para
configuração ou controle de acesso;
 Nº MAC do Inner : endereço físico do equipamento;
 Nº do Inner : número do Inner, utilizado pelos softwares de configuração ou controle de
acesso.
 Qtd. Biometrias : para o Inner Acesso 2 Bio, exibe a quantidade de digitais que estão
gravadas no equipamento;
 Versão FW: exibe a versão do firmware do Inner Principal;
 Inner Complementar : informa se há um Inner Complementar conectado. Se “Sim”,
também é exibida a versão do firmware do Inner Complementar entre parênteses.
```

## 6. LIBERAR ACESSO

Pelo Web Server é possível liberar acesso direto ao local (porta, torniquete, portão e etc)
clicando no botão **Liberar Acesso** :

## 7. ADMINISTRADOR

Utilize a tela Administrador para alterar o Usuário e Senha de acesso ao Web Server:

O Web Server possui apenas um usuário que vem como padrão “ADMIN” e pode ser
alterado.
Para os campos Usuário e Senha são permidos inserir até 50 caracteres entre letras,
números e caracteres especiais, com exceção do caracter especial “:” (dois pontos).
Por questões de segurança, a Topdata recomenda que o Usuário e Senha padrão do Web
Server sejam alterados.


## 8. CONFIGURAÇÕES

Clique em **Gerenciamento => Configurações** para abrir a tela de configurações do Inner
Acesso 2:

As alterações de configurações serão aplicadas para o Inner Principal e para o Inner
Complementar.

## 8.1 ACESSO

Na tela Acesso é possível alterar as configurações relacionadas ao acesso dos usuários e a
função do Inner sendo controle de porta ou torniquete. Clique em **Editar** para liberar a edição
dos campos e ao final clique em **Salvar** para salvar as configurações no Inner Acesso 2:

## 8.1.1 Função de Controle

É possível escolher qual tipo de controle de acesso o Inner Acesso 2 irá fazer, sendo eles
Porta ou Torniquete.


**Função de Controle – Porta**
Selecionar esta opção caso o Inner Acesso 2 for utilizado para controlar o acesso de
portas, portões, cancelas e etc.
**Função de Controle – Torniquete**
Selecionar esta opção caso o Inner Acesso 2 for utilizado para controlar o acesso de
torniquetes. Para uso em torniquites bidirecionais será preciso o uso de dois Inner Acesso
2 Principal, um para cada lado do torniquete.

## 8.1.2 Padrão do Cartão

```
É possível configurar de forma flexível o padrão de cartão a ser utilizado pelo Inner Acesso
```
2. Por padrão, o tipo do leitor é configurado como ABATRACK / QRCODE.

Se necessário o tipo de cartão pode ser alterado conforme as seguintes opções:

Algumas opções com o tipo de leitor e quantidade de dígitos fixos são listadas para facilitar
o processo de configuração. Caso deseje outra opção que não esteja na lista, selecione a opção
CUSTOMIZADO e configure o tipo de leitor, quantidade de dígitos desejado, caso deseje pode ser
configurado como dígitos variáveis.

No exemplo a seguir o modo customizado está configurado com dígitos fixos, ou seja, só pode ser
usado cartão de proximidade AbaTrack com 14 dígitos.


No exemplo a seguir o modo customizado está configurado com dígitos variáveis, ou seja, pode
ser usado cartão de proximidade AbaTrack com 8,10 ou 14 dígitos.

```
 Abatrack : para configurar o padrão do leitor como Abatrack e ou QR Code. Para
equipamentos com QR Code embutido por padrão pode ser lido códigos de 4 a 16 dígitos
variáveis. Para cartões AbaTrack será lido os dígitos contido no cartão de acordo com o
tipo do mesmo. Por exemplo, cartões TopProx serão lidos 14 dígitos ou TopSmart serão
lidos 10 dígitos.
 Wiegand: para configurar o padrão do leitor com Wiegand 26 bits e 37 bits.
 Wiegand Facility Code: para configurar o padrão do leitor com Wiegand 26 e 37 bits com
Facility Code. Nesta configuração é inserido o número “zero” para separar o código FC do
número Wiegand.
 Wiegand Facility Code s/ separador: para configurar o padrão do leitor com Wiegand 26
e 37 bits com Facility Code sem o número zero como separador.
 Número de dígitos: para configurar o número de dígitos compatível com o leitor
utilizado.
 Habilitar Dígitos Variáveis: Para utilizar uma faixa de dígitos que serão lidos entre 4 a 16
dígitos.
```
**Exemplo de leitura de um cartão em Abatrack, Wiegand e Wiegand com Facility Code:
Abatrack Wiegand Wiegand Facility Code Wiegand Facility Code s/ separador**
4370241601 38977 124038977 12438977


## 8.1.3 Operação Inner Principal

Definição da forma de acesso, podendo ter a função de entrada ou saída e do tipo de bilhete que
será gravado na memória pelo leitor interno do Inner Acesso 2:

```
 ENTRADA: todas as leituras de cartão serão consideradas como entrada.
 SAÍDA: todas as leituras de cartão serão consideradas como saída.
```
**Observações:**

- O acesso por biometria terá a mesma forma configurada no leitor principal.
- Quando o Inner Acesso 2 for utilizado com o Inner Complementar, não é necessário realizar
nenhuma configuração do Inner Complementar quanto à entrada ou saída. Automaticamente o
Inner Complementar terá a configuração inversa à configuração do Inner Principal.

```
Inner Principal como ENTRADA = Inner Complementar como SAIDA
Inner Principal como SAIDA = Inner Complementar como ENTRADA
```
Acesse o tópico Bilhetes para saber mais sobre os tipos de bilhetes.

## 8.1.4 Operação Leitor Externo

O funcionamento do “Leitor Externo” sempre estará associado à configuração do “Leitor 2”. A
forma de acesso pode ser entrada ou saída e o tipo de bilhete que será gravado na memória pelo
leitor externo que opcionalmente pode ser instalado do Inner Acesso 2. Também é possível
deixá-lo como DESABILITADO.

```
 DESABILITADO: o leitor externo fica desabilitado.
 ENTRADA: todas as leituras de cartão serão consideradas como entrada.
 SAÍDA: todas as leituras de cartão serão consideradas como saída.
```

Exemplos de configuração com o uso do “Leitor Externo”.

```
 “Operação Inner Principal” com “Leitor Externo” e sem “Complementar”:
```
A “Operação Inner Principal” será “Somente entrada” e “Operação Leitor Externo” será
“Somente saída”. Para isso no Web Server, deve – se configurar como no exemplo a seguir:

A “Operação Inner Principal” será “Somente Saída” e “Operação Leitor Externo” será “Somente
Entrada”. Para isso no Web Server, deve – se configurar como no exemplo a seguir:

Acesse o tópico Bilhetes para saber mais sobre os tipos de bilhetes.

```
 “Inner Principal” com Leitor Externo e com “Complementar”:
```
Todos os leitores do “Inner Principal”, inclusive o seu “Leitor Externo” operam como “Somente
Entrada”.
Todos os leitores do “Complementar”, inclusive o seu “Leitor Externo” operam como “Somente
Saída”.

```
 “Inner Principal” com Leitor Externo no modo de operação “Torniquete”:
```

Quando em modo torniquete leitor do Inner Principal e o leitor externo, obrigatoriamente serão
para o mesmo sentido de acesso caso o leitor externo esteja habilitado. Ou seja, ambos entrada
ou ambos saída.
Quando o Inner Acesso 2 está controlando um torniquete, não deve ser utilizado o Inner Acesso 2
Complementar. A razão disso é que caso queira utilizar um torniquete bidirecional (que libera
acesso para ambos os lados) é nescessário instalar dois Inner Acesso 2 Principal, um para cada
lado de acesso ao torniquete.

## 8.1.5 Configuração Botão de Liberação

Configuração do botão externo de liberação que opcionalmente pode ser instalado no Inner
Acesso 2 para liberação da porta:

```
 DESABILITADO: Botão desabilitado.
 NORMALMENTE ABERTO: A porta é liberada quando o contato do botão for fechado.
 NORMALMENTE FECHADO: A porta é liberada quando a contato do botão for aberto.
```
## 8.1.6 Tempo de Acesso

Configuração do tempo em segundos que a porta ou torniquete deve permanecer ativo após a
liberação do acesso por cartão, biometria ou acionamento do botão externo de liberação:

Tempo configurável entre 1 e 255 segundos.

## 8.1.7 Habilita Sinalização Sonora

Configuração que permite habilitar ou desabilitar a sinalização sonora do Inner Acesso 2. Quando
desabilitado o Inner passar a operar emitindo apenas sinalizações luminosas através do seu led
frontal.


## 8 .2 SEGURANÇA

Na tela Segurança é possível alterar as configurações relacionadas à segurança do sistema.
Clique em **Editar** para liberar a edição dos campos e ao final clique em **Salvar** para salvar as
configurações no Inner Acesso 2:

## 8.2.1 Controle do acesso

Determina a forma de como será realizado o controle do acesso dos usuários.

```
 Desabilitado : Nesta configuração o controle do acesso fica desabilitado, qualquer cartão
ou biometria que for identificado pelo Inner terá o acesso liberado e o registro na
memória de bilhetes.
 Cartão não cadastrado não pode passar: Nesta configuração, somente usuários que
estiverem na lista de acesso como “Liberado” ou “Conforme horário” e dentro de pelo
menos um horário válido terão o acesso liberado e o registro na memória de bilhetes.
 Cartão não cadastrado pode passar: Nesta configuração o controle de acesso é realizado
apenas para os usuários cadastrados na lista de acesso. Cartões e biometrias que não
estiverem na lista de acesso terão o acesso liberado e o registro na memória de bilhetes.
```

## 8.2.2 Sensor de porta aberta

Configuração do sensor de porta aberta que pode opcionalmente ser instalado no Inner Acesso 2
para gerar um alarme caso a porta tenha sido aberta sem autorização ou permaneça aberta por
um tempo superior ao configurado no campo “Tempo” para aviso de porta aberta:

```
 DESABILITADO : Sensor de porta desabilitado.
 NORMALMENTE ABERTO : Sensor com contato aberto indica que a porta está fechada.
 NORMALMENTE FECHADO : Sensor com contato fechado indica que a porta está fechada.
 Tempo para Aviso de Porta Aberta: Tempo que a porta pode permanecer aberta antes
de gerar o alarme. Tempo configurável entre 1 e 255 segundos.
```
**Observação:** No modo torniquete esta opção não fica disponível. Isto ocorre devido a esse sensor
ser utilizado para receber a confirmação do torniquete que houve um acesso no mesmo. Para
saber como realizar a conexão consulte o manual do Inner Acesso 2.

## 8.2.3 Registra acesso negado

Permite que os acessos negados de usuários que não estejam na lista de acesso, com acesso
como “Bloqueado” ou fora de horário válido sejam registrados na memória.

## 8.2.4 Registra falha na verificação biométrica

Para o Inner Acesso 2 Bio, permite que os acessos negados de usuários que possuem digital
cadastrada e tiveram falha na verificação 1:1 da digital sejam registrados na memória.

## 8.2.5 Habilita sensor de violação

Configuração para habilitar e desabilitar o sensor de violação do Inner. Quando habilitado, se o
Inner for removido da sua base que fica fixada na parede ele gera um alarme sonoro e luminoso
para alertar sobre a sua violação.


## 8.3 COMUNICAÇÃO

Na tela Comunicação é possível alterar as configurações relacionadas à comunicação de rede do
Inner Acesso 2. Clique em **Editar** para liberar a edição dos campos e ao final clique em **Salvar**
para salvar as configurações no Inner Acesso 2.

Na aba comunicação será apresentada a seguinte tela:

```
 Número do Inner: Configuração do número do Inner
 IP do servidor: Endereço IP do Servidor
 Porta: Porta de comunicação
 Nº MAC do Inner: Número MAC do equipamento
 DHCP habilitado: Habilita e desabilita configuração de IP automático
 IP do Inner: Endereço IP do equipamento
 Máscara de rede: Máscara de rede do equipamento
 Gateway: Gateway do equipamento
 Nome de Rede: Nome para acesso pela rede
```
Para acessar o Inner Acesso 2 através do nome da rede é necessário utilizá-lo com o DHCP
habilitado para que a rede possa identificar o Inner Acesso através do nome. Basta inserir o
nome do Inner na barra de endereços do navegador para acessá-lo:


```
8.3 Biometria
```
Na tela Biometria é possível alterar as configurações relacionadas à biometria do Inner Acesso 2.
Esta tela só é exibida para equipamentos que possuam tecnologia biométrica. Clique em **Editar**
para liberar a edição dos campos e ao final clique em **Salvar** para salvar as configurações no
Inner Acesso 2:

## 8.3.2 Habilita Identificação

No modo de identificação, o usuário simplesmente coloca seu dedo sobre o leitor biométrico
para que sua impressão digital seja capturada e reconhecida. O Inner Acesso 2 Bio faz a
comparação dessa impressão digital com todas as digitais cadastradas e identifica o usuário. Por
padrão, o modo de identificação sai de fábrica habilitado.

## 8.3.3 Habilita Verificação

No modo de verificação, o usuário primeiro se identifica através de seu cartão, e em seguida
coloca seu dedo sobre o leitor biométrico. A impressão digital será lida e comparada com a que
está cadastrada para esse usuário específico, verificando a identidade do usuário. Por padrão, o
modo de verificação sai de fábrica desabilitado.


## 8.3. 4 Nível de segurança

Configuração que permite ajustar o nível de segurança da biometria conforme a necessidade de
uso.

##  MÉDIO (RECOMENDADO): Proporciona maior velocidade no processo de captura e

```
reconhecimento das digitais com segurança. É a opção recomendada pela Topdata.
 ALTO: Nível de segurança um pouco superior ao MÈDIO.
 MUITO ALTO: Proporciona maior segurança, mas em alguns casos pode demandar um
pouco mais de tempo no processo de captura e reconhecimento das digitais.
```
## 8.4 RELÓGIO Índice

Na tela Relógio é possível alterar as configurações relacionadas ao relógio e horário de verão do
Inner Acesso 2.

## 8.4.2 Atualizar relógio

Ao lado esquerdo com a indicação “Inner” será exibido o horário que está configurado no Inner,
e ao lado direito com a indicação “Computador” será exibido o horário atual do computador que


está acessando o Web Server. Se os horários estiverem diferentes, ao clicar em **Sincronizar** , o
relógio do Inner é sincronizado com o relógio do computador:

## 8.4. 3 Horário de verão

O Inner Acesso 2 pode ajustar automaticamente o seu relógio nos dias configurados com Início e

Fim do horário de verão. Configure os dias de **Início** e **Fim** do horário de verão e clique em
**Enviar Horário de Verão.**

```
Observação: Estando com o seu relógio ajustado, o Inner Acesso 2 permanece com o relógio
atualizado por aproximadamente 1 hora após ser desconectado da energia. Após este tempo,
o seu relógio é desconfigurado e ele precisa ser ajustado novamente. Portanto é
recomendado que após o processo de instalação ele fosse atualizado antes de iniciar a
operação.
```

## 8.5 MASTER

Na tela **Master** é possível alterar as configurações relacionadas ao usuário Master do Inner Acesso

2. O usuário Master é responsável pelos cadastros de novos usuários através do Inner com
permissão de acesso por cartão ou biometria:

**Master para cadastro:** habilita ou desabilita o usuário Master para cadastrar de novos usuários
através do Inner.

## 8.5.2 Cadastrar cartão do Master

**Número do Master** : para alterar o cartão do Master duas formas são possíveis:

- Digite o número do cartão do Master e clique em **Cadastrar**.
ou
- Clique em **Cadastrar Cartão via Leitor** , o Inner começará a piscar o led BRANCO. Aproxime o
cartão no leitor interno ou externo do Inner Principal. O cartão apresentado será cadastrado
como novo Master. Caso o Inner Complementar Bio esteja conectado a um Inner Principal Prox, o
cadastro do máster é feito pelo terminal complementar.

**Atenção:** para o Inner Acesso 2 Bio, ao alterar o número do cartão do usuário Master as
biometrias associadas a aquele número serão apagadas. O Inner exibe a mensagem de
confirmação ao alterar o número do Master:


## 8.5.3 Cadastrar biometria do Master

**Biometrias do Master:** para o Inner Acesso 2 Bio, esta tela pode ser utilizada para gravar as
biometrias do Master. Para cadastrar a primeira biometria clique em **Cadastrar Biometria via
Leitor:**

```
Siga as instruções para realizar o cadastro da biometria no Inner:
Passo Instrução Sinalização
```
```
1 O led BRANCO piscando indica que o Inner está
aguardando o cadastro do usuário Master: BRANCO^
```
2 Insira a digital para o Master pela 1ª vez: (^) VERDE
3 Remova o dedo: (^) AMARELO
4 Insira a digital para o Master pela 2ª vez: (^) VERDE
5 Remova o dedo: (^) AMARELO
7 Insira a digital para o Master pela 3ª vez: (^) VERDE
8 Remova o dedo.^
Cadastro concluído com sucesso: VERDE^
9 O Inner volta para o repouso: (^) AZUL


E o Web Server exibirá a mensagem:

Possíveis falhas no processo de
cadastro:

```
Led Inner Mensagem no Web Server:
```
### 1

```
Qualidade baixa da impressão
digital ou
as 3 amostras da digital não
são iguais:
```
### ROXO

2 Processo de cadastro
incompleto: VERMELHO^

### 3

```
Digital já cadastrada.
Pisca VERMELHO duas vezes: VERMELHO^
```
### 4

```
Memória do módulo biométrico
cheia.
Pisca VERMELHO três vezes:
```
### VERMELHO

Para cadastrar a segunda digital para o Master, após concluir com sucesso o cadastro da
primeira, pressione novamente o botão **Cadastrar Biometria via Leitor:**

E realize o mesmo procedimento no Inner do cadastro da primeira digital.

Após o cadastro das duas digitais, o botão **Cadastrar Biometria via Leitor** fica desabilitado:


## 8.5.4 Excluir biometria do Master

Para excluir as biometrias do Master clique no ícone e confirme na mensagem de
confirmação que será exibida:

Após confirmar, todas as biometrias do Master serão excluídas e a mensagem de confirmação
será exibida no Web Server:


## 9. LISTA DE ACESSO

O Inner Acesso 2 permite controlar em modo offline o acesso de até 15.000 usuários através da
sua lista de acesso. Para esta lista também é possível realizar o cadastro de tabelas de horários
para realizar o controle de horários e dias da semana de acesso destes usuários.

## 9.1 Incluir usuário

Para incluir usuários na lista, na tela de Lista de Acesso clique em Incluir Novo:

A tela de inclusão de novos usuários será aberta:

## 9.2 Cadastro de cartão

Para incluir um novo cartão duas formas são possíveis:


- Digite o número do Cartão e clique em **Cadastrar**.
ou
- Clique em **Cadastrar Cartão via Leitor** ao lado de **Cartão**. O Inner começará a piscar o led
BRANCO. Aproxime o cartão do leitor do Inner Principal. O cartão apresentado será incluído na
lista e preenchido no campo do número do cartão. Caso deseje, o usuário pode ser incluído em
uma tabela para controle de acesso por horário. Consulte o tópico “ **Cadastro de horários** ” para
mais detalhes.

## 9.2.1 Lista somente cartão

É possível marcar um cartão para que o mesmo não exija a Verificação Biométrica, opção que
geralmente é utilizada para cartões de visitantes em que as digitais não são cadastradas. Para
ativar esta opção em um usuário é possível marcar a flag “Dispensar Verificação Biométrica” na
tela de cadastro de cartões, conforme destacado abaixo.

Através do Web Server, é possível adicionar todos os usuários da lista de acesso para
“Dispensar Verificação Biométrica”, diferente do envio via software que limita esta lista a 8.000
cartões.


## 9.3 Cadastro de biometria

Para incluir um novo usuário por biometria duas formas são possíveis:

```
Biometria sem cartão: Biometria com cartão:
```
```
Sem cadastrar nenhum cartão, na
tela de cadastro de novos usuários clique
em Cadastrar via Leitor para cadastrar a
biometria.
```
```
Realize o cadastro do cartão
manualmente ou via Leitor, e então
acesse o menu de edição do usuário
cadastrado e clique em Cadastrar via
Leitor para cadastrar a biometria.
A digital será gravada com o
identificador sendo o número do cartão.
```
Ao realizar um cadastro de digital sem cartão, o Inner irá gerar automaticamente um número
sequencial para cada biometria, incrementado a partir da numeração 900001 conforme as
biometrias forem cadastradas. Ex.: 900001, 900002, etc.

```
Passo Instrução Sinalização
```
```
1 O led BRANCO piscando indica que o Inner está
aguardando o cadastro do novo usuário: BRANCO^
```
2 Insira a nova digital pela 1ª vez: (^) VERDE
3 Remova o dedo: (^) AMARELO
4 Insira a nova digital pela 2ª vez: (^) VERDE
5 Remova o dedo: (^) AMARELO
7 Insira a nova digital pela 3ª vez: (^) VERDE

### 8

```
Remova o dedo.
Cadastro concluído com sucesso: VERDE^
```
9 O Inner volta para o repouso: (^) AZUL


E o Web Server exibirá a mensagem:

Possíveis falhas no processo de
cadastro:

```
Led Inner Mensagem no Web Server:
```
### 1

```
Qualidade baixa da
impressão digital ou
as 3 amostras da digital não
são iguais:
```
### ROXO

### 2

```
Processo de cadastro
incompleto: VERMELHO^
```
### 3

```
Digital já cadastrada.
Pisca VERMELHO duas
vezes:
```
### VERMELHO

### 4

```
Capacidade máxima de
digitais atingida.
Pisca VERMELHO três vezes:
```
### VERMELHO

Para cadastrar a segunda digital, após concluir com sucesso o cadastro da primeira, pressione
novamente o botão **Cadastrar via Leitor** e realize o mesmo procedimento no Inner do cadastro
da primeira digital. Após o cadastro das duas digitais, o botão **Cadastrar via Leitor** fica
desabilitado:


Os usuários que forem cadastrados sem número de cartão, terão o número definido
automaticamente pelo Inner. As biometrias serão cadastradas com um número de forma
sequencial a partir do número 900001, ou seja, a primeira biometria cadastrada terá o número
900001, a segunda 900002, a terceira 900003 e assim sucessivamente.

## 9.4 Cadastro de horários

Por padrão, o Inner cadastra os novos usuários com a configuração de horários “Liberado”.
Usuários com esta configuração possuem acesso liberado o tempo todo, sem restrições de
horários e dias da semana. É possível deixar os usuários como “Bloqueado” no qual não possuem
acesso em nenhum horário ou “Conforme Horário”, que terão a controle de acesso por horário
habilitado, possuindo liberação de acesso somente nos horários configurados em suas tabelas de
horários.
Para selecionar as tabelas de horários para o usuário, na tela do cadastro do usuário, selecione o

modo de horários como “Conforme Horário” e clique no ícone incluir as tabelas de

horários ou selecione o horário desejado e clique no ícone para excluir.

Para incluir, selecione o número do Horário desejado e clique em **Selecionar** :


Após selecionar os horários desejados, o cadastro do usuário estará concluído:

## 9.5 Tabelas de horários

É possível realizar o cadastro de até 100 tabelas de horários diferentes para realizar o controle
de acesso de usuários cadastrados, controlando horários e dia da semana liberados.


Acesse a tela Lista de Acesso => Horários, selecione o número da tabela que deseja alterar e
clique em Editar para inserir os horários desejados:

Durante a edição estão disponíveis na lateral direita de todos os horários as opções “ **Copiar** ”,
“ **Colar** ” e “ **Excluir** ”:

```
Copiar : copia todos os horários da linha.
```
```
Colar : cola nesta linha os horários copiados.
```
```
Excluir : excluir todos os horários da linha.
```
Após completar o preenchimento dos horários conforme desejado, clique em **Salvar** para gravar
as informações no Inner.

Ao associar um usuário a um horário no controle de acesso, será utilizada uma das 15.000
posições de memória disponíveis para este tipo de informação. Associando o mesmo usuário para
2 horários, duas posições serão ocupadas e assim sucessivamente.

```
Dica: as tabelas de horários também podem ser utilizadas para separar grupos de usuários por
perfil de acesso.
```

## 9.6 Lista de biometrias

É possível visualizar as biometrias cadastradas no Inner Acesso 2 separadamente da lista de
acesso. Para isto acesse a tela Lista de Acesso => Biometrias.
Será exibida uma lista com todos as biometrias cadastradas e ao lado de cada uma a informação
se elas estão na lista de acesso. Nesta tela também é possível excluir apenas a biometria do
usuário deixando seu acesso somente via cartão:

Ainda na tela de biometrias, é possível adicionar uma biometria diretamente para a lista de
acesso através do botão ( **+** ), conforme imagem:

Caso a digital do máster seja adicionada à lista de acesso através do botão (+), ao colocar o dedo
no módulo biométrico a ação ainda será a de acessar o menu de Cadastro Master, que é o padrão
do produto. Para utilizar a digital do usuário Master para acesso, deve-se alterar a opção
“Master para Cadastro” presente no menu Gerenciamento -> Configurações -> Master, conforme
imagem a seguir:


As configurações para este campo são:
Sim -> Usuário Master (cartão/digital) acessam menu de Cadastro Master.
Não -> Usuário Master (cartão/digital) não acessam menu de Cadastro Master.

É possível excluir todas as biometrias de uma só vez caso deseje, clicando em “Excluir Lista de
Biometrias” localizada na parte inferior da aba Biometrias.

## 10. REGISTROS

O Inner possui capacidade para armazenar em sua memória os últimos 30.000 registros de
acessos realizados. Caso a capacidade total de bilhetes seja atingida, a cada novo bilhete gerado
o Inner apaga o registro mais antigo, permanecendo sempre com os registros mais recentes.
Para realizar a coleta dos registros acesse a tela **Registros** :


Os registros podem ser exportados filtrando por data e hora do registro através da **Exportação
por Data** , e também é possível coletar todos os registros presentes na memória do Inner através
da **Exportação Completa.**
Será exportado um arquivo de texto chamado **bilhetes.txt**.

Segue abaixo um exemplo de coleta utilizando o Web Server:

No exemplo acima, podemos identificar as seguintes informações no último registro gerado **“010
19/03/19 11:31 0000094525336525 01”** :
Dado Informação
**010** Tipo do registro: Entrada liberada
**19/03/19** Data do acesso


```
11:31 Horário do acesso
0000094525336525 Número do cartão
01 Número do Inner
```
**Tipos de registros**

```
Tipo Descrição
010 Entrada liberada
011 Saída liberada
012 Entrada bloqueada (acesso negado/falha na verificação)
013 Saída bloqueada (acesso negado/falha na verificação)
```
Caso necessário, a coleta pelo software Gerenciador de Inners permite uma exportação de
registros mais flexível possibilitando a customização da exportação dos dados:

Além disso, pelo software também é possível configurar para que a coleta seja realizada de
forma automática, salvando o arquivo com a coleta no local desejado. Consulte o manual do
software Gerenciador de Inners para mais informações.


## 11. IMPORTAÇÃO E EXPORTAÇÃO NO WEB SERVER

## 11.1 IMPORTAÇÃO E EXPORTAÇÃO DE CONFIGURAÇÕES

O Web Server permite a importação e exportação das configurações. As configurações incluídas
no arquivo são: Configurações de Acesso, Configurações de Segurança, Configurações de
Biometria (para modelos com biometria), Configurações do Master e Configurações do Horário de
Verão.
Durante os processos de exportação e importação o Web Server exibirá a mensagem
“Aguarde...”. Recomenda-se não fechar o navegador nem desligar o Inner durante o processo.

**Para Exportar:**
Acesse o menu Gerenciamento => Exportar => Configurações:

Será gerado um arquivo com a extensão _Configurações.ab1_.

**Para Importar:**
Acesse o menu Gerenciamento => Importar => Configurações:


## 11.2 IMPORTAÇÃO E EXPORTAÇÃO DE LISTA DE ACESSO

O Web Server permite a importação e exportação da lista de acesso com todos os cartões
cadastrados, incluindo os horários cadastrados e os usuários com a Flag Dispensa Verificação
biométrica (ver item 9.2.1).

**Para Exportar:**
Acesse o menu Gerenciamento => Exportar => Lista de Acesso:

Será gerado um arquivo com a extensão _Lista de Acesso.ab1_.

**Para Importar:**
Acesse o menu Gerenciamento => Importar => Configurações:


Ao selecionar o arquivo para importação o seguinte aviso será exibido:

Durante os processos de exportação e importação o Web Server exibirá a mensagem
“Aguarde...”. Recomenda-se não fechar o navegador nem desligar o Inner durante o processo.

Caso o arquivo selecionado contenha uma lista de cartões com o número de dígitos menor do
que o configurado no Inner, o seguinte aviso será exibido:

Caso o arquivo selecionado contenha uma lista de cartões com número de dígitos maior do que o
configurado no Inner, a importação não será realizada e a seguinte mensagem será exibida:


## 11.3 IMPORTAÇÃO E EXPORTAÇÃO DE BIOMETRIAS

O Web Server permite a importação e exportação das biometrias cadastradas, permitindo a
replicação de base de forma rápida e sem a necessidade de uso de softwares. Os menus abaixo
somente serão exibidos em equipamentos com módulo biométrico.

Para Exportar:
Acesse o menu Gerenciamento => Exportar => Lista de Acesso:

Será gerado um arquivo com a extensão _biometrias.ab1_.

Para Importar:
Acesse o menu Gerenciamento => Importar => Biometrias:


Ao selecionar o arquivo para importação o seguinte aviso será exibido:

Durante os processos de exportação e importação o Web Server exibirá a mensagem
“Aguarde...”. Recomenda-se não fechar o navegador nem desligar o Inner durante o processo.

Caso um arquivo inválido seja selecionado, a seguinte mensagem será exibida:


## 12. DESABILITAR WEB SERVER

É possível desabilitar o acesso ao Web Server do Inner Acesso 2 após a sua configuração inicial
por questões de segurança. Caso o Web Server esteja desabilitado, ao tentar acessá-lo a
seguinte mensagem será exibida no navegador:

O Web Server pode ser desabilitado pelo software Gerenciador de Inners quando utilizado
offline, ou pelo software TopAcesso quando utilizado em modo online.

**Importante:** Durante a utilização do equipamento no modo online o equipamento desativará
automaticamente o Web Server:


## 12.1 GERENCIADOR DE INNERS

Para desabilitar o Web Server pelo Gerenciador de Inners, na tela de configurações do Inner
Acesse a aba “Segurança”, e marque a opção “Desabilitar o Web Server” e envie as
configurações para o Inner:


## 12.2 TOPACESSO...........................................................................................................

Para desabilitar o Web Server pelo TopAcesso, no módulo Cliente, na tela Arquivo =>
Configurações, acesse a aba Segurança, marque a opção “Desabilitar Web Server (Inner Acesso
2)” e reinicie o módulo Monitoramento do TopAcesso:

Todos os Inners Acesso 2 que se conectarem a este Top Acesso terão o Web Server desabilitado
em suas configurações.


## 13. DÚVIDAS FREQUENTES

**1) Como fazer para excluir um cartão ou biometria da lista de acesso?**

Alteração ou exclusão de usuários pode ser realizada com auxilio do Web Server.
Não é possível remover usuários pelo Inner, através do usuário Master.

**2) O que ocorre se entrar no menu master e cadastrar uma biometria para um cartão
que já havia uma biometria cadastrada?**

Será excluída a digital que estava cadastrada e será cadastrada a nova digital no lugar.

**3) Como é feito o cadastro de duas digitais por usuário?**

A segunda digital pode ser cadastrada com o auxilio do Web Server, através da edição do
cadastro do usuário.

**4) Ao aproximar o cartão o Inner está sinalizando com o led amarelo. O que significa?**

O modo de verificação está habilitado e o cartão não possui digital cadastrada ou a quantidade
de dígitos configurada no Inner não corresponde ao tipo de cartão aproximado. Consulte a tabela
de sinalizações para mais informações, consulte o capítulo Sinalizações para mais informações
sobre as sinalizações do Inner Acesso 2.

**5) Posso utilizar a fonte de alimentação de outros produtos da linha Inner no Inner
Acesso 2?**

Não. O Inner Acesso 2 utiliza uma fonte de alimentação com saída de 12Vcc e os outros produtos
da linha Inner utilizam a fonte 5V. A utilização de outras fontes deixa o sistema sujeito a erros e
possíveis danos que pode resultar na perda da garantia.

**6) Como faço o backup das biometrias?**
Para realizar este procedimento você deverá utilizar o software Gerenciador de Inners ou a
exportação via Web Server. Mais informações podem ser encontradas no manual do Gerenciador
e do Web Server respectivamente.


**7) Posso copiar as biometrias de um Inner para outro para não precisar recadastrar todas
as digitais?**
É possível copiar biometrias entre equipamentos exportando e restaurando estas informações
através do procedimento de backup. Para realizar este procedimento, acesse o menu
“Gerenciamento” > “Importar” ou “Exportar” > “Biometrias”.

**8) Ao tentar acessar o Web Server uma mensagem é exibida informando que o acesso foi
desabilitado. Como proceder?**
O Web Server possui mecanismos de proteção de acesso. Verificar com o administrador do
sistema para avaliar a habilitação do acesso ou restauração de configurações do Inner.

**9 ) Qual o operador e senha padrão para acesso ao Web Server?**
Inicialmente o Web Server vem de fábrica com as credenciais definidas como:
Usuário: ADMIN (em letras maiúsculas)
Senha: Inner@cesso2 (primeira letra em maiúsculo)
A Topdata recomenda a alteração da senha por questões de segurança.
Para realizar este procedimento, acesse o menu “Gerenciamento” > “Administrador”.

**10) Ao acessar o Web Server o navegador não exibe a página corretamente. Como
proceder?**
O Web Server utiliza componentes de programação que exigem o uso de um navegador
atualizado. Por gentileza verifique se o seu navegador é compatível.
Seguem navegadores homologados:

Navegador Versão

Google Chrome Versão 73 ou superior

Mozilla Firefox Versão 47 ou superior

Edge Versão 41 ou superior

Internet Explorer Versão 11 ou superior

Opera Versão 58 ou superior


**11 ) Posso utilizar um Inner Acesso 2 Complementar em um torniquete bidirecional para
realizar entrada e saída?**
Não, caso precise será necessário utilizar dois Inner Acesso 2 Principal um em cada lado do
torniquete.

**12 ) Posso utilizar um Inner Acesso 2 em conjunto com um leitor externo em um torniquete
bidirecional para realizar entrada e saída?**
Não, pois o leitor externo neste caso realizará o acesso para o mesmo lado que o Inner Principal.
Caso precise será necessário utilizar dois Inner Acesso 2 Principal um em cada lado do
torniquete.


## 14. ESPECIFICAÇÕES TÉCNICAS

```
Compatibilidade
 Navegadores compatíveis: Google Chrome, Internet Explorer, Opera, Mozilla
Firefox e Edge;
 Telas responsivas: tela se ajusta automaticamente, podendo ser acessado por
computador, tablet e celular.
```
```
Segurança
 Operador protegido por senha;
 Web Server pode ser desabilitado pelo Gerenciador de Inner e TopAcesso;
```
```
Cadastros
 Cadastro de usuários por cartão de proximidade e biometria;
 Cadastro de cartão de proximidade e biometria para o Master;
 Tabelas para controle de acesso por horário e dia da semana;
 Bloqueio de usuários.
 Importação e exportação de lista de acesso e horários.
```
```
Relógio
 Atualização do relógio e Configuração do horário de verão.
```
```
Informações e operações
 Liberação de Acesso direto pelo Web Server;
 Quantidade de biometrias cadastradas;
 Versão do firmware e Web Server;
 Número de série e MAC Address.
```
```
Configurações
 Configuração de modos de operação: Porta ou Torniquete;
 Configurações de acesso e tipo de leitor;
 Configurações de segurança;
 Configurações de comunicação;
 Configurações biométricas;
 Configurações do usuário Master;
 Importação e exportação de configurações e biometrias;
```

**Coleta**
 Exportação de registros com filtro por data e exportação de registros completa.


## 15. HISTÓRICO DE REVISÕES DESTE MANUAL

```
Revisão Data Alterações
```
Revisão 01
01 /0 4 / 2019

```
Primeira versão do manual do Web Server dos
coletores Inner Acesso 2 e Inner Acesso 2 Bio.
```
Revisão 02 07 /0 6 /2019

```
Informações sobre exportação e importação de
Configurações, lista de acesso e biometrias.
Informações sobre flag “Dispensar Verificação
Biométrica”.
Atualização de imagens.
```
Revisão 03 10/06/2019
Atualização do tópico “Dúvidas frequentes”.

Revisão 04 13 / 11 /2020

```
Atualização da logo.
Atualização das Imagens com o novo Layout do Web
Server.
Inclusão da configuração de dígitos variáveis para
cartões e QR Code.
Inclusão das informações sobre a configuração do
Leitor Externo.
```
Revisão 06 05/01/2021

```
Inclusão do modo de operação para Torniquetes
Alteração de nomenclaturas das funções na aba
Acesso.
```
Revisão 07 25/05/2021 Atualização da logomarca


