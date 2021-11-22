
namespace Fundamentos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPulsar = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPulsar
            // 
            this.btnPulsar.Location = new System.Drawing.Point(163, 195);
            this.btnPulsar.Name = "btnPulsar";
            this.btnPulsar.Size = new System.Drawing.Size(156, 81);
            this.btnPulsar.TabIndex = 0;
            this.btnPulsar.Text = "Pulsar";
            this.btnPulsar.UseVisualStyleBackColor = true;
            this.btnPulsar.Click += new System.EventHandler(this.btnPulsar_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(416, 195);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(130, 81);
            this.btnPrueba.TabIndex = 1;
            this.btnPrueba.Text = "button1";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(328, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnPulsar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPulsar;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
    }
}

