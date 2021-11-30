
namespace Fundamentos
{
    partial class Form27SerializationList
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarRegistros = new System.Windows.Forms.Button();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.btnLeerRegistro = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnyos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mascotas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Raza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre: ";
            // 
            // btnGuardarRegistros
            // 
            this.btnGuardarRegistros.Location = new System.Drawing.Point(60, 354);
            this.btnGuardarRegistros.Name = "btnGuardarRegistros";
            this.btnGuardarRegistros.Size = new System.Drawing.Size(100, 47);
            this.btnGuardarRegistros.TabIndex = 14;
            this.btnGuardarRegistros.Text = "Guardar Registros";
            this.btnGuardarRegistros.UseVisualStyleBackColor = true;
            this.btnGuardarRegistros.Click += new System.EventHandler(this.btnGuardarRegistros_Click);
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 15;
            this.lstMascotas.Location = new System.Drawing.Point(219, 67);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(203, 334);
            this.lstMascotas.TabIndex = 13;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(60, 136);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 23);
            this.txtRaza.TabIndex = 12;
            // 
            // btnLeerRegistro
            // 
            this.btnLeerRegistro.Location = new System.Drawing.Point(60, 308);
            this.btnLeerRegistro.Name = "btnLeerRegistro";
            this.btnLeerRegistro.Size = new System.Drawing.Size(100, 23);
            this.btnLeerRegistro.TabIndex = 11;
            this.btnLeerRegistro.Text = "Leer Registro";
            this.btnLeerRegistro.UseVisualStyleBackColor = true;
            this.btnLeerRegistro.Click += new System.EventHandler(this.btnLeerRegistro_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(60, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 10;
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Location = new System.Drawing.Point(60, 262);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(100, 23);
            this.btnNuevoRegistro.TabIndex = 9;
            this.btnNuevoRegistro.Text = "Nuevo Registro";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Años";
            // 
            // txtAnyos
            // 
            this.txtAnyos.Location = new System.Drawing.Point(60, 209);
            this.txtAnyos.Name = "txtAnyos";
            this.txtAnyos.Size = new System.Drawing.Size(100, 23);
            this.txtAnyos.TabIndex = 19;
            // 
            // Form27SerializationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 455);
            this.Controls.Add(this.txtAnyos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarRegistros);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.btnLeerRegistro);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Name = "Form27SerializationList";
            this.Text = "Form27SerializationList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarRegistros;
        private System.Windows.Forms.ListBox lstMascotas;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Button btnLeerRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnyos;
    }
}