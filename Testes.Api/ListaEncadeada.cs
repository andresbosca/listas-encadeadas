namespace ConsoleApp1;

public class ListaEncadeada
{
    private No<Pedido>? Primeiro { get; set; }

    public void InserirInicio(Pedido value)
    {
        No<Pedido> novoNo = new(value, Primeiro); //Cria um novo nó
        Primeiro = novoNo; //O primeiro nó passa a ser o nó criado
    }

    public void InserirPosicao(int posicao, Pedido value)
    {
        if (posicao == 0)
        {
            InserirInicio(value);
            return;
        }

        No<Pedido>? no = Primeiro;
        for (int i = 0; i <= posicao; i++)
        {
            if (i == posicao - 1)
                break;

            if (i != posicao)
                no = no?.Proximo;

            if (no == null)
            {
                Console.WriteLine($"Erro ao inserir, a lista não vai até a posição {posicao}");
                return;
            }
        }

        No<Pedido> novoNo = new(value, no?.Proximo); //O próximo passa a ser o próximo do próximo

        if (no is null)
        {
            Console.WriteLine($"Erro ao inserir, a lista não vai até a posição {posicao}");
            return;
        }
        no.Proximo = novoNo; //O primeiro nó passa a ser o nó criado
    }

    public void MostrarValores()
    {
        if (Primeiro is null)
        {
            Console.WriteLine("Lista vazia.");
            return;
        }

        No<Pedido>? no = Primeiro;
        while (no != null)
        {
            no.ImprimirValor();
            no = no.Proximo;
        }
    }

    public No<Pedido>? Pesquisar(string nome)
    {
        if (Primeiro is null)
        {
            Console.WriteLine("Lista vazia.");
            return null;
        }

        No<Pedido>? no = Primeiro;
        while (no != null)
        {
            if (no.Valor.Nome.Equals(nome)) //Se for igual retorna o nó
                return no;

            no = no.Proximo;
        }

        Console.WriteLine("Não foi encontrado o valor na lista.");
        return null;
    }

    public void ExcluirInicio()
    {
        if (Primeiro is null)
        {
            Console.WriteLine("A lista está vazia");
            return;
        }

        Primeiro = Primeiro.Proximo; //O primeiro nó passa a ser o segundo nó
    }

    public void ExcluirPosicao(int posicao)
    {
        if (posicao < 0)
        {
            ExcluirFim();
            return;
        }
        if (posicao == 0)
        {
            ExcluirInicio();
            return;
        }

        No<Pedido>? no = Primeiro;
        for (int i = 0; i <= posicao; i++)
        {
            if (i == posicao - 1)
                break;

            if (i != posicao)
                no = no?.Proximo;

            if (no == null)
            {
                Console.WriteLine($"Erro ao excluir, a lista não vai até a posição {posicao}");
                return;
            }
        }

        if (no is null || no.Proximo is null)
        {
            Console.WriteLine($"Erro ao excluir, a lista não vai até a posição {posicao}");
            return;
        }

        no.Proximo = no.Proximo?.Proximo; //O nó passa a ser o próximo
    }

    public void ExcluirFim()
    {
        if (Primeiro is null)
        {
            Console.WriteLine("A lista está vazia");
            return;
        }

        No<Pedido>? no = Primeiro;
        while (no != null)
        {
            if (no.Proximo?.Proximo is null) //Se o próximo do próximo for nulo, o próximo é o último
            {
                no.Proximo = null;
                return;
            }

            no = no.Proximo;
        }
    }

    public class No<T>
    {
        public T Valor { get; set; }
        public No<T>? Proximo { get; set; }

        public No(T valor, No<T>? proximo = null)
        {
            Valor = valor;
            Proximo = proximo;
        }

        public void ImprimirValor() => Console.WriteLine(Valor?.ToString());
    }
}

public class Pedido
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }

    public Pedido(string nome, int quantidade, decimal valor)
    {
        Nome = nome;
        Quantidade = quantidade;
        Valor = valor;
    }

    public override string ToString() => $"Nome: {Nome}, Quantidade: {Quantidade}, Valor: {Valor}";
}
