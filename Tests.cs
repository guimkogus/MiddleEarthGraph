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
}