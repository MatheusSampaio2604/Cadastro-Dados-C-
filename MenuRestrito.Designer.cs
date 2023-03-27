namespace AppNovo
{
    partial class MenuRestrito
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
            this.group_Info = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matrícula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CadData = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_UpData = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Info
            // 
            this.group_Info.Controls.Add(this.dataGridView1);
            this.group_Info.Location = new System.Drawing.Point(12, 65);
            this.group_Info.Name = "group_Info";
            this.group_Info.Size = new System.Drawing.Size(713, 264);
            this.group_Info.TabIndex = 0;
            this.group_Info.TabStop = false;
            this.group_Info.Text = "Cadastrados:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Nome_Completo,
            this.Setor,
            this.Matrícula,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(700, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Nome_Completo
            // 
            this.Nome_Completo.HeaderText = "Nome_Completo";
            this.Nome_Completo.Name = "Nome_Completo";
            // 
            // Setor
            // 
            this.Setor.HeaderText = "Setor";
            this.Setor.Name = "Setor";
            // 
            // Matrícula
            // 
            this.Matrícula.HeaderText = "Matrícula";
            this.Matrícula.Name = "Matrícula";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btn_CadData
            // 
            this.btn_CadData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CadData.FlatAppearance.BorderSize = 0;
            this.btn_CadData.Location = new System.Drawing.Point(408, 18);
            this.btn_CadData.Name = "btn_CadData";
            this.btn_CadData.Size = new System.Drawing.Size(74, 41);
            this.btn_CadData.TabIndex = 1;
            this.btn_CadData.Text = "Cadastrar Perfil";
            this.btn_CadData.UseVisualStyleBackColor = false;
            this.btn_CadData.Click += new System.EventHandler(this.btn_CadData_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(644, 351);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(81, 26);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Sair";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.Location = new System.Drawing.Point(644, 18);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(74, 41);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Deletar Cadastro";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_UpData
            // 
            this.btn_UpData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_UpData.Location = new System.Drawing.Point(523, 18);
            this.btn_UpData.Name = "btn_UpData";
            this.btn_UpData.Size = new System.Drawing.Size(83, 41);
            this.btn_UpData.TabIndex = 3;
            this.btn_UpData.Text = "Atualizar Informação";
            this.btn_UpData.UseVisualStyleBackColor = false;
            this.btn_UpData.Click += new System.EventHandler(this.btn_UpData_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // MenuRestrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 397);
            this.Controls.Add(this.group_Info);
            this.Controls.Add(this.btn_UpData);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_CadData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MenuRestrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuRestrito";
            this.Load += new System.EventHandler(this.MenuRestrito_Load);
            this.group_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox group_Info;
        private Button btn_CadData;
        private Button btn_Close;
        private Button btn_Delete;
        private Button btn_UpData;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Nome_Completo;
        private DataGridViewTextBoxColumn Setor;
        private DataGridViewTextBoxColumn Matrícula;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}