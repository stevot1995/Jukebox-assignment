using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] Folderbrowser, MP3;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Folderbrowser = openFileDialog1.FileNames;
                MP3 = openFileDialog1.SafeFileNames;
                for (int M = 0 ; M <MP3.Length; M++)
                {
                    listBox1.Items.Add(MP3[M]);
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADD();
        }

        private void ADD()
        { int c = listBox1.Items.Count - 1;
            for (int i = c; i >= 0; i--)
            {
                if (listBox1.GetSelected(i))
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                    listBox1.Items.RemoveAt(i);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
