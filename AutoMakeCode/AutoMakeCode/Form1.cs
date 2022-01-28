using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMakeCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aa = richTextBox1.Text;
            string[] striparr = aa.Split(new string[] { "\t\n" }, StringSplitOptions.None);
            if (striparr.Count() == 1)
            {
                striparr = aa.Split(new string[] { "\n" }, StringSplitOptions.None);
            }
            if (striparr.Count() == 1)
            {
                striparr = aa.Split(new string[] { "," }, StringSplitOptions.None);
            }
            striparr = striparr.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            foreach (var item in striparr)
            {
                string line = " \t\n gridcolumns.Add(new GridColumnInfo() { Header = \"列含义\", PropertyName = \"" + item + "\", Width = 120, DataTemplate = \"DT_" + item + "\", Resource = this.Resources });";

                richTextBox2.Text += line;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aa = richTextBox1.Text;
            string[] striparr = aa.Split(new string[] { "\t\n" }, StringSplitOptions.None);
            if (striparr.Count() == 1)
            {
                striparr = aa.Split(new string[] { "\n" }, StringSplitOptions.None);
            }
            if (striparr.Count() == 1)
            {
                striparr = aa.Split(new string[] { "," }, StringSplitOptions.None);
            }
            striparr = striparr.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            foreach (var item in striparr)
            {
                string line = " \t\n <DataTemplate x:Key=\"DT_" + item + "\">";
                line += " \t\n <TextBlock Margin=\"5,2,5,2\" VerticalAlignment=\"Center\" HorizontalAlignment=\"Center\" Text=\"{Binding " + item + "}\" />";
                line += " \t\n  </DataTemplate>";
                richTextBox2.Text += line;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }




    }
 
}
