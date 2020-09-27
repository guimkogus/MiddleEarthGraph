using System;

public class Graph
{
    private int totVertices;
    private int totEdges;
    private string[] vertices;
    private bool[,] adjacencies;

    public Graph(string[] names)
    {
        totVertices = names.Length;
        totEdges = 0;
        vertices = names;

        adjacencies = new bool[totVertices, totVertices];
    }

    public void addEdge(int x, int y)
    {
        if (isNeighbors(x, y))
            return;

        adjacencies[x, y] = true;
        adjacencies[y, x] = true;

        totEdges++;
    }

    public void addEdge(string vertex1, string vertex2)
    {
        int x = getVertexIndex(vertex1);
        int y = getVertexIndex(vertex2);

        if (isNeighbors(vertex1, vertex2))
            return;

        adjacencies[x, y] = true;
        adjacencies[y, x] = true;

        totEdges++;
    }

    public void removeEdge(int x, int y)
    {
        if (isNeighbors(x, y))
        {
            adjacencies[x, y] = false;
            adjacencies[y, x] = false;

            totEdges--;
        }
    }

    public void removeEdge(string vertex1, string vertex2)
    {
        int x = getVertexIndex(vertex1);
        int y = getVertexIndex(vertex2);

        if (isNeighbors(vertex1, vertex2))
        {
            adjacencies[x, y] = false;
            adjacencies[y, x] = false;

            totEdges--;
        }
    }

    public bool isNeighbors(string vertex1, string vertex2)
    {
        int x = getVertexIndex(vertex1);
        int y = getVertexIndex(vertex2);

        if (x < 0 || y < 0)
            return false;

        return adjacencies[x, y];
    }

    public bool isNeighbors(int x, int y)
    {
        if (x < 0 || y < 0)
            return false;

        return adjacencies[x, y];
    }

    public int getVertexIndex(string vertex)
    {
        return Array.IndexOf(vertices, vertex);
    }

    public string getVertexName(int index)
    {
        return vertices[index];
    }

    public int numberOfEdges()
    {
        return totEdges;
    }

    public int numberOfVertices()
    {
        return totVertices;
    }

    void getAdjacencies()
    {
        for (int i = 0; i < totVertices; i++)
        {
            for (int j = 0; j < totVertices; j++)
            {
                if (adjacencies[i, j])
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
            Console.WriteLine();
        }
    }

    public int getDegree(int vertex)
    {
        int numberOfNeighbors = 0;

        for (int i = 0; i < totVertices; i++)
            if (adjacencies[vertex, i])
                numberOfNeighbors++;

        return numberOfNeighbors;
    }

    public int getDegree(string vertex)
    {
        int numberOfNeighbors = 0;
        int x = getVertexIndex(vertex);

        for (int i = 0; i < totVertices; i++)
            if (adjacencies[x, i])
                numberOfNeighbors++;

        return numberOfNeighbors;
    }

    public void printNeighbors(int vertex)
    {
        Console.WriteLine("neighbors do " + vertices[vertex]);
        for (int i = 0; i < totVertices; i++)
        {
            if (isNeighbors(vertex, i))
                Console.Write(vertices[i] + " ");
        }
        Console.WriteLine();
    }

    public void printDistances(int vertex)
    {
        int[] dist = new int[totVertices];

        for (int i = 0; i < totVertices; i++)
            dist[i] = -1;

        Queue Q = new Queue(totVertices);
        dist[vertex] = 0;
        Q.push(vertex);

        while (Q.lenght() > 0)
        {
            int x = Q.pop();
            for (int y = 0; y < totVertices; y++)
            {
                if (isNeighbors(x, y) && dist[y] < 0)
                {
                    Console.WriteLine(vertices[x] + " descobriu " + vertices[y]);

                    dist[y] = dist[x] + 1;
                    Q.push(y);
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Distância de cada vértice até " + vertices[vertex]);

        for (int i = 0; i < totVertices; i++)
            Console.WriteLine(vertices[i] + " = " + dist[i]);
    }

    public void printDistances(string vertex)
    {
        int[] dist = new int[totVertices];
        int vIndex = getVertexIndex(vertex);

        for (int i = 0; i < totVertices; i++)
            dist[i] = -1;

        Queue Q = new Queue(totVertices);
        dist[vIndex] = 0;
        Q.push(vIndex);

        while (Q.lenght() > 0)
        {
            int x = Q.pop();
            for (int y = 0; y < totVertices; y++)
            {
                if (isNeighbors(x, y) && dist[y] < 0)
                {
                    Console.WriteLine(vertices[x] + " descobriu " + vertices[y]);

                    dist[y] = dist[x] + 1;
                    Q.push(y);
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Distância de cada vértice até " + vertices[vIndex]);

        for (int i = 0; i < totVertices; i++)
            Console.WriteLine(vertices[i] + " = " + dist[i]);
    }
}