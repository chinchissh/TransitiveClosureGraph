using System;

namespace TransitiveClosureGraph
{
    public class Program // Графы, транзитивное замыкание
    {
        public static void Main()
        {
            int[,] adjacencyMatrix = {
            { 0, 3, 0, 2, 0, 0, 0, 0 },
            { 0, 0, 5, 0, 4, 0, 0, 0 },
            { 0, 5, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 6 },
            { 0, 0, 0, 0, 0, 0, 0, 7 },
            { 0, 0, 0, 0, 0, 0, 3, 0 },
            { 0, 0, 0, 0, 0, 3, 0, 2 },
            { 0, 0, 0, 0, 0, 0, 0, 0 }
        };

            TransitiveClosure transitiveClosure = new TransitiveClosure(adjacencyMatrix);
            int[,] closure = transitiveClosure.GetTransitiveClosure();

            Console.WriteLine("Транзитивное замыкание графа:");
            for (int i = 0; i < closure.GetLength(0); i++)
            {
                for (int j = 0; j < closure.GetLength(1); j++)
                {
                    Console.Write(closure[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
