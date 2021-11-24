
namespace Fundamentos
{
    partial class Form09InvertirTextStringBuilder
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
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.btnInvertirString = new System.Windows.Forms.Button();
            this.btnInvertirStringBuilder = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(69, 80);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(506, 239);
            this.txtTexto.TabIndex = 2;
            this.txtTexto.Text = "";
            // 
            // btnInvertirString
            // 
            this.btnInvertirString.Location = new System.Drawing.Point(626, 80);
            this.btnInvertirString.Name = "btnInvertirString";
            this.btnInvertirString.Size = new System.Drawing.Size(121, 54);
            this.btnInvertirString.TabIndex = 3;
            this.btnInvertirString.Text = "Invertir String";
            this.btnInvertirString.UseVisualStyleBackColor = true;
            this.btnInvertirString.Click += new System.EventHandler(this.btnInvertirString_Click);
            // 
            // btnInvertirStringBuilder
            // 
            this.btnInvertirStringBuilder.Location = new System.Drawing.Point(626, 173);
            this.btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            this.btnInvertirStringBuilder.Size = new System.Drawing.Size(121, 54);
            this.btnInvertirStringBuilder.TabIndex = 4;
            this.btnInvertirStringBuilder.Text = "Invertir String Builder";
            this.btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            this.btnInvertirStringBuilder.Click += new System.EventHandler(this.btnInvertirStringBuilder_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.ForeColor = System.Drawing.Color.Red;
            this.lblTiempo.Location = new System.Drawing.Point(626, 259);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(60, 15);
            this.lblTiempo.TabIndex = 5;
            this.lblTiempo.Text = "lblTiempo";
            // 
            // Form09InvertirTextStringBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnInvertirStringBuilder);
            this.Controls.Add(this.btnInvertirString);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Name = "Form09InvertirTextStringBuilder";
            this.Text = "Form09InvertirTextStringBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.Button btnInvertirString;
        private System.Windows.Forms.Button btnInvertirStringBuilder;
        private System.Windows.Forms.Label lblTiempo;
    }
}