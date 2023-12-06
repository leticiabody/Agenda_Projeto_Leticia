namespace Agenda_Projeto_Leticia.View
{
    partial class Menu
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
            btn_Cadastrar = new Button();
            btn_Pesquisar = new Button();
            btn_Alterar = new Button();
            btn_Deletar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = SystemColors.GradientInactiveCaption;
            btn_Cadastrar.Location = new Point(29, 108);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(141, 76);
            btn_Cadastrar.TabIndex = 0;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.BackColor = SystemColors.GradientInactiveCaption;
            btn_Pesquisar.Location = new Point(256, 108);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(141, 76);
            btn_Pesquisar.TabIndex = 1;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = false;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // btn_Alterar
            // 
            btn_Alterar.BackColor = SystemColors.GradientInactiveCaption;
            btn_Alterar.Location = new Point(29, 273);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(141, 76);
            btn_Alterar.TabIndex = 2;
            btn_Alterar.Text = "Alterar";
            btn_Alterar.UseVisualStyleBackColor = false;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // btn_Deletar
            // 
            btn_Deletar.BackColor = SystemColors.GradientInactiveCaption;
            btn_Deletar.Location = new Point(256, 273);
            btn_Deletar.Name = "btn_Deletar";
            btn_Deletar.Size = new Size(141, 76);
            btn_Deletar.TabIndex = 3;
            btn_Deletar.Text = "Deletar";
            btn_Deletar.UseVisualStyleBackColor = false;
            btn_Deletar.Click += btn_Deletar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 31);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 4;
            label1.Text = "Agenda de Pessoas";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(427, 397);
            Controls.Add(label1);
            Controls.Add(btn_Deletar);
            Controls.Add(btn_Alterar);
            Controls.Add(btn_Pesquisar);
            Controls.Add(btn_Cadastrar);
            MaximizeBox = false;
            Name = "Menu";
            ShowIcon = false;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cadastrar;
        private Button btn_Pesquisar;
        private Button btn_Alterar;
        private Button btn_Deletar;
        private Label label1;
    }
}