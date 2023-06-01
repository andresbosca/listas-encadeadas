namespace ConsoleApp1;

public class ListaDuplamenteEncadeada
{
    private NoDuplo<string>? Primeiro { get; set; }

    public void InserirInicio(string value)
    {
        NoDuplo<string> novoNo = new(value, Primeiro); //Cria um novo nó
        if (Primeiro != null)
            Primeiro.Anterior = novoNo; //O anterior do primeiro nó passa a ser o nó criado

        Primeiro = novoNo; //O primeiro nó passa a ser o nó criado
    }

    public void InserirPosicao(int posicao, string value)
    {
        if (posicao == 0)
        {
            InserirInicio(value);
            return;
        }

        NoDuplo<string>? no = Primeiro;
        for (int i = 0; i <= posicao; i++)
        {
            if (i == posicao - 1)
                break;

            if (i != posicao)
                no = no!.Proximo;

            if (no == null)
            {
                Console.WriteLine($"Erro ao inserir, a lista não vai até a posição {posicao}");
                return;
            }
        }

        NoDuplo<string> novoNo = new(value, no?.Proximo, no); //O próximo passa a ser o próximo do próximo
        no!.Proximo = novoNo; //O primeiro nó passa a ser o nó criado
    }

    public void MostrarValores(string ordem = "asc")
    {
        if (Primeiro is null)
        {
            Console.WriteLine("Lista vazia");
            return;
        }

        bool asc = ordem == "asc";

        if (asc)
        {
            NoDuplo<string>? no = Primeiro;
            while (no != null)
            {
                Console.WriteLine(no.Valor);
                no = no.Proximo;
            }
        }
        else
        {
            NoDuplo<string>? no = Primeiro;
            while (no?.Proximo != null)
                no = no.Proximo;

            while (no != null)
            {
                Console.WriteLine(no.Valor);
                no = no.Anterior;
            }
        }
    }

    public NoDuplo<string>? Pesquisar(string value)
    {
        NoDuplo<string>? no = Primeiro;
        while (no != null)
        {
            if (no.Valor == value)
                return no;

            no = no.Proximo;
        }

        return null;
    }

    public void ExcluirInicio()
    {
        if (Primeiro is null)
        {
            Console.WriteLine("Lista vazia");
            return;
        }

        Primeiro = Primeiro.Proximo;
        Primeiro!.Anterior = null;
    }

    public void ExcluirPosicao(int posicao)
    {
        if (posicao == 0)
        {
            ExcluirInicio();
            return;
        }

        NoDuplo<string>? no = Primeiro;
        for (int i = 0; i <= posicao; i++)
        {
            if (i == posicao - 1)
                break;

            if (i != posicao)
                no = no!.Proximo;

            if (no == null)
            {
                Console.WriteLine($"Erro ao excluir, a lista não vai até a posição {posicao}");
                return;
            }
        }

        if (no is null || no.Proximo is null || no.Proximo.Proximo is null)
        {
            Console.WriteLine($"Erro ao excluir, a lista não vai até a posição {posicao}");
            return;
        }

        no.Proximo = no.Proximo?.Proximo;
        no.Proximo!.Anterior = no;
    }

    public class NoDuplo<T>
    {
        public T Valor { get; set; }
        public NoDuplo<T>? Proximo { get; set; }
        public NoDuplo<T>? Anterior { get; set; }

        public NoDuplo(T valor, NoDuplo<T>? proximo = null, NoDuplo<T>? anterior = null)
        {
            Valor = valor;
            Proximo = proximo;
            Anterior = anterior;
        }

        public void ImprimirValor() => Console.WriteLine(Valor);
    }
}
