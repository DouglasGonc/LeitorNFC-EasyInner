
## ÍNDICE


- 1 APRESENTAÇÃO
   - 1.1 MODELOS DE INNER ACESSO
   - 1.2 VISTA EXTERNA
   - 1.3 DIMENSÕES
   - 1.4 COMPOSIÇÃO DO INNER ACESSO
   - 1.5 INNER ACESSO 2 COMPLEMENTAR
   - 1.6 VISÃO GERAL
   - 1.7 COMBINAÇÕES POSSÍVEIS
      - 1.7.1 MODO PORTA
      - 1.7.2 MODO TORNIQUETE
- 2 INSTALAÇÃO DO INNER ACESSO
   - 2.1 FIXAÇÃO NA PAREDE
   - 2.2 INSTALAÇÃO DO INNER ACESSO 2 – USO EXTERNO
   - 2.3 INSTALAÇÃO DO INNER ACESSO 2 – PEDESTAL
   - 2.4 FONTE DE ALIMENTAÇÃO
- 3 CONEXÕES
   - 3.1 FECHADURA
      - 3.1.1 FECHADURA ELÉTRICA
      - 3.1.2 FECHADURA ELETROMAGNÉTICA
   - 3.2 BOTÃO EXTERNO DE LIBERAÇÃO
   - 3.3 SENSOR DE PORTA
   - 3.4 SENSOR DE VIOLAÇÃO
   - 3.5 INNER ACESSO 2 COMPLEMENTAR
   - 3.6 LEITOR DE CARTÕES EXTERNO
   - 3.7 CONEXÃO DE TORNIQUETE NO INNER ACESSO
- 4 OPERAÇÃO
   - 4.1 CADASTRO DO USUÁRIO MASTER
      - 4.1.1 CADASTRO DO USUÁRIO MASTER COM CARTÃO
      - 4.1.2 CADASTRO DO USUÁRIO MASTER COM BIOMETRIA
   - 4.2 CADASTRO DE USUÁRIOS
      - 4.2.1 CADASTRO DE CARTÕES
      - 4.2.2 CADASTRO DE BIOMETRIA
   - 4.3 EXCLUSÃO DE USUÁRIOS
- 5 ACESSAR O WEB SERVER
   - 5.1 LOGIN
- 6 CONFIGURAÇÕES
   - 6.1 LISTA DE CONTROLE DE ACESSO
   - 6.2 TABELAS DE HORÁRIOS
   - 6.3 CONTROLE DE ACESSO
      - 6.3.1 DESABILITADO
      - 6.3.2 CARTÃO NÃO CADASTRADO NÃO PODE PASSAR
      - 6.3.3 CARTÃO NÃO CADASTRADO PODE PASSAR
   - 6.4 BIOMETRIA
      - 6.4.1 MODO DE IDENTIFICAÇÃO (1:N)
      - 6.4.2 MODO DE VERIFICAÇÃO (1:1)
      - 6.4.3 USUÁRIOS SOMENTE CARTÃO
      - 6.4.4 REGISTROS
      - 6.4.5 TIPOS DE BILHETES
      - 6.4.6 CONFIGURAÇÕES DE REGISTROS
      - 6.4.7 REGISTRO DE ACESSO NEGADO
      - 6.4.8 REGISTRO DE FALHA NA VERIFICAÇÃO BIOMÉTRICA
      - 6.4.9 DESABILITAR WEB SERVER
- 7 SINALIZAÇÕES
- 8 CONFIGURAÇÕES INICIAIS
- 9 RESTAURAÇÃO DE CONFIGURAÇÕES
   - 9.1 RESTAURAR CONFIGURAÇÃO DE REDE
   - 9.2 RESTAURAR CONFIGURAÇÕES DE FÁBRICA
- 10 DÚVIDAS FREQUENTES
- 11 REGULAMENTAÇÃO ANATEL
   - 11.1 REGULAMENTAÇÃO LEITOR PCI TOPPROX PRO
   - 11.2 REGULAMENTAÇÃO LEITOR TOPSMART
   - 11.3 REGULAMENTAÇÃO MÓDULO COM CONEXÃO WI-FI
- 12 APÊNDICE
   - 12.1 CONFIGURAÇÃO DO “LEITOR EXTERNO” NO INNER ACESSO 2.
   - 12.2 INSTALAÇÃO LEITOR FACIAL T4 E F4 PARA COLETORES
- 13 ESPECIFICAÇÕES TÉCNICAS
- 14 HISTÓRICO DE REVISÕES DESTE MANUAL..............................................


##### NOTA AO USUÁRIO

```
Preparamos este manual com detalhes do produto Inner Acesso 2 para que você possa
utilizá-lo da maneira correta e facilitada.
Recomendamos que o leia com atenção, seguindo todas as orientações e
recomendações.
Considere somente as informações referentes ao modelo do seu produto e dos
acessórios adquiridos.
```
##### ATENÇÃO

```
Nota 1: O Inner Acesso 2 permite o cadastramento do cartão Master e novos
usuários através do equipamento. Para alteração de configurações se faz
necessário a utilização do Web Server ou outro software Topdata.
Nota 2: Recomenda-se que as conexões elétricas sejam estanhadas e
devidamente isoladas, pois instalações inadequadas podem implicar no mau
funcionamento das portas e fechaduras controladas pelo Inner.
Nota 3: Estando com relógio ajustado, o Inner Acesso 2 permanece
atualizado por aproximadamente 6 dias após ser desconectado da energia.
Passado este tempo, o relógio é desconfigurado e precisa ser ajustado
novamente. Portanto, recomenda-se que após o processo de instalação o
produto seja atualizado antes de iniciar a operação.
```

## 1 APRESENTAÇÃO

Os produtos da linha Inner Acesso 2 são coletores de dados versáteis e inteligentes,

voltados para aplicações de controle de acesso. Devido ao fato de ser um produto

compacto e de dimensões reduzidas, pode ser instalado em vários tipos de ambientes,

que aliado à sua robustez, o torna um produto extremamente eficiente e seguro para

o controle de acesso de ambientes.

Dentre suas diversas características se destacam:

- Controle de acesso inteligente, com funcionamento mesmo sem ser configurado
através de computadores;
- Controle de acesso a torniquetes.
- Comunicação através de rede Wi-Fi (opcional), cabeada ou ambos;
- Possui sinalização visual e sonora para indicar as diversas situações de operação
do produto, configuração e cadastros;
- Web Server embarcado;
- Entrada para sensor de porta, com sinalização de porta esquecida aberta ou
aberta sem autorização, que funciona online e offline;
- Sensor de violação do Inner, que gera um alarme sonoro e luminoso ao ser
retirado do seu suporte que fica fixado na parede;
- Entrada para botão externo para liberação de portas;
- Saída com contato seco de acionamento para controle de portas e fechaduras.


**Características da linha de produtos Inner Acesso 2**

A linha Inner Acesso 2 se divide em dois modelos principais de produto, o Coletor Inner
Acesso 2 e o Coletor Inner Acesso 2 Complementar. O primeiro é o modelo para ser
instalado no lado seguro do ambiente e possui entrada para cabo de rede, saída a relé
para controle de fechos e fechaduras de portas e entradas para sensores de porta e
botão de liberação. Já o segundo modelo é um complemento ao primeiro, que permite
que do lado não seguro da aplicação seja possível ter os mesmos modelos de leitores
biométricos e de proximidade, com o mesmo nível de sinalização visual e sonora para
o usuário, existentes no modelo que fica no lugar seguro da aplicação. Pelo fato de ter
sido concebido para uso em conjunto com o Inner Acesso 2, o modelo complementar
não tem saída a relé, entradas para sensores de porta e nem mesmo entrada para cabo
de rede.

Além de portas é possível utilizar o Inner Acesso 2 para controle de acesso a
Torniquetes.

O Inner Acesso 2 pode ter integrado na placa para toda sua linha de produtos o módulo
para conexão de rede Wi-Fi, além da entrada de comunicação por cabo de rede.

A combinação de um Inner Acesso 2 Bio com Inner Acesso 2 Bio Complementar permite
um controle de acesso extremamente eficiente e seguro com biometria dos 2 lados da
porta.

O Inner Acesso 2 sai de fábrica com uma configuração que permite a sua utilização
offline sem a necessidade de conexão a um computador para funcionamento. Os
usuários de cartão ou biometria podem ser cadastrados através do usuário Master que
é cadastrado na primeira utilização. Caso necessário, alterações de configurações e
cadastros de usuários também podem ser realizados pelo Web Server ou software
Gerenciador de Inners pela conexão de rede.

A lista de controle de acesso permite que sejam configurados os dias e horários que
cada um dos usuários pode ter acesso ao local controlado. A placa Inner Acesso 2
executa todas as configurações definidas no software Gerenciador.


O acesso pode ser realizado utilizando um cartão de proximidade, um código QR Code
ou biometria de acordo com o modelo adquirido. No caso de cartão, pode ser utilizado
cartão de proximidade Top Prox, Smart Card ou outro tipo de cartão realizando a
instalação de um leitor externo compatível com o Inner Acesso 2. No caso de QR Code a
leitura é realizada apenas aproximando a distância o código sem contato com o leitor.
Podem ser utilizados códigos impressos em papel, cartão ou mesmo da tela de um
celular, tablet ou similar.

A comunicação é realizada através da interface Ethernet ou Wi-Fi (opcional) e os
coletores Inner Acesso 2 podem ser conectados em rede. Podem ser conectados até
255 Inners Acesso 2 com o Gerenciador de Inners e até 99 com o TopAcesso ou
TopPortaria. Também possui o Web Server que pode ser utilizado para alteração de
configurações, cadastros de usuários, exportação de registro, backup e restauração de
dados, entre outros.

O software Gerenciador de Inners oferece amplas possibilidades de configuração para
a operação do Inner, sendo suficiente para aplicações em geral. No entanto, a Topdata
permite também que integradores desenvolvam softwares customizados voltados a
necessidades específicas, permitindo que sejam desenvolvidas aplicações “online” ou
“offline”.

No modo “online”, o computador fica permanentemente em comunicação com o Inner
Acesso 2, dedicado inteiramente a uma aplicação. Os dados coletados pelo Inner são
imediatamente transferidos ao computador que os analisa e devolve um comando para
o Inner realizar ou não a liberação do acesso. Para a utilização do modo “online” é
necessário um programa especial. Se houver interesse do usuário em desenvolver o seu
próprio sistema, a Topdata pode fornecer as bibliotecas de programação utilizadas
para a comunicação com os coletores Inner Acesso 2. Neste caso será necessário entrar
em contato com a Topdata para obter maiores detalhes.

No modo “offline” o Inner Acesso 2 pode ser configurado pelo computador e mantém
esta configuração em sua memória. Com isto, o computador pode ser desligado ou
utilizado para outros fins enquanto o Inner permanecerá operando, controlando o
acesso e salvando os dados em sua memória. O software Gerenciador de Inners opera
no modo “offline”, mas permite que a coleta dos dados ocorra automaticamente
através do recurso de coleta automática.


### 1.1 MODELOS DE INNER ACESSO

