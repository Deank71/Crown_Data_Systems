using Question2.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
             ConverStringToBytes converStringToBytes = new ConverStringToBytes();
            Byte[] reverseBytes = converStringToBytes.GenerateBytesFromString(textBoxNumbers.Text);
            foreach(var number in reverseBytes)
            {
                listBoxResult.Items.Add(number);
            }

        }

       
    }
}
