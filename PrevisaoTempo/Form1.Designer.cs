
namespace PrevisaoTempo
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbTempoIcone = new System.Windows.Forms.PictureBox();
            this.btnProcurarCidade = new System.Windows.Forms.Button();
            this.lbCondicao = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTemperatura = new System.Windows.Forms.Label();
            this.lbSensacaoTermica = new System.Windows.Forms.Label();
            this.lbTemperaturaMax = new System.Windows.Forms.Label();
            this.lbTemperaturaMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempoIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCidade
            // 
            resources.ApplyResources(this.txtCidade, "txtCidade");
            this.txtCidade.Name = "txtCidade";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // pbTempoIcone
            // 
            resources.ApplyResources(this.pbTempoIcone, "pbTempoIcone");
            this.pbTempoIcone.Name = "pbTempoIcone";
            this.pbTempoIcone.TabStop = false;
            // 
            // btnProcurarCidade
            // 
            resources.ApplyResources(this.btnProcurarCidade, "btnProcurarCidade");
            this.btnProcurarCidade.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurarCidade.Name = "btnProcurarCidade";
            this.btnProcurarCidade.UseVisualStyleBackColor = false;
            this.btnProcurarCidade.Click += new System.EventHandler(this.btnProcurarCidade_Click);
            // 
            // lbCondicao
            // 
            resources.ApplyResources(this.lbCondicao, "lbCondicao");
            this.lbCondicao.BackColor = System.Drawing.Color.Transparent;
            this.lbCondicao.Name = "lbCondicao";
            // 
            // lbDescricao
            // 
            resources.ApplyResources(this.lbDescricao, "lbDescricao");
            this.lbDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lbDescricao.Name = "lbDescricao";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // lbTemperatura
            // 
            resources.ApplyResources(this.lbTemperatura, "lbTemperatura");
            this.lbTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.lbTemperatura.Name = "lbTemperatura";
            // 
            // lbSensacaoTermica
            // 
            resources.ApplyResources(this.lbSensacaoTermica, "lbSensacaoTermica");
            this.lbSensacaoTermica.BackColor = System.Drawing.Color.Transparent;
            this.lbSensacaoTermica.Name = "lbSensacaoTermica";
            // 
            // lbTemperaturaMax
            // 
            resources.ApplyResources(this.lbTemperaturaMax, "lbTemperaturaMax");
            this.lbTemperaturaMax.BackColor = System.Drawing.Color.Transparent;
            this.lbTemperaturaMax.Name = "lbTemperaturaMax";
            // 
            // lbTemperaturaMin
            // 
            resources.ApplyResources(this.lbTemperaturaMin, "lbTemperaturaMin");
            this.lbTemperaturaMin.BackColor = System.Drawing.Color.Transparent;
            this.lbTemperaturaMin.Name = "lbTemperaturaMin";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrevisaoTempo.Properties.Resources.dia;
            this.Controls.Add(this.lbTemperaturaMin);
            this.Controls.Add(this.lbTemperaturaMax);
            this.Controls.Add(this.lbSensacaoTermica);
            this.Controls.Add(this.lbTemperatura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbCondicao);
            this.Controls.Add(this.btnProcurarCidade);
            this.Controls.Add(this.pbTempoIcone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbTempoIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTempoIcone;
        private System.Windows.Forms.Button btnProcurarCidade;
        private System.Windows.Forms.Label lbCondicao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTemperatura;
        private System.Windows.Forms.Label lbSensacaoTermica;
        private System.Windows.Forms.Label lbTemperaturaMax;
        private System.Windows.Forms.Label lbTemperaturaMin;
    }
}

