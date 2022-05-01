namespace SeguidoresInstagram
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
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iniciarSeguir = new System.Windows.Forms.Button();
            this.tempoEspera = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroLinha = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tempoEspera2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numeroLinha2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesquisar2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempoEspera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroLinha)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempoEspera2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroLinha2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar por:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(22, 50);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(264, 22);
            this.txtPesquisar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iniciarSeguir);
            this.groupBox1.Controls.Add(this.tempoEspera);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numeroLinha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seguir";
            // 
            // iniciarSeguir
            // 
            this.iniciarSeguir.Location = new System.Drawing.Point(38, 157);
            this.iniciarSeguir.Name = "iniciarSeguir";
            this.iniciarSeguir.Size = new System.Drawing.Size(232, 36);
            this.iniciarSeguir.TabIndex = 6;
            this.iniciarSeguir.Text = "Iniciar";
            this.iniciarSeguir.UseVisualStyleBackColor = true;
            this.iniciarSeguir.Click += new System.EventHandler(this.iniciarSeguir_Click);
            // 
            // tempoEspera
            // 
            this.tempoEspera.Location = new System.Drawing.Point(22, 106);
            this.tempoEspera.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.tempoEspera.Minimum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.tempoEspera.Name = "tempoEspera";
            this.tempoEspera.Size = new System.Drawing.Size(120, 22);
            this.tempoEspera.TabIndex = 5;
            this.tempoEspera.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tempo espera:";
            // 
            // numeroLinha
            // 
            this.numeroLinha.Location = new System.Drawing.Point(159, 106);
            this.numeroLinha.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numeroLinha.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeroLinha.Name = "numeroLinha";
            this.numeroLinha.Size = new System.Drawing.Size(120, 22);
            this.numeroLinha.TabIndex = 3;
            this.numeroLinha.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nº linha para inicio:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tempoEspera2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numeroLinha2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPesquisar2);
            this.groupBox2.Location = new System.Drawing.Point(345, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 218);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parar Seguir";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tempoEspera2
            // 
            this.tempoEspera2.Location = new System.Drawing.Point(22, 106);
            this.tempoEspera2.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.tempoEspera2.Minimum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.tempoEspera2.Name = "tempoEspera2";
            this.tempoEspera2.Size = new System.Drawing.Size(120, 22);
            this.tempoEspera2.TabIndex = 5;
            this.tempoEspera2.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tempo espera:";
            // 
            // numeroLinha2
            // 
            this.numeroLinha2.Location = new System.Drawing.Point(159, 106);
            this.numeroLinha2.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numeroLinha2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroLinha2.Name = "numeroLinha2";
            this.numeroLinha2.Size = new System.Drawing.Size(120, 22);
            this.numeroLinha2.TabIndex = 3;
            this.numeroLinha2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nº linha para inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Usuario:";
            // 
            // txtPesquisar2
            // 
            this.txtPesquisar2.Location = new System.Drawing.Point(22, 50);
            this.txtPesquisar2.Name = "txtPesquisar2";
            this.txtPesquisar2.Size = new System.Drawing.Size(264, 22);
            this.txtPesquisar2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempoEspera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroLinha)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempoEspera2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroLinha2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeroLinha;
        private System.Windows.Forms.NumericUpDown tempoEspera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button iniciarSeguir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown tempoEspera2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeroLinha2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesquisar2;
    }
}

