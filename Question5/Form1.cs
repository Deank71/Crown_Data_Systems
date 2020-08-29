using Question5.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            StringParser stringParser = new StringParser();
            List<string> result = stringParser.GenerateList(textBoxString.Text,textBoxParser.Text);
            foreach(var item in result)
            {
                listBoxResult.Items.Add(item);
            }
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