Os modelos variam entre tecnologias de leitor de cartões de proximidade, leitor
biométrico, leitor de cartões tipo QR Code, equipamentos para uso externo e conexão
através de rede Wi-Fi. Podendo ter as tecnologias combinadas de acordo com a
necessidade.

Todos os modelos possuem Saída a relé, entradas para sensores (porta aberta, violação
e arrombamento), entrada para leitores externos e entrada para conexão Ethernet.

- **Equipamentos com biometria LC**

Possuem módulo biométrico com capacidade de armazenamento de 3.000 usuários
biométricos com uma digital ou 1.500 com duas digitais, sem leitor de proximidade
interno instalado, onde poderá ser utilizado um leitor externo compatível.

- **Equipamentos com Leitor Facial**

Possuem Leitor Facial, um dispositivo avançado de controle de acesso facial.
Permite cadastro por reconhecimento facial ou fotos em JPG. Detecta "Rosto Vivo" e
usuários com máscara. Administradores controlam configurações. Oferece proteção de
tela, desligamento automático, ativação por detecção facial, antifraude durante
cadastro, ajuste de distância e iluminação frontal para baixa luz. Segurança e
eficiência em um só sistema. Para usá-lo, conecta-se o cabo, que acompanha o kit do
leitor facial, na posição do leitor externo do Inner Acesso 2. A comunicação acontece
com o formato Wiegand com Facility Code.

- **Equipamentos com leitor de cartões Prox**

Possuem leitor de proximidade interno Top Prox 125KHz com comunicação
AbaTrack, Wiegand ou Wiegand com Facility Code.

- **Equipamentos com leitor de cartões Smart**

Possuem leitor de proximidade interno Top Smart Card 13,56MHz com
comunicação AbaTrack, Wiegand ou Wiegand com Facility Code.


- **Equipamentos com leitor QR Code**

Possuem leitor QR Code interno, com a capacidade de realizar a leitura de QR
Code (model 1, model 2 e micro QR Code), código de barras do tipo 3 de 9 e do tipo 2
de 5 intercalado. Os códigos podem ter de 4 a 16 dígitos e serem lidos a partir da tela
de um _Smartphone_ , impressos em papel ou em cartão PVC.

- **Equipamentos para uso externo**

Possuem gabinete de proteção para ambientes externos e expostos a chuva,
confeccionado em aço-carbono com pintura epóxi eletrostática na cor preta.

- **Equipamentos Prox sem leitor**

Não possuem leitor de proximidade interno instalado, para aplicação onde será
utilizado um leitor externo compatível.

- **Equipamento com Botão**

Inner Acesso 2 com um botão para liberar acesso integrado ao gabinete. Não possui
leitores. Poderá ser utilizado um leitor externo compatível ou com qualquer modelo
de Inner Acesso 2 Complementar.

- **Equipamento com conexão Wi-Fi**

Inner Acesso 2 com módulo interno para conexão via rede Wi-Fi. Atende o padrão
de comunicação IEEE 802.11 b/g/n, opera na frequência de 2,4GHz. Suporta os níveis
de segurança WEP, WPA e WPA2. Equipamentos com conexão Wi-Fi também possuem
conexão através de cabos de rede Ethernet.

**Inner Acesso 2 Complementar**

Todos os equipamentos listados acima podem ser usados com uma versão
_Complementar,_ que pode ser adquirida para ser utilizada no lado não seguro do local
de acesso. As principais características de um equipamento Complementar são:

- Produto para ser usado obrigatoriamente em conjunto com o Inner Acesso 2.


- Possuem opções com biometria LC, leitor de proximidade tipo Prox ou Smart e
    leitor de QR Code com as mesmas características do Inner Acesso 2.
- Saída para leitor externo
- Não possui conexão para acionamentos e rede Ethernet. / Wi-Fi.

**Leitor TopProx Adicional**

- Leitor de proximidade interno Top Prox 125 KHz – AbaTrack, Wiegand e Wiegand
    com Facility Code.
- Montado em gabinete seguindo o design do Inner Acesso 2.
- Não possui placa de controle, sendo necessário conectá-lo a um Inner Acesso 2
    na entrada de leitor externo com auxílio do cabo de extensão que acompanha
    este produto.

**Leitor TopSmart Adicional**

- Leitor de proximidade interno Top Smart Card 13,56MHz – AbaTrack, Wiegand
    e Wiegand com Facility Code.
- Montado em gabinete seguindo o design do Inner Acesso 2.
- Não possui placa de controle, sendo necessário conectá-lo a um Inner Acesso 2
    na entrada de leitor externo com auxílio do cabo de extensão que acompanha
    este produto.


### 1.2 VISTA EXTERNA

```
Inner Acesso 2 Prox Inner Acesso 2 LC Bio Prox
```
**Inner Acesso 2 Com Botão** (^) *Disponível em todos os modelos de Inner Acesso 2 **Inner Acesso 2 Uso Externo**^
**Inner Acesso 2 Prox QR Code** (^) **Inner Acesso 2 Bio QR Code**


### 1.3 DIMENSÕES

Inner Acesso 2:

Inner Acesso 2 Uso Externo:

Obs.: Dimensões em milímetros.

```
(*) Distância para instalação em
caixas padrão 4x
```

### 1.4 COMPOSIÇÃO DO INNER ACESSO

```
O Inner Acesso 2 é composto por:
```
- Coletor Inner Acesso 2;
- Suporte de fixação;
- Cabo de alimentação;
- Cabo de acionamentos;
- Certificado de Garantia.

O Inner Acesso 2 Para uso externo é composto por:

- Coletor Inner Acesso 2;
- Suporte de fixação;
- Cabo de alimentação;
- Cabo de acionamentos;
- Gabinete em aço-carbono com pintura epóxi.
- Certificado de Garantia.

### 1.5 INNER ACESSO 2 COMPLEMENTAR

O Inner Acesso 2 possibilita a instalação de um Inner Acesso 2 Complementar no lado
oposto da porta em que se encontra instalado o Inner Acesso 2, com o objetivo de
controlar o acesso da entrada dos usuários.

Os modelos complementares acompanham o seguinte cabo serial para conexão:

Caso necessário, este cabo pode ser estendido. A distância máxima de cabo entre o
Inner Acesso 2 e o Inner Acesso 2 Complementar não deve ser superior a 15 metros.
Recomendamos utilizar cabo LAN CAT5.


```
O Inner Acesso 2 Complementar terá a configuração inversa à configuração do Inner
Acesso 2, por exemplo:
```
- Inner Acesso 2 como ENTRADA -> Inner Acesso 2 Complementar será SAÍDA
- Inner Acesso 2 como SAÍDA -> Inner Acesso 2 Complementar será ENTRADA
O Inner Acesso 2 Complementar possui modelos com módulo biométrico, com QR Code,
com leitores de proximidade e sem leitor (para uso com leitores externos).
O Inner Acesso 2 Complementar não é recomendado apenas no caso de uso para
controle de Torniquete unidirecional.

### 1.6 VISÃO GERAL

**LEITOR
INTERNO DE
CARTÕES
RFID
COMUNICAÇÃO
SERIAL**

```
LEITOR DE
QR CODE
LEITOR
BIOMÉTRICO
```
```
ENTRADA PARA
LEITOR DE
CARTÕES
EXTERNO
```
**INNER ACESSO 2** (^) **INNER ACESSO 2 COMPLEMENTAR**


### 1.7 COMBINAÇÕES POSSÍVEIS

```
A seguir apresentamos algumas das combinações possíveis para controle de acesso de
uma porta ou Torniquete utilizando o Inner Acesso 2.
```
#### 1.7.1 MODO PORTA

```
Leitor TopProx/TopSmart
Adicional ou Leitor Externo
Prox/Smart
```
```
Inner Acesso 2 LC
Bio Prox/Smart
```
```
Inner Acesso 2 LC Bio
```
Inner Prox/SmartAcesso (^2) Prox/Smart
Inner Acesso 2
Prox/Smart
Inner Acesso 2
Prox/Smart
Leitor TopProx/TopSmart
Adicional ou Leitor Externo
Prox/Smart
Inner Acesso 2 LC
Bio Prox/Smart
Complementar
Inner Acesso 2 LC Bio
Prox/Smart
Complementar
Inner Acesso 2 Prox/Smart
Inner Prox/SmartAcesso (^2) Complementar
Inner Acesso 2 Prox/Smart
Inner Prox/SmartAcesso 2 LC Bio Complementar


```
Inner Acesso 2 LC Bio
Prox/Smart Complementar
+ Leitor Externo
```
```
Inner Acesso 2 sem
leitor + Leitor
Externo
```
```
Inner Acesso 2
Complementar sem
leitor + Leitor Externo
```
```
Inner Acesso 2 LC Bio
Prox/Smart + Leitor
Externo
```
```
Inner Acesso 2 Complementar
sem leito + Leitor Externo
```
Inner Acesso 2 LC Bio
Prox/Smart + Leitor
Externo

```
Inner Acesso 2 LC Bio
Prox/Smart + Leitor
Facial
```
```
Inner Acesso 2 Complementar
sem leito + Leitor Facial
```
```
Inner Acesso 2 sem
leitor + Leitor
Facial
```
```
Inner Acesso 2
Complementar sem
leitor + Leitor Facial
```
```
Inner Acesso 2 LC Bio
Prox/Smart + Leitor
Facial
```
```
Inner Acesso 2 LC Bio
Prox/Smart Complementar
+ Leitor Facial
```
```
Inner Acesso 2
Complementar sem
leitor + Leitor Externo
```
```
Inner Acesso 2 LC Bio
Prox/Smart + Leitor
Externo
```

```
Inner Acesso 2
LC Bio QR Code
```
```
Inner Acesso 2
LC Bio QR Code
Complementar
```
```
Inner Acesso 2
LC Bio QR Code
```
```
Inner Acesso 2 QR
Code ou Prox /Smart
QR Code
Complementar
```
```
Inner Acesso 2
QR Code ou Prox
/Smart QR Code
```
```
Inner Acesso 2
LC Bio QR Code
Complementar
```
```
Inner Acesso 2
QR Code ou Prox
/Smart QR Code
Complementar
```
Inner Acesso 2
QR Code ou Prox
/Smart QR Code

```
Inner Acesso 2
com Botão
```
```
Inner Acesso 2
Prox/Smart
Complementar
```
```
Inner Acesso 2
com Botão
```
```
Leitor TopProx/
TopSmart Adicional
```
```
Inner Acesso 2 LC
Bio Prox/Smart
Complementar
```
```
Inner Acesso 2
com Botão
```

(^)
(^) Inner Acesso 2 QR
Code ou Prox
/Smart QR Code +
Leitor Externo
Inner Acesso 2 QR Code
ou Prox /Smart QR Code
Complementar + Leitor
Externo
Inner Acesso 2
QR Code ou Prox
/Smart QR Code
+ Leitor Externo
Inner Acesso 2
LC Bio QR Code
Complementar
+ Leitor Externo
Inner Acesso 2
LC Bio QR Code
+ Leitor Externo
Inner Acesso 2
LC Bio QR Code
Complementar
+ Leitor Externo
Inner Acesso 2
LC Bio QR Code
+ Leitor Externo
Inner Acesso 2 QR
Code ou Prox /Smart
QR Code
Complementar +
Leitor Externo
Inner Acesso 2
LC Bio QR Code
Complementar
Inner Acesso 2
com Botão
Inner Acesso 2 QR
Code ou Prox
/Smart QR Code
Complementar
Inner Acesso 2
com Botão


