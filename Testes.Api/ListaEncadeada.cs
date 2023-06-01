namespace ConsoleApp1;

public class ListaEncadeada
{
    private No? Primeiro { get; set; }

    public void InserirInicio(string value)
    {
        No novoNo = new(value, Primeiro); //Cria um novo nó
        Primeiro = novoNo; //O primeiro nó passa a ser o nó criado
    }

    public void InserirPosicao(int posicao, string value)
    {
        if (posicao == 0)
        {
            InserirInicio(value);
            return;
        }

        No? no = Primeiro;
        for (int i = 0; i <= posicao; i++)
        {
            if (i == posicao - 1)
                break;

            if (i != posicao)
                no = no.Proximo;

            if (no == null)
            {
                Console.WriteLine($"Erro ao inserir, a lista não vai até a posição {posicao}");
                return;
            }
        }

        No novoNo = new(value, no.Proximo); //O próximo passa a ser o próximo do próximo
        no.Proximo = novoNo; //O primeiro nó passa a ser o nó criado
    }

    public void MostrarValores()
    {
        if (Primeiro is null)
        {
            Console.WriteLine("Lista vazia.");
            return;
        }

        No? no = Primeiro;
        while (no != null)
        {
            no.ImprimirValor();
            no = no.Proximo;
        }
    }

    public No? Pesquisar(string valor)
    {
        if (Primeiro is null)
        {
            Console.WriteLine("Lista vazia.");
            return null;
        }

        No? no = Primeiro;
        while (no != null)
        {
            if (no.Valor.Equals(valor)) //Se for igual retorna o nó
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
        if (posicao == 0)
        {
            ExcluirInicio();
            return;
        }

        No? no = Primeiro;
        for (int i = 0; i <= posicao; i++)
        {
            if (i == posicao - 1)
                break;

            if (i != posicao)
                no = no.Proximo;

            if (no == null)
            {
                Console.WriteLine($"Erro ao excluir, a lista não vai até a posição {posicao}");
                return;
            }
        }

        no.Proximo = no.Proximo?.Proximo; //O nó passa a ser o próximo
    }

    public class No
    {
        public string Valor { get; set; }
        public No? Proximo { get; set; }

        public No(string valor, No? proximo = null)
        {
            Valor = valor;
            Proximo = proximo;
        }

        public void ImprimirValor() => Console.WriteLine(Valor);
    }
}
