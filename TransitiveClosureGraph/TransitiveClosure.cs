using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitiveClosureGraph
{
    public class TransitiveClosure
    {
        private int[,] closure;
        private int verticesCount;

        public TransitiveClosure(int[,] adjacencyMatrix)
        {
            verticesCount = adjacencyMatrix.GetLength(0);
            closure = new int[verticesCount, verticesCount];

            // Инициализация транзитивного замыкания исходной матрицей смежности
            Array.Copy(adjacencyMatrix, closure, verticesCount * verticesCount);
        }

        public int[,] GetTransitiveClosure()
        {
            for (int k = 0; k < verticesCount; k++)
            {
                for (int i = 0; i < verticesCount; i++)
                {
                    for (int j = 0; j < verticesCount; j++)
                    {
                        closure[i, j] = @closure[i, j] !=
                            0 || (closure[i, k] != 0 && closure
                            [k, j] != 0) ? 1 : 0;
                    }
                }
            }

            return closure;
        }
    }
}