Inner Acesso 2
QR Code ou Prox
/Smart QR Code
+ Leitor Facial

```
Inner Acesso 2
LC Bio QR Code
Complementar
+ Leitor Facial
```
```
Inner Acesso 2
QR Code ou Prox
/Smart QR Code
+ Leitor Facial
```
```
Inner Acesso 2 QR Code
ou Prox /Smart QR Code
Complementar
+ Leitor Facial
```
```
Inner Acesso 2
LC Bio QR Code
+ Leitor Facial
```
```
Inner Acesso 2 QR
Code ou Prox /Smart
QR Code
Complementar +
Leitor Facial
```
```
Inner Acesso 2
LC Bio QR Code
+ Leitor Externo
```
```
Inner Acesso 2
LC Bio QR Code
Complementar
+ Leitor Externo
```

#### 1.7.2 MODO TORNIQUETE

A seguir apresentamos algumas das combinações possíveis para controle de acesso de
um Torniquete utilizando o Inner Acesso 2. Alguns pontos a serem considerados:

- O modo torniquete permite apenas o uso do Inner Acesso 2 Principal.
- Para uso de um torniquete unidirecional é necessário utilizar apenas um Inner
    Acesso 2 Principal no lado que deseja controlar o acesso.
- Para uso de um torniquete bidirecional é necessário utilizar dois Inner Acesso 2
    Principal. Um para cada sentido de acesso.
- Pode ser utilizado com qualquer modelo de Inner Acesso 2 disponível.
- Quando em modo Torniquete, caso utilize um leitor externo conectado ao Inner
    Acesso 2 este sempre realizará o acesso no mesmo sentido que o leitor
    (proximidade ou biometria) interno do equipamento.

As imagens à seguir exemplificam esta instalação:


Torniquete Unidirecional Torniquete Bidirecional

```
Inner
Acesso 2
Acesso 2 Inner Principal^
Principal
```
```
Estrada
ou
Saída
```
## 2 INSTALAÇÃO DO INNER ACESSO

**Principal**


**2 Instalação do Inner Acesso 2**

O Inner Acesso 2 possui um suporte removível para facilitar o processo de instalação.
Este suporte possui o tamanho e furação compatível com as caixas de passagem 2x4”
comumente utilizadas na construção civil.

### 2.1 FIXAÇÃO NA PAREDE

Para a instalação será necessário:

- Posicionar o suporte do Inner Acesso 2 contra a parede e marcar a posição dos
furos de fixação. O próprio suporte do Inner Acesso 2 pode ser utilizado como
gabarito. Para fixação em parede de concreto, recomenda-se o uso de parafuso
AA M4, 2x25mm cabeça panela e bucha número 6;
- Fazer os furos na parede e colocar as buchas;
- Posicionar o suporte no local dos furos e colocar os parafusos, fixando o suporte
na parede, como demonstrado à seguir:


- Conectar os cabos de ligação utilizados, como alimentação, cabo de rede, cabo de
acionamentos, cabo do Inner Acesso 2 Complementar e cabo do leitor externo no corpo
do Inner e o encaixar no suporte fixado na parede:
- Colocar o parafuso de trava do suporte na parte inferior do Inner:
- Pronto, o Inner Acesso 2 está fixado e pronto para ser utilizado.


### 2.2 INSTALAÇÃO DO INNER ACESSO 2 – USO EXTERNO

**Dimensões e peso do Gabinete**

- 147 x 112 x 66 mm (Altura x Largura x Profundidade).
- Gabinete: 0,300 Kg.
    - Essa instalação é válida para as linhas Inner Acesso 2 Uso Externo sendo: LC
       Bio / Prox / Smart / QR / Sem leitor / Botão
    - No momento que for instalar o equipamento Inner Acesso 2 com o gabinete
       de proteção contra a chuva na parede, aplique uma camada contínua de
       silicone neutro em toda a borda do gabinete. O afastamento pode ser de até
       1 cm das bordas, para que o silicone não fique aparecendo após a instalação
- Após aplicação do silicone na parte traseira do gabinete, monte o gabinete
junto com o suporte da parede na seguinte sequência de montagem (vide
imagem abaixo):

1 – Gabinete


2 - Suporte plástico do equipamento
3 - Parafusos de fixação (não acompanham)
Aparafuse o conjunto na parede usando uma chave apropriada para a montagem.

- Com o conjunto gabinete e suporte fixo na parede, conecte os cabos no Inner
    Acesso 2 e encaixe o equipamento no suporte.
- Depois, fixe o Inner Acesso 2 ao suporte da parede, usando o parafuso plástico
    e chave philips. Esse furo de fixação se encontra na parte de baixo do
    equipamento.


ATENÇÃO: O Inner Acesso 2 Uso Externo tem componentes específicos, e é preparado
internamente para este uso. Apenas equipamentos que saíram da fábrica com esta
especificação devem ser instalados em conjunto com o gabinete de uso externo


### 2.3 INSTALAÇÃO DO INNER ACESSO 2 – PEDESTAL

**Dimensões e peso do Pedestal**

- 1050 x 80 x 40 mm (Altura x Largura x Profundidade).
- Pedestal: 3,25 Kg.

```
Pedestal sem Gabinete Pedestal com Gabinete
```
O Pedestal para Inner Acesso 2 é um item opcional para soluções externas, como
controle de acesso de veículos. Uma de suas vantagens é o fato de o usuário não ter a
necessidade de sair do veículo para ter acesso ao local.


**Guia rápido de Instalação para acesso com veículos**

No momento que for instalar o gabinete, aplique uma camada contínua de silicone
neutro em toda a borda do pedestal onde será instalado. O afastamento pode ser de
até 1 cm das bordas, para que o silicone não fique aparecendo depois de instalado.

Depois de aplicar o silicone no pedestal, monte o gabinete junto com o suporte da
parede na seguinte sequência de montagem.

1 - Gabinete
2 - Suporte plástico do equipamento

3 - Parafusos de fixação

Parafuse o conjunto no pedestal com os parafusos fornecidos e use uma chave philips
para realizar o aperto. Mantendo os recortes alinhados o alinhamento dos parafusos se
dará de forma mais fácil.
_Base de fixação_


**Fixação no piso**

Com o conjunto pronto conecte os cabos e encaixe o equipamento Inner Acesso 2 no
suporte da parede. Depois, fixe o Inner Acesso 2 ao suporte da parede, usando o
parafuso plástico fornecido e chave philips. Esse furo de fixação se encontra na parte
de baixo do equipamento.

O Totem deve ser instalado em uma superfície elevada de aproximadamente 15
centímetros de altura para facilitar o acesso aos leitores pelo usuário que estará dentro
do automóvel. Veja exemplo a seguir:

Na base do Totem encontram-se 4 furos de diâmetro 9 milímetros para a passagem de
fixadores, escolha a melhor forma de fixação com o propósito de garantir que o
pedestal fique firme no piso.


Chumbadores Parabolt com sistemas de fixação por parafuso ou rosca podem ser
utilizados para a fixação dependendo do material do piso a ser instalado. Na dúvida
sempre consulte um técnico para a correta fixação.

### 2.4 FONTE DE ALIMENTAÇÃO

O Inner Acesso 2 requer fonte de alimentação externa (que não acompanha o produto)
com saída de 12V DC e plugue ABNT NBR 14136.


## 3 CONEXÕES

As conexões elétricas do Inner Acesso 2 são realizadas através dos conectores
localizados na parte traseira do equipamento, conforme demonstrado a seguir.
Recomenda-se que estejam estanhadas e devidamente isoladas; Instalações
inadequadas podem implicar no mau funcionamento das portas e fechaduras
controladas pelo Inner.

Para os modelos de Inner Acesso 2 com comunicação de rede Wi-Fi, o cabo de rede
precisa estar conectado somente ao fazer as configurações iniciais no Web Server,
referente a comunicação com a rede Wi-Fi. Após essa configuração não é necessário
manter o cabo de rede conectado ao equipamento. Caso o cabo de rede permaneça
conectado e a comunicação Wi-Fi também, a comunicação ocorrerá primeiro via cabo,
ou seja, a conexão via cabo tem prioridade sobre a Wi-Fi.

A Topdata recomenda para os modelos com Wi-Fi desconectar o cabo de rede após
realização a configuração de rede.

### 3.1 FECHADURA

O Inner Acesso 2 permite o acionamento de fechaduras elétricas e eletromagnéticas
através da sua saída de contato seco. O acionamento pode ser realizado através dos
contatos “Normalmente Aberto” e “Normalmente Fechado”.

Para isso, deve ser utilizado o conector “ **Acionamentos** ” onde:


```
NF Contato normalmente fechado do relê.
```
```
C Contato comum do relê.
```
```
NA Contato normalmente aberto do relê.
```
```
+12V Saída +12V para alimentar a fechadura.
```
```
S2 Entrada para sensor de porta.
```
##### GND

```
Negativo para fechadura e comum para os
sensores.
```
```
S1 Entrada para botoeira externa.
```
#### 3.1.1 FECHADURA ELÉTRICA

Para o acionamento de fechaduras elétricas deve ser utilizado o contato Normalmente
Aberto (NA) da saída “Acionamentos”. Para fechaduras alimentadas com 12V pode-se
utilizar a mesma fonte que alimenta o Inner Acesso 2 para alimentar também a
fechadura. Neste caso, utilizar o seguinte esquema de ligação:

**ATENÇÃO:** A capacidade da fonte deve ser suficiente para suprir o consumo do Inner
Acesso 2 e da fechadura. Para fechaduras com alimentação diferente de 12V utilizar
alimentação individual conforme recomendação do fabricante. Neste caso utilizar o
seguinte esquema de ligação:


#### 3.1.2 FECHADURA ELETROMAGNÉTICA

Para o acionamento de fechaduras eletromagnéticas deve ser utilizado o contato
Normalmente Fechado (NF) da saída “Acionamentos”. Para fechaduras alimentadas
com 12V pode-se utilizar a mesma fonte que alimenta o Inner Acesso 2 para alimentar
também a fechadura. Neste caso, utilizar o seguinte esquema de ligação:

**ATENÇÃO:** A capacidade da fonte deve ser suficiente para suprir o consumo do Inner
Acesso 2 e da fechadura. Para fechaduras com alimentação diferente de 12V utilizar
alimentação individual conforme recomendação do fabricante. Neste caso utilizar o
seguinte esquema de ligação:


### 3.2 BOTÃO EXTERNO DE LIBERAÇÃO

Uma botoeira pode ser instalada para realizar a liberação da porta ou torniquete sem
o controle de acesso, somente pelo seu acionamento. Podem ser utilizados modelos
com contatos normalmente aberto ou normalmente fechado, sendo a configuração
padrão “normalmente aberto”.

