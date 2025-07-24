namespace Standard_Calculator
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            visorTextBox = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            botao0 = new System.Windows.Forms.Button();
            botao3 = new System.Windows.Forms.Button();
            botao2 = new System.Windows.Forms.Button();
            botao1 = new System.Windows.Forms.Button();
            botao6 = new System.Windows.Forms.Button();
            botao5 = new System.Windows.Forms.Button();
            botao4 = new System.Windows.Forms.Button();
            botao9 = new System.Windows.Forms.Button();
            botao8 = new System.Windows.Forms.Button();
            botao7 = new System.Windows.Forms.Button();
            botaoSoma = new System.Windows.Forms.Button();
            botaoSubtracao = new System.Windows.Forms.Button();
            botaoMultiplicacao = new System.Windows.Forms.Button();
            botaoDivisao = new System.Windows.Forms.Button();
            botaoLimpar = new System.Windows.Forms.Button();
            botaoIgual = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // visorTextBox
            // 
            visorTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            visorTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            visorTextBox.Location = new System.Drawing.Point(0, 0);
            visorTextBox.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            visorTextBox.Multiline = true;
            visorTextBox.Name = "visorTextBox";
            visorTextBox.ReadOnly = true;
            visorTextBox.Size = new System.Drawing.Size(578, 85);
            visorTextBox.TabIndex = 1;
            visorTextBox.Text = "0";
            visorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(botao0, 0, 4);
            tableLayoutPanel1.Controls.Add(botao3, 2, 3);
            tableLayoutPanel1.Controls.Add(botao2, 1, 3);
            tableLayoutPanel1.Controls.Add(botao1, 0, 3);
            tableLayoutPanel1.Controls.Add(botao6, 2, 2);
            tableLayoutPanel1.Controls.Add(botao5, 1, 2);
            tableLayoutPanel1.Controls.Add(botao4, 0, 2);
            tableLayoutPanel1.Controls.Add(botao9, 2, 1);
            tableLayoutPanel1.Controls.Add(botao8, 1, 1);
            tableLayoutPanel1.Controls.Add(botao7, 0, 1);
            tableLayoutPanel1.Controls.Add(botaoSoma, 3, 4);
            tableLayoutPanel1.Controls.Add(botaoSubtracao, 3, 3);
            tableLayoutPanel1.Controls.Add(botaoMultiplicacao, 3, 2);
            tableLayoutPanel1.Controls.Add(botaoDivisao, 3, 1);
            tableLayoutPanel1.Controls.Add(botaoLimpar, 3, 0);
            tableLayoutPanel1.Controls.Add(botaoIgual, 2, 4);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(578, 350);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // botao0
            // 
            tableLayoutPanel1.SetColumnSpan(botao0, 2);
            botao0.Dock = System.Windows.Forms.DockStyle.Fill;
            botao0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botao0.Location = new System.Drawing.Point(36, 294);
            botao0.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botao0.Name = "botao0";
            botao0.Size = new System.Drawing.Size(216, 42);
            botao0.TabIndex = 1;
            botao0.Text = "0";
            botao0.Click += ClicouNumero;
            // 
            // botao3
            // 
            botao3.Dock = System.Windows.Forms.DockStyle.Fill;
            botao3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botao3.Location = new System.Drawing.Point(324, 224);
            botao3.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botao3.Name = "botao3";
            botao3.Size = new System.Drawing.Size(72, 42);
            botao3.TabIndex = 2;
            botao3.Text = "3";
            botao3.Click += ClicouNumero;
            // 
            // botao2
            // 
            botao2.Dock = System.Windows.Forms.DockStyle.Fill;
            botao2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botao2.Location = new System.Drawing.Point(180, 224);
            botao2.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botao2.Name = "botao2";
            botao2.Size = new System.Drawing.Size(72, 42);
            botao2.TabIndex = 3;
            botao2.Text = "2";
            botao2.Click += ClicouNumero;
            // 
            // botao1
            // 
            botao1.Dock = System.Windows.Forms.DockStyle.Fill;
            botao1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botao1.Location = new System.Drawing.Point(36, 224);
            botao1.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botao1.Name = "botao1";
            botao1.Size = new System.Drawing.Size(72, 42);
            botao1.TabIndex = 4;
            botao1.Text = "1";
            botao1.Click += ClicouNumero;
            // 
            // botao6
            // 
            botao6.Dock = System.Windows.Forms.DockStyle.Fill;
            botao6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botao6.Location = new System.Drawing.Point(324, 154);
            botao6.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botao6.Name = "botao6";
            botao6.Size = new System.Drawing.Size(72, 42);
            botao6.TabIndex = 5;
            botao6.Text = "6";
            botao6.Click += ClicouNumero;
            // 
            // botao5
            // 
            botao5.Dock = System.Windows.Forms.DockStyle.Fill;
            botao5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botao5.Location = new System.Drawing.Point(180, 154);
            botao5.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botao5.Name = "botao5";
            botao5.Size = new System.Drawing.Size(72, 42);
            botao5.TabIndex = 6;
            botao5.Text = "5";
            botao5.Click += ClicouNumero;
            // 
            // botao4
            // 
            botao4.Dock = System.Windows.Forms.DockStyle.Fill;
            botao4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botao4.Location = new System.Drawing.Point(36, 154);
            botao4.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botao4.Name = "botao4";
            botao4.Size = new System.Drawing.Size(72, 42);
            botao4.TabIndex = 7;
            botao4.Text = "4";
            botao4.Click += ClicouNumero;
            // 
            // botao9
            // 
            botao9.Dock = System.Windows.Forms.DockStyle.Fill;
            botao9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botao9.Location = new System.Drawing.Point(324, 84);
            botao9.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botao9.Name = "botao9";
            botao9.Size = new System.Drawing.Size(72, 42);
            botao9.TabIndex = 8;
            botao9.Text = "9";
            botao9.Click += ClicouNumero;
            // 
            // botao8
            // 
            botao8.Dock = System.Windows.Forms.DockStyle.Fill;
            botao8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botao8.Location = new System.Drawing.Point(180, 84);
            botao8.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botao8.Name = "botao8";
            botao8.Size = new System.Drawing.Size(72, 42);
            botao8.TabIndex = 9;
            botao8.Text = "8";
            botao8.Click += ClicouNumero;
            // 
            // botao7
            // 
            botao7.Dock = System.Windows.Forms.DockStyle.Fill;
            botao7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botao7.Location = new System.Drawing.Point(36, 84);
            botao7.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botao7.Name = "botao7";
            botao7.Size = new System.Drawing.Size(72, 42);
            botao7.TabIndex = 10;
            botao7.Text = "7";
            botao7.Click += ClicouNumero;
            // 
            // botaoSoma
            // 
            botaoSoma.Dock = System.Windows.Forms.DockStyle.Fill;
            botaoSoma.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botaoSoma.Location = new System.Drawing.Point(468, 294);
            botaoSoma.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botaoSoma.Name = "botaoSoma";
            botaoSoma.Size = new System.Drawing.Size(74, 42);
            botaoSoma.TabIndex = 11;
            botaoSoma.Text = "+";
            botaoSoma.Click += ClicouOperador;
            // 
            // botaoSubtracao
            // 
            botaoSubtracao.Dock = System.Windows.Forms.DockStyle.Fill;
            botaoSubtracao.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botaoSubtracao.Location = new System.Drawing.Point(468, 224);
            botaoSubtracao.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botaoSubtracao.Name = "botaoSubtracao";
            botaoSubtracao.Size = new System.Drawing.Size(74, 42);
            botaoSubtracao.TabIndex = 12;
            botaoSubtracao.Text = "-";
            botaoSubtracao.Click += ClicouOperador;
            // 
            // botaoMultiplicacao
            // 
            botaoMultiplicacao.Dock = System.Windows.Forms.DockStyle.Fill;
            botaoMultiplicacao.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botaoMultiplicacao.Location = new System.Drawing.Point(468, 154);
            botaoMultiplicacao.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botaoMultiplicacao.Name = "botaoMultiplicacao";
            botaoMultiplicacao.Size = new System.Drawing.Size(74, 42);
            botaoMultiplicacao.TabIndex = 13;
            botaoMultiplicacao.Text = "×";
            botaoMultiplicacao.Click += ClicouOperador;
            // 
            // botaoDivisao
            // 
            botaoDivisao.Dock = System.Windows.Forms.DockStyle.Fill;
            botaoDivisao.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botaoDivisao.Location = new System.Drawing.Point(468, 84);
            botaoDivisao.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botaoDivisao.Name = "botaoDivisao";
            botaoDivisao.Size = new System.Drawing.Size(74, 42);
            botaoDivisao.TabIndex = 14;
            botaoDivisao.Text = "÷";
            botaoDivisao.Click += ClicouOperador;
            // 
            // botaoLimpar
            // 
            botaoLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            botaoLimpar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botaoLimpar.Location = new System.Drawing.Point(468, 14);
            botaoLimpar.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botaoLimpar.Name = "botaoLimpar";
            botaoLimpar.Size = new System.Drawing.Size(74, 42);
            botaoLimpar.TabIndex = 15;
            botaoLimpar.Text = "C";
            botaoLimpar.Click += botaoLimpar_Click;
            // 
            // botaoIgual
            // 
            botaoIgual.Dock = System.Windows.Forms.DockStyle.Fill;
            botaoIgual.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            botaoIgual.Location = new System.Drawing.Point(324, 294);
            botaoIgual.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            botaoIgual.Name = "botaoIgual";
            botaoIgual.Size = new System.Drawing.Size(72, 42);
            botaoIgual.TabIndex = 0;
            botaoIgual.Text = "=";
            botaoIgual.Click += botaoIgual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(578, 435);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(visorTextBox);
            Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            MinimumSize = new System.Drawing.Size(200, 100);
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Declarações dos componentes
        private System.Windows.Forms.TextBox visorTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Button botaoDivisao;
        private System.Windows.Forms.Button botaoMultiplicacao;
        private System.Windows.Forms.Button botaoSubtracao;
        private System.Windows.Forms.Button botaoSoma;
        private System.Windows.Forms.Button botao7;
        private System.Windows.Forms.Button botao8;
        private System.Windows.Forms.Button botao9;
        private System.Windows.Forms.Button botao4;
        private System.Windows.Forms.Button botao5;
        private System.Windows.Forms.Button botao6;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Button botao0;
        private System.Windows.Forms.Button botaoIgual;
    }
}