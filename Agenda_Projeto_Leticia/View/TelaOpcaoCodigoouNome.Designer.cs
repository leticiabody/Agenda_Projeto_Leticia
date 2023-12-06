namespace Agenda_Projeto_Leticia.View
{
    partial class TelaOpcaoCodigoouNome
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
            btn_pornome = new Button();
            btn_porcodigo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 23);
            label1.Name = "label1";
            label1.Size = new Size(275, 21);
            label1.TabIndex = 0;
            label1.Text = "Pesquisa Por nome ou por Código?";
            // 
            // btn_pornome
            // 
            btn_pornome.BackColor = SystemColors.ControlLightLight;
            btn_pornome.ForeColor = SystemColors.Highlight;
            btn_pornome.Location = new Point(164, 89);
            btn_pornome.Name = "btn_pornome";
            btn_pornome.Size = new Size(102, 49);
            btn_pornome.TabIndex = 1;
            btn_pornome.Text = "Por Nome";
            btn_pornome.UseVisualStyleBackColor = false;
            btn_pornome.Click += button1_Click;
            // 
            // btn_porcodigo
            // 
            btn_porcodigo.BackColor = SystemColors.ControlLightLight;
            btn_porcodigo.ForeColor = SystemColors.Highlight;
            btn_porcodigo.Location = new Point(22, 89);
            btn_porcodigo.Name = "btn_porcodigo";
            btn_porcodigo.Size = new Size(102, 49);
            btn_porcodigo.TabIndex = 2;
            btn_porcodigo.Text = "Por Código";
            btn_porcodigo.UseVisualStyleBackColor = false;
            btn_porcodigo.Click += button2_Click;
            // 
            // TelaOpcaoCodigoouNome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(288, 175);
            Controls.Add(btn_porcodigo);
            Controls.Add(btn_pornome);
            Controls.Add(label1);
            Name = "TelaOpcaoCodigoouNome";
            Text = "TelaOpcaoCodigoouNome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_pornome;
        private Button btn_porcodigo;
    }
}