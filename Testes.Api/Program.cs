namespace ConsoleApp1;

public class MainClass
{
    public static void Main(string[] args)
    {
        TestListaEncadeada();
// João
// Andres
// Thomas

// Carlos
// João
// Renan
// Andres
// Thomas

// Erro ao inserir, a lista não vai até a posição 6

// João

// Não foi encontrado o valor na lista.

// João
// Renan
// Andres
// Thomas

// João
// Andres
// Thomas
   
        TestListaDuplamenteEncadeada();
// MOSTRAR VALORES
// João
// Andres
// Thomas
// MOSTRAR VALORES
// Carlos
// João
// Renan
// Andres
// Thomas
// INSERIR NO FIM, SEM POSIÇÃO
// Erro ao inserir, a lista não vai até a posição 6
// IMPRIMIR VALOR
// João
// IMPRIMIR VALOR
// EXCLUIR INICIO
// MOSTRAR VALORES
// João
// Renan
// Andres
// Thomas
// EXCLUIR POSIÇÃO
// MOSTRAR VALORES
// João
// Andres
// Thomas
// DESCENDENTE
// Thomas
// Andres
// João
// DESCENDENTE COM MAIS VALORES
// Thomas
// Andres
// João
// Bernardo
// Fernanda
// Ana
// Maria
// Erro ao excluir, a lista não vai até a posição 6
// DESCENDENTE COM MAIS VALORES E EXCLUSÃO
// Thomas
// João
// Bernardo
// Fernanda
// Ana
// Maria
// ASCENDENTE COM MAIS VALORES E EXCLUSÃO
// Maria
// Ana
// Fernanda
// Bernardo
// João
// Thomas
// ASCENDENTE COM MAIS VALORES E EXCLUSÃO
// Fernanda
// Bernardo
// João
// Thomas
    }

    private static void TestListaDuplamenteEncadeada()
    {
        ListaDuplamenteEncadeada lista = new();
        //Adiciona 3 valores na lista
        lista.InserirInicio("Thomas");
        lista.InserirInicio("Andres");
        lista.InserirInicio("João");
        Console.WriteLine("MOSTRAR VALORES");
        lista.MostrarValores(); //Vai imprimir a lista

        //Adiciona 1 valor no inicio, 1 no meio e 1 não tem como adicionar pois não existe esta posição
        lista.InserirPosicao(0, "Carlos");
        lista.InserirPosicao(2, "Renan");
        Console.WriteLine("MOSTRAR VALORES");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine("INSERIR NO FIM, SEM POSIÇÃO");
        lista.InserirPosicao(6, "Maria");

        var pesquisaUm = lista.Pesquisar("João");
        Console.WriteLine("IMPRIMIR VALOR");
        pesquisaUm?.ImprimirValor(); //Vai imprimir o nome

        var pesquisaDois = lista.Pesquisar("Marcos");
        Console.WriteLine("IMPRIMIR VALOR");
        pesquisaDois?.ImprimirValor(); //Não vai imprimir pois não existe

        Console.WriteLine("EXCLUIR INICIO");
        lista.ExcluirInicio();
        Console.WriteLine("MOSTRAR VALORES");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine("EXCLUIR POSIÇÃO");
        lista.ExcluirPosicao(1);
        Console.WriteLine("MOSTRAR VALORES");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine("DESCENDENTE");
        lista.MostrarValores("desc"); //Vai imprimir a lista em ordem decrescente

        Console.WriteLine("DESCENDENTE COM MAIS VALORES");
        lista.InserirInicio("Bernardo");
        lista.InserirInicio("Fernanda");
        lista.InserirInicio("Ana");
        lista.InserirInicio("Maria");

        lista.MostrarValores("desc"); //Vai imprimir a lista em ordem decrescente

        lista.ExcluirPosicao(6);
        lista.ExcluirPosicao(5);

        Console.WriteLine("DESCENDENTE COM MAIS VALORES E EXCLUSÃO");
        lista.MostrarValores("desc"); //Vai imprimir a lista em ordem decrescente

        Console.WriteLine("ASCENDENTE COM MAIS VALORES E EXCLUSÃO");
        lista.MostrarValores(); //Vai imprimir a lista em ordem crescente

        Console.WriteLine("ASCENDENTE COM MAIS VALORES E EXCLUSÃO");
        lista.ExcluirInicio();
        lista.ExcluirInicio();
        lista.MostrarValores(); //Vai imprimir a lista em ordem crescente5
    }

    private static void TestListaEncadeada()
    {
        ListaEncadeada lista = new();
        //Adiciona 3 valores na lista
        lista.InserirInicio("Thomas");
        lista.InserirInicio("Andres");
        lista.InserirInicio("João");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine();

        //Adiciona 1 valor no inicio, 1 no meio e 1 não tem como adicionar pois não existe esta posição
        lista.InserirPosicao(0, "Carlos");
        lista.InserirPosicao(2, "Renan");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine();

        lista.InserirPosicao(6, "Maria");

        Console.WriteLine();

        var pesquisaUm = lista.Pesquisar("João");
        pesquisaUm?.ImprimirValor(); //Vai imprimir o nome

        Console.WriteLine();

        var pesquisaDois = lista.Pesquisar("Marcos");
        pesquisaDois?.ImprimirValor(); //Não vai imprimir pois não existe

        Console.WriteLine();

        lista.ExcluirInicio();
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine();

        lista.ExcluirPosicao(1);
        lista.MostrarValores(); //Vai imprimir a lista
    }
}
