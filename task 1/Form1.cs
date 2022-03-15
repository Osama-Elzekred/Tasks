using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        public int rows, coulms,temp1=1,temp2=0;
        public string text=" ";
        public int i = 0, j = 0;
        public double[,] arr;
        public double[] arr2;

        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            temp2 = 0;
            textBox2.Clear();


            arr2 = new double[coulms * rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coulms; j++)
                {

                    arr2[temp2] = arr[i, j];
                    temp2++;
                }
            }
            Array.Sort(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                textBox2.Text += arr2[i].ToString() + " ";
                if ((i+1)%coulms==0)
                {
                    //textBox2.Text = text;
                    textBox2.Text += Environment.NewLine;
                }

            }
            //foreach (var item in arr2)
            //{
            //    text += item.ToString()+" ";
            //}
           
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temp2 = 0;
            textBox2.Clear();

            arr2 = new double[coulms * rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coulms; j++)
                {

                    arr2[temp2] = arr[i, j];
                    temp2++;
                }
            }
            
            Array.Sort(arr2);
            for (int i = arr2.Length-1; i >=0; i--)
            {
                textBox2.Text += arr2[i].ToString() + " ";
                if ((i + 1) % coulms ==1)
                {
                    //textBox2.Text = text;
                    textBox2.Text += Environment.NewLine;
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        

            arr[i, j] = double.Parse(textBox1.Text);
            textBox1.Clear();
            if (i == rows-1 && j == coulms-1)
            {
                button1.Enabled = false;
            }

            if (j <= coulms)
            {
                if (j==coulms-1)
                {
                    j = -1;
                    i++;
                  
                }
                j++;
              }

            
          
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            rows = int.Parse(rows_num.Text);
            coulms = int.Parse(coulm_num.Text);
             arr = new double[rows, coulms];
            rows_num.Clear();
            coulm_num.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
