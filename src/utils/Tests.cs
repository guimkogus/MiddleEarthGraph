using System;
public class Tests
{
    public void queueTest()
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Iniciando teste de FILA:");
        Console.WriteLine();

        int size = 6;
        Queue queue = new Queue(size);
        Console.WriteLine("Criamos a FILA com " + size + " espaços");
        queue.push(16);
        Console.WriteLine("Inserimos o elemento " + queue.getLast());
        queue.push(35);
        Console.WriteLine("Inserimos o elemento " + queue.getLast());
        queue.push(28);
        Console.WriteLine("Inserimos o elemento " + queue.getLast());
        queue.push(24);
        Console.WriteLine("Inserimos o elemento " + queue.getLast());
        queue.push(43);
        Console.WriteLine("Inserimos o elemento " + queue.getLast());

        Console.WriteLine("O primeiro elemento é o '" + queue.getFirst() + "'");
        Console.WriteLine("Tamanho atual da fila: " + queue.lenght());
        Console.WriteLine("O elemento '" + queue.pop() + "' foi removido.");
        Console.WriteLine("O elemento '" + queue.pop() + "' foi removido.");
        Console.WriteLine("Agora o primeiro elemento é o '" + queue.getFirst() + "'");
        Console.WriteLine("Tamanho atual da fila: " + queue.lenght());

        Console.WriteLine();
        queue.push(96);
        Console.WriteLine("Inserimos o elemento " + queue.getLast());
        queue.push(99);
        Console.WriteLine("Inserimos o elemento " + queue.getLast());
        Console.WriteLine("Ao todo se passaram " + queue.getTotalHistory() + " elementos na FILA.");

        Console.WriteLine();
        Console.WriteLine("Fim do teste");
        Console.WriteLine("-------------------");
        Console.WriteLine();
    }

    public void stackTest()
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Iniciando teste de PILHA:");
        Console.WriteLine();

        int size = 6;
        Stack stack = new Stack(size);
        Console.WriteLine("Criamos a PILHA com " + size + " espaços");
        stack.push('A');
        Console.WriteLine("Inserimos o elemento '" + stack.getLast() + "'");
        stack.push('B');
        Console.WriteLine("Inserimos o elemento '" + stack.getLast() + "'");
        stack.push('C');
        Console.WriteLine("Inserimos o elemento '" + stack.getLast() + "'");
        stack.push('D');
        Console.WriteLine("Inserimos o elemento '" + stack.getLast() + "'");
        stack.push('E');
        Console.WriteLine("Inserimos o elemento '" + stack.getLast() + "'");

        Console.WriteLine("O elemento no topo é o '" + stack.getLast() + "'");
        Console.WriteLine("Tamanho atual da pilha: " + stack.lenght());
        Console.WriteLine("O elemento '" + stack.pop() + "' foi removido.");
        Console.WriteLine("Agora o elemento no topo é o '" + stack.getLast() + "'");
        Console.WriteLine("Tamanho atual da pilha: " + stack.lenght());

        Console.WriteLine();
        int n = 3;
        Console.WriteLine("Executando multipop para os últimos " + n + " elementos...");
        stack.multipop(n);
        Console.WriteLine("Agora o elemento no topo é o '" + stack.getLast() + "'");
        Console.WriteLine("Tamanho atual da pilha: " + stack.lenght());

        Console.WriteLine();
        Console.WriteLine("Fim do teste");
        Console.WriteLine("-------------------");
        Console.WriteLine();
    }

    public void graphTest()
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Iniciando teste de GRAFO:");
        Console.WriteLine();

        string[] locations = new string[] {
            "Embu",
            "Capão Redondo",
            "Campo Limpo",
            "Vila das Belezas",
            "Giovanni Groncchi",
            "Santo Amaro",
            "Socorro",
            "Jurubatuba"
        };

        Graph graph = new Graph(locations);
        Console.WriteLine("Criamos o GRAFO com " + locations.Length + " vertices");

        graph.addEdge("Embu", "Capão Redondo");
        graph.addEdge("Capão Redondo", "Campo Limpo");
        graph.addEdge("Campo Limpo", "Vila das Belezas");
        graph.addEdge("Vila das Belezas", "Giovanni Groncchi");
        graph.addEdge("Giovanni Groncchi", "Santo Amaro");
        graph.addEdge("Santo Amaro", "Socorro");
        graph.addEdge("Socorro", "Jurubatuba");

        graph.BreadthFirstSearch("Santo Amaro", "Embu");
        Console.WriteLine();
        Console.WriteLine("Capão Redondo possui " + graph.getDegree("Capão Redondo") + " vizinhos");

        Console.WriteLine();
        Console.WriteLine("Fim do teste");
        Console.WriteLine("-------------------");
        Console.WriteLine();
    }
}