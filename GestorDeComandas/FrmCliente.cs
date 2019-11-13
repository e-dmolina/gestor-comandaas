using GestorDeComandas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeComandas
{
   public partial class FrmCliente : Form
   {
      private string telefono;
      public FrmCliente()
      {
         InitializeComponent();
      }

      public FrmCliente(string telefono)
      {
         InitializeComponent();
         this.telefono = telefono;
      }
      //private void FrmCliente_Load(object sender, EventArgs e)
      //{
         
      //}

      private void btnGuardar_Click(object sender, EventArgs e)
      {
         if (ValidarCamposVacios())
         {
            using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
            {
               Clientes cli = db.Clientes.FirstOrDefault(c => c.telfono == txtTelefono.Text);

               if (cli == null)
               {
                  cli = new Clientes();
                  cli.telfono = txtTelefono.Text;
                  cli.nombre = txtNombre.Text;
                  cli.observacion = txtObservacionCli.Text;

                  db.Clientes.Add(cli);
                  db.SaveChanges();
                  cli = db.Clientes.FirstOrDefault(c => c.telfono == cli.telfono);

                  Domicilios dom = new Domicilios();
                  dom.direccion = txtDireccion.Text;
                  dom.id_cliente = cli.id;
                  db.Domicilios.Add(dom);
                  db.SaveChanges();

                  LimpiarCampos();

               }
               else
               {
                  MessageBox.Show("El cliente ya está registrado");
               }
            }
         }        
      }

      private bool ValidarCamposVacios()
      {
         if (txtTelefono.Text == "")
         {
            MessageBox.Show("Debe completar el campo Telefono");
            txtTelefono.Focus();
            return false;
         }
         if (txtNombre.Text == "")
         {
            MessageBox.Show("Debe completar el campo Nombre");
            txtNombre.Focus();
            return false;
         }
         if (txtDireccion.Text == "")
         {
            MessageBox.Show("Debe completar el campo Dirección");
            txtDireccion.Focus();
            return false;
         }
         return true;
      }

      private void LimpiarCampos()
      {
         txtTelefono.Clear();
         txtNombre.Clear();
         txtDireccion.Clear();
         txtObservacionCli.Clear();
      }

      private void btnCancelar_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void FrmCliente_Load_1(object sender, EventArgs e)
      {
         MessageBox.Show(telefono);
         txtTelefono.Text = telefono;
      }
   }
}
