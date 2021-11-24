
namespace Fundamentos
{
    partial class Form12SeleccionMultipleColeccion
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
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Elementos = new System.Windows.Forms.Label();
            this.lstElemento = new System.Windows.Forms.ListBox();
            this.btnSeleccionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(75, 252);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(95, 15);
            this.lblSeleccionado.TabIndex = 19;
            this.lblSeleccionado.Text = "lblSeleccionados";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(75, 211);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(76, 15);
            this.lblPosicion.TabIndex = 18;
            this.lblPosicion.Text = "lblPosiciones";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(261, 93);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 23);
            this.txtElemento.TabIndex = 16;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(261, 173);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 37);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInsertar.Location = new System.Drawing.Point(261, 122);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 32);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar ";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elemento:";
            // 
            // Elementos
            // 
            this.Elementos.AutoSize = true;
            this.Elementos.Location = new System.Drawing.Point(75, 47);
            this.Elementos.Name = "Elementos";
            this.Elementos.Size = new System.Drawing.Size(114, 15);
            this.Elementos.TabIndex = 11;
            this.Elementos.Text = "Elementos Múltiples";
            // 
            // lstElemento
            // 
            this.lstElemento.FormattingEnabled = true;
            this.lstElemento.ItemHeight = 15;
            this.lstElemento.Location = new System.Drawing.Point(75, 93);
            this.lstElemento.Name = "lstElemento";
            this.lstElemento.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstElemento.Size = new System.Drawing.Size(120, 94);
            this.lstElemento.TabIndex = 10;
            // 
            // btnSeleccionado
            // 
            this.btnSeleccionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSeleccionado.Location = new System.Drawing.Point(261, 230);
            this.btnSeleccionado.Name = "btnSeleccionado";
            this.btnSeleccionado.Size = new System.Drawing.Size(100, 37);
            this.btnSeleccionado.TabIndex = 20;
            this.btnSeleccionado.Text = "Seleccionados";
            this.btnSeleccionado.UseVisualStyleBackColor = false;
            this.btnSeleccionado.Click += new System.EventHandler(this.btnSeleccionado_Click);
            // 
            // Form12SeleccionMultipleColeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeleccionado);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Elementos);
            this.Controls.Add(this.lstElemento);
            this.Name = "Form12SeleccionMultipleColeccion";
            this.Text = "Form12SeleccionMultipleColeccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Elementos;
        private System.Windows.Forms.ListBox lstElemento;
        private System.Windows.Forms.Button btnSeleccionado;
    }
}