
namespace Fundamentos
{
    partial class Form28ColeccionCoches
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.Modelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCoches = new System.Windows.Forms.ListBox();
            this.btnNuevoCoche = new System.Windows.Forms.Button();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(31, 66);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 23);
            this.txtMarca.TabIndex = 1;
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Location = new System.Drawing.Point(31, 122);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(48, 15);
            this.Modelo.TabIndex = 2;
            this.Modelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(31, 140);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 23);
            this.txtModelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coches";
            // 
            // lstCoches
            // 
            this.lstCoches.FormattingEnabled = true;
            this.lstCoches.ItemHeight = 15;
            this.lstCoches.Location = new System.Drawing.Point(213, 66);
            this.lstCoches.Name = "lstCoches";
            this.lstCoches.Size = new System.Drawing.Size(131, 259);
            this.lstCoches.TabIndex = 5;
            // 
            // btnNuevoCoche
            // 
            this.btnNuevoCoche.Location = new System.Drawing.Point(367, 67);
            this.btnNuevoCoche.Name = "btnNuevoCoche";
            this.btnNuevoCoche.Size = new System.Drawing.Size(93, 23);
            this.btnNuevoCoche.TabIndex = 6;
            this.btnNuevoCoche.Text = "Nuevo Coche";
            this.btnNuevoCoche.UseVisualStyleBackColor = true;
            this.btnNuevoCoche.Click += new System.EventHandler(this.btnNuevoCoche_Click);
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Location = new System.Drawing.Point(367, 105);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(93, 24);
            this.btnGuardarDatos.TabIndex = 7;
            this.btnGuardarDatos.Text = "Guardar Datos";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(367, 153);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(93, 36);
            this.btnCargarDatos.TabIndex = 8;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(31, 297);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(165, 23);
            this.btnExaminar.TabIndex = 10;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // Form28ColeccionCoches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 357);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnGuardarDatos);
            this.Controls.Add(this.btnNuevoCoche);
            this.Controls.Add(this.lstCoches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Name = "Form28ColeccionCoches";
            this.Text = "Form28ColeccionCoches";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCoches;
        private System.Windows.Forms.Button btnNuevoCoche;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExaminar;
    }
}