using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Gestion_De_Fuentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font,
                label1.Font.Style |FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font,
                label1.Font.Style | FontStyle.Italic);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font,
                label1.Font.Style | FontStyle.Underline);
        }
    }
}
