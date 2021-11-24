
namespace Fundamentos
{
    partial class Form08SumarNumerosString
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
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnSumarNumeros = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca números";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(70, 81);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(100, 23);
            this.txtNumeros.TabIndex = 1;
            // 
            // btnSumarNumeros
            // 
            this.btnSumarNumeros.Location = new System.Drawing.Point(70, 136);
            this.btnSumarNumeros.Name = "btnSumarNumeros";
            this.btnSumarNumeros.Size = new System.Drawing.Size(90, 23);
            this.btnSumarNumeros.TabIndex = 2;
            this.btnSumarNumeros.Text = "Sumar Números";
            this.btnSumarNumeros.UseVisualStyleBackColor = true;
            this.btnSumarNumeros.Click += new System.EventHandler(this.btnSumarNumeros_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(70, 200);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 15);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "lblResultado";
            // 
            // Form08SumarNumerosString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSumarNumeros);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label1);
            this.Name = "Form08SumarNumerosString";
            this.Text = "Form08SumarNumerosString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btnSumarNumeros;
        private System.Windows.Forms.Label lblResultado;
    }
}