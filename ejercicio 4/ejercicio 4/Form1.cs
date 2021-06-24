using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_4
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_ingresanombre_Click(object sender, EventArgs e)
        {
            string[] vector1 = new string[] { txt_nombre.Text};
            lista1.Items.Add(txt_nombre.Text);
 
        }

        private void btn_ingresarnombre_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_agregaredad_Click(object sender, EventArgs e)
        {
            int[] vector2 = new int[] { Convert.ToInt32(txt_edad.Text)};
            lista2.Items.Add(txt_edad.Text);
            cbx_edadynombre.Items.Add(txt_nombre.Text + txt_edad.Text);


        }

        private void bnt_ingresaredad_Click(object sender, EventArgs e)
        {
            
            {
             
            }
        }
    }



}
