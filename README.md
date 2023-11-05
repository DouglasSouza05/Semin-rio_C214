[![build](https://github.com/DouglasSouza05/Seminario_C214/actions/workflows/workflow.yml/badge.svg)](https://github.com/DouglasSouza05/Seminario_C214/actions/workflows/workflow.yml)

# Seminário_C214

Seminário da Matéria de Engenharia de Software

Neste seminário será apresentado o MSTest, uma ferramenta de testes unitários desenvolvida pela Microsoft e fornecida com o Visual Studio. Antes de começar a falar sobre a ferramenta vamos fazer as instalações.

## Instalar VScode
 
1. Para abrir a página de download do VScode, acesse a seguinte URL:
https://code.visualstudio.com/

2. Escolher o seu sistema operacional e clique em download.

3. Execute o arquivo do instalador do Visual Studio Code.

4. Selecione Aceito o contrato de licença e continue seguindo as instruções para concluir a instalação.

## Instalar o SDK do .NET


1. Para abrir a página de download do SDK do .NET, acesse a seguinte URL:
https://dotnet.microsoft.com/download

2. Na página Baixar o .NET , selecione a versão recomendada do SDK do .NET.

3. Execute o arquivo do instalador do SDK do .NET.

4. Na janela do instalador do SDK do .NET, selecione Instalar.

5. Aguarde a conclusão da instalação.

6. Para verificar se a instalação deu certo abra um aplicativo que exiba um prompt de comando do terminal.

7. No prompt de comando, digite: dotnet --version e pressione a tecla Enter.

8. Verifique se um número de versão do .NET 7 está listado.

## Instalar extensão C# no VScode

1. Verifique se o Visual Studio Code está aberto.

2. Na barra Atividade, selecione Extensões.

3. Na caixa de texto Procurar extensões no Marketplace, insira C#

4. Na lista filtrada de extensões disponíveis, selecione a extensão rotulada "Kit de desenvolvimento em C# – extensão oficial de C# da Microsoft" publicada pela Microsoft.

5. Para instalar a extensão, selecione Instalar.

6. Observe que a instalação do Kit de desenvolvimento em C# instala as seguintes extensões:

    Kit de Desenvolvimento em C# – extensão oficial de C# da Microsoft.
    C# – suporte à linguagem base para C#.
    IntelliCode para C# – desenvolvimento assistido por IA para Kit de desenvolvimento em C#.
    Ferramenta de instalação do .NET para autores de extensão.

# Criando o projeto

1. No prompt de comando, digite: dotnet new console -o ./CsharpProjects/TestProject e pressione a tecla Enter.
    - O driver: dotnet neste exemplo.
    - O comando: new console neste exemplo.
    - Os argumentos de comando: -o ./CsharpProjects/TestProject neste exemplo.

Observação

Os argumentos de comando são parâmetros opcionais que podem ser usados para fornecer mais informações. O comando anterior pôde ser executado sem especificar o local de pasta opcional. Por exemplo: dotnet new console. Neste caso, o novo aplicativo de console seria criado no local da pasta atual.

## Adionando a dependência do MSTest

1. No prompt de comando, digite: dotnet add package MSTest.TestFramework --version 3.1.1 e pressione a tecla Enter.
    
    O pacote deve aparecer no arquivo .csproj da seguinte forma:
```
    <ItemGroup>
      <PackageReference Include="MSTest.TestFramework" Version="3.1.1" />
    </ItemGroup>
```