Para a instalação, utilize as vias **S1** (fio roxo) e **GND** (fio azul) do conector
“Acionamentos” conforme mostrado no diagrama a seguir. A botoeira não possui
polaridade.

### 3.3 SENSOR DE PORTA

Um sensor de porta pode ser instalado para verificar o estado da porta e gerar alarme
nos seguintes casos:


**Porta aberta sem autorização** : caso a porta tenha sido aberta sem que tenha sido
identificado um usuário por cartão ou biometria ou o acionamento do botão externo
de liberação.

**Porta esquecida aberta** : caso a porta tenha sido aberta após um acesso de um usuário
por cartão, biometria ou pelo acionamento do botão externo de liberação e tenha
permanecido aberta por um tempo superior ao configurado.

Em ambos os casos, o Inner gerará um bip longo do buzzer e piscará o LED ROSA a cada
5 segundos até que a porta seja fechada.

Utilize os fios **S2** (fio verde) e **GND** (fio azul) do Inner Acesso 2 para conectar os dois
fios do sensor de porta (que não possui polaridade), como demonstrado no diagrama a
seguir:

Por padrão, o Inner Acesso 2 sai de fábrica com o sensor de porta desabilitado, podendo
ser habilitado através do Web Server ou do software Gerenciador de Inners. O sensor
de porta funciona em modo online e offline.

### 3.4 SENSOR DE VIOLAÇÃO

O Inner Acesso 2 e o Inner Acesso 2 Complementar possuem sensor com alarme sonoro
e luminoso em caso de o equipamento ser removido de seu suporte fixado na parede.
Por padrão, este sensor sai de fábrica como desabilitado, podendo ser habilitado pelo
Web Server ou pelos softwares Topdata. O sensor de violação funciona em modo online
e offline.


Se o sensor de violação estiver habilitado, ao ser retirado do seu suporte ao Inner
gerará três bips curtos no buzzer e piscará o LED AMARELO a cada 5 segundos, até que
ele seja recolocado novamente no suporte.

### 3.5 INNER ACESSO 2 COMPLEMENTAR

A comunicação entre o Inner Acesso 2 e o Complementar é feita através da interface
serial por meio de 4 fios, para os modelos com ou sem biometria e com ou sem QR
Code.

Para a instalação do Inner Acesso 2 Complementar, não é necessário nenhuma
configuração, basta realizar a conexão física entre o Inner Acesso 2 e o Inner Acesso 2
Complementar (desconectado da energia). Ao ser alimentado todas as configurações
são repassadas para o Inner Acesso 2 Complementar automaticamente.

Se o Inner Acesso 2 for biométrico e estiver com biometrias cadastradas, na primeira
inicialização serão enviadas ao Inner Acesso 2 Complementar. Durante o processo de
sincronização, o LED do Inner Acesso 2 Complementar ficará piscando na cor LARANJA,
e sua utilização ficará bloqueada até a conclusão do processo. O Inner Acesso 2
Principal poderá ser utilizado para acesso normalmente durante o processo.

Para a instalação do Inner Acesso 2 Complementar realize as conexões conforme o
diagrama a seguir:


A distância máxima de cabo entre o Inner Acesso 2 e o Inner Acesso 2 Complementar
não deve ser superior a 15 metros. Recomendamos utilizar cabo LAN Cat5.

**Observação**

Quando o Inner Acesso 2 for utilizado em conjunto com o Inner Acesso 2 Complementar,
não será necessária nenhuma configuração quanto à entrada ou saída.
Automaticamente o Inner Acesso 2 Complementar terá a configuração inversa à
configuração do Inner Acesso 2, ou seja, para:

Inner Acesso 2 configurado como ENTRADA -> Inner Acesso 2 Compl. será SAÍDA

Inner Acesso 2 configurado como SAÍDA - > Inner Acesso 2 Compl. será ENTRADA

### 3.6 LEITOR DE CARTÕES EXTERNO

Opcionalmente pode ser instalado um leitor de cartões externo ao Inner Acesso 2,
através de sua entrada para leitor externo, localizada na parte traseira do
equipamento. São fornecidas saídas com as tensões 5V e 12V para alimentação do leitor
externo.

Podem ser utilizados leitores externos dos modelos Top Prox, Top Smart, Acura Prox,
Acura Mifare, HID, entre outros. Além disso, o Inner Acesso 2 também é compatível
com o Leitor Facial, que permite uma experiência de acesso ainda mais segura e
conveniente. Para a instalação, utilize o seguinte conector:


```
GND Alimentação para o leitor externo - Negativo (-)
```
```
+5V Alimentação para o leitor externo – Positivo (+5V)
```
```
CLK/D1 Clock/D1 da comunicação serial do leitor externo
```
```
DT/D0 Data/D0 da comunicação serial do leito externo
```
```
GND Alimentação para o leitor externo - Negativo (-)
```
```
+12V Alimentação para o leitor externo – Positivo (+12V)
```
A distância máxima entre o Inner Acesso 2 e o leitor externo ou Leitor Facial não deve
ser superior a 15 metros. Recomendamos a utilização de cabo LAN CAT 5 para garantir
um bom desempenho na comunicação.

Consulte o consumo máximo da saída de alimentação para o leitor externo de 5V e
12V, bem como para o Leitor Facial, no tópico “Especificações Técnicas”. Caso o
consumo seja superior à especificação máxima do Inner Acesso 2, será necessário
utilizar uma fonte auxiliar para alimentação do leitor externo ou Leitor Facial.

Ao adquirir o leitor adicional montado no gabinete seguindo o layout do Inner, o cabo
de conexão será fornecido e a ligação deverá ser realizada conforme demonstrado a
seguir:


```
Esquema de conexão para leitores com alimentação de 5V para leitores de
proximidade
```
```
Esquema de conexão para leitores com alimentação de 12V para leitores de
proximidade
```
**Esquema de conexão para leitores com alimentação de 12 V para leitores faciais**

```
N.C = Não conectado
```
```
N.C = Não conectado
```

### 3.7 CONEXÃO DE TORNIQUETE NO INNER ACESSO

```
A conexão é feita usando o sensor 2 e o contato “Normalmente Aberto” (NA) da
seguinte maneira:
```
- O fio do contato Normalmente Aberto (NA) e o fio do Comum (C) são responsáveis pelo
    acionamento do torniquete para acesso. Devem ser conectados onde libera giro no
    sentido horário ou anti-horário na placa do torniquete.
- O sensor 2 é responsável por receber do torniquete a confirmação que houve giro no
    mesmo após a liberação do acesso. Usando um torniquete unidirecional conecte o fio
    do sensor 2 (S2) e o fio GND no sinal de giro (horário ou anti-horário) da placa do
    torniquete.
    A seguir como exemplo segue a conexão de um torniquete unidirecional liberando o
    sentido anti-horário com o Inner internamente configurado como Entrada.

```
Para torniquetes bidirecionais é necessário utilizar dois Inner Acesso 2 Principal um
controlando cada lado do torniquete (entrada e saída). A seguir um exemplo de uso
onde um Inner realiza acesso de entrada no sentido anti-horário e o outro Inner realiza
a saída no sentido horário.
```

**Observações Importantes**

- Consultar a Topdata sobre os modelos de Torniquetes disponíveis.
- A opção Tempo de Acesso no Web Server ou Gerenciador de Inners deve ser
    preenchido com o tempo de time out de giro do torniquete.


## 4 OPERAÇÃO

### 4.1 CADASTRO DO USUÁRIO MASTER

Quando o Inner Acesso 2 é inicializado pela primeira vez é iniciado o processo de
cadastro do usuário Master. Este usuário é responsável pelo cadastro de novos usuários
com permissão de acesso por cartão ou biometria.

Na primeira inicialização, o Inner ficará piscando o LED BRANCO seguido de um bip
curto, indicando que ele está aguardando o cadastro do usuário Master. O primeiro
cartão de proximidade, QR Code ou biometria válida inserida será armazenado na
memória do Inner como usuário Master. Opcionalmente pode ser cadastrada a segunda
digital para o usuário Master com o auxílio do Web Server.

Para aplicações onde o Inner Acesso 2 não possui biometria e será utilizado em
conjunto com um Inner Acesso 2 LC Bio Complementar, o cadastro do master será
acessível pelo Inner Acesso 2 Complementar. Já em casos onde será utilizado apenas o
Inner Acesso 2 (Prox, QR Code ou Bio), o cadastro inicial do master poderá ser realizado
tanto pelo leitor interno quanto pelo leitor externo.

Em caso de falha no cadastro do Master com a biometria, o processo de cadastro
retorna ao início para uma nova tentativa. Se o usuário Master não for cadastrado,
após 30 segundos o Inner sai do processo de cadastro e entra em modo de operação.
Reiniciando o equipamento o Inner entra novamente no processo de cadastro. Uma vez
concluído com sucesso o processo de cadastro, ao reiniciar, o Inner não entra mais no
processo de cadastro do Master.

O número do cartão e biometrias do usuário Master podem ser alterados através do
Web Server ou pelo software Gerenciador de Inners.

#### 4.1.1 CADASTRO DO USUÁRIO MASTER COM CARTÃO

```
Passo Instrução Sinalização
```
##### 1

```
Na primeira inicialização, o LED BRANCO piscando
indica que o Inner está aguardando o cadastro do
usuário Master:
```
##### BRANCO


```
2 Aproxime o cartão para ser cadastrado como Master.
Cadastro concluído com sucesso: VERDE^
```
3 O Inner entra em repouso: (^) AZUL

#### 4.1.2 CADASTRO DO USUÁRIO MASTER COM BIOMETRIA

Passo (^) Instrução Sinalização

##### 1

```
Na primeira inicialização, o LED BRANCO
piscando indica que o Inner está aguardando o
cadastro do usuário Master:
```
##### BRANCO

2 Insira a digital para o Master pela 1ª vez: (^) VERDE
3 Remova o dedo: (^) AMARELO
4 Insira a digital para o Master pela 2ª vez: (^) VERDE
5 Remova o dedo: (^) AMARELO
7 Insira a digital para o Master pela 3ª vez: (^) VERDE
8 Remova o dedo.^
Cadastro concluído com sucesso:

##### VERDE

9 O Inner volta para o repouso: (^) AZUL
Possíveis falhas no processo de cadastro:

##### 1

```
Qualidade baixa da impressão digital ou as 3
amostras da digital não são iguais: ROXO^
```
2 Processo de cadastro incompleto: (^) VERMELHO


##### 3

```
Digital já cadastrada.
Pisca VERMELHO duas vezes: VERMELHO^
```
##### 4

```
Memória do módulo biométrico cheia.
Pisca VERMELHO três vezes: VERMELHO^
```
Ao utilizar o Inner Acesso 2 sem biometria em conjunto com um Inner Acesso 2 LC Bio
Complementar, o cadastro do master será acessível pelo Complementar.

Já em casos onde será utilizado apenas o Inner Acesso 2 (Prox, QR Code ou Bio), o
acesso ao master poderá ser realizado tanto pelo leitor interno quanto pelo leitor
externo, desde que a configuração do leitor 2 (externo) esteja igual a configuração do
leitor 1 (interno). Caso a configuração do leitor 2 esteja diferente do leitor 1, apenas
o leitor 1 acessará o menu master.

