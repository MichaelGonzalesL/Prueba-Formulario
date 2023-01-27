using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows2
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }
        //Texto
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && e.KeyChar != 8)
                e.Handled = true;
            int APROBO = 0;
        }
        //Botones
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int aprobo = 0;
            //Apellido
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else {
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
                aprobo++;
                //string apellido=txtApellido.Text;
            }
            //Nombre
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                aprobo++;
                //string nombre= txtNombre.Text;
            }
            //Edad
            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
            {
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
                aprobo++;
            }
            //Direccion
            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
            {
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;
                aprobo++;
            }
            string apellido = "Apellido y Nombre: " + txtApellido.Text;
            string nombre =" "+ txtNombre.Text;
            string edad= "\r\n" + "Edad : " + txtEdad.Text;
            string direccion = "Dirección : " + txtDireccion.Text;
            //Muestra el resultado
            if (aprobo == 4)
                    txtResulado.Text= apellido + nombre + edad +Environment.NewLine + direccion;
                    //txtResulado.Text= "Edad : " + edad;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //Close();
            //System.Environment.Exit(0);
        }
    }
}
