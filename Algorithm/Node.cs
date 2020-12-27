using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Node
    {
        public int start;
        public int to;
        public int weight;
        public Node(int start, int to, int weight)
        {
            this.start = start;
            this.to = to;
            this.weight = weight;
        }

        public void setNode(int start, int to, int weight)
        {
            this.start = start;
            this.to = to;
            this.weight = weight;
        }
    }
}
