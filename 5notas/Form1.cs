using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5notas
{
    public partial class Form1 : Form
    {
        Promedio promedio = new Promedio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            promedio.setNota1(double.Parse(txtnota1.Text));
            promedio.setNota2(double.Parse(txtnota2.Text));
            promedio.setNota3(double.Parse(txtnota3.Text));
            promedio.setNota4(double.Parse(txtnota4.Text));
            promedio.setNota5(double.Parse(txtnota5.Text));

            lbltotal.Text = promedio.calcularPromedio().ToString();
            double lbltotal2 = double.Parse(lbltotal.Text);
            
            if (lbltotal2>=0 && lbltotal2<=2.99)
            {
                lblmensaje.Text = "Deficiente";
                lblmensaje.Visible = true;
                lbltotal.Visible = true;
            }
            if (lbltotal2>=3 && lbltotal2<=3.99 )
            {
                lblmensaje.Text = "Bien";
                lblmensaje.Visible = true;
                lbltotal.Visible = true;
            }
            if (lbltotal2>=4 && lbltotal2<=5)
            {
                lblmensaje.Text = "Excelente";
                lblmensaje.Visible = true;
                lbltotal.Visible = true;
            }
        }
    }
}
