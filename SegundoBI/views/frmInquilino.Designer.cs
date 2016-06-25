namespace SegundoBI.views
{
    partial class frmInquilino
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inquilinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInqNovo = new System.Windows.Forms.Button();
            this.btnInqSalvar = new System.Windows.Forms.Button();
            this.btnInqVoltar = new System.Windows.Forms.Button();
            this.inqNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inqIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inqEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inqBairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inqCidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inqTelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inqCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alguelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inquilinoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inqNomeDataGridViewTextBoxColumn,
            this.inqIDDataGridViewTextBoxColumn,
            this.inqEnderecoDataGridViewTextBoxColumn,
            this.inqBairroDataGridViewTextBoxColumn,
            this.inqCidadeDataGridViewTextBoxColumn,
            this.inqTelefoneDataGridViewTextBoxColumn,
            this.inqCPFDataGridViewTextBoxColumn,
            this.alguelDataGridViewTextBoxColumn,
            this.btnEditar,
            this.btnExcluir});
            this.dataGridView1.DataSource = this.inquilinoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(584, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // inquilinoBindingSource
            // 
            this.inquilinoBindingSource.DataSource = typeof(SegundoBI.Inquilino);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(379, 91);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(217, 20);
            this.textBox6.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "CPF";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(72, 87);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(230, 20);
            this.textBox5.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefone";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(379, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 20);
            this.textBox4.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Bairro";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 20);
            this.textBox3.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cidade";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(524, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Endereço";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // btnInqNovo
            // 
            this.btnInqNovo.Location = new System.Drawing.Point(359, 125);
            this.btnInqNovo.Name = "btnInqNovo";
            this.btnInqNovo.Size = new System.Drawing.Size(75, 23);
            this.btnInqNovo.TabIndex = 31;
            this.btnInqNovo.Text = "Novo";
            this.btnInqNovo.UseVisualStyleBackColor = true;
            // 
            // btnInqSalvar
            // 
            this.btnInqSalvar.Location = new System.Drawing.Point(440, 125);
            this.btnInqSalvar.Name = "btnInqSalvar";
            this.btnInqSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnInqSalvar.TabIndex = 30;
            this.btnInqSalvar.Text = "Salvar";
            this.btnInqSalvar.UseVisualStyleBackColor = true;
            // 
            // btnInqVoltar
            // 
            this.btnInqVoltar.Location = new System.Drawing.Point(521, 125);
            this.btnInqVoltar.Name = "btnInqVoltar";
            this.btnInqVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnInqVoltar.TabIndex = 29;
            this.btnInqVoltar.Text = "Voltar";
            this.btnInqVoltar.UseVisualStyleBackColor = true;
            this.btnInqVoltar.Click += new System.EventHandler(this.btnInqVoltar_Click);
            // 
            // inqNomeDataGridViewTextBoxColumn
            // 
            this.inqNomeDataGridViewTextBoxColumn.DataPropertyName = "InqNome";
            this.inqNomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.inqNomeDataGridViewTextBoxColumn.Name = "inqNomeDataGridViewTextBoxColumn";
            this.inqNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inqIDDataGridViewTextBoxColumn
            // 
            this.inqIDDataGridViewTextBoxColumn.DataPropertyName = "InqID";
            this.inqIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.inqIDDataGridViewTextBoxColumn.Name = "inqIDDataGridViewTextBoxColumn";
            this.inqIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inqEnderecoDataGridViewTextBoxColumn
            // 
            this.inqEnderecoDataGridViewTextBoxColumn.DataPropertyName = "InqEndereco";
            this.inqEnderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.inqEnderecoDataGridViewTextBoxColumn.Name = "inqEnderecoDataGridViewTextBoxColumn";
            this.inqEnderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inqBairroDataGridViewTextBoxColumn
            // 
            this.inqBairroDataGridViewTextBoxColumn.DataPropertyName = "InqBairro";
            this.inqBairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.inqBairroDataGridViewTextBoxColumn.Name = "inqBairroDataGridViewTextBoxColumn";
            this.inqBairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inqCidadeDataGridViewTextBoxColumn
            // 
            this.inqCidadeDataGridViewTextBoxColumn.DataPropertyName = "InqCidade";
            this.inqCidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.inqCidadeDataGridViewTextBoxColumn.Name = "inqCidadeDataGridViewTextBoxColumn";
            this.inqCidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inqTelefoneDataGridViewTextBoxColumn
            // 
            this.inqTelefoneDataGridViewTextBoxColumn.DataPropertyName = "InqTelefone";
            this.inqTelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.inqTelefoneDataGridViewTextBoxColumn.Name = "inqTelefoneDataGridViewTextBoxColumn";
            this.inqTelefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inqCPFDataGridViewTextBoxColumn
            // 
            this.inqCPFDataGridViewTextBoxColumn.DataPropertyName = "InqCPF";
            this.inqCPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.inqCPFDataGridViewTextBoxColumn.Name = "inqCPFDataGridViewTextBoxColumn";
            this.inqCPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alguelDataGridViewTextBoxColumn
            // 
            this.alguelDataGridViewTextBoxColumn.DataPropertyName = "Alguel";
            this.alguelDataGridViewTextBoxColumn.HeaderText = "Alguel";
            this.alguelDataGridViewTextBoxColumn.Name = "alguelDataGridViewTextBoxColumn";
            this.alguelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "btnEditar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "btnExcluir";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ReadOnly = true;
            // 
            // frmInquilino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 327);
            this.Controls.Add(this.btnInqNovo);
            this.Controls.Add(this.btnInqSalvar);
            this.Controls.Add(this.btnInqVoltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmInquilino";
            this.Text = "frmInquilino";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inquilinoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInqNovo;
        private System.Windows.Forms.Button btnInqSalvar;
        private System.Windows.Forms.Button btnInqVoltar;
        private System.Windows.Forms.BindingSource inquilinoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn inqNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inqIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inqEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inqBairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inqCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inqTelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inqCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alguelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
    }
}