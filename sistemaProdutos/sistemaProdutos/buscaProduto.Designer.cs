namespace sistemaProdutos
{
    partial class buscaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscaProduto));
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outPutName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uotPutQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outPutCategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.historicoProd = new System.Windows.Forms.Label();
            this.Historico = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.removeFromStock = new System.Windows.Forms.TextBox();
            this.retirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputSearch
            // 
            this.inputSearch.Location = new System.Drawing.Point(57, 103);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(760, 26);
            this.inputSearch.TabIndex = 0;
            this.inputSearch.TextChanged += new System.EventHandler(this.InputSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // outPutName
            // 
            this.outPutName.Location = new System.Drawing.Point(57, 311);
            this.outPutName.Name = "outPutName";
            this.outPutName.Size = new System.Drawing.Size(177, 26);
            this.outPutName.TabIndex = 2;
            this.outPutName.TextChanged += new System.EventHandler(this.OutPutName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 3;
            // 
            // uotPutQuantidade
            // 
            this.uotPutQuantidade.Location = new System.Drawing.Point(381, 311);
            this.uotPutQuantidade.Name = "uotPutQuantidade";
            this.uotPutQuantidade.Size = new System.Drawing.Size(127, 26);
            this.uotPutQuantidade.TabIndex = 15;
            this.uotPutQuantidade.TextChanged += new System.EventHandler(this.UotPutQuantidade_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Em estoque";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Produto";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // outPutCategoria
            // 
            this.outPutCategoria.Location = new System.Drawing.Point(630, 311);
            this.outPutCategoria.Name = "outPutCategoria";
            this.outPutCategoria.Size = new System.Drawing.Size(197, 26);
            this.outPutCategoria.TabIndex = 21;
            this.outPutCategoria.TextChanged += new System.EventHandler(this.OutPutCategoria_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(749, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Categoria";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(700, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 43);
            this.button3.TabIndex = 19;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 43);
            this.button2.TabIndex = 18;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // historicoProd
            // 
            this.historicoProd.AutoSize = true;
            this.historicoProd.Location = new System.Drawing.Point(53, 532);
            this.historicoProd.Name = "historicoProd";
            this.historicoProd.Size = new System.Drawing.Size(19, 20);
            this.historicoProd.TabIndex = 23;
            this.historicoProd.Text = "--";
            this.historicoProd.Click += new System.EventHandler(this.HistoricoProd_Click);
            // 
            // Historico
            // 
            this.Historico.AutoSize = true;
            this.Historico.Location = new System.Drawing.Point(53, 494);
            this.Historico.Name = "Historico";
            this.Historico.Size = new System.Drawing.Size(71, 20);
            this.Historico.TabIndex = 22;
            this.Historico.Text = "Historico";
            this.Historico.Click += new System.EventHandler(this.Historico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1005, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 33);
            this.label5.TabIndex = 26;
            this.label5.Text = "Retirar do estoque";
            // 
            // removeFromStock
            // 
            this.removeFromStock.Location = new System.Drawing.Point(1047, 103);
            this.removeFromStock.Name = "removeFromStock";
            this.removeFromStock.Size = new System.Drawing.Size(160, 26);
            this.removeFromStock.TabIndex = 25;
            // 
            // retirar
            // 
            this.retirar.Location = new System.Drawing.Point(1047, 150);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(160, 41);
            this.retirar.TabIndex = 24;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.Retirar_Click);
            // 
            // buscaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 599);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeFromStock);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.historicoProd);
            this.Controls.Add(this.Historico);
            this.Controls.Add(this.outPutCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uotPutQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outPutName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "buscaProduto";
            this.Text = "buscaProduto";
            this.Load += new System.EventHandler(this.BuscaProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outPutName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uotPutQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outPutCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label historicoProd;
        private System.Windows.Forms.Label Historico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox removeFromStock;
        private System.Windows.Forms.Button retirar;
    }
}