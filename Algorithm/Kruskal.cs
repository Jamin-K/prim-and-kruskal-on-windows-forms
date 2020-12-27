using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Kruskal
    {
       
        static int n = 7;
        int[] parents = new int[n];
        int weight_min = 0;
        public int[,] graphs = new int[n, n];
        static int INF = int.MaxValue;
        public Queue<Node> semiq = new Queue<Node>();
        public Queue<Node> resultq = new Queue<Node>();

        /*int [,] graphs = {{INF, 29, INF, INF, INF, 10, INF},
         {29, INF, 16, INF, INF, INF, 15},
         {INF, 16, INF, 12, INF, INF, INF},
         {INF, INF, 12, INF, 22, INF, 18},
         {INF, INF, INF, 22, INF, 27, 25},
         {10, INF, INF, INF, 27, INF, INF},
         {INF, 15, INF, 18, 25, INF, INF}
         };*/

        public Kruskal()
        {
            for(int i =0; i<graphs.GetLength(0); i++)
            {
                for(int j=0; j<graphs.GetLength(1); j++)
                {
                    graphs[i, j] = INF;
                }
            }
        }

        public void setGraphs(int i, int j, int weight)
        {
            this.graphs[i, j] = weight;
            this.graphs[j, i] = weight;
        }

        public Queue<Node> getsetmiq()
        {
            return this.semiq;
        }
        public Queue<Node> getresultq()
        {
            return this.resultq;
        }


        public int find(int i)
        {
            while (parents[i] != i)
                i = parents[i];
            return i;
        }
        public int getWeight_min()
        {
            return this.weight_min;
        }

        public void union(int i, int j)
        {
            int a = find(i);
            int b = find(j);
            parents[a] = b;
        }

        public void kru()
        {
            int value = 0;
            for(int i = 0; i<n; i++)
            {
                parents[i] = i;
            }

            int count = 0;
            while(count < n - 1)
            {
                int min = INF;
                int a = -1;
                int b = -1;
                for(int i = 0; i<n; i++){
                    for(int j=0; j<n; j++)
                    {
                        if(find(i) != find(j) && graphs[i,j] < min)
                        {
                            min = graphs[i, j];
                            a = i;
                            b = j;
                        }
                    }
                }

                union(a, b);
                value = value + min;
                Node node = new Node(a, b, value);
                semiq.Enqueue(node);
                resultq.Enqueue(node);
                /*Console.WriteLine("------------");
                Console.WriteLine("count: " + count);
                Console.WriteLine("a : "+ a);
                Console.WriteLine("b : "+ b);
                Console.WriteLine("------------");*/
                count++;

            }
            //Console.WriteLine("Kruskal 결과 = ");
            //Console.WriteLine(value);
            this.weight_min = value;
        }
    }
}
