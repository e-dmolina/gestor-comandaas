namespace GestorDeComandas
{
   partial class FrmPedidos
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.cbxCategorias = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.lblInfo = new System.Windows.Forms.Label();
         this.btnAgregar = new System.Windows.Forms.Button();
         this.btnQuitar = new System.Windows.Forms.Button();
         this.ltbProductos = new System.Windows.Forms.ListBox();
         this.lblCliente = new System.Windows.Forms.Label();
         this.dtgDetalles = new System.Windows.Forms.DataGridView();
         this.btnGuardarImprimir = new System.Windows.Forms.Button();
         this.printDocument1 = new System.Drawing.Printing.PrintDocument();
         ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).BeginInit();
         this.SuspendLayout();
         // 
         // cbxCategorias
         // 
         this.cbxCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cbxCategorias.FormattingEnabled = true;
         this.cbxCategorias.Location = new System.Drawing.Point(64, 65);
         this.cbxCategorias.Name = "cbxCategorias";
         this.cbxCategorias.Size = new System.Drawing.Size(121, 28);
         this.cbxCategorias.TabIndex = 0;
         this.cbxCategorias.SelectedIndexChanged += new System.EventHandler(this.cbxCategorias_SelectedIndexChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(60, 42);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(92, 20);
         this.label1.TabIndex = 1;
         this.label1.Text = "Categoría:";
         // 
         // lblInfo
         // 
         this.lblInfo.AutoSize = true;
         this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblInfo.Location = new System.Drawing.Point(60, 287);
         this.lblInfo.Name = "lblInfo";
         this.lblInfo.Size = new System.Drawing.Size(46, 20);
         this.lblInfo.TabIndex = 4;
         this.lblInfo.Text = "Info:";
         // 
         // btnAgregar
         // 
         this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAgregar.Location = new System.Drawing.Point(485, 158);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(49, 27);
         this.btnAgregar.TabIndex = 5;
         this.btnAgregar.Text = ">";
         this.btnAgregar.UseVisualStyleBackColor = true;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // btnQuitar
         // 
         this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnQuitar.Location = new System.Drawing.Point(485, 203);
         this.btnQuitar.Name = "btnQuitar";
         this.btnQuitar.Size = new System.Drawing.Size(49, 27);
         this.btnQuitar.TabIndex = 6;
         this.btnQuitar.Text = "<";
         this.btnQuitar.UseVisualStyleBackColor = true;
         // 
         // ltbProductos
         // 
         this.ltbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ltbProductos.FormattingEnabled = true;
         this.ltbProductos.ItemHeight = 20;
         this.ltbProductos.Location = new System.Drawing.Point(64, 132);
         this.ltbProductos.Name = "ltbProductos";
         this.ltbProductos.Size = new System.Drawing.Size(310, 124);
         this.ltbProductos.TabIndex = 7;
         this.ltbProductos.SelectedIndexChanged += new System.EventHandler(this.ltbProductos_SelectedIndexChanged);
         // 
         // lblCliente
         // 
         this.lblCliente.AutoSize = true;
         this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCliente.Location = new System.Drawing.Point(703, 42);
         this.lblCliente.Name = "lblCliente";
         this.lblCliente.Size = new System.Drawing.Size(75, 20);
         this.lblCliente.TabIndex = 8;
         this.lblCliente.Text = "Cliente: ";
         // 
         // dtgDetalles
         // 
         this.dtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtgDetalles.Location = new System.Drawing.Point(562, 132);
         this.dtgDetalles.Name = "dtgDetalles";
         this.dtgDetalles.Size = new System.Drawing.Size(389, 175);
         this.dtgDetalles.TabIndex = 9;
         // 
         // btnGuardarImprimir
         // 
         this.btnGuardarImprimir.Location = new System.Drawing.Point(478, 419);
         this.btnGuardarImprimir.Name = "btnGuardarImprimir";
         this.btnGuardarImprimir.Size = new System.Drawing.Size(104, 23);
         this.btnGuardarImprimir.TabIndex = 10;
         this.btnGuardarImprimir.Text = "Guardar e Imprimir";
         this.btnGuardarImprimir.UseVisualStyleBackColor = true;
         this.btnGuardarImprimir.Click += new System.EventHandler(this.btnGuardarImprimir_Click);
         // 
         // FrmPedidos
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1088, 634);
         this.Controls.Add(this.btnGuardarImprimir);
         this.Controls.Add(this.dtgDetalles);
         this.Controls.Add(this.lblCliente);
         this.Controls.Add(this.ltbProductos);
         this.Controls.Add(this.btnQuitar);
         this.Controls.Add(this.btnAgregar);
         this.Controls.Add(this.lblInfo);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cbxCategorias);
         this.Name = "FrmPedidos";
         this.Text = "FrmPedidos";
         this.Load += new System.EventHandler(this.FrmPedidos_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox cbxCategorias;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblInfo;
      private System.Windows.Forms.Button btnAgregar;
      private System.Windows.Forms.Button btnQuitar;
      private System.Windows.Forms.ListBox ltbProductos;
      private System.Windows.Forms.Label lblCliente;
      private System.Windows.Forms.DataGridView dtgDetalles;
      private System.Windows.Forms.Button btnGuardarImprimir;
      private System.Drawing.Printing.PrintDocument printDocument1;
   }
}