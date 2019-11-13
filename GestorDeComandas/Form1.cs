using GestorDeComandas.ClasesAuxiliares;
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
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         autoCompletarTelefono();
         iniciarCbxFiltrar();
      }

      private void iniciarCbxFiltrar()
      {
         using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
         {
            List<Estados> lstEstados = db.Estados.ToList();

            foreach (var item in lstEstados)
            {
               cbxEstados.Items.Add(item.descripcion);
               cbxEstados.SelectedIndex = 0;
            }
         }
      }

      private void autoCompletarTelefono()
      {
         using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
         {
            List<Clientes> lstClientes = db.Clientes.ToList();

            foreach (var item in lstClientes)
            {
               txtTelefono.AutoCompleteCustomSource.Add(item.telfono);
            }
         }
      }

      private void completarCampos()
      {
         using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
         {
            Clientes cli = db.Clientes.FirstOrDefault(c => c.telfono == txtTelefono.Text);
                        
            if (cli != null)
            {
               LimpiarCampos();
               txtTelefono.Text = cli.telfono;
               txtNombre.Text = cli.nombre;
               txtObservacionCli.Text = cli.observacion;

               cbxDireccion.DataSource = cli.Domicilios.ToList();
               cbxDireccion.DisplayMember = "direccion";

               if (cbxDireccion.SelectedIndex > 0)
               {
                  cbxDireccion.SelectedIndex = 0;
               }               
            }
            else
            {
               FrmCliente frm = new FrmCliente(txtTelefono.Text);
               frm.ShowDialog();
            }
         }
      }

      private void btnBuscar_Click(object sender, EventArgs e)
      {
         completarCampos();
         autoCompletarTelefono();
      }

      // Agregar diección
      private void btnAddDir_Click(object sender, EventArgs e)
      {

         if (txtAddDireccion.Text != string.Empty)
         {
            using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
            {
               Clientes cli = db.Clientes.FirstOrDefault(c => c.telfono == txtTelefono.Text);
                                            
               Domicilios dom = new Domicilios();
               dom.direccion = txtAddDireccion.Text;
               dom.id_cliente = cli.id;

               db.Domicilios.Add(dom);
               db.SaveChanges();             
            }
            completarCampos();
            cbxDireccion.SelectedIndex = cbxDireccion.Items.Count - 1;
            txtAddDireccion.Clear();
         }
      }

      private void btnLimpiar_Click(object sender, EventArgs e)
      {
         LimpiarCampos();
      }

      private void LimpiarCampos()
      {
         txtTelefono.Clear();
         txtNombre.Clear();
         cbxDireccion.DataSource = null;
         cbxDireccion.Items.Clear();
         txtObservacionCli.Clear();
      }

      // Muestra el detalle de la orden seleccionada
      private void dtgOrdenes_SelectionChanged(object sender, EventArgs e)
      {
         lblDetalles.Text = "DETALLE DE ORDEN: \n\n";
         int indice = dtgOrdenes.CurrentRow.Index;
         int id = Convert.ToInt32(dtgOrdenes.Rows[indice].Cells[0].Value);
         using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
         {
            var lstDetalle = db.DetallesOrden.Where(d => d.id_orden == id);
            List<DetallesOrden> dtOrden = lstDetalle.ToList();

            foreach (var item in dtOrden)
            {
               lblDetalles.Text += "Producto: " + item.Productos.nombre + "\n";
               lblDetalles.Text += "Cantidad: " + item.cantidad + "\n";
               lblDetalles.Text += "Subtotal: $" + Math.Round(item.sub_total, 2) + "\n";
               lblDetalles.Text += "\n";
            }
         }
      }

      // Filtra las ordenes por estado
      private void cbxEstados_SelectedIndexChanged(object sender, EventArgs e)
      {
         string estado = cbxEstados.SelectedItem.ToString();
         using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
         {
            List<Ordenes> lstOrdenes = null;
            lstOrdenes = db.Ordenes.Where(es => es.Estados.descripcion == estado).ToList();

            if (lstOrdenes != null)
            {
               List<OrdenMostrar> lstMostrar = new List<OrdenMostrar>();

               foreach (var item in lstOrdenes)
               {
                  OrdenMostrar om = new OrdenMostrar();
                  om.id = item.id;
                  om.estado = item.Estados.descripcion;
                  om.observacion = item.observacion;
                  om.total = item.total;
                  om.nombre = item.Clientes.nombre;
                  om.direccion = item.Domicilios.direccion;
                  om.fecha = item.fecha;
                  om.hora = item.hora;
                  lstMostrar.Add(om);
               }

              // dtgOrdenes.Rows.Clear();

               dtgOrdenes.DataSource = lstMostrar;

               if (dtgOrdenes.Rows.Count == 0) lblDetalles.Text = "DETALLE DE ORDEN: \n\n";
            }           
         }
      }

      private void btnEliminarDir_Click(object sender, EventArgs e)
      {
         using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
         {
            string direccion = cbxDireccion.Text;
            var dom = db.Domicilios.FirstOrDefault(d => d.direccion == direccion);
            if (dom != null)
            {
               db.Domicilios.Remove(dom);
               db.SaveChanges();
            }            
         }
         completarCampos();
      }

      private void btnTomarPedido_Click(object sender, EventArgs e)
      {
         if (ValidarCamposVacios())
         {
            using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
            {
               Clientes cliente = db.Clientes.FirstOrDefault(c => c.telfono == txtTelefono.Text);
               cliente.nombre = txtNombre.Text;
               cliente.observacion = txtObservacionCli.Text;
               db.SaveChanges();
               string direccion = cbxDireccion.Text;

               FrmPedidos frmp = new FrmPedidos(cliente, direccion);
               frmp.Show();
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
         if (cbxDireccion.Text == "")
         {
            MessageBox.Show("Debe Agregar una dirección");
            txtAddDireccion.Focus();
            return false;
         }
         return true;
      }
   }
}
