namespace GestaoHospital.front.Desktop.Ui
{
    partial class FrmMapa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            grvMapa = new DataGridView();
            panel4 = new Panel();
            tbcControle = new TabControl();
            tbpPesquisa = new TabPage();
            panel7 = new Panel();
            panel9 = new Panel();
            lblEspecialidade = new Label();
            txbEspecialidade = new TextBox();
            label1 = new Label();
            lblPesquisaNome = new Label();
            txbPesquisaNome = new TextBox();
            panel8 = new Panel();
            btnPesquisar = new Button();
            tabPage2 = new TabPage();
            panel6 = new Panel();
            btnAlterar = new Button();
            btnCadastrar = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvMapa).BeginInit();
            panel4.SuspendLayout();
            tbcControle.SuspendLayout();
            tbpPesquisa.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            tabPage2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(956, 684);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(956, 660);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(grvMapa);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(735, 660);
            panel5.TabIndex = 1;
            // 
            // grvMapa
            // 
            grvMapa.AllowUserToAddRows = false;
            grvMapa.AllowUserToDeleteRows = false;
            grvMapa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvMapa.Dock = DockStyle.Fill;
            grvMapa.Location = new Point(0, 0);
            grvMapa.Name = "grvMapa";
            grvMapa.ReadOnly = true;
            grvMapa.Size = new Size(735, 660);
            grvMapa.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(tbcControle);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(735, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 660);
            panel4.TabIndex = 0;
            // 
            // tbcControle
            // 
            tbcControle.Controls.Add(tbpPesquisa);
            tbcControle.Controls.Add(tabPage2);
            tbcControle.Dock = DockStyle.Fill;
            tbcControle.Location = new Point(0, 0);
            tbcControle.Name = "tbcControle";
            tbcControle.SelectedIndex = 0;
            tbcControle.Size = new Size(221, 660);
            tbcControle.TabIndex = 0;
            // 
            // tbpPesquisa
            // 
            tbpPesquisa.Controls.Add(panel7);
            tbpPesquisa.Location = new Point(4, 24);
            tbpPesquisa.Name = "tbpPesquisa";
            tbpPesquisa.Padding = new Padding(3);
            tbpPesquisa.Size = new Size(213, 632);
            tbpPesquisa.TabIndex = 0;
            tbpPesquisa.Text = "Pesquisa";
            tbpPesquisa.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(207, 626);
            panel7.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(lblEspecialidade);
            panel9.Controls.Add(txbEspecialidade);
            panel9.Controls.Add(label1);
            panel9.Controls.Add(lblPesquisaNome);
            panel9.Controls.Add(txbPesquisaNome);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(207, 575);
            panel9.TabIndex = 1;
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.AutoSize = true;
            lblEspecialidade.Location = new Point(6, 70);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(78, 15);
            lblEspecialidade.TabIndex = 6;
            lblEspecialidade.Text = "Especialidade";
            // 
            // txbEspecialidade
            // 
            txbEspecialidade.BorderStyle = BorderStyle.FixedSingle;
            txbEspecialidade.Cursor = Cursors.IBeam;
            txbEspecialidade.Location = new Point(3, 89);
            txbEspecialidade.Name = "txbEspecialidade";
            txbEspecialidade.Size = new Size(199, 23);
            txbEspecialidade.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            label1.Location = new Point(42, 11);
            label1.Name = "label1";
            label1.Size = new Size(75, 12);
            label1.TabIndex = 2;
            label1.Text = "(Parte do nome)";
            // 
            // lblPesquisaNome
            // 
            lblPesquisaNome.AutoSize = true;
            lblPesquisaNome.Location = new Point(6, 10);
            lblPesquisaNome.Name = "lblPesquisaNome";
            lblPesquisaNome.Size = new Size(40, 15);
            lblPesquisaNome.TabIndex = 1;
            lblPesquisaNome.Text = "Nome";
            // 
            // txbPesquisaNome
            // 
            txbPesquisaNome.BorderStyle = BorderStyle.FixedSingle;
            txbPesquisaNome.Cursor = Cursors.IBeam;
            txbPesquisaNome.Location = new Point(3, 29);
            txbPesquisaNome.Name = "txbPesquisaNome";
            txbPesquisaNome.Size = new Size(199, 23);
            txbPesquisaNome.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnPesquisar);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 575);
            panel8.Name = "panel8";
            panel8.Size = new Size(207, 51);
            panel8.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Green;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.Dock = DockStyle.Fill;
            btnPesquisar.Font = new Font("Calibri", 14F, FontStyle.Bold);
            btnPesquisar.ForeColor = SystemColors.ButtonHighlight;
            btnPesquisar.Location = new Point(0, 0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(207, 51);
            btnPesquisar.TabIndex = 0;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(213, 409);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnAlterar);
            panel6.Controls.Add(btnCadastrar);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(207, 403);
            panel6.TabIndex = 0;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.Green;
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.Dock = DockStyle.Top;
            btnAlterar.Enabled = false;
            btnAlterar.Font = new Font("Calibri", 14F, FontStyle.Bold);
            btnAlterar.ForeColor = SystemColors.ButtonHighlight;
            btnAlterar.Location = new Point(0, 51);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(207, 51);
            btnAlterar.TabIndex = 2;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Green;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Dock = DockStyle.Top;
            btnCadastrar.Font = new Font("Calibri", 14F, FontStyle.Bold);
            btnCadastrar.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrar.Location = new Point(0, 0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(207, 51);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 660);
            panel2.Name = "panel2";
            panel2.Size = new Size(956, 24);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(956, 684);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(972, 723);
            MinimumSize = new Size(972, 723);
            Name = "Form1";
            ShowIcon = false;
            Text = "Mapa de pacientes";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grvMapa).EndInit();
            panel4.ResumeLayout(false);
            tbcControle.ResumeLayout(false);
            tbpPesquisa.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private DataGridView grvMapa;
        private Panel panel4;
        private TabControl tbcControle;
        private TabPage tbpPesquisa;
        private Panel panel7;
        private Panel panel9;
        private Label lblEspecialidade;
        private TextBox txbEspecialidade;
        private Label label1;
        private Label lblPesquisaNome;
        private TextBox txbPesquisaNome;
        private Panel panel8;
        private Button btnPesquisar;
        private TabPage tabPage2;
        private Panel panel6;
        private Button btnAlterar;
        private Button btnCadastrar;
        private Panel panel2;
    }
}
