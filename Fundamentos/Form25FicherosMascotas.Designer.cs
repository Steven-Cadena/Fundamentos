
namespace Fundamentos
{
    partial class Form25FicherosMascotas
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
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.btnLeerRegistro = new System.Windows.Forms.Button();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.btnGuardarRegistros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Location = new System.Drawing.Point(43, 202);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(100, 23);
            this.btnNuevoRegistro.TabIndex = 0;
            this.btnNuevoRegistro.Text = "Nuevo Registro";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(43, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(43, 146);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 23);
            this.txtRaza.TabIndex = 3;
            // 
            // btnLeerRegistro
            // 
            this.btnLeerRegistro.Location = new System.Drawing.Point(43, 248);
            this.btnLeerRegistro.Name = "btnLeerRegistro";
            this.btnLeerRegistro.Size = new System.Drawing.Size(100, 23);
            this.btnLeerRegistro.TabIndex = 2;
            this.btnLeerRegistro.Text = "Leer Registro";
            this.btnLeerRegistro.UseVisualStyleBackColor = true;
            this.btnLeerRegistro.Click += new System.EventHandler(this.btnLeerRegistro_Click);
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 15;
            this.lstMascotas.Location = new System.Drawing.Point(202, 77);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(203, 334);
            this.lstMascotas.TabIndex = 4;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // btnGuardarRegistros
            // 
            this.btnGuardarRegistros.Location = new System.Drawing.Point(43, 294);
            this.btnGuardarRegistros.Name = "btnGuardarRegistros";
            this.btnGuardarRegistros.Size = new System.Drawing.Size(100, 47);
            this.btnGuardarRegistros.TabIndex = 5;
            this.btnGuardarRegistros.Text = "Guardar Registros";
            this.btnGuardarRegistros.UseVisualStyleBackColor = true;
            this.btnGuardarRegistros.Click += new System.EventHandler(this.btnGuardarRegistros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Raza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mascotas:";
            // 
            // Form25FicherosMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarRegistros);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.btnLeerRegistro);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Name = "Form25FicherosMascotas";
            this.Text = "Form25FicherosMascotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Button btnLeerRegistro;
        private System.Windows.Forms.ListBox lstMascotas;
        private System.Windows.Forms.Button btnGuardarRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}