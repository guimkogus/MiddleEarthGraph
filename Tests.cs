using System;
public class Tests
{
    public void queueTest()
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Iniciando teste de FILA:");
        Console.WriteLine();

        int tamanho = 6;
        Queue queue = new Queue(tamanho);
        Console.WriteLine("Criamos a FILA com " + tamanho + " espaços");
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

        int tamanho = 6;
        Stack stack = new Stack(tamanho);
        Console.WriteLine("Criamos a PILHA com " + tamanho + " espaços");
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
}