using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Wheat;
            textBox1.Multiline = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(text))
            {
                listBox1.Items.Add(text);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen bir metin girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t2 = (string)listBox1.SelectedItem;
            listBox1.Items.Remove(t2);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = (string)listBox1.SelectedItem;
        }
    }
}
