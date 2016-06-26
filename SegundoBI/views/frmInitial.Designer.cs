namespace SegundoBI.views
{
    partial class frmInitial
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
            this.btnCadPro = new System.Windows.Forms.Button();
            this.btnCadInq = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLocação = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadPro
            // 
            this.btnCadPro.Location = new System.Drawing.Point(12, 15);
            this.btnCadPro.Name = "btnCadPro";
            this.btnCadPro.Size = new System.Drawing.Size(237, 101);
            this.btnCadPro.TabIndex = 0;
            this.btnCadPro.Text = "Cadastrar Proprietário";
            this.btnCadPro.UseVisualStyleBackColor = true;
            this.btnCadPro.Click += new System.EventHandler(this.btnCadPro_Click);
            // 
            // btnCadInq
            // 
            this.btnCadInq.Location = new System.Drawing.Point(255, 15);
            this.btnCadInq.Name = "btnCadInq";
            this.btnCadInq.Size = new System.Drawing.Size(237, 101);
            this.btnCadInq.TabIndex = 1;
            this.btnCadInq.Text = "Cadastrar Inquilino";
            this.btnCadInq.UseVisualStyleBackColor = true;
            this.btnCadInq.Click += new System.EventHandler(this.btnCadInq_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(744, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 101);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnLocação
            // 
            this.btnLocação.Location = new System.Drawing.Point(498, 15);
            this.btnLocação.Name = "btnLocação";
            this.btnLocação.Size = new System.Drawing.Size(237, 101);
            this.btnLocação.TabIndex = 2;
            this.btnLocação.Text = "Locações";
            this.btnLocação.UseVisualStyleBackColor = true;
            this.btnLocação.Click += new System.EventHandler(this.btnLocação_Click);
            // 
            // frmInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 137);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLocação);
            this.Controls.Add(this.btnCadInq);
            this.Controls.Add(this.btnCadPro);
            this.Name = "frmInitial";
            this.Text = "frmInitial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadPro;
        private System.Windows.Forms.Button btnCadInq;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLocação;
    }
}