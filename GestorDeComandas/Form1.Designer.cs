namespace GestorDeComandas
{
   partial class Form1
   {
      /// <summary>
      /// Variable del diseñador necesaria.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpiar los recursos que se estén usando.
      /// </summary>
      /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código generado por el Diseñador de Windows Forms

      /// <summary>
      /// Método necesario para admitir el Diseñador. No se puede modificar
      /// el contenido de este método con el editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.lblDetalles = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.cbxEstados = new System.Windows.Forms.ComboBox();
         this.dtgOrdenes = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.btnLimpiar = new System.Windows.Forms.Button();
         this.btnTomarPedido = new System.Windows.Forms.Button();
         this.btnAddDir = new System.Windows.Forms.Button();
         this.btnEliminarDir = new System.Windows.Forms.Button();
         this.btnBuscar = new System.Windows.Forms.Button();
         this.label8 = new System.Windows.Forms.Label();
         this.cbxDireccion = new System.Windows.Forms.ComboBox();
         this.txtObservacionCli = new System.Windows.Forms.TextBox();
         this.txtAddDireccion = new System.Windows.Forms.TextBox();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.txtTelefono = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenes)).BeginInit();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.lblDetalles);
         this.splitContainer1.Panel1.Controls.Add(this.label7);
         this.splitContainer1.Panel1.Controls.Add(this.cbxEstados);
         this.splitContainer1.Panel1.Controls.Add(this.dtgOrdenes);
         this.splitContainer1.Panel1.Controls.Add(this.label1);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.btnLimpiar);
         this.splitContainer1.Panel2.Controls.Add(this.btnTomarPedido);
         this.splitContainer1.Panel2.Controls.Add(this.btnAddDir);
         this.splitContainer1.Panel2.Controls.Add(this.btnEliminarDir);
         this.splitContainer1.Panel2.Controls.Add(this.btnBuscar);
         this.splitContainer1.Panel2.Controls.Add(this.label8);
         this.splitContainer1.Panel2.Controls.Add(this.cbxDireccion);
         this.splitContainer1.Panel2.Controls.Add(this.txtObservacionCli);
         this.splitContainer1.Panel2.Controls.Add(this.txtAddDireccion);
         this.splitContainer1.Panel2.Controls.Add(this.txtNombre);
         this.splitContainer1.Panel2.Controls.Add(this.txtTelefono);
         this.splitContainer1.Panel2.Controls.Add(this.label6);
         this.splitContainer1.Panel2.Controls.Add(this.label5);
         this.splitContainer1.Panel2.Controls.Add(this.label4);
         this.splitContainer1.Panel2.Controls.Add(this.label3);
         this.splitContainer1.Panel2.Controls.Add(this.label2);
         this.splitContainer1.Size = new System.Drawing.Size(1243, 556);
         this.splitContainer1.SplitterDistance = 796;
         this.splitContainer1.TabIndex = 0;
         // 
         // lblDetalles
         // 
         this.lblDetalles.AutoSize = true;
         this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDetalles.Location = new System.Drawing.Point(23, 386);
         this.lblDetalles.Name = "lblDetalles";
         this.lblDetalles.Size = new System.Drawing.Size(80, 20);
         this.lblDetalles.TabIndex = 12;
         this.lblDetalles.Text = "Detalles:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(23, 349);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(152, 20);
         this.label7.TabIndex = 11;
         this.label7.Text = "Filtrar por estado:";
         // 
         // cbxEstados
         // 
         this.cbxEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cbxEstados.FormattingEnabled = true;
         this.cbxEstados.Location = new System.Drawing.Point(181, 349);
         this.cbxEstados.Name = "cbxEstados";
         this.cbxEstados.Size = new System.Drawing.Size(128, 28);
         this.cbxEstados.TabIndex = 11;
         this.cbxEstados.SelectedIndexChanged += new System.EventHandler(this.cbxEstados_SelectedIndexChanged);
         // 
         // dtgOrdenes
         // 
         this.dtgOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dtgOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtgOrdenes.Location = new System.Drawing.Point(27, 82);
         this.dtgOrdenes.MultiSelect = false;
         this.dtgOrdenes.Name = "dtgOrdenes";
         this.dtgOrdenes.ReadOnly = true;
         this.dtgOrdenes.RowHeadersVisible = false;
         this.dtgOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dtgOrdenes.Size = new System.Drawing.Size(720, 248);
         this.dtgOrdenes.TabIndex = 1;
         this.dtgOrdenes.SelectionChanged += new System.EventHandler(this.dtgOrdenes_SelectionChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(293, 36);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(193, 24);
         this.label1.TabIndex = 0;
         this.label1.Text = "Listado de Ordenes";
         // 
         // btnLimpiar
         // 
         this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLimpiar.Location = new System.Drawing.Point(252, 440);
         this.btnLimpiar.Name = "btnLimpiar";
         this.btnLimpiar.Size = new System.Drawing.Size(127, 27);
         this.btnLimpiar.TabIndex = 16;
         this.btnLimpiar.Text = "Limpiar";
         this.btnLimpiar.UseVisualStyleBackColor = true;
         this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
         // 
         // btnTomarPedido
         // 
         this.btnTomarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnTomarPedido.Location = new System.Drawing.Point(71, 440);
         this.btnTomarPedido.Name = "btnTomarPedido";
         this.btnTomarPedido.Size = new System.Drawing.Size(127, 27);
         this.btnTomarPedido.TabIndex = 15;
         this.btnTomarPedido.Text = "Tomar pedido";
         this.btnTomarPedido.UseVisualStyleBackColor = true;
         this.btnTomarPedido.Click += new System.EventHandler(this.btnTomarPedido_Click);
         // 
         // btnAddDir
         // 
         this.btnAddDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAddDir.ForeColor = System.Drawing.Color.Lime;
         this.btnAddDir.Location = new System.Drawing.Point(352, 258);
         this.btnAddDir.Name = "btnAddDir";
         this.btnAddDir.Size = new System.Drawing.Size(27, 27);
         this.btnAddDir.TabIndex = 14;
         this.btnAddDir.Text = "V";
         this.btnAddDir.UseVisualStyleBackColor = true;
         this.btnAddDir.Click += new System.EventHandler(this.btnAddDir_Click);
         // 
         // btnEliminarDir
         // 
         this.btnEliminarDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnEliminarDir.ForeColor = System.Drawing.Color.Red;
         this.btnEliminarDir.Location = new System.Drawing.Point(352, 184);
         this.btnEliminarDir.Name = "btnEliminarDir";
         this.btnEliminarDir.Size = new System.Drawing.Size(27, 27);
         this.btnEliminarDir.TabIndex = 13;
         this.btnEliminarDir.Text = "X";
         this.btnEliminarDir.UseVisualStyleBackColor = true;
         this.btnEliminarDir.Click += new System.EventHandler(this.btnEliminarDir_Click);
         // 
         // btnBuscar
         // 
         this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnBuscar.Location = new System.Drawing.Point(173, 105);
         this.btnBuscar.Name = "btnBuscar";
         this.btnBuscar.Size = new System.Drawing.Size(74, 27);
         this.btnBuscar.TabIndex = 12;
         this.btnBuscar.Text = "Buscar";
         this.btnBuscar.UseVisualStyleBackColor = true;
         this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.Location = new System.Drawing.Point(67, 310);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(254, 20);
         this.label8.TabIndex = 11;
         this.label8.Text = "Observaciones sobre el cliente";
         // 
         // cbxDireccion
         // 
         this.cbxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cbxDireccion.FormattingEnabled = true;
         this.cbxDireccion.Location = new System.Drawing.Point(71, 181);
         this.cbxDireccion.Name = "cbxDireccion";
         this.cbxDireccion.Size = new System.Drawing.Size(275, 28);
         this.cbxDireccion.TabIndex = 10;
         // 
         // txtObservacionCli
         // 
         this.txtObservacionCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtObservacionCli.Location = new System.Drawing.Point(71, 333);
         this.txtObservacionCli.Multiline = true;
         this.txtObservacionCli.Name = "txtObservacionCli";
         this.txtObservacionCli.Size = new System.Drawing.Size(308, 84);
         this.txtObservacionCli.TabIndex = 9;
         // 
         // txtAddDireccion
         // 
         this.txtAddDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtAddDireccion.Location = new System.Drawing.Point(71, 257);
         this.txtAddDireccion.Name = "txtAddDireccion";
         this.txtAddDireccion.Size = new System.Drawing.Size(275, 26);
         this.txtAddDireccion.TabIndex = 8;
         // 
         // txtNombre
         // 
         this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNombre.Location = new System.Drawing.Point(255, 105);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(124, 26);
         this.txtNombre.TabIndex = 7;
         // 
         // txtTelefono
         // 
         this.txtTelefono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
         this.txtTelefono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
         this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtTelefono.Location = new System.Drawing.Point(71, 106);
         this.txtTelefono.Name = "txtTelefono";
         this.txtTelefono.Size = new System.Drawing.Size(100, 26);
         this.txtTelefono.TabIndex = 6;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(67, 234);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(203, 20);
         this.label6.TabIndex = 5;
         this.label6.Text = "Agregar nueva dirección";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(67, 158);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(84, 20);
         this.label5.TabIndex = 4;
         this.label5.Text = "Dirección";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(67, 82);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(79, 20);
         this.label4.TabIndex = 3;
         this.label4.Text = "Teléfono";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(251, 82);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(71, 20);
         this.label3.TabIndex = 2;
         this.label3.Text = "Nombre";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(186, 36);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(75, 24);
         this.label2.TabIndex = 1;
         this.label2.Text = "Cliente";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1243, 556);
         this.Controls.Add(this.splitContainer1);
         this.Name = "Form1";
         this.Text = "Gestor de Comandas";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.Form1_Load);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         this.splitContainer1.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenes)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.DataGridView dtgOrdenes;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtObservacionCli;
      private System.Windows.Forms.TextBox txtAddDireccion;
      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.TextBox txtTelefono;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.ComboBox cbxEstados;
      private System.Windows.Forms.ComboBox cbxDireccion;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Button btnAddDir;
      private System.Windows.Forms.Button btnEliminarDir;
      private System.Windows.Forms.Button btnBuscar;
      private System.Windows.Forms.Button btnLimpiar;
      private System.Windows.Forms.Button btnTomarPedido;
      private System.Windows.Forms.Label lblDetalles;
   }
}

