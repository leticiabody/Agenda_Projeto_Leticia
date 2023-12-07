namespace Agenda_Projeto_Leticia.View
{
    partial class TelaDeletar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txb_emailTelaDeletar = new TextBox();
            label5 = new Label();
            txb_fone_TelaDeletar = new TextBox();
            txb_nomeTeladelar = new TextBox();
            label4 = new Label();
            txb_buscarId_TelaDeletar = new TextBox();
            btn_excluirTelaDeletar = new Button();
            btn_buscar_TelaDeletar = new Button();
            btnsair = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 25);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Deletar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(100, 73);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Pesquisar por Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 43);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(txb_emailTelaDeletar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txb_fone_TelaDeletar);
            groupBox1.Controls.Add(txb_nomeTeladelar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 186);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // txb_emailTelaDeletar
            // 
            txb_emailTelaDeletar.Location = new Point(148, 131);
            txb_emailTelaDeletar.Name = "txb_emailTelaDeletar";
            txb_emailTelaDeletar.Size = new Size(193, 29);
            txb_emailTelaDeletar.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 134);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // txb_fone_TelaDeletar
            // 
            txb_fone_TelaDeletar.Location = new Point(148, 90);
            txb_fone_TelaDeletar.Name = "txb_fone_TelaDeletar";
            txb_fone_TelaDeletar.Size = new Size(193, 29);
            txb_fone_TelaDeletar.TabIndex = 6;
            // 
            // txb_nomeTeladelar
            // 
            txb_nomeTeladelar.Location = new Point(148, 40);
            txb_nomeTeladelar.Name = "txb_nomeTeladelar";
            txb_nomeTeladelar.Size = new Size(193, 29);
            txb_nomeTeladelar.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 90);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 3;
            label4.Text = "fone";
            // 
            // txb_buscarId_TelaDeletar
            // 
            txb_buscarId_TelaDeletar.Location = new Point(224, 70);
            txb_buscarId_TelaDeletar.Name = "txb_buscarId_TelaDeletar";
            txb_buscarId_TelaDeletar.Size = new Size(67, 23);
            txb_buscarId_TelaDeletar.TabIndex = 4;
            // 
            // btn_excluirTelaDeletar
            // 
            btn_excluirTelaDeletar.BackColor = SystemColors.ControlLightLight;
            btn_excluirTelaDeletar.Location = new Point(334, 344);
            btn_excluirTelaDeletar.Name = "btn_excluirTelaDeletar";
            btn_excluirTelaDeletar.Size = new Size(81, 32);
            btn_excluirTelaDeletar.TabIndex = 4;
            btn_excluirTelaDeletar.Text = "Excluir";
            btn_excluirTelaDeletar.UseVisualStyleBackColor = false;
            btn_excluirTelaDeletar.Click += btn_excluirTelaDeletar_Click;
            // 
            // btn_buscar_TelaDeletar
            // 
            btn_buscar_TelaDeletar.BackColor = SystemColors.ControlLightLight;
            btn_buscar_TelaDeletar.Location = new Point(312, 65);
            btn_buscar_TelaDeletar.Name = "btn_buscar_TelaDeletar";
            btn_buscar_TelaDeletar.Size = new Size(59, 30);
            btn_buscar_TelaDeletar.TabIndex = 5;
            btn_buscar_TelaDeletar.Text = "Buscar";
            btn_buscar_TelaDeletar.UseVisualStyleBackColor = false;
            btn_buscar_TelaDeletar.Click += btn_buscar_TelaDeletar_Click;
            // 
            // btnsair
            // 
            btnsair.BackColor = Color.IndianRed;
            btnsair.Location = new Point(349, 12);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(75, 23);
            btnsair.TabIndex = 6;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = false;
            btnsair.Click += btnsair_Click;
            // 
            // TelaDeletar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(427, 397);
            Controls.Add(btnsair);
            Controls.Add(btn_buscar_TelaDeletar);
            Controls.Add(btn_excluirTelaDeletar);
            Controls.Add(groupBox1);
            Controls.Add(txb_buscarId_TelaDeletar);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "TelaDeletar";
            Text = "TelaDeletar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txb_buscarId_TelaDeletar;
        private Label label4;
        private TextBox txb_fone_TelaDeletar;
        private TextBox txb_nomeTeladelar;
        private Button btn_excluirTelaDeletar;
        private Button btn_buscar_TelaDeletar;
        private Label label5;
        private TextBox txb_emailTelaDeletar;
        private Button btnsair;
    }
}