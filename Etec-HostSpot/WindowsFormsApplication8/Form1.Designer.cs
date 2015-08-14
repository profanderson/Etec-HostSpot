namespace WindowsFormsApplication8
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.BtnCriarRede = new System.Windows.Forms.Button();
            this.TxtNomeDaRede = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstDetalhes = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.iniciarRedeJuntoComOWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarConexõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusDaRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoTécnicoEmInformáticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curtirNoAcebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCriarRede
            // 
            this.BtnCriarRede.Location = new System.Drawing.Point(279, 106);
            this.BtnCriarRede.Name = "BtnCriarRede";
            this.BtnCriarRede.Size = new System.Drawing.Size(75, 23);
            this.BtnCriarRede.TabIndex = 0;
            this.BtnCriarRede.Text = "Criar Rede";
            this.BtnCriarRede.UseVisualStyleBackColor = true;
            this.BtnCriarRede.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNomeDaRede
            // 
            this.TxtNomeDaRede.Location = new System.Drawing.Point(193, 54);
            this.TxtNomeDaRede.Name = "TxtNomeDaRede";
            this.TxtNomeDaRede.Size = new System.Drawing.Size(161, 20);
            this.TxtNomeDaRede.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome da Rede:";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(193, 80);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(161, 20);
            this.TxtSenha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(106, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Execute este aplicativo como Administrador.";
            // 
            // lstLog
            // 
            this.lstLog.BackColor = System.Drawing.SystemColors.WindowText;
            this.lstLog.ForeColor = System.Drawing.Color.White;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Items.AddRange(new object[] {
            " "});
            this.lstLog.Location = new System.Drawing.Point(19, 132);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(390, 212);
            this.lstLog.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pausar rede";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Excluir rede";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Conexões de Rede";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstDetalhes
            // 
            this.lstDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstDetalhes.ForeColor = System.Drawing.Color.Black;
            this.lstDetalhes.FormattingEnabled = true;
            this.lstDetalhes.Items.AddRange(new object[] {
            " "});
            this.lstDetalhes.Location = new System.Drawing.Point(421, 51);
            this.lstDetalhes.Name = "lstDetalhes";
            this.lstDetalhes.Size = new System.Drawing.Size(260, 290);
            this.lstDetalhes.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açõesToolStripMenuItem,
            this.cursoTécnicoEmInformáticaToolStripMenuItem,
            this.atualizaçãoToolStripMenuItem,
            this.curtirNoAcebookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // açõesToolStripMenuItem
            // 
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarRedeToolStripMenuItem,
            this.pausarRedeToolStripMenuItem,
            this.excluirRedeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.iniciarRedeJuntoComOWindowsToolStripMenuItem,
            this.verificarConexõesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.statusDaRedeToolStripMenuItem});
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            this.açõesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.açõesToolStripMenuItem.Text = "Ações";
            // 
            // criarRedeToolStripMenuItem
            // 
            this.criarRedeToolStripMenuItem.Name = "criarRedeToolStripMenuItem";
            this.criarRedeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.criarRedeToolStripMenuItem.Text = "Criar Rede";
            // 
            // pausarRedeToolStripMenuItem
            // 
            this.pausarRedeToolStripMenuItem.Name = "pausarRedeToolStripMenuItem";
            this.pausarRedeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.pausarRedeToolStripMenuItem.Text = "Pausar Rede";
            // 
            // excluirRedeToolStripMenuItem
            // 
            this.excluirRedeToolStripMenuItem.Name = "excluirRedeToolStripMenuItem";
            this.excluirRedeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.excluirRedeToolStripMenuItem.Text = "Excluir Rede";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(220, 6);
            // 
            // iniciarRedeJuntoComOWindowsToolStripMenuItem
            // 
            this.iniciarRedeJuntoComOWindowsToolStripMenuItem.Name = "iniciarRedeJuntoComOWindowsToolStripMenuItem";
            this.iniciarRedeJuntoComOWindowsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.iniciarRedeJuntoComOWindowsToolStripMenuItem.Text = "Iniciarjunto com o Windows";
            // 
            // verificarConexõesToolStripMenuItem
            // 
            this.verificarConexõesToolStripMenuItem.Name = "verificarConexõesToolStripMenuItem";
            this.verificarConexõesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.verificarConexõesToolStripMenuItem.Text = "Verificar conectados";
            this.verificarConexõesToolStripMenuItem.Click += new System.EventHandler(this.verificarConexõesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 6);
            // 
            // statusDaRedeToolStripMenuItem
            // 
            this.statusDaRedeToolStripMenuItem.Name = "statusDaRedeToolStripMenuItem";
            this.statusDaRedeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.statusDaRedeToolStripMenuItem.Text = "Status da Rede";
            // 
            // cursoTécnicoEmInformáticaToolStripMenuItem
            // 
            this.cursoTécnicoEmInformáticaToolStripMenuItem.Name = "cursoTécnicoEmInformáticaToolStripMenuItem";
            this.cursoTécnicoEmInformáticaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.cursoTécnicoEmInformáticaToolStripMenuItem.Text = "Sobre";
            // 
            // atualizaçãoToolStripMenuItem
            // 
            this.atualizaçãoToolStripMenuItem.Name = "atualizaçãoToolStripMenuItem";
            this.atualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.atualizaçãoToolStripMenuItem.Text = "Atualização";
            // 
            // curtirNoAcebookToolStripMenuItem
            // 
            this.curtirNoAcebookToolStripMenuItem.Name = "curtirNoAcebookToolStripMenuItem";
            this.curtirNoAcebookToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.curtirNoAcebookToolStripMenuItem.Text = "Curtir no Facebook";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(622, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 9999;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 392);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lstDetalhes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeDaRede);
            this.Controls.Add(this.BtnCriarRede);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ETEC HotSpot - Curso Técnico em Informática da ETEC Atibaia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCriarRede;
        private System.Windows.Forms.TextBox TxtNomeDaRede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstDetalhes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cursoTécnicoEmInformáticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curtirNoAcebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarRedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarRedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirRedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem iniciarRedeJuntoComOWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarConexõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statusDaRedeToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}

