using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;


namespace CapaVista
{
    public partial class Productos : Form
    {
        string table = "maestros";
        Controlador cn = new Controlador();
        public Productos()
        {
            InitializeComponent();
        }

        public void checkbox()
        {
            if (checkBox1.Checked)
            {
                txtEstado.Text = "1";
            }
            else
            {
                txtEstado.Text = "0";
            }
        }

        public void limpiar()
        {

            txtDireccion.Text = "";
            txtCodigoMestro.Text = "";
            txtNombre.Text = "";
            txtStockMaximo.Text = "";
            txtEstado.Text = "";
            txtTelefono.Text = "";
        }

        public void Actualizar()
        {
            DataTable dt = cn.producto(table);
            listProducto.DataSource = dt;
            // string idUsuario = txtCodigoMestro.Text;
            //cn.llenarListApliUsuariosstring(listProducto.Tag.ToString(), listProducto, idUsuario);
        }

        public void IngresarData()
        {
            DataTable dt = cn.llenarTbl(table);
            listProducto.DataSource = dt;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            checkbox();
            TextBox[] textbox = { txtCodigoMestro, txtNombre, txtDireccion,txtStockMaximo,txtEstado,txtTelefono };
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            Actualizar();
            limpiar();
            MessageBox.Show(message);
        }

        private void listAplicacionPerfil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Maestros_Load(object sender, EventArgs e)
        {
            txtEstado.Visible = false;
            txtEliminar.Visible = false;
            IngresarData();
        }

        private void listMaestro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string dato;
                dato = listProducto.CurrentCell.Value.ToString();
                txtEliminar.Text = dato;


                string message = "Deseas Eliminar el Registro?";
                string title = "Eliminar Registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //int campo = int.Parse(txtBusacar.Text);
                    string condicion = "codigo_maestro = ";
                    cn.eliminar(table, condicion, Int32.Parse(dato));
                    IngresarData();
                    //this.Close();
                }
                else
                {
                    limpiar();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkbox();
            TextBox[] textbox = { txtCodigoMestro, txtNombre, txtDireccion, txtStockMaximo, txtEstado, txtTelefono };
            int valor1 = int.Parse(txtBuscar.Text);
            string campo = "codigo_maestro = ";
            cn.actualizar(textbox, table, campo, valor1);
            IngresarData();
        }

        private void txtBusacar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
