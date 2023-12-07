namespace Agenda_Projeto_Leticia.View
{
    partial class TelaPesquisarCodigo
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
            txb_BuscaPorCodigoTelaBuscarporcodigo = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txb_emailTelaBuscarporCodigo = new TextBox();
            txb_foneTelaBuscarporCodigo = new TextBox();
            label9 = new Label();
            txb_nomeTelaBuscarporCodigo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btn_BuscarTelaPorCodigo = new Button();
            btnSAAIRR = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txb_BuscaPorCodigoTelaBuscarporcodigo
            // 
            txb_BuscaPorCodigoTelaBuscarporcodigo.BackColor = SystemColors.GradientInactiveCaption;
            txb_BuscaPorCodigoTelaBuscarporcodigo.BorderStyle = BorderStyle.FixedSingle;
            txb_BuscaPorCodigoTelaBuscarporcodigo.Location = new Point(83, 56);
            txb_BuscaPorCodigoTelaBuscarporcodigo.Name = "txb_BuscaPorCodigoTelaBuscarporcodigo";
            txb_BuscaPorCodigoTelaBuscarporcodigo.Size = new Size(142, 23);
            txb_BuscaPorCodigoTelaBuscarporcodigo.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(88, 33);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 9;
            label4.Text = "Buscar por Código";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ScrollBar;
            groupBox2.Controls.Add(txb_emailTelaBuscarporCodigo);
            groupBox2.Controls.Add(txb_foneTelaBuscarporCodigo);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txb_nomeTelaBuscarporCodigo);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(97, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 257);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // txb_emailTelaBuscarporCodigo
            // 
            txb_emailTelaBuscarporCodigo.Location = new Point(27, 179);
            txb_emailTelaBuscarporCodigo.Name = "txb_emailTelaBuscarporCodigo";
            txb_emailTelaBuscarporCodigo.Size = new Size(150, 23);
            txb_emailTelaBuscarporCodigo.TabIndex = 14;
            // 
            // txb_foneTelaBuscarporCodigo
            // 
            txb_foneTelaBuscarporCodigo.Location = new Point(27, 104);
            txb_foneTelaBuscarporCodigo.Name = "txb_foneTelaBuscarporCodigo";
            txb_foneTelaBuscarporCodigo.Size = new Size(150, 23);
            txb_foneTelaBuscarporCodigo.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 19);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 10;
            label9.Text = "Nome:";
            // 
            // txb_nomeTelaBuscarporCodigo
            // 
            txb_nomeTelaBuscarporCodigo.Location = new Point(27, 37);
            txb_nomeTelaBuscarporCodigo.Name = "txb_nomeTelaBuscarporCodigo";
            txb_nomeTelaBuscarporCodigo.Size = new Size(150, 23);
            txb_nomeTelaBuscarporCodigo.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 86);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 11;
            label8.Text = "Fone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 161);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 9;
            label7.Text = "Email:";
            // 
            // btn_BuscarTelaPorCodigo
            // 
            btn_BuscarTelaPorCodigo.Location = new Point(241, 56);
            btn_BuscarTelaPorCodigo.Name = "btn_BuscarTelaPorCodigo";
            btn_BuscarTelaPorCodigo.Size = new Size(75, 23);
            btn_BuscarTelaPorCodigo.TabIndex = 12;
            btn_BuscarTelaPorCodigo.Text = "Buscar";
            btn_BuscarTelaPorCodigo.UseVisualStyleBackColor = true;
            btn_BuscarTelaPorCodigo.Click += btn_BuscarTelaPorCodigo_Click;
            // 
            // btnSAAIRR
            // 
            btnSAAIRR.BackColor = Color.IndianRed;
            btnSAAIRR.Location = new Point(340, 12);
            btnSAAIRR.Name = "btnSAAIRR";
            btnSAAIRR.Size = new Size(75, 23);
            btnSAAIRR.TabIndex = 13;
            btnSAAIRR.Text = "Sair";
            btnSAAIRR.UseVisualStyleBackColor = false;
            btnSAAIRR.Click += btnSAAIRR_Click;
            // 
            // TelaPesquisarCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 397);
            Controls.Add(btnSAAIRR);
            Controls.Add(btn_BuscarTelaPorCodigo);
            Controls.Add(txb_BuscaPorCodigoTelaBuscarporcodigo);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Name = "TelaPesquisarCodigo";
            Text = "TelaPesquisarCodigo";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_BuscaPorCodigoTelaBuscarporcodigo;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox txb_emailTelaBuscarporCodigo;
        private TextBox txb_foneTelaBuscarporCodigo;
        private Label label9;
        private TextBox txb_nomeTelaBuscarporCodigo;
        private Label label8;
        private Label label7;
        private Button btn_BuscarTelaPorCodigo;
        private Button btnSAAIRR;
    }
}