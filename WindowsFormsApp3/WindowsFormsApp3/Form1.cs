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
    public partial class Form1 : Form

    {
        
        
        public Form1()

        {
           
            InitializeComponent();
        }
        
        private ListBox form3listbox;
        string[] Folderbrowser, MP3;
        private void Form1_Load(object sender, System.EventArgs e)
        {
            new Form3().Hide();

            form3listbox = Form3.form3listbox; // Where it tried to connect the forms
            
        }
   
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Setup = new Form3();
            Setup.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var About = new Form2();
            About.Show();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            // Where it tried to get it to play with this > axWindowsMediaPlayer2.URL = MP3[listBox2.SelectedIndex];
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Where it tried to get it to play  > axWindowsMediaPlayer2.URL = MP3[listBox2.SelectedIndex]; 
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Folderbrowser = openFileDialog1.FileNames;
                    MP3 = openFileDialog1.SafeFileNames;
                    for (int M = 0; M < MP3.Length; M++)
                    {
                        listBox2.Items.Add(MP3[M]);
                    }

                    foreach (string info in openFileDialog1.FileNames)
                {
                    listBox2.Items.Add(info);
                }
                }

            

        }
        
        
        
            
        }

        
        
            
            
        
    }

