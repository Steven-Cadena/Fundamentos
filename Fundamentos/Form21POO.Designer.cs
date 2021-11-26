
namespace Fundamentos
{
    partial class Form21POO
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
            this.btnInstanciarPersona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPropiedades = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnInstanciarPersona
            // 
            this.btnInstanciarPersona.Location = new System.Drawing.Point(51, 48);
            this.btnInstanciarPersona.Name = "btnInstanciarPersona";
            this.btnInstanciarPersona.Size = new System.Drawing.Size(85, 45);
            this.btnInstanciarPersona.TabIndex = 0;
            this.btnInstanciarPersona.Text = "Instanciar Persona";
            this.btnInstanciarPersona.UseVisualStyleBackColor = true;
            this.btnInstanciarPersona.Click += new System.EventHandler(this.btnInstanciarPersona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propiedades";
            // 
            // lstPropiedades
            // 
            this.lstPropiedades.FormattingEnabled = true;
            this.lstPropiedades.ItemHeight = 15;
            this.lstPropiedades.Location = new System.Drawing.Point(178, 84);
            this.lstPropiedades.Name = "lstPropiedades";
            this.lstPropiedades.Size = new System.Drawing.Size(231, 94);
            this.lstPropiedades.TabIndex = 2;
            // 
            // Form21POO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPropiedades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstanciarPersona);
            this.Name = "Form21POO";
            this.Text = "Form21POO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstanciarPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPropiedades;
    }
}