
namespace Fundamentos
{
    partial class Form10ValidarISBN
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
            this.btnComprobarISBN = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número ISBN: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(213, 60);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.Text = "8441513929";
            // 
            // btnComprobarISBN
            // 
            this.btnComprobarISBN.Location = new System.Drawing.Point(141, 116);
            this.btnComprobarISBN.Name = "btnComprobarISBN";
            this.btnComprobarISBN.Size = new System.Drawing.Size(113, 23);
            this.btnComprobarISBN.TabIndex = 2;
            this.btnComprobarISBN.Text = "Comprobar ISBN";
            this.btnComprobarISBN.UseVisualStyleBackColor = true;
            this.btnComprobarISBN.Click += new System.EventHandler(this.btnComprobarISBN_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.Color.Blue;
            this.lblResultado.Location = new System.Drawing.Point(158, 177);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 15);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "lblResultado";
            // 
            // Form10ValidarISBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnComprobarISBN);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form10ValidarISBN";
            this.Text = "Form10ValidarISBN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnComprobarISBN;
        private System.Windows.Forms.Label lblResultado;
    }
}