### 4.2 CADASTRO DE USUÁRIOS

Para realizar o cadastro de novos usuários pelo Inner Acesso 2 é necessário que o
cadastro do usuário Master tenha sido concluído com sucesso. Usuários cadastrados
pelo usuário Master são cadastrados na lista de acesso como “Liberado”, ou seja, sem
restrições de horários e dias da semana, mas podem ter o acesso controlado por até
100 tabelas de horários configuráveis com o auxílio do Web Server ou pelo software
Gerenciador de Inners.

Com o cartão ou biometria do usuário Master, realize o processo de cadastro de novos
usuários por cartão ou biometria:

#### 4.2.1 CADASTRO DE CARTÕES

```
Passo Instrução Sinalização
```
1 Inicie o processo com o Inner em repouso: (^) AZUL
2 Aproxime o cartão, aponte o QR Code ou insira a
biometria do Master: BRANCO^


##### 3

```
Aproxime o novo cartão a ser cadastrado.
Cadastro concluído com sucesso: VERDE^
```
4 O Inner volta para o repouso: (^) AZUL

#### 4.2.2 CADASTRO DE BIOMETRIA

```
4.2.2.1 Cadastro de biometria sem cartão
```
É possível o cadastramento de uma digital sem vincular a um número de cartão. Ao
realizar este tipo de cadastro, o Inner gerará automaticamente um número de cartão
sequencial para cada biometria, incrementado a partir da numeração 900001 conforme
as biometrias sejam cadastradas. Ex.: 900001, 900002, etc.

Para realizar o cadastro siga os passos a seguir:

```
Passo Instrução Sinalização
```
1 Inicie o processo com o Inner em repouso: (^) AZUL
2 Aproxime o cartão ou insira a biometria do Master: (^) BRANCO
3 Insira a nova digital pela 1ª vez: (^) VERDE
4 Remova o dedo: (^) AMARELO
5 Insira a nova digital pela 2ª vez: (^) VERDE
6 Remova o dedo:^ AMARELO
7 Insira a nova digital pela 3ª vez:^ VERDE

##### 8

```
Remova o dedo.
Cadastro concluído com sucesso:
```
##### VERDE

9 O Inner volta para o repouso: (^) AZUL


Possíveis falhas no processo de cadastro:

##### 1

```
Qualidade baixa da impressão digital ou as 3
amostras da digital não são iguais: ROXO^
```
2 Processo de cadastro incompleto: (^) VERMELHO

##### 3

```
Digital já cadastrada.
Pisca VERMELHO duas vezes:
```
##### VERMELHO

##### 4

```
Capacidade máxima de digitais atingida.
Pisca VERMELHO três vezes:
```
##### VERMELHO


```
4.2.2.2 Cadastro de biometria com cartão
```
Para realizar o cadastro da biometria vinculando a um cartão, primeiramente realize
o cadastro do cartão através do usuário Master. Com o cartão já cadastrado, siga os
passos a seguir:

```
Passo Instrução Sinalização
```
1 Inicie o processo com o Inner em repouso: (^) AZUL

##### 2

```
Aproxime o cartão, aponte o QR Code ou insira
a biometria do Master: BRANCO^
```
3 Aproxime o cartão já cadastrado: (^) AMARELO
4 Insira a nova digital pela 1ª vez: (^) VERDE
5 Remova o dedo: (^) AMARELO
6 Insira a nova digital pela 2ª vez: (^) VERDE
7 Remova o dedo: (^) AMARELO
8 Insira a nova digital pela 3ª vez: (^) VERDE
9 Remova o dedo. Cadastro concluído com
sucesso: VERDE^
10 O Inner volta para o repouso: (^) AZUL
Possíveis falhas no processo de cadastro:
1 Qualidade baixa da impressão digital ou as 3
amostras da digital não são iguais: ROXO^
2 Processo de cadastro incompleto: (^) VERMELHO


##### 3

```
Digital já cadastrada.
Pisca VERMELHO duas vezes:
```
VERMELHO (^)

##### 4

```
Capacidade máxima de digitais atingida.
Pisca VERMELHO três vezes:
```
##### VERMELHO

```
4.2.2.3 Recadastro da biometria com cartão
```
Para recadastrar a biometria de um usuário com cartão, realize os mesmos passos
descritos no procedimento de cadastro (ver tópico 4.2.2.2), aproximando o cartão
referente à biometria a ser recadastrada. A antiga biometria será removida e
substituída pela nova cadastrada.

### 4.3 EXCLUSÃO DE USUÁRIOS

Para realizar este procedimento consulte o Web Server do produto. Pelo Web Server,
é possível editar ou excluir usuários, bloquear o acesso e inseri-los em tabelas de
horários. Também é possível realizar o controle dos usuários com o auxílio do software
Gerenciador de Inners. O menu Master do Inner Acesso 2 não contempla a exclusão de
usuários, somente a inclusão.


## 5 ACESSAR O WEB SERVER

Para acessar o Web Server do Inner Acesso 2, conecte o Inner e o computador na mesma
rede Ethernet e utilize o navegador compatível de sua preferência. Por padrão o Inner
Acesso 2 sai de fábrica com o IP 192.168.1.123. Digite este IP na barra de endereços
do seu navegador:

Após iniciar o acesso, será exibida a mensagem “CARREGANDO....” enquanto o Web
Server está sendo carregado:

Obs.: para acessar o Web Server, é necessário que o computador esteja na mesma
faixa de IP que o Inner Acesso. Caso a sua rede possua outra faixa de IP, recomendamos
a conexão de um cabo de rede conectado diretamente entre o Inner e o Computador
e ajuste o IP do computador manualmente. Consulte o manual do Web Server para
mais informações sobre a configuração do computador.


### 5.1 LOGIN

Após o carregamento da página de login, será exibida a tela a seguir. Insira o Usuário
e Senha nos campos do login e clique em **Iniciar Sessão** :

**Usuário e senha padrão:**

**Usuário:** ADMIN

**Senha:** Inner@cesso2

Por questões de segurança, a Topdata recomenda que o Usuário e Senha padrão do
Web Server sejam alterados. Consulte o manual do Web Server para mais detalhes
sobre a utilização do Web Server.

Para equipamentos Inner Acesso 2 que possuem módulo para comunicação de rede Wi-
Fi, Após realizar o primeiro acesso ao Web Server via cabo de rede e ser feito as devidas
configurações da rede local, realizar a configuração da rede Wi-Fi. Após estabelecida
a conexão com a rede Wi-Fi, o acesso ao Web Server poderá ser realizado pelo número
do IP da rede Wi-Fi, que deve ser um número de IP diferente do número de IP da rede
com cabo. Consulte o manual do Web Server para mais informações sobre a
configuração da rede Wi-Fi.


## 6 CONFIGURAÇÕES

### 6.1 LISTA DE CONTROLE DE ACESSO

O Inner Acesso 2 permite controlar em modo offline o acesso de até 15.000 usuários
através da sua lista de acesso. Para esta lista também é possível realizar o cadastro de
tabelas de horários para realizar o controle de horários e dias da semana de acesso
destes usuários. Por padrão, os usuários cadastrados com o usuário Master são
adicionados na lista de acesso “Liberado”, que não possui restrições de horários e dias
da semana, tem o acesso liberado o tempo todo. A lista de acesso pode ser configurada
com o auxílio do Web Server ou pelo software Gerenciador de Inners.

Também é possível alterar a forma como o controle de acesso será realizado em
relação à lista de acesso, podendo controlar o acesso dos usuários cadastrados na lista,
os que não estão na lista ou ainda desabilitar o controle de acesso, como veremos nos
próximos tópicos.

### 6.2 TABELAS DE HORÁRIOS

É possível realizar o cadastro de até 100 tabelas de horários diferentes para realizar o
controle de acesso de usuários cadastrados, controlando horários e dias da semana
liberados. As configurações das tabelas de horários dos usuários podem ser realizadas
com o auxílio do Web Server.

Também é possível realizar o cadastro dos usuários com suas respectivas tabelas
associadas pelo software Gerenciador de Inners.

Os usuários cadastrados pelo Inner Acesso 2 com o usuário Master, são
automaticamente adicionados à lista de acesso “Liberado” e possuem acesso sem
restrições de horários e dias da semana.

Obs.: Estando com o seu relógio ajustado, o Inner Acesso 2 permanece atualizado por
6 dias após ser desconectado da energia. Após este tempo, o relógio é desconfigurado
e precisa ser ajustado novamente. Portanto é recomendado que após a instalação o
Inner seja atualizado antes de iniciar a operação.


### 6.3 CONTROLE DE ACESSO

Determina a regra de controle do acesso dos usuários podendo ser alterada através do
Web Server ou software Gerenciador de Inners.

#### 6.3.1 DESABILITADO

Nesta configuração o controle do acesso fica desabilitado, qualquer cartão ou
biometria que for identificado pelo Inner terá o acesso liberado e o registro na memória
de bilhetes.

#### 6.3.2 CARTÃO NÃO CADASTRADO NÃO PODE PASSAR

Nesta configuração, somente usuários que estiverem na lista de acesso como
“Liberado” ou “Conforme horário” e dentro de, pelo menos, um horário válido terão o
acesso liberado e o registro na memória de bilhetes.

#### 6.3.3 CARTÃO NÃO CADASTRADO PODE PASSAR

Nesta configuração o controle de acesso é realizado apenas para os usuários
cadastrados na lista de acesso. Cartões e biometrias que não estiverem na lista de
acesso terão o acesso liberado e o registro na memória de bilhetes.

### 6.4 BIOMETRIA

O Inner Acesso 2 Bio possibilita a identificação dos usuários por biometria através da
impressão digital. Possui capacidade para armazenar até 3.000 digitais, sendo possível,
portanto realizar o cadastro de até 3.000 usuários com uma digital cada, ou 1.500
usuários com duas digitais cada. Dois modos de validação podem ser configurados para
controlar o acesso, são eles:

#### 6.4.1 MODO DE IDENTIFICAÇÃO (1:N)

No modo de identificação o usuário simplesmente posiciona seu dedo sobre o leitor
biométrico para que sua impressão digital seja lida e identificada. O Inner Acesso 2 Bio
faz a comparação dessa impressão digital com todas as digitais cadastradas e identifica
o usuário. Por padrão, o modo de identificação sai de fábrica habilitado.

#### 6.4.2 MODO DE VERIFICAÇÃO (1:1)

No modo de verificação o usuário primeiro se identifica através de seu cartão, e em
seguida posiciona seu dedo sobre o leitor biométrico. A impressão digital será lida e
comparada com a que está cadastrada para esse usuário específico, verificando a
identidade do usuário. Por padrão, o modo de verificação sai de fábrica desabilitado.


Estas configurações podem ser alteradas através do Web Server ou software
Gerenciador de Inners.

#### 6.4.3 USUÁRIOS SOMENTE CARTÃO

Para o Inner Acesso 2 com biometria e com Modo de Verificação habilitado, sempre
que o usuário aproximar o cartão de proximidade no leitor será solicitada sua biometria
para completar a verificação da identidade. Porém é possível cadastrar alguns usuários
na lista de usuários “somente cartão”, e para estes não será solicitada a verificação
biométrica. Este recurso normalmente é utilizado para usuários que possuem
dificuldade com a identificação das suas digitais.

