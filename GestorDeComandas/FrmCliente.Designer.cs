namespace GestorDeComandas
{
   partial class FrmCliente
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
         this.label1 = new System.Windows.Forms.Label();
         this.btnGuardar = new System.Windows.Forms.Button();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.txtTelefono = new System.Windows.Forms.TextBox();
         this.txtDireccion = new System.Windows.Forms.TextBox();
         this.txtObservacionCli = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.btnCancelar = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(290, 39);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(142, 24);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nuevo Cliente";
         // 
         // btnGuardar
         // 
         this.btnGuardar.Location = new System.Drawing.Point(319, 379);
         this.btnGuardar.Name = "btnGuardar";
         this.btnGuardar.Size = new System.Drawing.Size(75, 23);
         this.btnGuardar.TabIndex = 1;
         this.btnGuardar.Text = "Guardar";
         this.btnGuardar.UseVisualStyleBackColor = true;
         this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
         // 
         // txtNombre
         // 
         this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNombre.Location = new System.Drawing.Point(294, 139);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(100, 26);
         this.txtNombre.TabIndex = 2;
         // 
         // txtTelefono
         // 
         this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtTelefono.Location = new System.Drawing.Point(294, 88);
         this.txtTelefono.Name = "txtTelefono";
         this.txtTelefono.Size = new System.Drawing.Size(100, 26);
         this.txtTelefono.TabIndex = 3;
         // 
         // txtDireccion
         // 
         this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDireccion.Location = new System.Drawing.Point(294, 190);
         this.txtDireccion.Name = "txtDireccion";
         this.txtDireccion.Size = new System.Drawing.Size(213, 26);
         this.txtDireccion.TabIndex = 4;
         // 
         // txtObservacionCli
         // 
         this.txtObservacionCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtObservacionCli.Location = new System.Drawing.Point(294, 243);
         this.txtObservacionCli.Multiline = true;
         this.txtObservacionCli.Name = "txtObservacionCli";
         this.txtObservacionCli.Size = new System.Drawing.Size(259, 70);
         this.txtObservacionCli.TabIndex = 5;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(189, 90);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(99, 24);
         this.label2.TabIndex = 6;
         this.label2.Text = "Teléfono:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(197, 141);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(91, 24);
         this.label3.TabIndex = 7;
         this.label3.Text = "Nombre:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(183, 192);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(105, 24);
         this.label4.TabIndex = 8;
         this.label4.Text = "Dirección:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(26, 243);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(262, 24);
         this.label5.TabIndex = 9;
         this.label5.Text = "Observaciones del Cliente:";
         // 
         // btnCancelar
         // 
         this.btnCancelar.Location = new System.Drawing.Point(415, 379);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(75, 23);
         this.btnCancelar.TabIndex = 10;
         this.btnCancelar.Text = "Salir";
         this.btnCancelar.UseVisualStyleBackColor = true;
         this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
         // 
         // FrmCliente
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(731, 472);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtObservacionCli);
         this.Controls.Add(this.txtDireccion);
         this.Controls.Add(this.txtTelefono);
         this.Controls.Add(this.txtNombre);
         this.Controls.Add(this.btnGuardar);
         this.Controls.Add(this.label1);
         this.Name = "FrmCliente";
         this.Text = "FrmCliente";
         this.Load += new System.EventHandler(this.FrmCliente_Load_1);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnGuardar;
      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.TextBox txtTelefono;
      private System.Windows.Forms.TextBox txtDireccion;
      private System.Windows.Forms.TextBox txtObservacionCli;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button btnCancelar;
   }
}