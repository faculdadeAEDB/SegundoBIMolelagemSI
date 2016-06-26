namespace SegundoBI.views
{
    partial class frmProprietario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomePro = new System.Windows.Forms.TextBox();
            this.txbEnderecoPro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCidadePro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbBairroPro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTelefonePro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCPFPro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdProprietario = new System.Windows.Forms.DataGridView();
            this.proprietarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnProVoltar = new System.Windows.Forms.Button();
            this.btnProSalvar = new System.Windows.Forms.Button();
            this.btnProNovo = new System.Windows.Forms.Button();
            this.btnImovel = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProprietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txbNomePro
            // 
            this.txbNomePro.Location = new System.Drawing.Point(73, 10);
            this.txbNomePro.Name = "txbNomePro";
            this.txbNomePro.Size = new System.Drawing.Size(524, 20);
            this.txbNomePro.TabIndex = 1;
            // 
            // txbEnderecoPro
            // 
            this.txbEnderecoPro.Location = new System.Drawing.Point(73, 36);
            this.txbEnderecoPro.Name = "txbEnderecoPro";
            this.txbEnderecoPro.Size = new System.Drawing.Size(524, 20);
            this.txbEnderecoPro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // txbCidadePro
            // 
            this.txbCidadePro.Location = new System.Drawing.Point(73, 62);
            this.txbCidadePro.Name = "txbCidadePro";
            this.txbCidadePro.Size = new System.Drawing.Size(230, 20);
            this.txbCidadePro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cidade";
            // 
            // txbBairroPro
            // 
            this.txbBairroPro.Location = new System.Drawing.Point(380, 62);
            this.txbBairroPro.Name = "txbBairroPro";
            this.txbBairroPro.Size = new System.Drawing.Size(217, 20);
            this.txbBairroPro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bairro";
            // 
            // txbTelefonePro
            // 
            this.txbTelefonePro.Location = new System.Drawing.Point(73, 88);
            this.txbTelefonePro.Name = "txbTelefonePro";
            this.txbTelefonePro.Size = new System.Drawing.Size(230, 20);
            this.txbTelefonePro.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // txbCPFPro
            // 
            this.txbCPFPro.Location = new System.Drawing.Point(380, 92);
            this.txbCPFPro.Name = "txbCPFPro";
            this.txbCPFPro.Size = new System.Drawing.Size(217, 20);
            this.txbCPFPro.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPF";
            // 
            // grdProprietario
            // 
            this.grdProprietario.AllowUserToDeleteRows = false;
            this.grdProprietario.AutoGenerateColumns = false;
            this.grdProprietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProprietario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.imovelDataGridViewTextBoxColumn,
            this.btnEditar,
            this.btnExcluir});
            this.grdProprietario.DataSource = this.proprietarioBindingSource;
            this.grdProprietario.Location = new System.Drawing.Point(13, 154);
            this.grdProprietario.Name = "grdProprietario";
            this.grdProprietario.ReadOnly = true;
            this.grdProprietario.Size = new System.Drawing.Size(584, 159);
            this.grdProprietario.TabIndex = 12;
            // 
            // proprietarioBindingSource
            // 
            this.proprietarioBindingSource.DataSource = typeof(SegundoBI.Proprietario);
            // 
            // btnProVoltar
            // 
            this.btnProVoltar.Location = new System.Drawing.Point(521, 119);
            this.btnProVoltar.Name = "btnProVoltar";
            this.btnProVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnProVoltar.TabIndex = 13;
            this.btnProVoltar.Text = "Voltar";
            this.btnProVoltar.UseVisualStyleBackColor = true;
            this.btnProVoltar.Click += new System.EventHandler(this.btnProVoltar_Click);
            // 
            // btnProSalvar
            // 
            this.btnProSalvar.Location = new System.Drawing.Point(440, 119);
            this.btnProSalvar.Name = "btnProSalvar";
            this.btnProSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnProSalvar.TabIndex = 14;
            this.btnProSalvar.Text = "Salvar";
            this.btnProSalvar.UseVisualStyleBackColor = true;
            this.btnProSalvar.Click += new System.EventHandler(this.btnProSalvar_Click);
            // 
            // btnProNovo
            // 
            this.btnProNovo.Location = new System.Drawing.Point(359, 119);
            this.btnProNovo.Name = "btnProNovo";
            this.btnProNovo.Size = new System.Drawing.Size(75, 23);
            this.btnProNovo.TabIndex = 28;
            this.btnProNovo.Text = "Novo";
            this.btnProNovo.UseVisualStyleBackColor = true;
            this.btnProNovo.Click += new System.EventHandler(this.btnProNovo_Click);
            // 
            // btnImovel
            // 
            this.btnImovel.Location = new System.Drawing.Point(13, 119);
            this.btnImovel.Name = "btnImovel";
            this.btnImovel.Size = new System.Drawing.Size(96, 23);
            this.btnImovel.TabIndex = 29;
            this.btnImovel.Text = "Cadastrar Imóvel";
            this.btnImovel.UseVisualStyleBackColor = true;
            this.btnImovel.Click += new System.EventHandler(this.btnImovel_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProNome";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProNome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProEndereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProEndereco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProBairro";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProBairro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProCidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "ProCidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProTelefone";
            this.dataGridViewTextBoxColumn6.HeaderText = "ProTelefone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProCPF";
            this.dataGridViewTextBoxColumn7.HeaderText = "ProCPF";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // imovelDataGridViewTextBoxColumn
            // 
            this.imovelDataGridViewTextBoxColumn.DataPropertyName = "Imovel";
            this.imovelDataGridViewTextBoxColumn.HeaderText = "Imovel";
            this.imovelDataGridViewTextBoxColumn.Name = "imovelDataGridViewTextBoxColumn";
            this.imovelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Excluir";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ReadOnly = true;
            // 
            // frmProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 325);
            this.Controls.Add(this.btnImovel);
            this.Controls.Add(this.btnProNovo);
            this.Controls.Add(this.btnProSalvar);
            this.Controls.Add(this.btnProVoltar);
            this.Controls.Add(this.grdProprietario);
            this.Controls.Add(this.txbCPFPro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbTelefonePro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbBairroPro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCidadePro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbEnderecoPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNomePro);
            this.Controls.Add(this.label1);
            this.Name = "frmProprietario";
            this.Text = "frmProprietario";
            this.Load += new System.EventHandler(this.frmProprietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProprietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomePro;
        private System.Windows.Forms.TextBox txbEnderecoPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCidadePro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbBairroPro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTelefonePro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCPFPro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdProprietario;
        private System.Windows.Forms.Button btnProVoltar;
        private System.Windows.Forms.Button btnProSalvar;
        private System.Windows.Forms.Button btnProNovo;
        private System.Windows.Forms.Button btnImovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proBairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proTelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proprietarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn imovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
    }
}