Esta lista pode ser enviada através do software Gerenciador de Inners ou ativada
individualmente através da marcação da flag “Dispensa verificação biométrica” no
cadastro de usuário via Web Server, sendo possível cadastrar até 8.000 cartões para
acesso somente por cartão.

#### 6.4.4 REGISTROS

O Inner possui capacidade para armazenar em sua memória os últimos 30.000 registros
de acessos realizados. Caso a capacidade total de bilhetes seja atingida, a cada novo
bilhete gerado o Inner apaga o registro mais antigo, permanecendo sempre com os
registros mais recentes.

A coleta dos registros pode ser realizada com o auxílio do Web Server ou pelo software
Gerenciador de Inners bem como a configuração de quais registros devem ser
armazenados na memória. Segue abaixo um exemplo de coleta utilizando o Web
Server:

No exemplo acima, podemos identificar as seguintes informações no último registro
gerado **“010 19/03/19 11:31 0000094525336525 01”** :


```
Dado Informação
```
```
010 Tipo do bilhete: Entrada liberada
```
```
19/03/19 Data do acesso
```
```
11:31 Horário do acesso
```
```
0000094525336525 Número do cartão
```
```
01 Número do Inner
```
#### 6.4.5 TIPOS DE BILHETES

```
Tipo Descrição
010 Entrada liberada
011 Saída liberada
012 Entrada bloqueada / Falha na verificação biométrica
013 Saída bloqueada / Falha na verificação biométrica
```
A coleta pelo software Gerenciador de Inners permite uma exportação de bilhetes mais
flexível possibilitando a customização da exportação dos dados:


Além disso, pelo software também é possível configurar para que a coleta seja
realizada de forma automática, salvando o arquivo com a coleta no local desejado.
Consulte o manual do software Gerenciador de Inners para mais informações.

#### 6.4.6 CONFIGURAÇÕES DE REGISTROS

Os registros de acesso liberado são sempre armazenados na memória e pelo Web Server
ou pelo software Gerenciador de Inners é possível configurar se os acessos negados
também serão armazenados:

#### 6.4.7 REGISTRO DE ACESSO NEGADO

Permite que os acessos negados de usuários que não estejam na lista de acesso, com
acesso como “Bloqueado” ou fora de horário válido sejam registrados na memória.

#### 6.4.8 REGISTRO DE FALHA NA VERIFICAÇÃO BIOMÉTRICA

Para o Inner Acesso 2 Bio, permite que os acessos negados de usuários que possuem
digital cadastrada e tiveram falha na verificação 1:1 da digital sejam registrados na
memória.

#### 6.4.9 DESABILITAR WEB SERVER

É possível desabilitar o acesso ao Web Server do Inner Acesso 2 em casos em que ele
não será utilizado para configurações e deseje reduzir a possibilidade de utilizadores
indesejados do sistema pela interface de rede.

Para utilização offline, o Web Server pode ser desabilitado pelo software Gerenciador
de Inners, e para utilização online a configuração deverá ser realizada no software
TopAcesso ou TopPortaria. Consulte o manual do software para mais informações.


## 7 SINALIZAÇÕES

```
O Inner Acesso 2 possui diversas sinalizações luminosas e sonoras para indicar o seu
estado e também situações de sucesso ou falha de operações.
Segue tabela com as principais sinalizações do Inner Acesso 2:
```
```
Estado Sinalização luminosa (pisca) Sinalização sonora
```
Repouso (modo offline) (^) AZUL
Repouso (modo online) (^) AZUL oscilando
Acesso liberado (^) VERDE 1 bip curto agudo
Acesso bloqueado (^) VERMELHO 1 bip longo grave
Biometria não identificada (^) AMARELO 1 bip longo grave
Cartão sem digital cadastrada
(Verificação habilitada) AMARELO^ 1 bip longo grave^
Erro na leitura do cartão.
Verifique o tipo do leitor AMARELO^
1 bip longo grave
Alarme de porta aberta (^) ROSA (5 seg) 1 bip longo agudo a cada 5 segundos
Alarme de violação do Inner (^) AMARELO (5 seg) 3 bips curtos agudosegundos s^ a cada 5
Cadastro do Master ou novos
usuários BRANCO (1 seg)^ 1 bip curto grave a cada 1 segundo^
Sincronização do Inner Acesso
2 Complementar LARANJA (1 seg)^
Reset de parcial de
configurações ROXO^
1 bip curto agudo
Reset de completo de
configurações ROXO (1 seg)^
1 bip curto agudo a cada 2
segundos


## 8 CONFIGURAÇÕES INICIAIS

O Inner Acesso 2 sai de fábrica com uma configuração que permite a sua utilização
offline sem a necessidade de conexão a um computador para funcionamento. Os
usuários de cartão, QR Code ou biometria podem ser cadastrados através do usuário
Master, que é cadastrado na primeira utilização do Inner. Caso necessário, alterações
de configurações e cadastros de usuários também podem ser realizados com o auxílio
do Web Server ou pelo software Gerenciador de Inners.

**Configurações padrão de fábrica:**

```
Tipo Configuração Valor Observações
Web Server Usuário ADMIN
Senha Inner@cesso2
```
```
Acesso
```
```
Função de Controle
```
```
Porta Configurado para uso em
portas, portões, cancelas
e etc.
```
```
Padrão do Cartão AbaTrack /QRCode 4 a 16^ dígitos variáveis^
```
```
Operação Inner
Principal
```
```
Entrada Bilhetes gerados no leitor
interno geram bilhetes de
entrada.
Operação Leitor
Externo
```
```
Desabilitado Configuração do leitor
externo.
Configuração Botão
de Liberação
```
```
Normalmente
aberto
```
```
Botão externo conectado a
entrada S1.
```
```
Tempo de Acesso
```
```
5 segundos Tempo definido para o
acesso ocorrer após
liberação do mesmo no
Inner.
```
```
Segurança
```
```
Controle de acesso Cartão não
cadastrado não
pode passar
```
```
Apenas cartões e
biometrias incluídos na
lista de acesso são
liberados.
Sensor de porta
aberta
```
```
Desabilitado Sensor de porta conectado
a entrada S2.
Registra Acesso
negado
```
```
Não Acessos negados não são
gravados na memória.
```

```
Registra falha na
verificação
biométrica
```
```
Não Falha na verificação não
será gravada na memória.
```
```
Sensor de violação Desabilitado Sensor de remoção do
Inner do seu suporte de
fixação na parede.
```
```
Comunicação
```
```
IP do Inner 192.168.1.123 Endereço para conexão via
rede Ethernet.
Porta de
comunicação
```
##### 3570

```
Máscara de rede 255.0.0.0
Gateway 0.0.0.0
IP do Servidor 192.168.1.100
DHCP Desabilitado
Número do Inner 1
```
```
Biometria
```
```
Identificação Habilitado Identificação 1:N habilitado
Verificação Desabilitado Identificação 1:1 desabilitado
Nível de Segurança Médio Recomendado
```
```
Master
```
```
Master para
cadastro
```
```
Sim Permite cadastrar cartões e
biometrias via cartão master
Número do Master Número do cartão master
cadastrado no após reset
```
Para o Inner Acesso 2 com módulo Wi-Fi a configuração padrão de fábrica quanto a
rede Wi-Fi é:

```
Configuração
Rede Wi-Fi
```
```
Wi-Fi habilitado Sim Wi-Fi ligado, porém sem
conexão estabelecida
DHCP habilitado Sim
IP do módulo 0.0.0.0
Gateway 0.0.0.0
Nome de rede Inneracesso2
```

Rede conectada Campo em branco, pois ainda
não foi conectado a nenhuma
rede.

Redes disponíveis Lista as redes ao redor
disponíveis para conexão


## 9 RESTAURAÇÃO DE CONFIGURAÇÕES

Duas formas de restauração de configurações são possíveis para o Inner Acesso 2:

- Restauração das configurações de rede;
- Restauração das configurações de fábrica.

Para a realização das restaurações, utilize o botão RESET localizado na parte traseira
do equipamento, que pode ser pressionado com o auxílio de um objeto apropriado que
não danifique o produto:

### 9.1 RESTAURAR CONFIGURAÇÃO DE REDE

Esta restauração é recomendada para restaurar os dados de acesso ao Web Server. Esta
restauração retorna para o padrão de fábrica somente as configurações de rede e do
usuário Administrador do Web Server.

Para realizar esta restauração, mantenha o equipamento ligado à energia e pressione
o botão de reset por 5 segundos. O Inner pisca o LED ROXO uma vez seguido de um bip
curto, indicando que a restauração foi realizada com sucesso. Para saber mais sobre
as configurações da fábrica referentes à configuração de rede, consultar o capítulo
**Configurações Iniciais** deste manual (ver tópico 8).


### 9.2 RESTAURAR CONFIGURAÇÕES DE FÁBRICA

Esta restauração retorna para os valores de fábrica todas as configurações do Inner
Acesso 2 e também apaga a lista de acesso, lista de horários e a memória de bilhetes.
Apenas as biometrias são mantidas no equipamento, no caso do Inner Acesso 2 LC Bio.

Para realizar esta restauração, desligue o equipamento da energia, mantenha o botão
de reset pressionado e conecte a energia novamente. Mantenha o botão reset
pressionado até que o Inner comece gerar um bip a cada 2 segundos piscando o LED
ROXO.

O Inner pisca o LED ROXO seguido de um bip curto por aproximadamente 1 minuto, e
no final pisca o LED AZUL indicando que o reset foi concluído com sucesso.

Após a conclusão do processo de reset completo, o usuário Master também foi apagado,
e por este motivo o Inner entra no processo de cadastro do novo usuário Master.
Consulte o tópico referente ao processo de cadastro do Master para mais informações
sobre o processo de cadastro. Para saber mais sobre as configurações da fábrica,
consultar o capítulo **Configurações Iniciais** deste manual (ver tópico 8).


## 10 DÚVIDAS FREQUENTES

**1) Como fazer para excluir um cartão ou biometria da lista de acesso?**

Alteração ou exclusão de usuários pode ser realizada com auxílio do Web Server. Não
é possível remover usuários pelo Inner, através do usuário Master.

**2) O que ocorre se entrar no menu master e cadastrar uma biometria para um
cartão que já possuía uma biometria cadastrada?**

Será excluída a digital que estava cadastrada e será cadastrada a nova digital no lugar.

**3) Como é feito o cadastro de duas digitais por usuário?**

A segunda digital pode ser cadastrada com o auxílio do Web Server, através da edição
do cadastro do usuário.

**4) Ao aproximar o cartão o Inner está sinalizando com o LED amarelo. O que
significa?**

O modo de verificação está habilitado e o cartão não possui digital cadastrada ou a
quantidade de dígitos configurada no Inner não corresponde ao tipo de cartão
aproximado. Consulte o capítulo Sinalizações para mais informações sobre as
sinalizações do Inner Acesso 2.

