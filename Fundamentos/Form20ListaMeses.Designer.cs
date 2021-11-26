
namespace Fundamentos
{
    partial class Form20ListaMeses
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.btnGenerarMeses = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempMaxima = new System.Windows.Forms.TextBox();
            this.txtTempMinima = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.txtTempMedia = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MESES";
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 15;
            this.lstMeses.Location = new System.Drawing.Point(45, 87);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(151, 259);
            this.lstMeses.TabIndex = 1;
            // 
            // btnGenerarMeses
            // 
            this.btnGenerarMeses.Location = new System.Drawing.Point(264, 87);
            this.btnGenerarMeses.Name = "btnGenerarMeses";
            this.btnGenerarMeses.Size = new System.Drawing.Size(100, 23);
            this.btnGenerarMeses.TabIndex = 2;
            this.btnGenerarMeses.Text = "Generar Meses";
            this.btnGenerarMeses.UseVisualStyleBackColor = true;
            this.btnGenerarMeses.Click += new System.EventHandler(this.btnGenerarMeses_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(264, 117);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperatura máxima";
            // 
            // txtTempMaxima
            // 
            this.txtTempMaxima.Location = new System.Drawing.Point(264, 196);
            this.txtTempMaxima.Name = "txtTempMaxima";
            this.txtTempMaxima.Size = new System.Drawing.Size(100, 23);
            this.txtTempMaxima.TabIndex = 5;
            // 
            // txtTempMinima
            // 
            this.txtTempMinima.Location = new System.Drawing.Point(264, 253);
            this.txtTempMinima.Name = "txtTempMinima";
            this.txtTempMinima.Size = new System.Drawing.Size(100, 23);
            this.txtTempMinima.TabIndex = 7;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(264, 224);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(117, 15);
            this.txt.TabIndex = 6;
            this.txt.Text = "Temperatura mínima";
            // 
            // txtTempMedia
            // 
            this.txtTempMedia.Location = new System.Drawing.Point(264, 323);
            this.txtTempMedia.Name = "txtTempMedia";
            this.txtTempMedia.Size = new System.Drawing.Size(100, 23);
            this.txtTempMedia.TabIndex = 9;
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(264, 294);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(112, 15);
            this.txt2.TabIndex = 8;
            this.txt2.Text = "Temperatura media ";
            // 
            // Form20ListaMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTempMedia);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txtTempMinima);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtTempMaxima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerarMeses);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.label1);
            this.Name = "Form20ListaMeses";
            this.Text = "Form20ListaMeses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.Button btnGenerarMeses;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTempMaxima;
        private System.Windows.Forms.TextBox txtTempMinima;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtTempMedia;
        private System.Windows.Forms.Label txt2;
    }
}