using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool content = true;
        int i = 35;
        string myString = "Hello World";
        int[] myInts = { 5, 10, 15 };
        string h = "";


        private void buttonPush_Click(object sender, EventArgs e)
        {
            textBoxHolaMundo.Text = content.ToString();
            textBoxI.Text = i.ToString();
            textBoxMyString.Text = myString;
            for (int a=0; a < myInts.Length; a++ )
            {
                
                 h += myInts[a] + " ";
            }
            textBoxArray.Text = h;
        }

        private void textBoxMyString_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
