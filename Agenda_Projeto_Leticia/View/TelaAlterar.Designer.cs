namespace Agenda_Projeto_Leticia.View
{
    partial class TelaAlterar
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
            label4 = new Label();
            txb_nomeTelaAlterar = new TextBox();
            txb_emailTelaAlterar = new TextBox();
            txb_foneTelaAlterar = new TextBox();
            label5 = new Label();
            txb_ID_Alterar = new TextBox();
            groupBox1 = new GroupBox();
            btn_Alterar = new Button();
            btn_SairNovatela = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Alterar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(35, 68);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(35, 103);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(35, 149);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Fone:";
            // 
            // txb_nomeTelaAlterar
            // 
            txb_nomeTelaAlterar.Location = new Point(110, 68);
            txb_nomeTelaAlterar.Name = "txb_nomeTelaAlterar";
            txb_nomeTelaAlterar.Size = new Size(236, 27);
            txb_nomeTelaAlterar.TabIndex = 4;
            // 
            // txb_emailTelaAlterar
            // 
            txb_emailTelaAlterar.Location = new Point(110, 104);
            txb_emailTelaAlterar.Name = "txb_emailTelaAlterar";
            txb_emailTelaAlterar.Size = new Size(202, 27);
            txb_emailTelaAlterar.TabIndex = 5;
            // 
            // txb_foneTelaAlterar
            // 
            txb_foneTelaAlterar.Location = new Point(110, 146);
            txb_foneTelaAlterar.Name = "txb_foneTelaAlterar";
            txb_foneTelaAlterar.Size = new Size(122, 27);
            txb_foneTelaAlterar.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 72);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 7;
            label5.Text = "Digite a Matricula/Id";
            // 
            // txb_ID_Alterar
            // 
            txb_ID_Alterar.Location = new Point(221, 69);
            txb_ID_Alterar.Name = "txb_ID_Alterar";
            txb_ID_Alterar.Size = new Size(100, 23);
            txb_ID_Alterar.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(btn_Alterar);
            groupBox1.Controls.Add(txb_foneTelaAlterar);
            groupBox1.Controls.Add(txb_emailTelaAlterar);
            groupBox1.Controls.Add(txb_nomeTelaAlterar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 225);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Digite os dados ";
            // 
            // btn_Alterar
            // 
            btn_Alterar.BackColor = SystemColors.ControlLightLight;
            btn_Alterar.Location = new Point(284, 188);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(75, 31);
            btn_Alterar.TabIndex = 7;
            btn_Alterar.Text = "Alterar";
            btn_Alterar.UseVisualStyleBackColor = false;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // btn_SairNovatela
            // 
            btn_SairNovatela.BackColor = Color.IndianRed;
            btn_SairNovatela.Location = new Point(322, 12);
            btn_SairNovatela.Name = "btn_SairNovatela";
            btn_SairNovatela.Size = new Size(75, 23);
            btn_SairNovatela.TabIndex = 10;
            btn_SairNovatela.Text = "Sair";
            btn_SairNovatela.UseVisualStyleBackColor = false;
            btn_SairNovatela.Click += btn_SairNovatela_Click;
            // 
            // TelaAlterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(399, 402);
            Controls.Add(btn_SairNovatela);
            Controls.Add(groupBox1);
            Controls.Add(txb_ID_Alterar);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "TelaAlterar";
            ShowIcon = false;
            Text = "TelaAlterar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txb_nomeTelaAlterar;
        private TextBox txb_emailTelaAlterar;
        private TextBox txb_foneTelaAlterar;
        private Label label5;
        private TextBox txb_ID_Alterar;
        private GroupBox groupBox1;
        private Button btn_Alterar;
        private Button btn_SairNovatela;
    }
}