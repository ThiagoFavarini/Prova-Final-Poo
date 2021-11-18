namespace ThiagoFavarini40_3A1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.DTG_jogos = new System.Windows.Forms.DataGridView();
            this.txt_jogos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_mudar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_jogos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(118, 132);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 20);
            this.txt_code.TabIndex = 1;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(118, 171);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 2;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // DTG_jogos
            // 
            this.DTG_jogos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DTG_jogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_jogos.Location = new System.Drawing.Point(118, 264);
            this.DTG_jogos.Name = "DTG_jogos";
            this.DTG_jogos.Size = new System.Drawing.Size(589, 150);
            this.DTG_jogos.TabIndex = 3;
            // 
            // txt_jogos
            // 
            this.txt_jogos.Location = new System.Drawing.Point(350, 132);
            this.txt_jogos.Name = "txt_jogos";
            this.txt_jogos.Size = new System.Drawing.Size(100, 20);
            this.txt_jogos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jogos";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(607, 132);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor";
            // 
            // btn_mudar
            // 
            this.btn_mudar.Location = new System.Drawing.Point(350, 171);
            this.btn_mudar.Name = "btn_mudar";
            this.btn_mudar.Size = new System.Drawing.Size(75, 23);
            this.btn_mudar.TabIndex = 8;
            this.btn_mudar.Text = "Mudar";
            this.btn_mudar.UseVisualStyleBackColor = true;
            this.btn_mudar.Click += new System.EventHandler(this.btn_mudar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(607, 171);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_deletar.TabIndex = 9;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_mudar);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_jogos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTG_jogos);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_jogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.DataGridView DTG_jogos;
        private System.Windows.Forms.TextBox txt_jogos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_mudar;
        private System.Windows.Forms.Button btn_deletar;
    }
}

