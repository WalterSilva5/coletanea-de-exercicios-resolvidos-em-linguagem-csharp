#Exercicios resolvidos em c#

[coletânea de exercícios resolvidos em C#](https://oprofessorleandro.wordpress.com/wp-content/uploads/2010/03/coletanea-de-exercicios-resolvidos-em-liguagem-c.pdf)


## como executar scripts C# no Linux

Como executar scripts C# no Linux utilizando o Mono e como fazer build com o `csc`.

## Pré-requisitos

1. **Instalar o Mono**:
    ```bash
    sudo apt update
    sudo apt install mono-complete
    ```

2. **Verificar a instalação**:
    ```bash
    mono --version
    ```

## Executando Scripts C#

1. **Criar um script C#**:
    Crie um arquivo com a extensão `.cs`, por exemplo, `hello.cs`:
    ```csharp
    using System;

    class Program
    {
         static void Main()
         {
              Console.WriteLine("Hello, World!");
         }
    }
    ```

2. **Executar o script**:
    Utilize o comando `mono` para executar o script:
    ```bash
    mono hello.exe
    ```

## Fazendo Build com `csc`

1. **Compilar o script**:
    Utilize o compilador `csc` para compilar o script:
    ```bash
    csc hello.cs
    ```

2. **Executar o executável**:
    Após a compilação, um arquivo `hello.exe` será gerado. Execute-o com o Mono:
    ```bash
    mono hello.exe
    ```

## Conclusão

Seguindo estes passos, você poderá executar scripts C# no Linux utilizando o Mono e fazer build com o `csc`. Para mais informações, consulte a [documentação oficial do Mono](https://www.mono-project.com/docs/).
