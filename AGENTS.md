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

1. **Abrir comunicação TCP/IP fixa (porta 3570)**
    - `DefinirTipoConexao(2)`
    - `AbrirPortaComunicacao(porta)`
2. **Testar comunicação com o Inner**
    - `TestarConexaoInner(numeroInner)`
    - Exibir retorno no log visual e console.
3. **Capturar leituras online** (fase 2, posterior)
    - `ReceberDadosOnLine` → popular `DataGridView`.

| Elemento       | Tipo             | Nome             | Observação                |
| -------------- | ---------------- | ---------------- | ------------------------- |
| Porta          | MaterialTextBox2 | `txtPorta`       | Padrão 3570               |
| Nº do Inner    | MaterialTextBox2 | `txtNumeroInner` | Ex.: 1                    |
| Botão Conectar | MaterialButton   | `btnConectar`    | Executa teste de conexão  |
| Botão Iniciar  | MaterialButton   | `btnIniciar`     | Iniciará leitura online   |
| Botão Parar    | MaterialButton   | `btnParar`       | Interrompe leitura        |
| Botão Limpar   | MaterialButton   | `btnLimpar`      | Limpa logs                |
| Log            | logRichTextBox   | logRichControle  | Verificação de Logs       |
| informativo    | Label            | `rtbLog`         | Registro textual          |
| Leituras       | DataGridView     | `dgvLeituras`    | Exibição de cartões lidos |
Campo de IP (`txtIpLeitor`) **é apenas informativo** e **não é usado** pela SDK.  
O Inner deve estar configurado via Web Server para conectar-se ao IP da máquina que roda este programa, porta 3570.

## Configurações fixas

Todos os parâmetros de configuração são **pré-definidos no código**, não editáveis em tela:

``` csharp
EasyInner.DefinirTipoConexao(2); // TCP/IP porta fixa
EasyInner.DefinirPadraoCartao((byte)Enumeradores.PadraoCartao.PADRAO_LIVRE);
EasyInner.DefinirQuantidadeDigitosCartao(14);
EasyInner.DefinirTipoLeitor((byte)Enumeradores.TipoLeitor.PROXIMIDADE_ABATRACK2);
EasyInner.DefinirTipoEquipamento((byte)Enumeradores.TipoEquipamento.COLETOR);

```

Não há botões **Incluir na Lista** ou **Remover da Lista**.  
O objetivo é testar operação **online** pura.