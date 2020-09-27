using System;
public class Stack
{
    private int last;
    private char[] stack;

    public Stack(int size)
    {
        last = -1;
        stack = new char[size];
    }

    public void push(char novo)
    {
        last++;
        stack[last] = novo;
        return;
    }

    public char getLast()
    {
        return stack[last];
    }

    public char pop()
    {
        char removido = stack[last];
        last--;
        return removido;
    }

    public void multipop(int n)
    {
        if (n > lenght())
        {
            Console.WriteLine("A pilha não possui " + n + " elementos!");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            pop();
        }
    }

    public int lenght()
    {
        return last + 1;
    }

    public void clear()
    {
        this.last = -1;
    }

}
