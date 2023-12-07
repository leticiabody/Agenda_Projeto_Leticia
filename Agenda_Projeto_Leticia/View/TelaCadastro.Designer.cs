namespace Agenda_Projeto_Leticia.View
{
    partial class TelaCadastro
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
            txb_nomeCadastro = new TextBox();
            txb_emailCadastro = new TextBox();
            txb_celularCadastro = new TextBox();
            btn_CadastrarTelaCadastro = new Button();
            btnSairCadastro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 45);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de dados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(43, 140);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(43, 178);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(43, 221);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Celular:";
            // 
            // txb_nomeCadastro
            // 
            txb_nomeCadastro.Location = new Point(139, 140);
            txb_nomeCadastro.Name = "txb_nomeCadastro";
            txb_nomeCadastro.Size = new Size(222, 23);
            txb_nomeCadastro.TabIndex = 4;
            // 
            // txb_emailCadastro
            // 
            txb_emailCadastro.Location = new Point(139, 179);
            txb_emailCadastro.Name = "txb_emailCadastro";
            txb_emailCadastro.Size = new Size(222, 23);
            txb_emailCadastro.TabIndex = 5;
            // 
            // txb_celularCadastro
            // 
            txb_celularCadastro.Location = new Point(139, 222);
            txb_celularCadastro.Name = "txb_celularCadastro";
            txb_celularCadastro.Size = new Size(100, 23);
            txb_celularCadastro.TabIndex = 6;
            // 
            // btn_CadastrarTelaCadastro
            // 
            btn_CadastrarTelaCadastro.BackColor = SystemColors.ControlLightLight;
            btn_CadastrarTelaCadastro.Location = new Point(283, 281);
            btn_CadastrarTelaCadastro.Name = "btn_CadastrarTelaCadastro";
            btn_CadastrarTelaCadastro.Size = new Size(78, 35);
            btn_CadastrarTelaCadastro.TabIndex = 7;
            btn_CadastrarTelaCadastro.Text = "Cadastrar";
            btn_CadastrarTelaCadastro.UseVisualStyleBackColor = false;
            btn_CadastrarTelaCadastro.Click += btn_CadastrarTelaCadastro_Click;
            // 
            // btnSairCadastro
            // 
            btnSairCadastro.BackColor = Color.IndianRed;
            btnSairCadastro.Location = new Point(351, 12);
            btnSairCadastro.Name = "btnSairCadastro";
            btnSairCadastro.Size = new Size(75, 23);
            btnSairCadastro.TabIndex = 8;
            btnSairCadastro.Text = "Sair";
            btnSairCadastro.UseVisualStyleBackColor = false;
            btnSairCadastro.Click += btnSairCadastro_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(427, 397);
            Controls.Add(btnSairCadastro);
            Controls.Add(btn_CadastrarTelaCadastro);
            Controls.Add(txb_celularCadastro);
            Controls.Add(txb_emailCadastro);
            Controls.Add(txb_nomeCadastro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txb_nomeCadastro;
        private TextBox txb_emailCadastro;
        private TextBox txb_celularCadastro;
        private Button btn_CadastrarTelaCadastro;
        private Button btnSairCadastro;
    }
}