namespace CalculeHipotenusa
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCatoposto = new System.Windows.Forms.Label();
            this.textBoxOposto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdjacenter = new System.Windows.Forms.TextBox();
            this.btnClique = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(72, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(215, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcule  a  Hipotenusa";
            // 
            // lblCatoposto
            // 
            this.lblCatoposto.AutoSize = true;
            this.lblCatoposto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatoposto.Location = new System.Drawing.Point(29, 108);
            this.lblCatoposto.Name = "lblCatoposto";
            this.lblCatoposto.Size = new System.Drawing.Size(137, 20);
            this.lblCatoposto.TabIndex = 1;
            this.lblCatoposto.Text = "Digite Cateto Oposto:";
            // 
            // textBoxOposto
            // 
            this.textBoxOposto.Location = new System.Drawing.Point(32, 136);
            this.textBoxOposto.Name = "textBoxOposto";
            this.textBoxOposto.Size = new System.Drawing.Size(171, 20);
            this.textBoxOposto.TabIndex = 2;
            this.textBoxOposto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite Cateto Adjacenter:";
            // 
            // textBoxAdjacenter
            // 
            this.textBoxAdjacenter.Location = new System.Drawing.Point(35, 220);
            this.textBoxAdjacenter.Name = "textBoxAdjacenter";
            this.textBoxAdjacenter.Size = new System.Drawing.Size(168, 20);
            this.textBoxAdjacenter.TabIndex = 4;
            // 
            // btnClique
            // 
            this.btnClique.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClique.Location = new System.Drawing.Point(18, 281);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(97, 31);
            this.btnClique.TabIndex = 5;
            this.btnClique.Text = "Clique";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(126, 281);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 31);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpa";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(234, 281);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 31);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculeHipotenusa.Properties.Resources.Hipotenusa;
            this.pictureBox1.Location = new System.Drawing.Point(209, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 340);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnClique);
            this.Controls.Add(this.textBoxAdjacenter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOposto);
            this.Controls.Add(this.lblCatoposto);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hipotenusa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCatoposto;
        private System.Windows.Forms.TextBox textBoxOposto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdjacenter;
        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