**5) Posso utilizar a fonte de alimentação de outros produtos da linha Inner no
Inner Acesso 2?**

Não. O Inner Acesso 2 utiliza uma fonte de alimentação com saída de 12Vcc e os outros
produtos da linha Inner utilizam a fonte 5V. A utilização de outras fontes deixa o
sistema sujeito a erros e possíveis danos que pode resultar na perda da garantia.

**6) Como faço o backup das biometrias?**

Para realizar este procedimento você deverá utilizar o software Gerenciador de Inners
ou a exportação via Web Server. Mais informações podem ser encontradas no manual
do Gerenciador e do Web Server respectivamente.


**7) Posso copiar as biometrias de um Inner para outro para não precisar
recadastrar todas as digitais?**

É possível copiar biometrias entre equipamentos exportando e restaurando estas
informações através do procedimento de backup. Mais informações podem ser
encontradas no manual do Gerenciador e do Web Server respectivamente.

**8) O Inner lê códigos QR Code com letras e números?**

O equipamento lê códigos com letra e outros caracteres alfanuméricos, porém,
substitui o mesmo pelo número zero. Por exemplo ao passar o cartão QR Code ou barras
n° _12A1C%_ o Inner irá ler como 120100. Para que seja possível a leitura de caracteres
é preciso utilizar um software online desenvolvido usando uma biblioteca SDK
fornecida pela Topdata.

**9) Como configuro o Wi-Fi?**

Para configurar a rede Wi-Fi deve-se entrar no Web Server do Inner Acesso 2, (consultar
capitulo 5 deste manual para saber como acessar o Web Server), após acessar o Web
Server no menu “Configuração” aba “Comunicação” entrar na opção “Configurar Wi-
Fi” para configurar a rede Wi-Fi de sua preferência selecione a mesma e informe a
senha caso tenha (para saber mais sobre a configuração da rede Wi-Fi consultar manual
do Web Server, capítulo de Configuração de Rede Wi-Fi).

**10) Se estiver o cabo de rede conectado com módulo Wi-Fi ativado, o que
acontece?**

Nesse caso é possível o acesso ao Web Server digitando no navegador o IP da rede do
cabo ou pelo IP da rede Wi-Fi configurada no Inner Acesso 2. Porém a comunicação de
rede via cabo tem prioridade sobre a rede Wi-Fi nos casos que for utilizado algum
software para estabelecer comunicação com o equipamento por exemplo; Gerenciador
de Inners, TopAcesso ou TopPortaria. Para esses casos o software estabelecerá a
comunicação através do IP configurado na conexão via cabo de rede.

**11) Posso utilizar qualquer modelo de torniquete?**

Consulte a Topdata com relação aos modelos de torniquete compatíveis.


## 11 REGULAMENTAÇÃO ANATEL

### 11.1 REGULAMENTAÇÃO LEITOR PCI TOPPROX PRO

```
Os Coletores Inner Acesso 2, dependendo do modelo do produto, utilizam o Leitor PCI
TopProx Pro para realizar a leitura de determinados modelos de cartões Prox.
Este leitor é regulamentado pela Anatel conforme dados abaixo:
```
- Modelo: Leitor PCI TopProx Pro
- Fabricante: Topdata Sistemas de Automação Ltda.
- Número de homologação: 00266- 16 - 02118
- País de origem: Brasil


### 11.2 REGULAMENTAÇÃO LEITOR TOPSMART

Os Coletores Inner Acesso 2, dependendo do modelo do produto, utilizam o Leitor
TopSmart para realizar a leitura de determinados modelos de cartões Mifare.

Este leitor é regulamentado pela Anatel conforme dados abaixo:

- Modelo: Leitor TopSmart
- Fabricante: Topdata Sistemas de Automação Ltda.
- Número de homologação: 07897- 17 - 02118
- País de origem: Brasil

### 11.3 REGULAMENTAÇÃO MÓDULO COM CONEXÃO WI-FI

Os Coletores Inner Acesso 2 Principal, com módulo de comunicação de rede via Wi-Fi
são regulamentados pela Anatel conforme dados abaixo:

- Modelo: ATWINC15x0-MR210PB/ATWINC15X0-MR210UB
- Número de homologação: 08497- 18 - 08759


## 12 APÊNDICE

### 12.1 CONFIGURAÇÃO DO “LEITOR EXTERNO” NO INNER ACESSO 2.

No “Inner Acesso 2 Principal”, pode ser instalado um “Leitor externo” de cartões
através de sua entrada para leitor externo, localizada na parte traseira do
equipamento.

```
COMUNICAÇÃO SERIAL
```
**Modo Off-line**

O funcionamento do “Leitor Externo” sempre estará associado a configuração do
“Leitor 2”, ou seja, em modo off-line, se utilizar o Gerenciador de Inners ou Web
Server, o “Leitor Externo” será configurado através do “Leitor 2” e pode ser definido
como “Somente entrada” ou “Somente saída”.

Exemplo de configuração pelo Software Gerenciador de Inners:

```
Configurável através
do “Leitor 1”
```
```
Configurável através
do “Leitor 2”
```

Exemplo de configuração no Web Server do Inner Acesso 2:

**Modo On-line**

Em modo on-line, por definição dos softwares TopPortaria e TopAcesso, o
funcionamento do “Leitor Externo” dependerá do Inner Principal possuir ou não um
“Complementar” conectado.

Exemplos de configuração com o Software TopPortaria:

**“Inner Principal” com “Leitor Externo” e sem “Complementar”:**

O “Leitor 1” será “Somente entrada” e “Leitor 2” “Somente saída”. Para isso no
TopPortaria, deve – se configurar no “Local” que o modo de operação será “Controla
Entrada e Saída”.

Caso necessite que o “Leitor 1” seja “Somente saída” e “Leitor 2” “Somente entrada”,
no TopPortaria, configurar no “Local” que o modo de operação será “Controla Saída e
Entrada”


**“Inner Principal” com Leitor Externo e com “Complementar”:**

Todos os leitores do “Principal”, inclusive o seu “Leitor Externo” operam como
“Somente Entrada”.

Todos os leitores do “Complementar”, inclusive o seu “Leitor Externo” operam como
“Somente Saída”.

Para isso no TopPortaria, configurar no “Local” que o modo de operação será “Controla
Entrada e Saída”.

Caso necessite da configuração contrária, para que todos os leitores do “Principal”,
inclusive o seu “Leitor Externo” operem como “Somente Saída” e todos os leitores do
“Complementar”, inclusive o seu “Leitor Externo” operem como “Somente Entrada”
configurar:


```
Exemplo de configuração com o Software TopAcesso:
Para ativar o “Leitor 2” do Inner Acesso 2, na aba “Leitor 1” marcar a opção “Utilizar
o leitor 2 para controlar o retorno do leitor 1”.
No exemplo a seguir, o usuário está “Fora da área de controle” ao passar o cartão fará
uma “Entrada” “para o Local 1” e ao passar o cartão no “Local 1” fará uma “Saída”
para “Fora da área de controle”.
```
```
A configuração de “Entrada ou Saída” é baseada na informação que está configurada
nas opções de “Local” e “Acesso a”.
```
- **“Inner Principal” com Leitor Externo e Sem “Complementar”**
    No TopAcesso o “Inner Principal” obedecerá a configuração do “Leitor 1” e o
“Leitor Externo” do “Leitor 2”.


- **“Inner Principal” com Leitor Externo e com “Complementar”**
    No TopAcesso o “Inner Principal” e o “Leitor Externo” obedecerá a configuração
do “Leitor 1” e o Complementar do “Leitor 2”.


### 12.2 INSTALAÇÃO LEITOR FACIAL T4 E F4 PARA COLETORES

O Leitor Facial é um acessório que pode ser instalado no Inner Acesso 2 para permitir
o acesso biométrico por meio da leitura de faces. O Leitor Facial pode ser instalado a
uma distância de até 15 metros do Inner Acesso 2.

Para instalar o Leitor Facial, siga estas etapas:

- Localize a conexão do leitor de cartão externo na parte traseira do Inner Acesso
    2.
- Conecte uma extremidade do cabo fornecido no kit do Leitor Facial à entrada
    do leitor externo do Inner Acesso 2.
- Conecte a outra extremidade do cabo ao Leitor Facial.
- Certifique-se de que as conexões estejam firmes e seguras.

Para obter mais informações sobre a instalação do Leitor Facial, consulte o Manual do
Leitor Facial.


O Inner Acesso 2 é fornecido com uma configuração padrão onde o “Leitor Externo”
não está ativado. No entanto, se você estiver usando um Inner Acesso 2 com
funcionalidade facial, será necessário ativar o leitor externo antes de usá-lo. Isso pode
ser feito através da interface Web Server do dispositivo. Para mais informações
consulte a seção ‘Configuração do “Leitor Externo” no Inner Acesso 2’ deste manual.

```
Observação:
O leitor facial possui seu próprio conector Ethernet e deve ser conectado a um
ponto de rede TCP/IP compatível para se comunicar com o software. Para Inner
Acesso 2 é necessário um cabo de rede e outro para o Leitor Facial.
```
```
Recomendação:
Para transferir de forma mais automatizada as biometrias faciais de um Leitor
Facial para outro, recomenda-se utilizar o software Gerenciador de Faces. O
software Gerenciador de Faces é um software gratuito que pode ser baixado
do site da Topdata. O software permite que você gerencie suas biometrias
faciais, incluindo a criação, edição e exclusão de registros de biometria facial.
O software também permite que você exporte e importe registros de biometria
facial para outros Leitores Faciais.
Para maiores detalhes consulte o manual do Gerenciador de faces.
```
```
Observação:
O leitor facial do Inner Acesso 2 possui um formato padrão de saída como
Wiegand FC sem separador. Isso significa que os dados de saída do leitor facial
serão transmitidos no formato Wiegand FC.
```

## 13 ESPECIFICAÇÕES TÉCNICAS

Especificações válidas para todos os produtos da linha Inner Acesso 2, conforme modelo
adquirido.

**Leitor de proximidade:**

- Top Prox - 125kHz;
- Top Smart Card - 13,56MHz;
- Configuração de leitores: AbaTrack, Wiegand, Wiegand com Facility Code;
- Wiegand: 26 e 37 bits;
- Número de dígitos configurável: 4 a 16 dígitos fixos ou variáveis;

**Leitor de QR Code:**

- Número de dígitos configurável: 4 a 16 dígitos fixos ou variáveis;
- Para leitura em telas de Smartphones ou similar recomenda-se brilho mínimo
    de 50%
- Para melhor leitura de cartões QR Code (modelo 1, modelo 2 e Micro QR Code)
    recomenda-se a confecção em tamanhos de 2,0 x 2,0 cm a 4,5 x 4,5 cm
- Para melhor leitura de cartões tipo Código de Barras recomenda-se a confecção
    em tamanhos de 5,5 x 1,5 cm a 9,5 x 2,0 cm. Válidos para cartões impressos ou
    lidos a partir de uma tela.
- Para leitura dos códigos, à distância de leitura pode variar, de acordo com o
    tamanho do código mostrado. O leitor tem um campo de leitura fixo, e é
    necessário mostrar o código inteiro a ser lido, dentro dos limites deste campo.


