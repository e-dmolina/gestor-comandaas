using GestorDeComandas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeComandas
{
   public partial class FrmPedidos : Form
   {
      private Clientes cliente;
      private string direccion;
      public FrmPedidos()
      {
         InitializeComponent();
      }

      public FrmPedidos(Clientes cliente, string direccion)
      {
         InitializeComponent();
         this.cliente = cliente;
         this.direccion = direccion;
      }
      private void FrmPedidos_Load(object sender, EventArgs e)
      {
         cargarCombo();
         lblCliente.Text = "Cliente: " + cliente.nombre + "\n" +
                           "Telefono: " + cliente.telfono + "\n" +
                           "Dirección: " + direccion;
         
      }

      private void cargarCombo()
      {
         using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
         {
            List<Categorias> lstCategorias = db.Categorias.ToList();

            foreach (var item in lstCategorias)
            {
               cbxCategorias.Items.Add(item.descripcion);
               cbxCategorias.SelectedIndex = 0;
            }
         }
      }
      private void cbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
      {
         ltbProductos.Items.Clear();
         using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
         {
            Categorias categoria = db.Categorias.FirstOrDefault(c => c.descripcion == cbxCategorias.Text);

            List<Productos> lstProductos = db.Productos.Where(p => p.id_categoria == categoria.id).ToList();

            if (lstProductos != null)
            {
               foreach (var item in lstProductos)
               {
                  ltbProductos.Items.Add(item.nombre);
               }
            }         
             
         }
      }

      private void ltbProductos_SelectedIndexChanged(object sender, EventArgs e)
      {
         using (FocacciaComandasDBEntities db = new FocacciaComandasDBEntities())
         {
            Productos prd = db.Productos.FirstOrDefault(p => p.nombre == ltbProductos.SelectedItem.ToString());
            lblInfo.Text = "Info: \n" + prd.descripcion;
         }
      }

      private void btnAgregar_Click(object sender, EventArgs e)
      {
         string descripcion = ltbProductos.Text;
         
      }

      private void btnGuardarImprimir_Click(object sender, EventArgs e)
      {
         printDocument1 = new PrintDocument();
         PrinterSettings ps = new PrinterSettings();
         printDocument1.PrinterSettings = ps;
         printDocument1.PrintPage += Imprimir;
         printDocument1.Print();
      }

      private void Imprimir(object sender, PrintPageEventArgs e)
      {
         Font font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
         e.Graphics.DrawString("Focaccia", font, Brushes.Black, new RectangleF(15, 20, 200, 20));
         e.Graphics.DrawString("------------------------", font, Brushes.Black, new RectangleF(5, 40, 200, 20));
         e.Graphics.DrawString("Orden Nº: ", font, Brushes.Black, new RectangleF(5, 60, 200, 20));
         e.Graphics.DrawString("Cliente: " + cliente.nombre, font, Brushes.Black, new RectangleF(5, 80, 200, 20));
         e.Graphics.DrawString("Fecha: " + DateTime.Today.Day, font, Brushes.Black, new RectangleF(5, 100, 200, 20));
         e.Graphics.DrawString("Hora: " + DateTime.Today.Hour, font, Brushes.Black, new RectangleF(5, 120, 200, 20));
         e.Graphics.DrawString("Dirección:", font, Brushes.Black, new RectangleF(5, 140, 200, 20));
         e.Graphics.DrawString(direccion, font, Brushes.Black, new RectangleF(5, 160, 200, 20));
         e.Graphics.DrawString("Teléfono: " + cliente.telfono, font, Brushes.Black, new RectangleF(5, 180, 200, 20));
         e.Graphics.DrawString("Detalles:", font, Brushes.Black, new RectangleF(5, 220, 200, 20));
      }
   }
}
