using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<char> list = new List<char>();
        private string Vypis(List<char> list)
        {
            string neco = "";
            foreach (char ch in list)
            {
                neco += ch.ToString();
            }
            return neco;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            list.Clear();
            foreach (char ch in textBox1.Text)
            {
                list.Add(ch);
            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string bt = ((Button)sender).Text;
            list.Remove(Char.Parse(bt));
            textBox1.Text = Vypis(list);
            ((Button)sender).Enabled = false;
        }
    }
}
