﻿
namespace Fundamentos
{
    partial class Form06ClaseChar
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
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSimbolos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letras";
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(110, 82);
            this.txtLetras.Multiline = true;
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(220, 150);
            this.txtLetras.TabIndex = 1;
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(326, 461);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(116, 23);
            this.btnAnalizar.TabIndex = 2;
            this.btnAnalizar.Text = "Analizar ASCII";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(438, 82);
            this.txtNumeros.Multiline = true;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(220, 150);
            this.txtNumeros.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Números";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(438, 277);
            this.txtPuntuacion.Multiline = true;
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(220, 150);
            this.txtPuntuacion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puntuación";
            // 
            // txtSimbolos
            // 
            this.txtSimbolos.Location = new System.Drawing.Point(110, 277);
            this.txtSimbolos.Multiline = true;
            this.txtSimbolos.Name = "txtSimbolos";
            this.txtSimbolos.Size = new System.Drawing.Size(220, 150);
            this.txtSimbolos.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Símbolos";
            // 
            // Form06ClaseChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 519);
            this.Controls.Add(this.txtSimbolos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.label1);
            this.Name = "Form06ClaseChar";
            this.Text = "Form06ClaseChar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLetras;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSimbolos;
        private System.Windows.Forms.Label label4;
    }
}