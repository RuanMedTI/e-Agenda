
namespace eAgenda
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditarCompromisso = new System.Windows.Forms.Button();
            this.btnExcluirCompromisso = new System.Windows.Forms.Button();
            this.btnInserirCompromisso = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLiberarExcluir = new System.Windows.Forms.Button();
            this.btnLiberarEditar = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dtCompromissos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbContatos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoraTermino = new System.Windows.Forms.TextBox();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDataCompromisso = new System.Windows.Forms.DateTimePicker();
            this.txtData = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCompromisso = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompromissos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compromissos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnEditarCompromisso);
            this.groupBox1.Controls.Add(this.btnExcluirCompromisso);
            this.groupBox1.Controls.Add(this.btnInserirCompromisso);
            this.groupBox1.Location = new System.Drawing.Point(427, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSair.Location = new System.Drawing.Point(100, 57);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditarCompromisso
            // 
            this.btnEditarCompromisso.Location = new System.Drawing.Point(19, 57);
            this.btnEditarCompromisso.Name = "btnEditarCompromisso";
            this.btnEditarCompromisso.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCompromisso.TabIndex = 2;
            this.btnEditarCompromisso.Text = "Editar";
            this.btnEditarCompromisso.UseVisualStyleBackColor = true;
            this.btnEditarCompromisso.Click += new System.EventHandler(this.btnEditarCompromisso_Click);
            // 
            // btnExcluirCompromisso
            // 
            this.btnExcluirCompromisso.Location = new System.Drawing.Point(100, 28);
            this.btnExcluirCompromisso.Name = "btnExcluirCompromisso";
            this.btnExcluirCompromisso.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCompromisso.TabIndex = 1;
            this.btnExcluirCompromisso.Text = "Excluir";
            this.btnExcluirCompromisso.UseVisualStyleBackColor = true;
            this.btnExcluirCompromisso.Click += new System.EventHandler(this.btnExcluirCompromisso_Click);
            // 
            // btnInserirCompromisso
            // 
            this.btnInserirCompromisso.Location = new System.Drawing.Point(19, 28);
            this.btnInserirCompromisso.Name = "btnInserirCompromisso";
            this.btnInserirCompromisso.Size = new System.Drawing.Size(75, 23);
            this.btnInserirCompromisso.TabIndex = 0;
            this.btnInserirCompromisso.Text = "Inserir";
            this.btnInserirCompromisso.UseVisualStyleBackColor = true;
            this.btnInserirCompromisso.Click += new System.EventHandler(this.btnInserirCompromisso_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLiberarExcluir);
            this.groupBox2.Controls.Add(this.btnLiberarEditar);
            this.groupBox2.Controls.Add(this.btnLiberar);
            this.groupBox2.Location = new System.Drawing.Point(243, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liberar Campos";
            // 
            // btnLiberarExcluir
            // 
            this.btnLiberarExcluir.Location = new System.Drawing.Point(28, 71);
            this.btnLiberarExcluir.Name = "btnLiberarExcluir";
            this.btnLiberarExcluir.Size = new System.Drawing.Size(114, 23);
            this.btnLiberarExcluir.TabIndex = 2;
            this.btnLiberarExcluir.Text = "Liberar Excluir";
            this.btnLiberarExcluir.UseVisualStyleBackColor = true;
            this.btnLiberarExcluir.Click += new System.EventHandler(this.btnLiberarExcluir_Click);
            // 
            // btnLiberarEditar
            // 
            this.btnLiberarEditar.Location = new System.Drawing.Point(28, 42);
            this.btnLiberarEditar.Name = "btnLiberarEditar";
            this.btnLiberarEditar.Size = new System.Drawing.Size(114, 23);
            this.btnLiberarEditar.TabIndex = 1;
            this.btnLiberarEditar.Text = "Liberar Editar";
            this.btnLiberarEditar.UseVisualStyleBackColor = true;
            this.btnLiberarEditar.Click += new System.EventHandler(this.btnLiberarEditar_Click);
            // 
            // btnLiberar
            // 
            this.btnLiberar.Location = new System.Drawing.Point(28, 13);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(114, 23);
            this.btnLiberar.TabIndex = 0;
            this.btnLiberar.Text = "Liberar Inserir";
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Location = new System.Drawing.Point(22, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 156);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 137);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 111);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compromissos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.assuntoDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.inicioDataGridViewTextBoxColumn,
            this.terminoDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "dtCompromissos";
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 105);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // assuntoDataGridViewTextBoxColumn
            // 
            this.assuntoDataGridViewTextBoxColumn.DataPropertyName = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.HeaderText = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.Name = "assuntoDataGridViewTextBoxColumn";
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // inicioDataGridViewTextBoxColumn
            // 
            this.inicioDataGridViewTextBoxColumn.DataPropertyName = "Inicio";
            this.inicioDataGridViewTextBoxColumn.HeaderText = "Inicio";
            this.inicioDataGridViewTextBoxColumn.Name = "inicioDataGridViewTextBoxColumn";
            // 
            // terminoDataGridViewTextBoxColumn
            // 
            this.terminoDataGridViewTextBoxColumn.DataPropertyName = "Termino";
            this.terminoDataGridViewTextBoxColumn.HeaderText = "Termino";
            this.terminoDataGridViewTextBoxColumn.Name = "terminoDataGridViewTextBoxColumn";
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dtCompromissos});
            // 
            // dtCompromissos
            // 
            this.dtCompromissos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.dtCompromissos.TableName = "dtCompromissos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Assunto";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Local";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Data";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Inicio";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Termino";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Contato";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbContatos);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtLocal);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtHoraTermino);
            this.groupBox4.Controls.Add(this.txtHoraInicio);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dtDataCompromisso);
            this.groupBox4.Controls.Add(this.txtData);
            this.groupBox4.Controls.Add(this.txtAssunto);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtIdCompromisso);
            this.groupBox4.Controls.Add(this.labelId);
            this.groupBox4.Location = new System.Drawing.Point(22, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(601, 98);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inserts";
            // 
            // cmbContatos
            // 
            this.cmbContatos.FormattingEnabled = true;
            this.cmbContatos.Location = new System.Drawing.Point(333, 69);
            this.cmbContatos.Name = "cmbContatos";
            this.cmbContatos.Size = new System.Drawing.Size(247, 21);
            this.cmbContatos.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contato";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(71, 69);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(185, 20);
            this.txtLocal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Local";
            // 
            // txtHoraTermino
            // 
            this.txtHoraTermino.Location = new System.Drawing.Point(480, 43);
            this.txtHoraTermino.Name = "txtHoraTermino";
            this.txtHoraTermino.Size = new System.Drawing.Size(100, 20);
            this.txtHoraTermino.TabIndex = 9;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(286, 43);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(100, 20);
            this.txtHoraInicio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hora término";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora Início";
            // 
            // dtDataCompromisso
            // 
            this.dtDataCompromisso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataCompromisso.Location = new System.Drawing.Point(71, 43);
            this.dtDataCompromisso.Name = "dtDataCompromisso";
            this.dtDataCompromisso.Size = new System.Drawing.Size(135, 20);
            this.dtDataCompromisso.TabIndex = 5;
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Location = new System.Drawing.Point(30, 46);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(30, 13);
            this.txtData.TabIndex = 4;
            this.txtData.Text = "Data";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(221, 17);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(359, 20);
            this.txtAssunto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assunto";
            // 
            // txtIdCompromisso
            // 
            this.txtIdCompromisso.Location = new System.Drawing.Point(71, 17);
            this.txtIdCompromisso.Name = "txtIdCompromisso";
            this.txtIdCompromisso.Size = new System.Drawing.Size(84, 20);
            this.txtIdCompromisso.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(30, 20);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 401);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompromissos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditarCompromisso;
        private System.Windows.Forms.Button btnExcluirCompromisso;
        private System.Windows.Forms.Button btnInserirCompromisso;
        private System.Windows.Forms.Button btnLiberarExcluir;
        private System.Windows.Forms.Button btnLiberarEditar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.ComboBox cmbContatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoraTermino;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDataCompromisso;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCompromisso;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dtCompromissos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
    }
}