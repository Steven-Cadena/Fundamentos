
namespace Fundamentos
{
    partial class Form05ClaseDateTime
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
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.chkFormato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDia = new System.Windows.Forms.RadioButton();
            this.rdbAnyo = new System.Windows.Forms.RadioButton();
            this.rdbMes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.btnIncremento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(92, 68);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(438, 23);
            this.txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            this.chkFormato.AutoSize = true;
            this.chkFormato.Location = new System.Drawing.Point(92, 114);
            this.chkFormato.Name = "chkFormato";
            this.chkFormato.Size = new System.Drawing.Size(153, 19);
            this.chkFormato.TabIndex = 2;
            this.chkFormato.Text = "Cambiar Formato Fecha";
            this.chkFormato.UseVisualStyleBackColor = true;
            this.chkFormato.CheckedChanged += new System.EventHandler(this.chkFormato_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncremento);
            this.groupBox1.Controls.Add(this.txtIncremento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbMes);
            this.groupBox1.Controls.Add(this.rdbAnyo);
            this.groupBox1.Controls.Add(this.rdbDia);
            this.groupBox1.Location = new System.Drawing.Point(92, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incrementar Fecha";
            // 
            // rdbDia
            // 
            this.rdbDia.AutoSize = true;
            this.rdbDia.Location = new System.Drawing.Point(26, 41);
            this.rdbDia.Name = "rdbDia";
            this.rdbDia.Size = new System.Drawing.Size(42, 19);
            this.rdbDia.TabIndex = 0;
            this.rdbDia.TabStop = true;
            this.rdbDia.Text = "Día";
            this.rdbDia.UseVisualStyleBackColor = true;
            // 
            // rdbAnyo
            // 
            this.rdbAnyo.AutoSize = true;
            this.rdbAnyo.Location = new System.Drawing.Point(26, 91);
            this.rdbAnyo.Name = "rdbAnyo";
            this.rdbAnyo.Size = new System.Drawing.Size(47, 19);
            this.rdbAnyo.TabIndex = 1;
            this.rdbAnyo.TabStop = true;
            this.rdbAnyo.Text = "Año";
            this.rdbAnyo.UseVisualStyleBackColor = true;
            // 
            // rdbMes
            // 
            this.rdbMes.AutoSize = true;
            this.rdbMes.Location = new System.Drawing.Point(26, 66);
            this.rdbMes.Name = "rdbMes";
            this.rdbMes.Size = new System.Drawing.Size(47, 19);
            this.rdbMes.TabIndex = 2;
            this.rdbMes.TabStop = true;
            this.rdbMes.Text = "Mes";
            this.rdbMes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(149, 61);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(100, 23);
            this.txtIncremento.TabIndex = 4;
            // 
            // btnIncremento
            // 
            this.btnIncremento.Location = new System.Drawing.Point(149, 91);
            this.btnIncremento.Name = "btnIncremento";
            this.btnIncremento.Size = new System.Drawing.Size(100, 23);
            this.btnIncremento.TabIndex = 5;
            this.btnIncremento.Text = "Incrementar";
            this.btnIncremento.UseVisualStyleBackColor = true;
            this.btnIncremento.Click += new System.EventHandler(this.btnIncremento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nueva Fecha";
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(92, 367);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(438, 23);
            this.txtNuevaFecha.TabIndex = 7;
            // 
            // Form05ClaseDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkFormato);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.label1);
            this.Name = "Form05ClaseDateTime";
            this.Text = "Form05ClaseDateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaActual;
        private System.Windows.Forms.CheckBox chkFormato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIncremento;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMes;
        private System.Windows.Forms.RadioButton rdbAnyo;
        private System.Windows.Forms.RadioButton rdbDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevaFecha;
    }
}