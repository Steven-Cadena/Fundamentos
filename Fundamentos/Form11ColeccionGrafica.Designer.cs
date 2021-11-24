
namespace Fundamentos
{
    partial class Form11ColeccionGrafica
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
            this.lstElemento = new System.Windows.Forms.ListBox();
            this.Elementos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstElemento
            // 
            this.lstElemento.FormattingEnabled = true;
            this.lstElemento.ItemHeight = 15;
            this.lstElemento.Location = new System.Drawing.Point(76, 86);
            this.lstElemento.Name = "lstElemento";
            this.lstElemento.Size = new System.Drawing.Size(120, 94);
            this.lstElemento.TabIndex = 0;
            this.lstElemento.SelectedIndexChanged += new System.EventHandler(this.lstElemento_SelectedIndexChanged);
            // 
            // Elementos
            // 
            this.Elementos.AutoSize = true;
            this.Elementos.Location = new System.Drawing.Point(76, 40);
            this.Elementos.Name = "Elementos";
            this.Elementos.Size = new System.Drawing.Size(62, 15);
            this.Elementos.TabIndex = 1;
            this.Elementos.Text = "Elementos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elemento:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInsertar.Location = new System.Drawing.Point(262, 115);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 32);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar ";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.Location = new System.Drawing.Point(262, 153);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 27);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(262, 183);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 37);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(262, 86);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 23);
            this.txtElemento.TabIndex = 6;
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarLista.Location = new System.Drawing.Point(262, 227);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(100, 34);
            this.btnLimpiarLista.TabIndex = 7;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = false;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(76, 204);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(65, 15);
            this.lblPosicion.TabIndex = 8;
            this.lblPosicion.Text = "lblPosicion";
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(76, 245);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(90, 15);
            this.lblSeleccionado.TabIndex = 9;
            this.lblSeleccionado.Text = "lblSeleccionado";
            // 
            // Form11ColeccionGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Elementos);
            this.Controls.Add(this.lstElemento);
            this.Name = "Form11ColeccionGrafica";
            this.Text = ".";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstElemento;
        private System.Windows.Forms.Label Elementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblSeleccionado;
    }
}