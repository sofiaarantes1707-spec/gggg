namespace Menu_Calculos
{
    partial class CalculadoraPlus
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
            this.lblVisor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button04 = new System.Windows.Forms.Button();
            this.button05 = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.button09 = new System.Windows.Forms.Button();
            this.button08 = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.divisao = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.mais = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVisor
            // 
            this.lblVisor.BackColor = System.Drawing.Color.Thistle;
            this.lblVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVisor.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVisor.Location = new System.Drawing.Point(12, 54);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(552, 60);
            this.lblVisor.TabIndex = 7;
            this.lblVisor.Text = "0";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVisor.UseCompatibleTextRendering = true;
            this.lblVisor.Click += new System.EventHandler(this.lblVisor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.btnVirgula);
            this.panel1.Controls.Add(this.button00);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button03);
            this.panel1.Controls.Add(this.button02);
            this.panel1.Controls.Add(this.button01);
            this.panel1.Controls.Add(this.button04);
            this.panel1.Controls.Add(this.button05);
            this.panel1.Controls.Add(this.button06);
            this.panel1.Controls.Add(this.button09);
            this.panel1.Controls.Add(this.button08);
            this.panel1.Controls.Add(this.button07);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Location = new System.Drawing.Point(12, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 433);
            this.panel1.TabIndex = 8;
            this.panel1.Click += new System.EventHandler(this.f_digitos);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVirgula
            // 
            this.btnVirgula.AutoSize = true;
            this.btnVirgula.BackColor = System.Drawing.Color.Indigo;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVirgula.Location = new System.Drawing.Point(235, 350);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(76, 72);
            this.btnVirgula.TabIndex = 18;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // button00
            // 
            this.button00.AutoSize = true;
            this.button00.BackColor = System.Drawing.Color.Indigo;
            this.button00.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button00.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button00.Location = new System.Drawing.Point(131, 350);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(76, 72);
            this.button00.TabIndex = 17;
            this.button00.Text = "0";
            this.button00.UseVisualStyleBackColor = false;
            this.button00.Click += new System.EventHandler(this.f_digitos);
            // 
            // button21
            // 
            this.button21.AutoSize = true;
            this.button21.BackColor = System.Drawing.Color.Indigo;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button21.Location = new System.Drawing.Point(35, 350);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(76, 72);
            this.button21.TabIndex = 16;
            this.button21.Text = "+/-";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button03
            // 
            this.button03.AutoSize = true;
            this.button03.BackColor = System.Drawing.Color.Indigo;
            this.button03.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button03.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button03.Location = new System.Drawing.Point(235, 267);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(76, 72);
            this.button03.TabIndex = 15;
            this.button03.Text = "3";
            this.button03.UseVisualStyleBackColor = false;
            this.button03.Click += new System.EventHandler(this.f_digitos);
            // 
            // button02
            // 
            this.button02.AutoSize = true;
            this.button02.BackColor = System.Drawing.Color.Indigo;
            this.button02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button02.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button02.Location = new System.Drawing.Point(131, 267);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(76, 72);
            this.button02.TabIndex = 14;
            this.button02.Text = "2";
            this.button02.UseVisualStyleBackColor = false;
            this.button02.Click += new System.EventHandler(this.f_digitos);
            // 
            // button01
            // 
            this.button01.AutoSize = true;
            this.button01.BackColor = System.Drawing.Color.Indigo;
            this.button01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button01.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button01.Location = new System.Drawing.Point(35, 267);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(76, 72);
            this.button01.TabIndex = 13;
            this.button01.Text = "1";
            this.button01.UseVisualStyleBackColor = false;
            this.button01.Click += new System.EventHandler(this.f_digitos);
            // 
            // button04
            // 
            this.button04.AutoSize = true;
            this.button04.BackColor = System.Drawing.Color.Indigo;
            this.button04.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button04.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button04.Location = new System.Drawing.Point(235, 184);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(76, 72);
            this.button04.TabIndex = 12;
            this.button04.Text = "4";
            this.button04.UseVisualStyleBackColor = false;
            this.button04.Click += new System.EventHandler(this.f_digitos);
            // 
            // button05
            // 
            this.button05.AutoSize = true;
            this.button05.BackColor = System.Drawing.Color.Indigo;
            this.button05.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button05.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button05.Location = new System.Drawing.Point(131, 184);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(76, 72);
            this.button05.TabIndex = 11;
            this.button05.Text = "5";
            this.button05.UseVisualStyleBackColor = false;
            this.button05.Click += new System.EventHandler(this.f_digitos);
            // 
            // button06
            // 
            this.button06.AutoSize = true;
            this.button06.BackColor = System.Drawing.Color.Indigo;
            this.button06.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button06.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button06.Location = new System.Drawing.Point(35, 184);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(76, 72);
            this.button06.TabIndex = 10;
            this.button06.Text = "6";
            this.button06.UseVisualStyleBackColor = false;
            this.button06.Click += new System.EventHandler(this.f_digitos);
            // 
            // button09
            // 
            this.button09.AutoSize = true;
            this.button09.BackColor = System.Drawing.Color.Indigo;
            this.button09.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button09.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button09.Location = new System.Drawing.Point(235, 106);
            this.button09.Name = "button09";
            this.button09.Size = new System.Drawing.Size(76, 72);
            this.button09.TabIndex = 9;
            this.button09.Text = "9";
            this.button09.UseVisualStyleBackColor = false;
            this.button09.Click += new System.EventHandler(this.f_digitos);
            // 
            // button08
            // 
            this.button08.AutoSize = true;
            this.button08.BackColor = System.Drawing.Color.Indigo;
            this.button08.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button08.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button08.Location = new System.Drawing.Point(131, 106);
            this.button08.Name = "button08";
            this.button08.Size = new System.Drawing.Size(76, 72);
            this.button08.TabIndex = 8;
            this.button08.Text = "8";
            this.button08.UseVisualStyleBackColor = false;
            this.button08.Click += new System.EventHandler(this.f_digitos);
            // 
            // button07
            // 
            this.button07.AutoSize = true;
            this.button07.BackColor = System.Drawing.Color.Indigo;
            this.button07.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button07.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button07.Location = new System.Drawing.Point(35, 106);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(76, 72);
            this.button07.TabIndex = 7;
            this.button07.Text = "7";
            this.button07.UseVisualStyleBackColor = false;
            this.button07.Click += new System.EventHandler(this.f_digitos);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.Indigo;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(235, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 72);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<=";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Indigo;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(131, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 72);
            this.button4.TabIndex = 5;
            this.button4.Text = "CE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.Color.Indigo;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(35, 24);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 72);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.divisao);
            this.panel2.Controls.Add(this.menos);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.multiplicacao);
            this.panel2.Controls.Add(this.mais);
            this.panel2.Location = new System.Drawing.Point(376, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 433);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // divisao
            // 
            this.divisao.BackColor = System.Drawing.Color.MediumOrchid;
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.ForeColor = System.Drawing.Color.Purple;
            this.divisao.Location = new System.Drawing.Point(12, 326);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(154, 52);
            this.divisao.TabIndex = 4;
            this.divisao.Text = "/";
            this.divisao.UseVisualStyleBackColor = false;
            this.divisao.Click += new System.EventHandler(this.f_operacoes);
            // 
            // menos
            // 
            this.menos.BackColor = System.Drawing.Color.MediumOrchid;
            this.menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menos.ForeColor = System.Drawing.Color.Purple;
            this.menos.Location = new System.Drawing.Point(12, 144);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(154, 52);
            this.menos.TabIndex = 1;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = false;
            this.menos.Click += new System.EventHandler(this.f_operacoes);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-198, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // multiplicacao
            // 
            this.multiplicacao.BackColor = System.Drawing.Color.MediumOrchid;
            this.multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.ForeColor = System.Drawing.Color.Purple;
            this.multiplicacao.Location = new System.Drawing.Point(12, 234);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(154, 52);
            this.multiplicacao.TabIndex = 2;
            this.multiplicacao.Text = "x";
            this.multiplicacao.UseVisualStyleBackColor = false;
            this.multiplicacao.Click += new System.EventHandler(this.f_operacoes);
            // 
            // mais
            // 
            this.mais.BackColor = System.Drawing.Color.MediumOrchid;
            this.mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mais.ForeColor = System.Drawing.Color.Purple;
            this.mais.Location = new System.Drawing.Point(12, 57);
            this.mais.Name = "mais";
            this.mais.Size = new System.Drawing.Size(154, 52);
            this.mais.TabIndex = 0;
            this.mais.Text = "+";
            this.mais.UseVisualStyleBackColor = false;
            this.mais.Click += new System.EventHandler(this.f_operacoes);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnIgual.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.Purple;
            this.btnIgual.Location = new System.Drawing.Point(22, 609);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(544, 60);
            this.btnIgual.TabIndex = 1;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.bntigual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(18, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.BackColor = System.Drawing.Color.Plum;
            this.lblHistorico.Location = new System.Drawing.Point(513, 21);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(51, 20);
            this.lblHistorico.TabIndex = 11;
            this.lblHistorico.Text = "label2";
            // 
            // CalculadoraPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(578, 690);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVisor);
            this.Controls.Add(this.btnIgual);
            this.Name = "CalculadoraPlus";
            this.Text = "CalculadoraPlus";
            this.Load += new System.EventHandler(this.CalculadoraPlus_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculadoraPlus_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CalculadoraPlus_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button mais;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Button button09;
        private System.Windows.Forms.Button button08;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHistorico;
    }
}