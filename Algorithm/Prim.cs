using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Prim
    {
        public Queue<int> q = new Queue<int>();//노드의 추적을 저장
        public Queue<int> q1 = new Queue<int>();
        public Queue<Node> semiq = new Queue<Node>();
        public Queue<Node> resultq = new Queue<Node>();
        static int n = 7;
        int[,] graphs = new int[n, n];


        /*int[,] graphs = {{0, 29, 0, 0, 0, 10, 0},
         {29, 0, 16, 0, 0, 0, 15},
         {0, 16, 0, 12, 0, 0, 0},
         {0, 0, 12, 0, 22, 0, 18},
         {0, 0, 0, 22, 0, 27, 25},
         {10, 0, 0, 0, 27, 0, 0},
         {0, 15, 0, 18, 25, 0, 0}
         };*/

        int[] connected = new int[n];
        int weight_min;

        public Prim()
        {
            for (int i = 0; i < graphs.GetLength(0); i++)
            {
                for (int j = 0; j < graphs.GetLength(1); j++)
                    graphs[i, j] = 0;
            }
            connected[0] = 1;
        }

        public Queue<int> getQ()
        {
            return this.q;
        }
        public Queue<int> getQ1()
        {
            return this.q1;
        }

        public Queue<Node> getsemiq()
        {
            return this.semiq;
        }
        public Queue<Node> getresultq()
        {
            return this.resultq;
        }

        public void setGraphs(int i, int j, int data)
        {
            this.graphs[i, j] = data;
            this.graphs[j, i] = data;
        }
        public int[,] getGraphs()
        {
            return this.graphs;
        }
        public int getWeight_min()
        {
            return this.weight_min;
        }

        public void call_prim()
        {
            weight_min = prim(this.graphs, this.connected, 0, 1);
        }

        public int prim(int[,] graphs2, int[] connected2, int value, int count)
        {
            if (count == connected2.GetLength(0))
            {
                return value;
            }
                

            int to = -1;
            int min = int.MaxValue;
            for (int i = 0; i < connected2.GetLength(0); i++)
            {
                if (connected2[i] == 1)
                {
                    for (int j = 0; j < graphs2.GetLength(0); j++) //length 사용 유의
                    {
                        if (connected2[j] == 0 && graphs2[i,j] != 0 && min > graphs2[i, j])
                        {
                            to = j;
                            min = graphs2[i, j];
                        }
                    }
                }
            }
            
            if(to>0) 
                connected2[to] = 1;
            value = value + min;
            count++;
            Node node = new Node(to, 0, value);
            semiq.Enqueue(node);
            resultq.Enqueue(node);
            q1.Enqueue(to);
            q.Enqueue(to);
  
            return prim(graphs2, connected2, value, count);
            
        }


    }
}
