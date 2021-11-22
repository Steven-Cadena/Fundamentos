
namespace Fundamentos
{
    partial class Form03ColorPosicion
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.txtPosicionX = new System.Windows.Forms.TextBox();
            this.txtPosicionY = new System.Windows.Forms.TextBox();
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnNumero = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posición X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posición Y:";
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(105, 216);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(75, 23);
            this.btnPosicion.TabIndex = 2;
            this.btnPosicion.Text = "Posición";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Location = new System.Drawing.Point(350, 76);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(34, 15);
            this.lblRojo.TabIndex = 3;
            this.lblRojo.Text = "Rojo:";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Location = new System.Drawing.Point(350, 110);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(39, 15);
            this.lblVerde.TabIndex = 4;
            this.lblVerde.Text = "Verde:";
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(350, 147);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(33, 15);
            this.lblAzul.TabIndex = 5;
            this.lblAzul.Text = "Azul:";
            // 
            // txtPosicionX
            // 
            this.txtPosicionX.Location = new System.Drawing.Point(157, 77);
            this.txtPosicionX.Name = "txtPosicionX";
            this.txtPosicionX.Size = new System.Drawing.Size(100, 23);
            this.txtPosicionX.TabIndex = 6;
            // 
            // txtPosicionY
            // 
            this.txtPosicionY.Location = new System.Drawing.Point(157, 139);
            this.txtPosicionY.Name = "txtPosicionY";
            this.txtPosicionY.Size = new System.Drawing.Size(100, 23);
            this.txtPosicionY.TabIndex = 7;
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(414, 76);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(100, 23);
            this.txtRojo.TabIndex = 8;
            // 
            // txtVerde
            // 
            this.txtVerde.Location = new System.Drawing.Point(414, 110);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(100, 23);
            this.txtVerde.TabIndex = 9;
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(414, 147);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(100, 23);
            this.txtAzul.TabIndex = 10;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(414, 216);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 11;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(204, 296);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 13;
            // 
            // btnNumero
            // 
            this.btnNumero.Location = new System.Drawing.Point(104, 358);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(139, 23);
            this.btnNumero.TabIndex = 14;
            this.btnNumero.Text = "Evaluar Número";
            this.btnNumero.UseVisualStyleBackColor = true;
            this.btnNumero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(261, 365);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(59, 15);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Número:";
            // 
            // Form03ColorPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.txtVerde);
            this.Controls.Add(this.txtRojo);
            this.Controls.Add(this.txtPosicionY);
            this.Controls.Add(this.txtPosicionX);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form03ColorPosicion";
            this.Text = "Form03ColorPosicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.TextBox txtPosicionX;
        private System.Windows.Forms.TextBox txtPosicionY;
        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.TextBox txtVerde;
        private System.Windows.Forms.TextBox txtAzul;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label3;
    }
}