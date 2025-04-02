# CalculadoraCP1

# Calculadora Simples em C#

Este é um projeto em C# que implementa uma calculadora de operações básicas (adição, subtração, multiplicação e divisão) com um menu interativo, validação de entrada e verificação para evitar divisão por zero. O projeto foi desenvolvido para ser utilizado em ambiente de console no Microsoft Visual Studio.

## Descrição

O Calculadora Simples tem como objetivo demonstrar conceitos básicos de programação em C#, como manipulação de entrada/saída, uso de estruturas de controle, métodos e validação de dados. O aplicativo permite ao usuário realizar operações aritméticas com apenas dois números por vez e limpa a tela após cada operação, proporcionando uma experiência de uso mais limpa e organizada.

## Funcionalidades

- Menu Interativo: Exibe um menu com opções para as operações disponíveis.
- Operações Básicas: Suporta adição, subtração, multiplicação e divisão.
- Validação de Entrada: Garante que o usuário insira apenas números válidos.
- Verificação de Divisão por Zero: Impede que o usuário realize uma divisão por zero, mostrando uma mensagem de erro.
- Limpeza da Tela: Após cada operação, a tela do terminal é limpa para melhorar a usabilidade.

## Requisitos

- Microsoft Visual Studio: Qualquer versão que suporte C# e .NET Core ou .NET Framework.
- .NET Core / .NET Framework: Dependendo da sua escolha na criação do projeto.
- Git: (Opcional) para versionamento e exportação do projeto ao GitHub.

## Instalação e Execução

### Executando o Projeto no Visual Studio

1. Abrir o Projeto:
   - Inicie o Visual Studio.
   - Selecione "Abrir um Projeto ou Solução" e navegue até a pasta onde o projeto está localizado.
2. Compilar e Executar:
   - Compile o projeto através do menu "Build → Build Solution".
   - Execute o projeto pressionando F5 ou clicando no botão "Start".

### Executando via Linha de Comando

1. Abra o terminal ou prompt de comando.
2. Navegue até a pasta do projeto:

       cd caminho/para/o/projeto/CalculadoraSimples

3. Compile o projeto:

       dotnet build

4. Execute o projeto:

       dotnet run

## Estrutura do Projeto

CalculadoraSimples/
│
├── Program.cs               // Código principal contendo a lógica da calculadora.
├── CalculadoraSimples.csproj // Arquivo de configuração do projeto.
└── README.md                // Este arquivo.

## Detalhes do Código

- Exibição do Menu:
  O método ExibirMenu() apresenta ao usuário as opções disponíveis, como adição, subtração, multiplicação, divisão e sair.

- Operações Matemáticas:
  Cada operação (adição, subtração, multiplicação e divisão) é implementada em métodos específicos. No caso da divisão, o método OperacaoDivisao() verifica se o segundo número é zero e impede a operação, mostrando uma mensagem de erro.

- Leitura e Validação de Números:
  O método LerNumero() solicita ao usuário que insira um número e valida a entrada, garantindo que o valor digitado seja um número válido.

- Limpeza da Tela:
  Após a conclusão de cada operação, a tela do terminal é limpa usando Console.Clear(), melhorando a experiência do usuário ao remover dados anteriores da tela.

## Contribuições

Contribuições são muito bem-vindas! Se você tiver sugestões de melhorias, correções ou novas funcionalidades, sinta-se à vontade para:
- Abrir uma issue detalhando a melhoria ou problema.
- Enviar um pull request com suas alterações.

## Licença

Este projeto está licenciado sob a MIT License. Sinta-se livre para utilizar, modificar e distribuir o código conforme os termos desta licença.

## Contato

Caso tenha dúvidas, sugestões ou queira contribuir, entre em contato através do enzo.sartorelli@outlook.com ou visite meu perfil no GitHub: https://github.com/efsartorelli
