using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formDebugger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testing button 1 method");
            int number = 15;
            number = number + 10;
            number = 36 * 15;
            number = 12 - (42 / 7);
            number += 10;
            number *= 3;
            number = 71 / 3;
            int count = 0;
            count++;
            count--;
            string result = "hello";
            result += " again " +result;
            MessageBox.Show(result);
            result = "the value is: " +count;
            result = "";
            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testing button2");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Kristopher Cowley 2015");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var txtBX = Console.ReadLine();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
