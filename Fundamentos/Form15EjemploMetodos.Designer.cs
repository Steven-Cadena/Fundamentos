
namespace Fundamentos
{
    partial class Form15EjemploMetodos
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnDobleValor = new System.Windows.Forms.Button();
            this.btnDobleReferencia = new System.Windows.Forms.Button();
            this.btnMetodoClaseReferencia = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoloNumeros = new System.Windows.Forms.TextBox();
            this.txtSoloLetras = new System.Windows.Forms.TextBox();
            this.lblMouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(109, 54);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 1;
            // 
            // btnDobleValor
            // 
            this.btnDobleValor.Location = new System.Drawing.Point(62, 102);
            this.btnDobleValor.Name = "btnDobleValor";
            this.btnDobleValor.Size = new System.Drawing.Size(147, 23);
            this.btnDobleValor.TabIndex = 2;
            this.btnDobleValor.Text = "Doble Valor";
            this.btnDobleValor.UseVisualStyleBackColor = true;
            this.btnDobleValor.Click += new System.EventHandler(this.btnDobleValor_Click);
            // 
            // btnDobleReferencia
            // 
            this.btnDobleReferencia.Location = new System.Drawing.Point(62, 145);
            this.btnDobleReferencia.Name = "btnDobleReferencia";
            this.btnDobleReferencia.Size = new System.Drawing.Size(147, 23);
            this.btnDobleReferencia.TabIndex = 3;
            this.btnDobleReferencia.Text = "Doble Referencia";
            this.btnDobleReferencia.UseVisualStyleBackColor = true;
            this.btnDobleReferencia.Click += new System.EventHandler(this.btnDobleReferencia_Click);
            // 
            // btnMetodoClaseReferencia
            // 
            this.btnMetodoClaseReferencia.Location = new System.Drawing.Point(62, 189);
            this.btnMetodoClaseReferencia.Name = "btnMetodoClaseReferencia";
            this.btnMetodoClaseReferencia.Size = new System.Drawing.Size(147, 47);
            this.btnMetodoClaseReferencia.TabIndex = 4;
            this.btnMetodoClaseReferencia.Text = "Método Clase Referencia";
            this.btnMetodoClaseReferencia.UseVisualStyleBackColor = true;
            this.btnMetodoClaseReferencia.Click += new System.EventHandler(this.btnMetodoClaseReferencia_Click);
            this.btnMetodoClaseReferencia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMetodoClaseReferencia_MouseMove);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblResultado.Location = new System.Drawing.Point(62, 239);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 15);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "lblResultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Solo Números";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Solo Letras";
            // 
            // txtSoloNumeros
            // 
            this.txtSoloNumeros.Location = new System.Drawing.Point(325, 54);
            this.txtSoloNumeros.Name = "txtSoloNumeros";
            this.txtSoloNumeros.Size = new System.Drawing.Size(100, 23);
            this.txtSoloNumeros.TabIndex = 8;
            this.txtSoloNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // txtSoloLetras
            // 
            this.txtSoloLetras.Location = new System.Drawing.Point(325, 99);
            this.txtSoloLetras.Name = "txtSoloLetras";
            this.txtSoloLetras.Size = new System.Drawing.Size(100, 23);
            this.txtSoloLetras.TabIndex = 9;
            this.txtSoloLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloLetras_KeyPress);
            // 
            // lblMouse
            // 
            this.lblMouse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMouse.Location = new System.Drawing.Point(246, 145);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(199, 215);
            this.lblMouse.TabIndex = 10;
            this.lblMouse.Text = "lblMouse";
            this.lblMouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouse_MouseMove);
            // 
            // Form15EjemploMetodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 369);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.txtSoloLetras);
            this.Controls.Add(this.txtSoloNumeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMetodoClaseReferencia);
            this.Controls.Add(this.btnDobleReferencia);
            this.Controls.Add(this.btnDobleValor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form15EjemploMetodos";
            this.Text = "Form15EjemploMetodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnDobleValor;
        private System.Windows.Forms.Button btnDobleReferencia;
        private System.Windows.Forms.Button btnMetodoClaseReferencia;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoloNumeros;
        private System.Windows.Forms.TextBox txtSoloLetras;
        private System.Windows.Forms.Label lblMouse;
    }
}