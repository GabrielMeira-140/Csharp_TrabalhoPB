namespace trabalhoPB
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedTBCep = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Pai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTBTell = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTBData = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Mae = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.dataVGDados = new System.Windows.Forms.DataGridView();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTBID = new System.Windows.Forms.MaskedTextBox();
            this.maskedTBProcurarID = new System.Windows.Forms.MaskedTextBox();
            this.lblAlteraExclui = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataVGDados)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTBCep
            // 
            this.maskedTBCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTBCep.Location = new System.Drawing.Point(262, 402);
            this.maskedTBCep.Mask = "00.000.000";
            this.maskedTBCep.Name = "maskedTBCep";
            this.maskedTBCep.Size = new System.Drawing.Size(330, 29);
            this.maskedTBCep.TabIndex = 48;
            this.maskedTBCep.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "CEP";
            // 
            // txt_Pai
            // 
            this.txt_Pai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pai.Location = new System.Drawing.Point(261, 297);
            this.txt_Pai.Name = "txt_Pai";
            this.txt_Pai.Size = new System.Drawing.Size(331, 29);
            this.txt_Pai.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Nome da  Pai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nome da mãe";
            // 
            // maskedTBTell
            // 
            this.maskedTBTell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTBTell.Location = new System.Drawing.Point(261, 345);
            this.maskedTBTell.Mask = "(99) 0-0000-0000";
            this.maskedTBTell.Name = "maskedTBTell";
            this.maskedTBTell.Size = new System.Drawing.Size(332, 29);
            this.maskedTBTell.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Data de nascimento";
            // 
            // maskedTBData
            // 
            this.maskedTBData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTBData.Location = new System.Drawing.Point(261, 196);
            this.maskedTBData.Mask = "00/00/0000";
            this.maskedTBData.Name = "maskedTBData";
            this.maskedTBData.Size = new System.Drawing.Size(332, 29);
            this.maskedTBData.TabIndex = 41;
            this.maskedTBData.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Numero de Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nome completo";
            // 
            // txt_Mae
            // 
            this.txt_Mae.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mae.Location = new System.Drawing.Point(262, 246);
            this.txt_Mae.Name = "txt_Mae";
            this.txt_Mae.Size = new System.Drawing.Size(331, 29);
            this.txt_Mae.TabIndex = 38;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(262, 150);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(331, 29);
            this.txt_Nome.TabIndex = 37;
            // 
            // dataVGDados
            // 
            this.dataVGDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataVGDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVGDados.Location = new System.Drawing.Point(611, 37);
            this.dataVGDados.Name = "dataVGDados";
            this.dataVGDados.Size = new System.Drawing.Size(734, 413);
            this.dataVGDados.TabIndex = 34;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Excluir.Location = new System.Drawing.Point(678, 512);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(145, 40);
            this.btn_Excluir.TabIndex = 33;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.FlatAppearance.BorderSize = 0;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sair.Location = new System.Drawing.Point(827, 512);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(145, 40);
            this.btn_Sair.TabIndex = 32;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.FlatAppearance.BorderSize = 0;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_alterar.Location = new System.Drawing.Point(536, 512);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(145, 40);
            this.btn_alterar.TabIndex = 31;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btn_Incluir.FlatAppearance.BorderSize = 0;
            this.btn_Incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Incluir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Incluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Incluir.Location = new System.Drawing.Point(385, 512);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(145, 40);
            this.btn_Incluir.TabIndex = 30;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = false;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "ID";
            // 
            // maskedTBID
            // 
            this.maskedTBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTBID.Location = new System.Drawing.Point(263, 99);
            this.maskedTBID.Mask = "0-0000";
            this.maskedTBID.Name = "maskedTBID";
            this.maskedTBID.Size = new System.Drawing.Size(332, 29);
            this.maskedTBID.TabIndex = 50;
            // 
            // maskedTBProcurarID
            // 
            this.maskedTBProcurarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTBProcurarID.Location = new System.Drawing.Point(263, 52);
            this.maskedTBProcurarID.Mask = "0-0000";
            this.maskedTBProcurarID.Name = "maskedTBProcurarID";
            this.maskedTBProcurarID.Size = new System.Drawing.Size(332, 29);
            this.maskedTBProcurarID.TabIndex = 51;
            // 
            // lblAlteraExclui
            // 
            this.lblAlteraExclui.AutoSize = true;
            this.lblAlteraExclui.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAlteraExclui.ForeColor = System.Drawing.Color.White;
            this.lblAlteraExclui.Location = new System.Drawing.Point(2, 59);
            this.lblAlteraExclui.Name = "lblAlteraExclui";
            this.lblAlteraExclui.Size = new System.Drawing.Size(245, 18);
            this.lblAlteraExclui.TabIndex = 53;
            this.lblAlteraExclui.Text = "alterar ou excluir (pesquisa por ID)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1346, 564);
            this.Controls.Add(this.lblAlteraExclui);
            this.Controls.Add(this.maskedTBProcurarID);
            this.Controls.Add(this.maskedTBID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTBCep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Pai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTBTell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTBData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Mae);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.dataVGDados);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_Incluir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataVGDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTBCep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Pai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTBTell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTBData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Mae;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.DataGridView dataVGDados;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTBID;
        private System.Windows.Forms.MaskedTextBox maskedTBProcurarID;
        private System.Windows.Forms.Label lblAlteraExclui;
    }
}

