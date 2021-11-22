
namespace Fundamentos
{
    partial class Form04DiaNacimiento
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnyo = new System.Windows.Forms.TextBox();
            this.btnCalcularDia = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(121, 38);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 23);
            this.txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(121, 76);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 23);
            this.txtMes.TabIndex = 4;
            // 
            // txtAnyo
            // 
            this.txtAnyo.Location = new System.Drawing.Point(121, 118);
            this.txtAnyo.Name = "txtAnyo";
            this.txtAnyo.Size = new System.Drawing.Size(100, 23);
            this.txtAnyo.TabIndex = 5;
            // 
            // btnCalcularDia
            // 
            this.btnCalcularDia.Location = new System.Drawing.Point(257, 61);
            this.btnCalcularDia.Name = "btnCalcularDia";
            this.btnCalcularDia.Size = new System.Drawing.Size(96, 60);
            this.btnCalcularDia.TabIndex = 6;
            this.btnCalcularDia.Text = "Calcular Día";
            this.btnCalcularDia.UseVisualStyleBackColor = true;
            this.btnCalcularDia.Click += new System.EventHandler(this.btnCalcularDia_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(121, 182);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 15);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "lblResultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Día";
            // 
            // Form04DiaNacimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularDia);
            this.Controls.Add(this.txtAnyo);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form04DiaNacimiento";
            this.Text = "Form04DiaNacimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnyo;
        private System.Windows.Forms.Button btnCalcularDia;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
    }
}