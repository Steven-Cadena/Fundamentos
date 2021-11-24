
namespace Fundamentos
{
    partial class Form07ValidarMail
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnValidarMail = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(146, 99);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(155, 23);
            this.txtMail.TabIndex = 1;
            this.txtMail.Text = "steven@gmail.com";
            // 
            // btnValidarMail
            // 
            this.btnValidarMail.Location = new System.Drawing.Point(146, 167);
            this.btnValidarMail.Name = "btnValidarMail";
            this.btnValidarMail.Size = new System.Drawing.Size(100, 23);
            this.btnValidarMail.TabIndex = 2;
            this.btnValidarMail.Text = "Validar Mail";
            this.btnValidarMail.UseVisualStyleBackColor = true;
            this.btnValidarMail.Click += new System.EventHandler(this.btnValidarMail_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(146, 228);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(59, 15);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // Form07ValidarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnValidarMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Name = "Form07ValidarMail";
            this.Text = "Form07ValidarMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnValidarMail;
        private System.Windows.Forms.Label lblResultado;
    }
}