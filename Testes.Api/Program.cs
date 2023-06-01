namespace ConsoleApp1;

public class MainClass
{
    public static void Main(string[] args)
    {
        // O restaurante recebe vários pedidos ao longo do dia. À medida que os pedidos são registrados no sistema,
        // você usa a lista encadeada para armazenar essas informações. Posteriormente,
        // você precisa exibir os pedidos na ordem em que foram recebidos,
        // para que a equipe de preparação possa trabalhar neles sequencialmente.

        // TestListaEncadeadaPedidos();
        // INSERE 3 PEDIDOS
        // MOSTRAR PEDIDOS
        // Nome: João, Quantidade: 3, Valor: 30
        // Nome: Andres, Quantidade: 6, Valor: 20
        // Nome: Thomas, Quantidade: 9, Valor: 10
        // INSERIR MAIS 2 PEDIDOS
        // MOSTRAR VALORES
        // Nome: Carlos, Quantidade: 1, Valor: 40
        // Nome: João, Quantidade: 3, Valor: 30
        // Nome: Renan, Quantidade: 2, Valor: 50
        // Nome: Andres, Quantidade: 6, Valor: 20
        // Nome: Thomas, Quantidade: 9, Valor: 10
        // INSERIR NO FIM DA FILA, SEM PRECISAR POSIÇÃO
        // Erro ao inserir, a lista não vai até a posição 6
        // PROCURA O PEDIDO DO JOÃO
        // IMPRIMIR VALOR
        // Nome: João, Quantidade: 3, Valor: 30
        // PROCURA O PEDIDO DO MARCOS
        // Não foi encontrado o valor na lista.
        // IMPRIMIR VALOR
        // MOSTRA OS PEDIDOS DO DIA
        // Nome: Carlos, Quantidade: 1, Valor: 40
        // Nome: João, Quantidade: 3, Valor: 30
        // Nome: Renan, Quantidade: 2, Valor: 50
        // Nome: Andres, Quantidade: 6, Valor: 20
        // Nome: Thomas, Quantidade: 9, Valor: 10
        // ENTREGA O PRIMEIRO PEDIDO DA FILA
        // MOSTRAR VALORES
        // Nome: João, Quantidade: 3, Valor: 30
        // Nome: Renan, Quantidade: 2, Valor: 50
        // Nome: Andres, Quantidade: 6, Valor: 20
        // Nome: Thomas, Quantidade: 9, Valor: 10
        // ENTREGA O ULTIMO PEDIDO DA FILA
        // MOSTRAR VALORES
        // Nome: João, Quantidade: 3, Valor: 30
        // Nome: Renan, Quantidade: 2, Valor: 50
        // Nome: Andres, Quantidade: 6, Valor: 20



        // Um usuário adicionou várias músicas à playlist e agora deseja reproduzi-las em ordem decrescente,
        // ou seja, da música que ele adicionou por último até a primeira.
        // Além disso, o usuário também quer ter a opção de voltar para a música anterior durante a reprodução.

        TestListaDuplamenteEncadeada();
        // INSERE 3 MÚSICAS
        // MOSTRAR MÚSICAS
        // Nome: Musica 3, Duração: 3
        // Nome: Musica 2, Duração: 2
        // Nome: Musica 1, Duração: 1
        // INSERIR MAIS 2 MÚSICAS
        // MOSTRAR VALORES
        // Nome: Musica 4, Duração: 4
        // Nome: Musica 3, Duração: 3
        // Nome: Musica 5, Duração: 5
        // Nome: Musica 2, Duração: 2
        // Nome: Musica 1, Duração: 1
        // INSERIR NO FIM DA FILA, SEM PRECISAR POSIÇÃO
        // Erro ao inserir, a lista não vai até a posição 6
        // PROCURA A MÚSICA 3
        // IMPRIMIR VALOR
        // Nome: Musica 3, Duração: 3
        // PROCURA A MÚSICA 7
        // IMPRIMIR VALOR
        // MOSTRA AS MÚSICAS DA PLAYLIST
        // Nome: Musica 4, Duração: 4
        // Nome: Musica 3, Duração: 3
        // Nome: Musica 5, Duração: 5
        // Nome: Musica 2, Duração: 2
        // Nome: Musica 1, Duração: 1
        // MOSTRA AS MÚSICAS DA PLAYLIST EM ORDEM INVERSA
        // Nome: Musica 1, Duração: 1
        // Nome: Musica 2, Duração: 2
        // Nome: Musica 3, Duração: 3
        // Nome: Musica 4, Duração: 4
        // VOLTA PARA A MÚSICA ANTERIOR
    }

