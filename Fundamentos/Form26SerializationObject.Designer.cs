
namespace Fundamentos
{
    partial class Form26SerializationObject
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtAnyos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.btnLeerDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(42, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(42, 139);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 23);
            this.txtRaza.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(42, 111);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(31, 15);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Raza";
            // 
            // txtAnyos
            // 
            this.txtAnyos.Location = new System.Drawing.Point(42, 218);
            this.txtAnyos.Name = "txtAnyos";
            this.txtAnyos.Size = new System.Drawing.Size(51, 23);
            this.txtAnyos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Años";
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Location = new System.Drawing.Point(191, 31);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(98, 51);
            this.btnGuardarDatos.TabIndex = 6;
            this.btnGuardarDatos.Text = "Guardar Datos";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // btnLeerDatos
            // 
            this.btnLeerDatos.Location = new System.Drawing.Point(191, 122);
            this.btnLeerDatos.Name = "btnLeerDatos";
            this.btnLeerDatos.Size = new System.Drawing.Size(98, 54);
            this.btnLeerDatos.TabIndex = 7;
            this.btnLeerDatos.Text = "Leer Datos";
            this.btnLeerDatos.UseVisualStyleBackColor = true;
            this.btnLeerDatos.Click += new System.EventHandler(this.btnLeerDatos_Click);
            // 
            // Form26SerializationObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 277);
            this.Controls.Add(this.btnLeerDatos);
            this.Controls.Add(this.btnGuardarDatos);
            this.Controls.Add(this.txtAnyos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form26SerializationObject";
            this.Text = "Form26Serializationp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtAnyos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Button btnLeerDatos;
    }
}