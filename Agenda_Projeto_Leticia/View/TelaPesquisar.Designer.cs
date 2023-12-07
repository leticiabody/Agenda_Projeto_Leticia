namespace Agenda_Projeto_Leticia.View
{
    partial class TelaPesquisar
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
            txb_email_Telapesquisar = new TextBox();
            txb_foneTelaPesquisar = new TextBox();
            txb_nomeTelaPesquisar = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txb_BuscaPorNome_TelaPesquisa = new TextBox();
            btn_BuscarTelaPesquisar = new Button();
            btn_SAIR = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(181, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(77, 63);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "Buscar por Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 76);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(txb_email_Telapesquisar);
            groupBox1.Controls.Add(txb_foneTelaPesquisar);
            groupBox1.Controls.Add(txb_nomeTelaPesquisar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(56, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 216);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // txb_email_Telapesquisar
            // 
            txb_email_Telapesquisar.Location = new Point(29, 94);
            txb_email_Telapesquisar.Name = "txb_email_Telapesquisar";
            txb_email_Telapesquisar.Size = new Size(261, 23);
            txb_email_Telapesquisar.TabIndex = 8;
            // 
            // txb_foneTelaPesquisar
            // 
            txb_foneTelaPesquisar.Location = new Point(34, 161);
            txb_foneTelaPesquisar.Name = "txb_foneTelaPesquisar";
            txb_foneTelaPesquisar.Size = new Size(150, 23);
            txb_foneTelaPesquisar.TabIndex = 7;
            // 
            // txb_nomeTelaPesquisar
            // 
            txb_nomeTelaPesquisar.Location = new Point(29, 41);
            txb_nomeTelaPesquisar.Name = "txb_nomeTelaPesquisar";
            txb_nomeTelaPesquisar.Size = new Size(261, 23);
            txb_nomeTelaPesquisar.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 143);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Fone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 23);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Nome:";
            // 
            // txb_BuscaPorNome_TelaPesquisa
            // 
            txb_BuscaPorNome_TelaPesquisa.BackColor = SystemColors.GradientInactiveCaption;
            txb_BuscaPorNome_TelaPesquisa.BorderStyle = BorderStyle.FixedSingle;
            txb_BuscaPorNome_TelaPesquisa.Location = new Point(81, 86);
            txb_BuscaPorNome_TelaPesquisa.Name = "txb_BuscaPorNome_TelaPesquisa";
            txb_BuscaPorNome_TelaPesquisa.Size = new Size(220, 23);
            txb_BuscaPorNome_TelaPesquisa.TabIndex = 7;
            // 
            // btn_BuscarTelaPesquisar
            // 
            btn_BuscarTelaPesquisar.Location = new Point(326, 80);
            btn_BuscarTelaPesquisar.Name = "btn_BuscarTelaPesquisar";
            btn_BuscarTelaPesquisar.Size = new Size(65, 31);
            btn_BuscarTelaPesquisar.TabIndex = 8;
            btn_BuscarTelaPesquisar.Text = "Buscar";
            btn_BuscarTelaPesquisar.UseVisualStyleBackColor = true;
            btn_BuscarTelaPesquisar.Click += btn_BuscarTelaPesquisar_Click;
            // 
            // btn_SAIR
            // 
            btn_SAIR.BackColor = Color.IndianRed;
            btn_SAIR.Location = new Point(378, 13);
            btn_SAIR.Name = "btn_SAIR";
            btn_SAIR.Size = new Size(75, 23);
            btn_SAIR.TabIndex = 9;
            btn_SAIR.Text = "Sair";
            btn_SAIR.UseVisualStyleBackColor = false;
            btn_SAIR.Click += btn_SAIR_Click;
            // 
            // TelaPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 410);
            Controls.Add(btn_SAIR);
            Controls.Add(btn_BuscarTelaPesquisar);
            Controls.Add(txb_BuscaPorNome_TelaPesquisa);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TelaPesquisar";
            Text = "TelaPesquisar";
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
        private TextBox txb_email_Telapesquisar;
        private TextBox txb_foneTelaPesquisar;
        private TextBox txb_nomeTelaPesquisar;
        private Label label6;
        private Label label5;
        private TextBox txb_BuscaPorNome_TelaPesquisa;
        private Button btn_BuscarTelaPesquisar;
        private Button btn_SAIR;
    }
}