A distância de leitura é proporcional ao tamanho do código, ou seja, quanto maior o
código apresentado, maior a distância para leitura e quanto menor, mais próximo deve
ficar para ser lido. O Laser de posição tem como objetivo ajudar na localização da
melhor posição de leitura e a iluminação adaptativa auxilia no melhor contraste.

O leitor pode realizar leituras inclusive em ambientes de muita luz com iluminação
solar direta (Até 70000Lux).

Abaixo está representado o ângulo de visão do leitor e as distâncias de leitura
recomendados para cada tipo de código. Pode variar de acordo com a qualidade e
tamanho do código.


**Usuário Master**

- Um usuário Master;
- Acessado via cartão, QR Code ou biometria;
- Cadastro de novos usuários por cartão, QR Code ou biometria.

**Web Server**

- Web Server embarcado no produto para configuração, cadastros e exportação
    de registros e configurações;
- Protegido por senha;
- Protocolo HTTP;
- Compatível com principais navegadores do mercado;
- Pode ser desabilitado o Web Server via Gerenciador ou TopAcesso.

**Comunicação via cabo de rede**

- Comunicação: Ethernet 10/100 Mbps (TCP/IP);
- Web Server para configuração e cadastros;
- Comunicação em modo online e offline;
- IP fixo e DHCP;
- Conexão TCP/IP iniciada pelo Inner Acesso 2;
- Permite comunicação com redes locais ou remotas;
- Protocolo de comunicação compatível com os softwares utilizados na linha
    Inner Acesso. Pode ser utilizar no mesmo software coletores e catracas das
    linhas Inner Acesso utilizando o mesmo banco de dados;
- Atualização de firmware e do Web Server através de conexão TCP/IP.

**Comunicação Wi-Fi**

- Possui os recursos já disponíveis na comunicação via cabo de rede
- Conexão de rede Ethernet por Wi-Fi;


- Atende padrão de comunicação IEEE 802.11 b/g/n.
- Opera na frequência de 2.4 GHz
- Possui antena interna integrada
- Suporta segurança WEP, WPA e WPA2
- Configurável através do Web Server do produto

Para melhor conexão entre o Inner Acesso 2 e os dispositivos utilizados para acessar
suas configurações (computadores, Smartphones e etc) é importante garantir uma boa
qualidade de sinal na comunicação estabelecida entre o equipamento e o roteador Wi-
Fi. Evitando assim, falhas, quedas ou lentidão na conexão.

Exemplo ilustrado de aplicação:

Em termos práticos, é recomendado uso de um roteador de no mínimo duas antenas
de-5dBi. A distância máxima é 30 metros em ambiente livre de paredes.

A qualidade do sinal é definida de acordo com o seguinte padrão:

```
➢ Ótimo; acima de -40 dBm
➢ Bom; Abaixo de -40 dBm e Acima de -70 dBm
```
```
A sensibilidade do Inner
acesso 2 é de -70 dBm, ou
seja, necessita de sinal Wi-
Fi de no mínimo -70dBm
para funcionar.
```

```
➢ Ruim; Abaixo de -70 dBm
```
Se houverem paredes, deve ser testado a potência de sinal Wi-Fi que está chegando ao
ambiente. Dependendo do modelo de roteador poderá haver variação nas
características de radiação. Se necessário for, poderão ser instalados repetidores de
sinal.

É possível verificar a qualidade do sinal de sua rede através do Web Server do Inner
acesso 2, para isso, verifique o tópico “Configuração da Rede Wi-Fi” no manual do Web
Server deste produto.

**Biometria**

- Tecnologia biométrica: LC
- Sensor do leitor biométrico com resolução de 500dpi.
- Tempo modo identificação 1:N - menos de 0,9 segundos (para 2.000 digitais
    cadastradas).
- FRR: 1/1. 000 (taxa de falsa rejeição) – máximo de 0,1%.
- FAR: 1/100. 000 (taxa de falsa aceitação) – máximo de 0,001%.
- Permite a combinação de Inner Acesso 2 e Inner Acesso 2 Complementar, para
    controle biométrico através de digitais dos dois lados da porta.
- Permite combinar um Inner Acesso 2 Complementar LC Bio com um Inner Acesso
    2 Prox/Smart, para situações de biometria apenas na entrada do local.
- Transferência automática das digitais do Inner Acesso 2 para o Inner Acesso 2
    Complementar.
- Capacidade de armazenamento: 3.000 templates com uma digital ou 1.500 com
    duas digitais por usuário.
- Acionamento automático do leitor de impressão digital quando o dedo é
    posicionado, sem necessidade de o usuário pressionar nenhuma tecla.
- Configuração de ajustes biométricos.
- Identificação de dedo duplicado.
- Identificação biométrica da impressão digital do usuário (1:N).
- Verificação biométrica para usuários identificados por cartão (1:1).


- Permite backup das digitais cadastradas através do software Gerenciador de
    Inners e do Web Server.
- Lista de usuários somente cartão: até 8.000 usuários;

**Armazenamento**

- Capacidade de armazenamento de 30.000 registros de acessos offline;
- Memória não volátil.

**Lista para controle de acesso**

- Armazenamento de lista para 15.000 usuários;
- Armazenamento de 100 tabelas de horário para controlar o acesso por horário
    e dias da semana;
- Criação de perfil de usuários por meio das tabelas de horários.

**Relógio**

- Mudança automática do início e fim do horário de verão.
- Memória do relógio: 6 dias após desconectado da energia elétrica;
- Atualização do relógio via software ou Web Server;

**LED de sinalização**

- LED RGB com indicação de estado e conclusão de operações em diversas cores;
- Indicação de modo online e offline pelo LED.

**Botão externo de liberação**

- Conexão para um botão externo para liberação da porta;

**Sensor de porta**

- Conexão para um sensor de porta para indicação de alarme de porta aberta sem
    autorização e porta esquecida aberta, com funcionamento online e offline.


- Para controle de torniquetes esse sensor é responsável por receber a
    confirmação de acesso no torniquete.

**Sensor de violação**

- Sensor que gera um alarme sonoro e luminoso em caso de o Inner ser removido
    do seu suporte fixado na parede.

**Acionamento**

- Saída de acionamento para liberação de uma porta a rele com contatos NA e
    NF.
- Saída de acionamento para liberação de um torniquete a rele com contatos NA.
- Capacidade de corrente máxima: 2A.

**Características elétricas**

- Alimentação
    o Tensão nominal: 12V
    o Corrente de consumo do produto:
       ▪ Em cenários que não utilizam leitor facial: 1A
       ▪ Em cenários com leitor facial (conectado ao coletor principal,
          complementar ou ambos): 2A
- Consumo de energia:
    o Inner Acesso 2 Prox = 3W;
    o Inner Acesso 2 LC Prox = 3,5W;
    o Inner Acesso 2 LC Prox QRCode = 4,1W
    o Inner Acesso 2 Prox ligado ao Inner Acesso 2 Prox Complementar = 4,8W;
    o Inner Acesso 2 LC Prox ligado ao Inner Acesso 2 LC Prox Complementar = 5,3W;
    o Inner Acesso 2 LC Prox QRCode ligado ao Inner Acesso 2 LC Prox QRCode
       Complementar = 6W
- Limites Absolutos:


```
o Tensão mínima de alimentação: 11,5Vcc
o Tensão máxima de alimentação: 15Vcc
o Corrente máx. da saída 12V no conector “Acionamentos”: 1A*
*OBS: Para esta condição utilizar fonte 12Vcc – 2A
o Consumo máx. Leitor externo:
▪ 5V: 300mA
▪ 12V: 180mA.
```
Para acionamentos de dispositivos com corrente de consumo superior a 1A utilizar relé
externo para acionamento. Consulte detalhes no site do Suporte Topdata.

**Condições ambientais**

- Uso interno;
- Temperatura: 0 a 45° C;
- Sem condensação.

**Dimensões e peso do Inner Acesso 2**

- 129 x 84 x 42 mm (Altura x Largura x Profundidade).
- Somente Inner: 0,2Kg;
- Caixa completa (Inner, suporte de fixação e cabos): 0,33kg.

**Dimensões e peso do Gabinete**

- 147 x 112 x 66 mm (Altura x Largura x Profundidade).
- Gabinete: 0,300 Kg.

**Dimensões e peso do Pedestal**

- 1050 x 80 x 40 mm (Altura x Largura x Profundidade).
- Pedestal: 3,25 Kg.


**Opcionais**

- Gabinete de proteção para ambientes externos;
- Pedestal;
- Leitor biométrico USB LC – leitor de impressões digitais com interface USB para
    cadastro dos usuários em um computador;
- Software de controle de acesso offline: Gerenciador de Inners;
- Software de controle de acesso online: TopAcesso e TopPortaria.


## 14 HISTÓRICO DE REVISÕES DESTE MANUAL..............................................

```
Revisão Data Alterações
```
```
Revisão 01
01/04/2019 Primeira versão do manual dos coletores Inner Acesso
2 Prox/Smart e Inner Acesso 2 LC Bio Prox/Smart.
```
```
Revisão 02 10/06/2019
```
```
Informações sobre novos modelos da linha Inner
Acesso 2.
Informações sobre importação e exportação via Web
Server.
Atualização de imagens.
Correções ortográficas.
```
```
Revisão 03 10/06/2019 Atualização de imagens.
```
```
Revisão 04 13/06/2019 Correção ortográfica.
```
```
Revisão 05 29/07/2019 Alterado imagem de ligação entre Inner Acesso 2
principal e Inner Acesso 2 complementar.
```
```
Revisão 06 22/11/2019 Correção especificação técnica do Inner Acesso 2.
```
```
Revisão 07 10/12/2019 Ajuste imagens.
```
```
Revisão 08 28/07/2020
```
```
Inclusão de nova linha Inner Acesso 2 Uso Externo.
Atualização da imagem dos cabos de leitor externo.
Atualização da nova logo
```
```
Revisão 09 13/11/2020
```
```
Inclusão da nova linha Inner Acesso 2 QR Code.
Inclusão de informações sobre Configuração do Leitor
Externo (Apêndice).
Atualizadas as imagens com Layout do Web Server.
```
```
Revisão 11 05/01/2021
```
```
Inclusão do modo de operação: Controle de acesso a
Torniquetes.
```

Revisão 12 25/05/2021 Atualização de logo.

Revisão 13 12/07/2021 Inclusão do Pedestal para Inner Acesso 2.

Revisão 14 05/10/2021

```
Inclusão da nova linha de produtos com comunicação
através da rede Wi-Fi.
```
Revisão 15 20/10/2021

```
Alteração na especificação técnica referente a
duração do relógio.
```
Revisão 16 09/11/2021 Atualização da especificação técnica.

Revisão 17 02/03/2023 Atualização de informações sobre a fonte.

Revisão 18 05/07/2023 (^) Atualização da especificação técnica da biometria.
Revisão 19 04/08/2023 (^) Inclusão de informações do leitor Facial.
Revisão 20 20/08/2024 (^) Correção ortográfica.
Revisão 21 22/11/2024 Atualização das^ especificações sobre leitores de
proximidade.


