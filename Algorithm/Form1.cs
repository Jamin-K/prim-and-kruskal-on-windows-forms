using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm
{
    public partial class Form1 : Form
    {
        int nodeCount = 1;
        int sourceNode = 0;
        int destinationNode = 0;
        int weight = 0;
        Prim prim = new Prim();
        Kruskal kruskal = new Kruskal();

        public Form1()
        {
            InitializeComponent();
        }


        private void node1_Click(object sender, EventArgs e)
        {
            switch (nodeCount)
            {
                case 1:
                    node1.Visible = true;
                    source_combo.Items.Add("1");
                    destination_combo.Items.Add("1");
                    nodeCount++;
                    break;

                case 2:
                    node2.Visible = true;
                    source_combo.Items.Add("2");
                    destination_combo.Items.Add("2");
                    nodeCount++;
                    break;

                case 3:
                    node3.Visible = true;
                    source_combo.Items.Add("3");
                    destination_combo.Items.Add("3");
                    nodeCount++;
                    break;

                case 4:
                    node4.Visible = true;
                    source_combo.Items.Add("4");
                    destination_combo.Items.Add("4");
                    nodeCount++;
                    break;

                case 5:
                    node5.Visible = true;
                    source_combo.Items.Add("5");
                    destination_combo.Items.Add("5");
                    nodeCount++;
                    break;

                case 6:
                    node6.Visible = true;
                    source_combo.Items.Add("6");
                    destination_combo.Items.Add("6");
                    nodeCount++;
                    break;

                case 7:
                    node7.Visible = true;
                    source_combo.Items.Add("7");
                    destination_combo.Items.Add("7");
                    nodeCount++;
                    break;

                default:
                    MessageBox.Show("노드는 최대 7개까지 생성 가능합니다.");
                    break;

            }
        } //클릭 시 노드 추가


        private void source_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            sourceNode = Convert.ToInt32(source_combo.SelectedItem) - 1;
        }

        private void destination_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            destinationNode = Convert.ToInt32(destination_combo.SelectedItem) - 1;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            weight = Convert.ToInt32(weight_textBox.Text);
            Graphics graphics = CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Point p1 = new Point();
            Point p2 = new Point();
            if (sourceNode == 0)
            {
                if (destinationNode == 1)
                {
                    p1 = node1.Location;
                    p2 = node2.Location;
                    label_1to2.Visible = true;
                    label_1to2.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 2)
                {
                    p1 = node1.Location;
                    p2 = node3.Location;
                    label_1to3.Visible = true;
                    label_1to3.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 3)
                {
                    p1 = node1.Location;
                    p2 = node4.Location;
                    label_1to4.Visible = true;
                    label_1to4.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 4)
                {
                    p1 = node1.Location;
                    p2 = node5.Location;
                    label_1to5.Visible = true;
                    label_1to5.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 5)
                {
                    p1 = node1.Location;
                    p2 = node6.Location;
                    label_1to6.Visible = true;
                    label_1to6.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 6)
                {
                    p1 = node1.Location;
                    p2 = node7.Location;
                    label_1to7.Visible = true;
                    label_1to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else
                    MessageBox.Show("가중치 입력 불가");

            }
            else if (sourceNode == 1)
            {
                if (destinationNode == 0)
                {
                    p1 = node2.Location;
                    p2 = node1.Location;
                    label_1to2.Visible = true;
                    label_1to2.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 2)
                {
                    p1 = node2.Location;
                    p2 = node3.Location;
                    label_2to3.Visible = true;
                    label_2to3.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 3)
                {
                    p1 = node2.Location;
                    p2 = node4.Location;
                    label_2to4.Visible = true;
                    label_2to4.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 4)
                {
                    p1 = node2.Location;
                    p2 = node5.Location;
                    label_2to5.Visible = true;
                    label_2to5.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 5)
                {
                    p1 = node2.Location;
                    p2 = node6.Location;
                    label_2to6.Visible = true;
                    label_2to6.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 6)
                {
                    p1 = node2.Location;
                    p2 = node7.Location;
                    label_2to7.Visible = true;
                    label_2to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else
                    MessageBox.Show("가중치 입력 불가");
            
            }
            else if(sourceNode == 2)
            {
                if(destinationNode == 0)
                {
                    p1 = node3.Location;
                    p2 = node1.Location;
                    label_1to3.Visible = true;
                    label_1to3.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if(destinationNode == 1)
                {
                    p1 = node3.Location;
                    p2 = node2.Location;
                    label_2to3.Visible = true;
                    label_2to3.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 3)
                {
                    p1 = node3.Location;
                    p2 = node4.Location;
                    label_3to4.Visible = true;
                    label_3to4.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 4)
                {
                    MessageBox.Show("간선이 노드를 지나감. 가중치 입력 불가");
                }
                else if (destinationNode == 5)
                {
                    p1 = node3.Location;
                    p2 = node6.Location;
                    label_3to6.Visible = true;
                    label_3to6.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 6)
                {
                    p1 = node3.Location;
                    p2 = node7.Location;
                    label_3to7.Visible = true;
                    label_3to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else
                    MessageBox.Show("가중치 입력 불가");
            }
            else if(sourceNode == 3)
            {
                if(destinationNode == 0)
                {
                    p1 = node4.Location;
                    p2 = node1.Location;
                    label_1to4.Visible = true;
                    label_1to4.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if(destinationNode == 1)
                {
                    p1 = node4.Location;
                    p2 = node2.Location;
                    label_2to4.Visible = true;
                    label_2to4.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 2)
                {
                    p1 = node4.Location;
                    p2 = node3.Location;
                    label_3to4.Visible = true;
                    label_3to4.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 4)
                {
                    p1 = node4.Location;
                    p2 = node5.Location;
                    label_4to5.Visible = true;
                    label_4to5.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 5)
                {
                    MessageBox.Show("간선이 노드를 지나감. 가중치 입력 불가");
                }
                else if (destinationNode == 6)
                {
                    p1 = node4.Location;
                    p2 = node7.Location;
                    label_4to7.Visible = true;
                    label_4to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else
                    MessageBox.Show("가중치 입력 불가");
            }
            else if(sourceNode == 4)
            {
                if (destinationNode == 0)
                {
                    p1 = node5.Location;
                    p2 = node1.Location;
                    label_1to5.Visible = true;
                    label_1to5.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 1)
                {
                    p1 = node5.Location;
                    p2 = node2.Location;
                    label_2to5.Visible = true;
                    label_2to5.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 2)
                {
                    MessageBox.Show("간선이 노드를 지나감. 가중치 입력 불가");
                }
                else if (destinationNode == 3)
                {
                    p1 = node5.Location;
                    p2 = node4.Location;
                    label_4to5.Visible = true;
                    label_4to5.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 5)
                {
                    p1 = node5.Location;
                    p2 = node6.Location;
                    label_5to6.Visible = true;
                    label_5to6.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 6)
                {
                    p1 = node5.Location;
                    p2 = node7.Location;
                    label_5to7.Visible = true;
                    label_5to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else
                    MessageBox.Show("가중치 입력 불가");
            }
            else if(sourceNode == 5)
            {
                if (destinationNode == 0)
                {
                    p1 = node6.Location;
                    p2 = node1.Location;
                    label_1to6.Visible = true;
                    label_1to6.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 1)
                {
                    p1 = node6.Location;
                    p2 = node2.Location;
                    label_2to6.Visible = true;
                    label_2to6.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 2)
                {
                    p1 = node6.Location;
                    p2 = node3.Location;
                    label_3to6.Visible = true;
                    label_3to6.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 3)
                {
                    MessageBox.Show("간선이 노드를 지나감. 가중치 입력 불가");
                }
                else if (destinationNode == 4)
                {
                    p1 = node6.Location;
                    p2 = node5.Location;
                    label_5to6.Visible = true;
                    label_5to6.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 6)
                {
                    p1 = node6.Location;
                    p2 = node7.Location;
                    label_6to7.Visible = true;
                    label_6to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else
                    MessageBox.Show("가중치 입력 불가");
            }
            else if(sourceNode == 6)
            {
                if (destinationNode == 0)
                {
                    p1 = node7.Location;
                    p2 = node1.Location;
                    label_1to7.Visible = true;
                    label_1to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 1)
                {
                    p1 = node7.Location;
                    p2 = node2.Location;
                    label_2to7.Visible = true;
                    label_2to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 2)
                {
                    p1 = node7.Location;
                    p2 = node3.Location;
                    label_3to7.Visible = true;
                    label_3to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 3)
                {
                    p1 = node7.Location;
                    p2 = node4.Location;
                    label_4to7.Visible = true;
                    label_4to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 4)
                {
                    p1 = node7.Location;
                    p2 = node5.Location;
                    label_5to7.Visible = true;
                    label_5to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else if (destinationNode == 5)
                {
                    p1 = node7.Location;
                    p2 = node6.Location;
                    label_6to7.Visible = true;
                    label_6to7.Text = Convert.ToString(weight);
                    graphics.DrawLine(pen, p1, p2);
                    prim.setGraphs(sourceNode, destinationNode, weight);
                    kruskal.setGraphs(sourceNode, destinationNode, weight);
                    MessageBox.Show("가중치 입력 완료" + sourceNode + " - " + destinationNode + " : " + weight);
                }
                else
                    MessageBox.Show("가중치 입력 불가");
            }

            
        }


        private void result_btn_Click(object sender, EventArgs e)
        {
            Node node;
            //prim.call_prim(); //계산 시작
            //kruskal.kru();
 
            Graphics graphics = CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Point p1 = new Point();
            Point p2 = new Point();

            Queue<int> prim_q = prim.getQ();
            Queue<Node> kruskal_q = kruskal.getresultq();
            circularButton1.Visible = true;
            circularButton_k1.Visible = true;
            circularButton_k2.Visible = true;
            circularButton_k3.Visible = true;
            circularButton_k4.Visible = true;
            circularButton_k5.Visible = true;
            circularButton_k6.Visible = true;
            circularButton_k7.Visible = true;
            //kruskal 알고리즘
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    node = kruskal_q.Dequeue();
                    Console.WriteLine("----------");
                    Console.WriteLine(node.start);
                    Console.WriteLine(node.to);
                    if (node.start == 0)
                    {
                        if (node.to == 1)
                        {
                            p1 = circularButton_k1.Location;
                            p2 = circularButton_k2.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 2)
                        {
                            p1 = circularButton_k1.Location;
                            p2 = circularButton_k3.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 3)
                        {
                            p1 = circularButton_k1.Location;
                            p2 = circularButton_k4.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 4)
                        {
                            p1 = circularButton_k1.Location;
                            p2 = circularButton_k5.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 5)
                        {
                            p1 = circularButton_k1.Location;
                            p2 = circularButton_k6.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 6)
                        {
                            p1 = circularButton_k1.Location;
                            p2 = circularButton_k7.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                    }
                    else if (node.start == 1)
                    {
                        if (node.to == 0)
                        {
                            p1 = circularButton_k2.Location;
                            p2 = circularButton_k1.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 2)
                        {
                            p1 = circularButton_k2.Location;
                            p2 = circularButton_k3.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 3)
                        {
                            p1 = circularButton_k2.Location;
                            p2 = circularButton_k4.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 4)
                        {
                            p1 = circularButton_k2.Location;
                            p2 = circularButton_k5.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 5)
                        {
                            p1 = circularButton_k2.Location;
                            p2 = circularButton_k6.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 6)
                        {
                            p1 = circularButton_k2.Location;
                            p2 = circularButton_k7.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                    }
                    else if (node.start == 2)
                    {
                        if (node.to == 0)
                        {
                            p1 = circularButton_k3.Location;
                            p2 = circularButton_k1.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 1)
                        {
                            p1 = circularButton_k3.Location;
                            p2 = circularButton_k2.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 3)
                        {
                            p1 = circularButton_k3.Location;
                            p2 = circularButton_k4.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 4)
                        {
                            p1 = circularButton_k3.Location;
                            p2 = circularButton_k5.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 5)
                        {
                            p1 = circularButton_k3.Location;
                            p2 = circularButton_k6.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 6)
                        {
                            p1 = circularButton_k3.Location;
                            p2 = circularButton_k7.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                    }
                    else if (node.start == 3)
                    {
                        if (node.to == 1)
                        {
                            p1 = circularButton_k4.Location;
                            p2 = circularButton_k2.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 2)
                        {
                            p1 = circularButton_k4.Location;
                            p2 = circularButton_k3.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 0)
                        {
                            p1 = circularButton_k4.Location;
                            p2 = circularButton_k1.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 4)
                        {
                            p1 = circularButton_k4.Location;
                            p2 = circularButton_k5.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 5)
                        {
                            p1 = circularButton_k4.Location;
                            p2 = circularButton_k6.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 6)
                        {
                            p1 = circularButton_k4.Location;
                            p2 = circularButton_k7.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                    }
                    else if (node.start == 4)
                    {
                        if (node.to == 1)
                        {
                            p1 = circularButton_k5.Location;
                            p2 = circularButton_k2.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 2)
                        {
                            p1 = circularButton_k5.Location;
                            p2 = circularButton_k3.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 3)
                        {
                            p1 = circularButton_k5.Location;
                            p2 = circularButton_k4.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 0)
                        {
                            p1 = circularButton_k5.Location;
                            p2 = circularButton_k1.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 5)
                        {
                            p1 = circularButton_k5.Location;
                            p2 = circularButton_k6.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 6)
                        {
                            p1 = circularButton_k5.Location;
                            p2 = circularButton_k7.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                    }
                    else if (node.start == 5)
                    {
                        if (node.to == 1)
                        {
                            p1 = circularButton_k6.Location;
                            p2 = circularButton_k2.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 2)
                        {
                            p1 = circularButton_k6.Location;
                            p2 = circularButton_k3.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 3)
                        {
                            p1 = circularButton_k6.Location;
                            p2 = circularButton_k4.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 4)
                        {
                            p1 = circularButton_k6.Location;
                            p2 = circularButton_k5.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 0)
                        {
                            p1 = circularButton_k6.Location;
                            p2 = circularButton_k1.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 6)
                        {
                            p1 = circularButton_k6.Location;
                            p2 = circularButton_k7.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                    }
                    else if (node.start == 6)
                    {
                        if (node.to == 1)
                        {
                            p1 = circularButton_k7.Location;
                            p2 = circularButton_k2.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 2)
                        {
                            p1 = circularButton_k7.Location;
                            p2 = circularButton_k3.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 3)
                        {
                            p1 = circularButton_k7.Location;
                            p2 = circularButton_k4.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 4)
                        {
                            p1 = circularButton_k7.Location;
                            p2 = circularButton_k5.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 5)
                        {
                            p1 = circularButton_k7.Location;
                            p2 = circularButton_k6.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                        else if (node.to == 0)
                        {
                            p1 = circularButton_k7.Location;
                            p2 = circularButton_k1.Location;
                            graphics.DrawLine(pen, p1, p2);
                        }
                    }
                }
            }
            catch
            {

            }
            MessageBox.Show("krukal 알고리즘 적용 결과 : " + Convert.ToString(kruskal.getWeight_min()), "최종결과");
            //prim 알고리즘 
            int start = 0;
            int to = 0;
            try //큐 범위 넘어가는 오류 발생
            {
                for (int j = 0; j < 100; j++)
                {
                    to = prim_q.Peek();
                    Console.WriteLine("prim tree");
                    Console.WriteLine(start);
                    Console.WriteLine(to);
                    Console.WriteLine("----------");
                    if (start == 0)
                    {
                        if (to == 1)
                        {
                            circularButton2.Visible = true;
                            p1 = circularButton1.Location;
                            p2 = circularButton2.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 2)
                        {
                            circularButton3.Visible = true;
                            p1 = circularButton1.Location;
                            p2 = circularButton3.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 3)
                        {
                            circularButton4.Visible = true;
                            p1 = circularButton1.Location;
                            p2 = circularButton4.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 4)
                        {
                            circularButton5.Visible = true;
                            p1 = circularButton1.Location;
                            p2 = circularButton5.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 5)
                        {
                            circularButton6.Visible = true;
                            p1 = circularButton1.Location;
                            p2 = circularButton6.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 6)
                        {
                            circularButton7.Visible = true;
                            p1 = circularButton1.Location;
                            p2 = circularButton7.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                    }
                    else if (start == 1)
                    {
                        if (to == 0)
                        {
                            circularButton1.Visible = true;
                            p1 = circularButton2.Location;
                            p2 = circularButton1.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 2)
                        {
                            circularButton3.Visible = true;
                            p1 = circularButton2.Location;
                            p2 = circularButton3.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 3)
                        {
                            circularButton4.Visible = true;
                            p1 = circularButton2.Location;
                            p2 = circularButton4.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 4)
                        {
                            circularButton5.Visible = true;
                            p1 = circularButton2.Location;
                            p2 = circularButton5.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 5)
                        {
                            circularButton6.Visible = true;
                            p1 = circularButton2.Location;
                            p2 = circularButton6.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 6)
                        {
                            circularButton7.Visible = true;
                            p1 = circularButton2.Location;
                            p2 = circularButton7.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                    }
                    else if (start == 2)
                    {
                        if (to == 0)
                        {
                            circularButton1.Visible = true;
                            p1 = circularButton3.Location;
                            p2 = circularButton1.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 1)
                        {
                            circularButton2.Visible = true;
                            p1 = circularButton3.Location;
                            p2 = circularButton2.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 3)
                        {
                            circularButton4.Visible = true;
                            p1 = circularButton3.Location;
                            p2 = circularButton4.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 4)
                        {
                            circularButton5.Visible = true;
                            p1 = circularButton3.Location;
                            p2 = circularButton5.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 5)
                        {
                            circularButton6.Visible = true;
                            p1 = circularButton3.Location;
                            p2 = circularButton6.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 6)
                        {
                            circularButton7.Visible = true;
                            p1 = circularButton3.Location;
                            p2 = circularButton7.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                    }
                    else if (start == 3)
                    {
                        if (to == 0)
                        {
                            circularButton1.Visible = true;
                            p1 = circularButton4.Location;
                            p2 = circularButton1.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 2)
                        {
                            circularButton3.Visible = true;
                            p1 = circularButton4.Location;
                            p2 = circularButton3.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 1)
                        {
                            circularButton2.Visible = true;
                            p1 = circularButton4.Location;
                            p2 = circularButton2.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 4)
                        {
                            circularButton5.Visible = true;
                            p1 = circularButton4.Location;
                            p2 = circularButton5.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 5)
                        {
                            circularButton6.Visible = true;
                            p1 = circularButton4.Location;
                            p2 = circularButton6.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 6)
                        {
                            circularButton7.Visible = true;
                            p1 = circularButton4.Location;
                            p2 = circularButton7.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                    }
                    else if (start == 4)
                    {
                        if (to == 0)
                        {
                            circularButton1.Visible = true;
                            p1 = circularButton5.Location;
                            p2 = circularButton1.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 2)
                        {
                            circularButton3.Visible = true;
                            p1 = circularButton5.Location;
                            p2 = circularButton3.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 3)
                        {
                            circularButton4.Visible = true;
                            p1 = circularButton5.Location;
                            p2 = circularButton4.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 1)
                        {
                            circularButton2.Visible = true;
                            p1 = circularButton5.Location;
                            p2 = circularButton2.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 5)
                        {
                            circularButton6.Visible = true;
                            p1 = circularButton5.Location;
                            p2 = circularButton6.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 6)
                        {
                            circularButton7.Visible = true;
                            p1 = circularButton5.Location;
                            p2 = circularButton7.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                    }
                    else if (start == 5)
                    {
                        if (to == 0)
                        {
                            circularButton1.Visible = true;
                            p1 = circularButton6.Location;
                            p2 = circularButton1.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 2)
                        {
                            circularButton3.Visible = true;
                            p1 = circularButton6.Location;
                            p2 = circularButton3.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 3)
                        {
                            circularButton4.Visible = true;
                            p1 = circularButton6.Location;
                            p2 = circularButton4.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 4)
                        {
                            circularButton5.Visible = true;
                            p1 = circularButton6.Location;
                            p2 = circularButton5.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 1)
                        {
                            circularButton2.Visible = true;
                            p1 = circularButton6.Location;
                            p2 = circularButton2.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 6)
                        {
                            circularButton7.Visible = true;
                            p1 = circularButton6.Location;
                            p2 = circularButton7.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                    }
                    else if (start == 6)
                    {
                        if (to == 0)
                        {
                            circularButton1.Visible = true;
                            p1 = circularButton7.Location;
                            p2 = circularButton1.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 2)
                        {
                            circularButton3.Visible = true;
                            p1 = circularButton7.Location;
                            p2 = circularButton3.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 3)
                        {
                            circularButton4.Visible = true;
                            p1 = circularButton7.Location;
                            p2 = circularButton4.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 4)
                        {
                            circularButton5.Visible = true;
                            p1 = circularButton7.Location;
                            p2 = circularButton5.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 5)
                        {
                            circularButton6.Visible = true;
                            p1 = circularButton7.Location;
                            p2 = circularButton6.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                        else if (to == 1)
                        {
                            circularButton2.Visible = true;
                            p1 = circularButton7.Location;
                            p2 = circularButton2.Location;
                            graphics.DrawLine(pen, p1, p2);
                            start = to;
                            to = prim_q.Dequeue();
                        }
                    }
                }
            }
            catch
            {

            }
            MessageBox.Show("Prim 알고리즘 적용 결과 : " + Convert.ToString(prim.getWeight_min()), "최종결과");


        }

        private void semiresult_btn_Click(object sender, EventArgs e)
        {
            Node node;
            prim.call_prim(); //계산 시작
            kruskal.kru();
            Graphics graphics = CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Point p1 = new Point();
            Point p2 = new Point();
            
            Queue<int> prim_q = prim.getQ1();
            Queue<Node> kruskal_q = kruskal.getsetmiq();
            Queue<Node> prim_q1 = prim.getsemiq();
            circularButton1.Visible = true;
            circularButton_k1.Visible = true;
            circularButton_k2.Visible = true;
            circularButton_k3.Visible = true;
            circularButton_k4.Visible = true;
            circularButton_k5.Visible = true;
            circularButton_k6.Visible = true;
            circularButton_k7.Visible = true;
            //kruskal 알고리즘
            for (int i = 0; i < 4; i++)
            {
                node = kruskal_q.Dequeue();
                if (node.start == 0)
                {
                    if (node.to == 1)
                    {
                        p1 = circularButton_k1.Location;
                        p2 = circularButton_k2.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 2)
                    {
                        p1 = circularButton_k1.Location;
                        p2 = circularButton_k3.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 3)
                    {
                        p1 = circularButton_k1.Location;
                        p2 = circularButton_k4.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 4)
                    {
                        p1 = circularButton_k1.Location;
                        p2 = circularButton_k5.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 5)
                    {
                        p1 = circularButton_k1.Location;
                        p2 = circularButton_k6.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 6)
                    {
                        p1 = circularButton_k1.Location;
                        p2 = circularButton_k7.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                }
                else if (node.start == 1)
                {
                    if (node.to == 0)
                    {
                        p1 = circularButton_k2.Location;
                        p2 = circularButton_k1.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 2)
                    {
                        p1 = circularButton_k2.Location;
                        p2 = circularButton_k3.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 3)
                    {
                        p1 = circularButton_k2.Location;
                        p2 = circularButton_k4.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 4)
                    {
                        p1 = circularButton_k2.Location;
                        p2 = circularButton_k5.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 5)
                    {
                        p1 = circularButton_k2.Location;
                        p2 = circularButton_k6.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 6)
                    {
                        p1 = circularButton_k2.Location;
                        p2 = circularButton_k7.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                }
                else if (node.start == 2)
                {
                    if (node.to == 0)
                    {
                        p1 = circularButton_k3.Location;
                        p2 = circularButton_k1.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 1)
                    {
                        p1 = circularButton_k3.Location;
                        p2 = circularButton_k2.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 3)
                    {
                        p1 = circularButton_k3.Location;
                        p2 = circularButton_k4.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 4)
                    {
                        p1 = circularButton_k3.Location;
                        p2 = circularButton_k5.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 5)
                    {
                        p1 = circularButton_k3.Location;
                        p2 = circularButton_k6.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 6)
                    {
                        p1 = circularButton_k3.Location;
                        p2 = circularButton_k7.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                }
                else if (node.start == 3)
                {
                    if (node.to == 1)
                    {
                        p1 = circularButton_k4.Location;
                        p2 = circularButton_k2.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 2)
                    {
                        p1 = circularButton_k4.Location;
                        p2 = circularButton_k3.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 0)
                    {
                        p1 = circularButton_k4.Location;
                        p2 = circularButton_k1.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 4)
                    {
                        p1 = circularButton_k4.Location;
                        p2 = circularButton_k5.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 5)
                    {
                        p1 = circularButton_k4.Location;
                        p2 = circularButton_k6.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 6)
                    {
                        p1 = circularButton_k4.Location;
                        p2 = circularButton_k7.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                }
                else if (node.start == 4)
                {
                    if (node.to == 1)
                    {
                        p1 = circularButton_k5.Location;
                        p2 = circularButton_k2.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 2)
                    {
                        p1 = circularButton_k5.Location;
                        p2 = circularButton_k3.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 3)
                    {
                        p1 = circularButton_k5.Location;
                        p2 = circularButton_k4.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 0)
                    {
                        p1 = circularButton_k5.Location;
                        p2 = circularButton_k1.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 5)
                    {
                        p1 = circularButton_k5.Location;
                        p2 = circularButton_k6.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 6)
                    {
                        p1 = circularButton_k5.Location;
                        p2 = circularButton_k7.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                }
                else if (node.start == 5)
                {
                    if (node.to == 1)
                    {
                        p1 = circularButton_k6.Location;
                        p2 = circularButton_k2.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 2)
                    {
                        p1 = circularButton_k6.Location;
                        p2 = circularButton_k3.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 3)
                    {
                        p1 = circularButton_k6.Location;
                        p2 = circularButton_k4.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 4)
                    {
                        p1 = circularButton_k6.Location;
                        p2 = circularButton_k5.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 0)
                    {
                        p1 = circularButton_k6.Location;
                        p2 = circularButton_k1.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 6)
                    {
                        p1 = circularButton_k6.Location;
                        p2 = circularButton_k7.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                }
                else if (node.start == 6)
                {
                    if (node.to == 1)
                    {
                        p1 = circularButton_k7.Location;
                        p2 = circularButton_k2.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 2)
                    {
                        p1 = circularButton_k7.Location;
                        p2 = circularButton_k3.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 3)
                    {
                        p1 = circularButton_k7.Location;
                        p2 = circularButton_k4.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 4)
                    {
                        p1 = circularButton_k7.Location;
                        p2 = circularButton_k5.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 5)
                    {
                        p1 = circularButton_k7.Location;
                        p2 = circularButton_k6.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                    else if (node.to == 0)
                    {
                        p1 = circularButton_k7.Location;
                        p2 = circularButton_k1.Location;
                        graphics.DrawLine(pen, p1, p2);
                    }
                }
            }
            Node semiq = kruskal_q.Peek();
            MessageBox.Show("krukal 알고리즘 적용 결과 : " + Convert.ToString(semiq.weight), "중간결과");
            circularButton1.Visible = true;
            circularButton2.Visible = true;
            circularButton3.Visible = true;
            circularButton4.Visible = true;
            circularButton5.Visible = true;
            circularButton6.Visible = true;
            circularButton7.Visible = true;
            //prim 알고리즘 
            int start = 0;
            int to = 0;

            for (int j = 0; j < 4; j++) { 
                prim_q1.Dequeue();
                to = prim_q.Peek();
                Console.WriteLine("prim tree");
                Console.WriteLine(start);
                Console.WriteLine(to);
                Console.WriteLine("----------");
                if (start == 0)
                {
                    if (to == 1)
                    {
                        circularButton2.Visible = true;
                        p1 = circularButton1.Location;
                        p2 = circularButton2.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 2)
                    {
                        circularButton3.Visible = true;
                        p1 = circularButton1.Location;
                        p2 = circularButton3.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 3)
                    {
                        circularButton4.Visible = true;
                        p1 = circularButton1.Location;
                        p2 = circularButton4.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 4)
                    {
                        circularButton5.Visible = true;
                        p1 = circularButton1.Location;
                        p2 = circularButton5.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 5)
                    {
                        circularButton6.Visible = true;
                        p1 = circularButton1.Location;
                        p2 = circularButton6.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 6)
                    {
                        circularButton7.Visible = true;
                        p1 = circularButton1.Location;
                        p2 = circularButton7.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                }
                else if (start == 1)
                {
                    if (to == 0)
                    {
                        circularButton1.Visible = true;
                        p1 = circularButton2.Location;
                        p2 = circularButton1.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 2)
                    {
                        circularButton3.Visible = true;
                        p1 = circularButton2.Location;
                        p2 = circularButton3.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 3)
                    {
                        circularButton4.Visible = true;
                        p1 = circularButton2.Location;
                        p2 = circularButton4.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 4)
                    {
                        circularButton5.Visible = true;
                        p1 = circularButton2.Location;
                        p2 = circularButton5.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 5)
                    {
                        circularButton6.Visible = true;
                        p1 = circularButton2.Location;
                        p2 = circularButton6.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 6)
                    {
                        circularButton7.Visible = true;
                        p1 = circularButton2.Location;
                        p2 = circularButton7.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                }
                else if (start == 2)
                {
                    if (to == 0)
                    {
                        circularButton1.Visible = true;
                        p1 = circularButton3.Location;
                        p2 = circularButton1.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 1)
                    {
                        circularButton2.Visible = true;
                        p1 = circularButton3.Location;
                        p2 = circularButton2.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 3)
                    {
                        circularButton4.Visible = true;
                        p1 = circularButton3.Location;
                        p2 = circularButton4.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 4)
                    {
                        circularButton5.Visible = true;
                        p1 = circularButton3.Location;
                        p2 = circularButton5.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 5)
                    {
                        circularButton6.Visible = true;
                        p1 = circularButton3.Location;
                        p2 = circularButton6.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 6)
                    {
                        circularButton7.Visible = true;
                        p1 = circularButton3.Location;
                        p2 = circularButton7.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                }
                else if (start == 3)
                {
                    if (to == 0)
                    {
                        circularButton1.Visible = true;
                        p1 = circularButton4.Location;
                        p2 = circularButton1.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 2)
                    {
                        circularButton3.Visible = true;
                        p1 = circularButton4.Location;
                        p2 = circularButton3.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 1)
                    {
                        circularButton2.Visible = true;
                        p1 = circularButton4.Location;
                        p2 = circularButton2.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 4)
                    {
                        circularButton5.Visible = true;
                        p1 = circularButton4.Location;
                        p2 = circularButton5.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 5)
                    {
                        circularButton6.Visible = true;
                        p1 = circularButton4.Location;
                        p2 = circularButton6.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 6)
                    {
                        circularButton7.Visible = true;
                        p1 = circularButton4.Location;
                        p2 = circularButton7.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                }
                else if (start == 4)
                {
                    if (to == 0)
                    {
                        circularButton1.Visible = true;
                        p1 = circularButton5.Location;
                        p2 = circularButton1.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 2)
                    {
                        circularButton3.Visible = true;
                        p1 = circularButton5.Location;
                        p2 = circularButton3.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 3)
                    {
                        circularButton4.Visible = true;
                        p1 = circularButton5.Location;
                        p2 = circularButton4.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 1)
                    {
                        circularButton2.Visible = true;
                        p1 = circularButton5.Location;
                        p2 = circularButton2.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 5)
                    {
                        circularButton6.Visible = true;
                        p1 = circularButton5.Location;
                        p2 = circularButton6.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 6)
                    {
                        circularButton7.Visible = true;
                        p1 = circularButton5.Location;
                        p2 = circularButton7.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                }
                else if (start == 5)
                {
                    if (to == 0)
                    {
                        circularButton1.Visible = true;
                        p1 = circularButton6.Location;
                        p2 = circularButton1.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 2)
                    {
                        circularButton3.Visible = true;
                        p1 = circularButton6.Location;
                        p2 = circularButton3.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 3)
                    {
                        circularButton4.Visible = true;
                        p1 = circularButton6.Location;
                        p2 = circularButton4.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 4)
                    {
                        circularButton5.Visible = true;
                        p1 = circularButton6.Location;
                        p2 = circularButton5.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 1)
                    {
                        circularButton2.Visible = true;
                        p1 = circularButton6.Location;
                        p2 = circularButton2.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 6)
                    {
                        circularButton7.Visible = true;
                        p1 = circularButton6.Location;
                        p2 = circularButton7.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                }
                else if (start == 6)
                {
                    if (to == 0)
                    {
                        circularButton1.Visible = true;
                        p1 = circularButton7.Location;
                        p2 = circularButton1.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 2)
                    {
                        circularButton3.Visible = true;
                        p1 = circularButton7.Location;
                        p2 = circularButton3.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 3)
                    {
                        circularButton4.Visible = true;
                        p1 = circularButton7.Location;
                        p2 = circularButton4.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 4)
                    {
                        circularButton5.Visible = true;
                        p1 = circularButton7.Location;
                        p2 = circularButton5.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 5)
                    {
                        circularButton6.Visible = true;
                        p1 = circularButton7.Location;
                        p2 = circularButton6.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                    else if (to == 1)
                    {
                        circularButton2.Visible = true;
                        p1 = circularButton7.Location;
                        p2 = circularButton2.Location;
                        graphics.DrawLine(pen, p1, p2);
                        start = to;
                        to = prim_q.Dequeue();
                    }
                }
            }
            Node semiq1 = prim_q1.Peek();
            MessageBox.Show("Prim 알고리즘 적용 결과 : " + Convert.ToString(semiq1.weight), "중간결과");

        }
    }
}
