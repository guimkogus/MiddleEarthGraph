using System;
public class Queue
{
    private int[] queue;
    private int first;
    private int last;
    private int actualLenght;
    private int totalHistory;

    public Queue(int size)
    {
        queue = new int[size];
        first = 0;
        last = -1;
        actualLenght = 0;
        totalHistory = 0;
    }

    public void push(int data)
    {
        if (actualLenght == queue.Length)
        {
            Console.WriteLine("Tentando inserir em fila lotada.");
            return;
        }

        totalHistory++;
        actualLenght++;
        last = (last + 1) % queue.Length;
        queue[last] = data;
    }

    public int pop()
    {
        int removed = this.getFirst();
        first = (first + 1) % queue.Length;
        actualLenght--;

        return removed;
    }

    public int getFirst()
    {
        if (actualLenght == 0)
        {
            Console.WriteLine("Tentando acessar inicio de fila vazia.");
            return -1;
        }

        return queue[first];
    }

    public int getLast()
    {
        if (actualLenght == 0)
            Console.WriteLine("Tentando acessar fim de fila vazia.");

        return queue[last];
    }

    public int lenght()
    {
        return actualLenght;
    }

    public int getTotalHistory()
    {
        return totalHistory;
    }
}