    private static void TestListaDuplamenteEncadeada()
    {
        ListaDuplamenteEncadeada lista = new();
        Console.WriteLine("INSERE 3 MÚSICAS");
        lista.InserirInicio(new Musica("Musica 1", 1));
        lista.InserirInicio(new Musica("Musica 2", 2));
        lista.InserirInicio(new Musica("Musica 3", 3));

        Console.WriteLine("MOSTRAR MÚSICAS");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine("INSERIR MAIS 2 MÚSICAS");
        //Adiciona 1 Música no inicio, 1 no meio e 1 não tem como adicionar pois não existe esta posição
        lista.InserirPosicao(0, new Musica("Musica 4", 4));
        lista.InserirPosicao(2, new Musica("Musica 5", 5));

        Console.WriteLine("MOSTRAR VALORES");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine("INSERIR NO FIM DA FILA, SEM PRECISAR POSIÇÃO");
        lista.InserirPosicao(6, new Musica("Musica 6", 6));

        Console.WriteLine("PROCURA A MÚSICA 3");
        var pesquisaUm = lista.Pesquisar("Musica 3");
        Console.WriteLine("IMPRIMIR VALOR");
        pesquisaUm?.ImprimirValor(); //Vai imprimir o nome

        Console.WriteLine("PROCURA A MÚSICA 7");
        var pesquisaDois = lista.Pesquisar("Musica 7");
        Console.WriteLine("IMPRIMIR VALOR");
        pesquisaDois?.ImprimirValor(); //Vai imprimir o nome

        Console.WriteLine("MOSTRA AS MÚSICAS DA PLAYLIST");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine("MOSTRA AS MÚSICAS DA PLAYLIST EM ORDEM INVERSA");
        lista.MostrarValores("desc");

        Console.WriteLine("VOLTA PARA A MÚSICA ANTERIOR");
        lista.VoltarMusica();

        Console.WriteLine("MOSTRA AS MÚSICAS DA PLAYLIST");
    }

    private static void TestListaEncadeadaPedidos()
    {
        ListaEncadeada lista = new();
        Console.WriteLine("INSERE 3 PEDIDOS");
        lista.InserirInicio(new Pedido("Thomas", 9, 10));
        lista.InserirInicio(new Pedido("Andres", 6, 20));
        lista.InserirInicio(new Pedido("João", 3, 30));

        Console.WriteLine("MOSTRAR PEDIDOS");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine("INSERIR MAIS 2 PEDIDOS");
        //Adiciona 1 Pedido no inicio, 1 no meio e 1 não tem como adicionar pois não existe esta posição
        lista.InserirPosicao(0, new Pedido("Carlos", 1, 40));
        lista.InserirPosicao(2, new Pedido("Renan", 2, 50));

        Console.WriteLine("MOSTRAR VALORES");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine("INSERIR NO FIM DA FILA, SEM PRECISAR POSIÇÃO");
        lista.InserirPosicao(6, new Pedido("Maria", 4, 60));

        Console.WriteLine("PROCURA O PEDIDO DO JOÃO");
        var pesquisaUm = lista.Pesquisar("João");
        Console.WriteLine("IMPRIMIR VALOR");
        pesquisaUm?.ImprimirValor(); //Vai imprimir o nome

        Console.WriteLine("PROCURA O PEDIDO DO MARCOS");
        var pesquisaDois = lista.Pesquisar("Marcos");
        Console.WriteLine("IMPRIMIR VALOR");
        pesquisaDois?.ImprimirValor(); //Não vai imprimir pois não existe

        Console.WriteLine("MOSTRA OS PEDIDOS DO DIA");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine("ENTREGA O PRIMEIRO PEDIDO DA FILA");
        lista.ExcluirInicio();
        Console.WriteLine("MOSTRAR VALORES");
        lista.MostrarValores(); //Vai imprimir a lista

        Console.WriteLine("ENTREGA O ULTIMO PEDIDO DA FILA");
        lista.ExcluirPosicao(-1);

        Console.WriteLine("MOSTRAR VALORES");
        lista.MostrarValores(); //Vai imprimir a lista
    }
}
