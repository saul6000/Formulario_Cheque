﻿using ProyectoVectores.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Formulario_Cheque
{
    public partial class Formulariocheque : Form
    {
     
        public Formulariocheque()
        {
            InitializeComponent();
           
        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (int.TryParse(this.alphaBlendTextBox1.Text, out int num))
                {
                    //TODO: asignar cada entero al vector 
                    this.label3.Text = numletras.getLetras(num);
                    this.alphaBlendTextBox1.Text = "";
                }
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printDialog1.ShowDialog();
        }
        
      

        private void Formulariocheque_Load(object sender, EventArgs e)
        {
         

        }
    }
}
