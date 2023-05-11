namespace Atividade17_JogoDaForca.WinForm
{
    partial class JogoDaForcaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JogoDaForcaForm));
            picBoxErro1 = new PictureBox();
            picBoxErro2 = new PictureBox();
            picBoxErro3 = new PictureBox();
            picBoxErro4 = new PictureBox();
            picBoxErro5 = new PictureBox();
            picBoxErro6 = new PictureBox();
            txtChute = new TextBox();
            labelPalavraSecreta = new Label();
            btnChute = new Button();
            btnJogarNovamente = new Button();
            picBoxAcertoPart1 = new PictureBox();
            picBoxAcertoPart2 = new PictureBox();
            picBoxGameOver = new PictureBox();
            picBoxStart = new PictureBox();
            btnStart = new Button();
            labelLetrasErradas = new Label();
            labelRevelaPalavraSecreta = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxErro1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxErro2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxErro3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxErro4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxErro5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxErro6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAcertoPart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAcertoPart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxGameOver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxStart).BeginInit();
            SuspendLayout();
            // 
            // picBoxErro1
            // 
            picBoxErro1.Dock = DockStyle.Fill;
            picBoxErro1.Image = Properties.Resources._1;
            picBoxErro1.Location = new Point(0, 0);
            picBoxErro1.Name = "picBoxErro1";
            picBoxErro1.Size = new Size(926, 610);
            picBoxErro1.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxErro1.TabIndex = 0;
            picBoxErro1.TabStop = false;
            // 
            // picBoxErro2
            // 
            picBoxErro2.Dock = DockStyle.Fill;
            picBoxErro2.Image = Properties.Resources._2;
            picBoxErro2.Location = new Point(0, 0);
            picBoxErro2.Name = "picBoxErro2";
            picBoxErro2.Size = new Size(926, 610);
            picBoxErro2.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxErro2.TabIndex = 1;
            picBoxErro2.TabStop = false;
            // 
            // picBoxErro3
            // 
            picBoxErro3.Dock = DockStyle.Fill;
            picBoxErro3.Image = Properties.Resources._3;
            picBoxErro3.Location = new Point(0, 0);
            picBoxErro3.Name = "picBoxErro3";
            picBoxErro3.Size = new Size(926, 610);
            picBoxErro3.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxErro3.TabIndex = 2;
            picBoxErro3.TabStop = false;
            // 
            // picBoxErro4
            // 
            picBoxErro4.Dock = DockStyle.Fill;
            picBoxErro4.Image = Properties.Resources._4;
            picBoxErro4.Location = new Point(0, 0);
            picBoxErro4.Name = "picBoxErro4";
            picBoxErro4.Size = new Size(926, 610);
            picBoxErro4.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxErro4.TabIndex = 3;
            picBoxErro4.TabStop = false;
            // 
            // picBoxErro5
            // 
            picBoxErro5.Dock = DockStyle.Fill;
            picBoxErro5.Image = Properties.Resources._5;
            picBoxErro5.Location = new Point(0, 0);
            picBoxErro5.Name = "picBoxErro5";
            picBoxErro5.Size = new Size(926, 610);
            picBoxErro5.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxErro5.TabIndex = 4;
            picBoxErro5.TabStop = false;
            // 
            // picBoxErro6
            // 
            picBoxErro6.Dock = DockStyle.Fill;
            picBoxErro6.Image = Properties.Resources._6;
            picBoxErro6.Location = new Point(0, 0);
            picBoxErro6.Name = "picBoxErro6";
            picBoxErro6.Size = new Size(926, 610);
            picBoxErro6.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxErro6.TabIndex = 5;
            picBoxErro6.TabStop = false;
            // 
            // txtChute
            // 
            txtChute.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtChute.BorderStyle = BorderStyle.None;
            txtChute.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtChute.HideSelection = false;
            txtChute.Location = new Point(755, 547);
            txtChute.MaxLength = 1;
            txtChute.Name = "txtChute";
            txtChute.Size = new Size(78, 36);
            txtChute.TabIndex = 7;
            txtChute.KeyPress += ApenasMaiusculo;
            // 
            // labelPalavraSecreta
            // 
            labelPalavraSecreta.AutoSize = true;
            labelPalavraSecreta.BackColor = Color.FromArgb(112, 205, 255);
            labelPalavraSecreta.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            labelPalavraSecreta.Location = new Point(400, 358);
            labelPalavraSecreta.Name = "labelPalavraSecreta";
            labelPalavraSecreta.Size = new Size(0, 81);
            labelPalavraSecreta.TabIndex = 8;
            // 
            // btnChute
            // 
            btnChute.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnChute.Location = new Point(839, 547);
            btnChute.Name = "btnChute";
            btnChute.Size = new Size(60, 36);
            btnChute.TabIndex = 9;
            btnChute.TabStop = false;
            btnChute.Text = "Chute!";
            btnChute.UseVisualStyleBackColor = true;
            btnChute.Click += ObterChute;
            // 
            // btnJogarNovamente
            // 
            btnJogarNovamente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnJogarNovamente.Location = new Point(540, 445);
            btnJogarNovamente.Name = "btnJogarNovamente";
            btnJogarNovamente.Size = new Size(157, 49);
            btnJogarNovamente.TabIndex = 10;
            btnJogarNovamente.Text = "Jogar Novamente";
            btnJogarNovamente.UseVisualStyleBackColor = true;
            btnJogarNovamente.Visible = false;
            btnJogarNovamente.Click += Jogar;
            // 
            // picBoxAcertoPart1
            // 
            picBoxAcertoPart1.Image = Properties.Resources.acertoPart1;
            picBoxAcertoPart1.Location = new Point(397, 211);
            picBoxAcertoPart1.Name = "picBoxAcertoPart1";
            picBoxAcertoPart1.Size = new Size(423, 228);
            picBoxAcertoPart1.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxAcertoPart1.TabIndex = 11;
            picBoxAcertoPart1.TabStop = false;
            picBoxAcertoPart1.Visible = false;
            // 
            // picBoxAcertoPart2
            // 
            picBoxAcertoPart2.Image = Properties.Resources.acertoPart2;
            picBoxAcertoPart2.Location = new Point(144, 126);
            picBoxAcertoPart2.Name = "picBoxAcertoPart2";
            picBoxAcertoPart2.Size = new Size(495, 184);
            picBoxAcertoPart2.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxAcertoPart2.TabIndex = 12;
            picBoxAcertoPart2.TabStop = false;
            picBoxAcertoPart2.Visible = false;
            // 
            // picBoxGameOver
            // 
            picBoxGameOver.Image = Properties.Resources.gameOver;
            picBoxGameOver.Location = new Point(426, 174);
            picBoxGameOver.Name = "picBoxGameOver";
            picBoxGameOver.Size = new Size(373, 265);
            picBoxGameOver.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxGameOver.TabIndex = 13;
            picBoxGameOver.TabStop = false;
            picBoxGameOver.Visible = false;
            // 
            // picBoxStart
            // 
            picBoxStart.Dock = DockStyle.Fill;
            picBoxStart.Image = Properties.Resources.telaStart;
            picBoxStart.Location = new Point(0, 0);
            picBoxStart.Name = "picBoxStart";
            picBoxStart.Size = new Size(926, 610);
            picBoxStart.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxStart.TabIndex = 14;
            picBoxStart.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(192, 255, 192);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(530, 405);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(89, 34);
            btnStart.TabIndex = 15;
            btnStart.Text = "Jogar";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += Jogar;
            // 
            // labelLetrasErradas
            // 
            labelLetrasErradas.AutoSize = true;
            labelLetrasErradas.BackColor = Color.FromArgb(112, 205, 255);
            labelLetrasErradas.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelLetrasErradas.Location = new Point(298, 130);
            labelLetrasErradas.Name = "labelLetrasErradas";
            labelLetrasErradas.Size = new Size(0, 28);
            labelLetrasErradas.TabIndex = 16;
            // 
            // labelRevelaPalavraSecreta
            // 
            labelRevelaPalavraSecreta.AutoSize = true;
            labelRevelaPalavraSecreta.BackColor = Color.FromArgb(112, 205, 255);
            labelRevelaPalavraSecreta.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelRevelaPalavraSecreta.Location = new Point(272, 126);
            labelRevelaPalavraSecreta.Name = "labelRevelaPalavraSecreta";
            labelRevelaPalavraSecreta.Size = new Size(0, 28);
            labelRevelaPalavraSecreta.TabIndex = 17;
            // 
            // JogoDaForcaForm
            // 
            AcceptButton = btnChute;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 610);
            Controls.Add(labelRevelaPalavraSecreta);
            Controls.Add(btnStart);
            Controls.Add(picBoxStart);
            Controls.Add(btnJogarNovamente);
            Controls.Add(picBoxGameOver);
            Controls.Add(picBoxAcertoPart1);
            Controls.Add(picBoxAcertoPart2);
            Controls.Add(labelLetrasErradas);
            Controls.Add(btnChute);
            Controls.Add(labelPalavraSecreta);
            Controls.Add(txtChute);
            Controls.Add(picBoxErro1);
            Controls.Add(picBoxErro2);
            Controls.Add(picBoxErro3);
            Controls.Add(picBoxErro4);
            Controls.Add(picBoxErro5);
            Controls.Add(picBoxErro6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "JogoDaForcaForm";
            Text = "Salve o Timmy";
            ((System.ComponentModel.ISupportInitialize)picBoxErro1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxErro2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxErro3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxErro4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxErro5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxErro6).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAcertoPart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAcertoPart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxGameOver).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxStart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxErro1;
        private PictureBox picBoxErro2;
        private PictureBox picBoxErro3;
        private PictureBox picBoxErro4;
        private PictureBox picBoxErro5;
        private PictureBox picBoxErro6;
        private TextBox txtChute;
        private Label labelPalavraSecreta;
        private Button btnChute;
        private Button btnJogarNovamente;
        private PictureBox picBoxAcertoPart1;
        private PictureBox picBoxAcertoPart2;
        private PictureBox picBoxGameOver;
        private PictureBox picBoxStart;
        private Button btnStart;
        private Label labelLetrasErradas;
        private Label labelRevelaPalavraSecreta;
    }
}