
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbTempoIcone = new System.Windows.Forms.PictureBox();
            this.btnProcurarCidade = new System.Windows.Forms.Button();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbTemperatura = new System.Windows.Forms.Label();
            this.lbSensacaoTermica = new System.Windows.Forms.Label();
            this.lbTemperaturaMinMax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTempoIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCidade
            // 
            resources.ApplyResources(this.txtCidade, "txtCidade");
            this.txtCidade.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCidade.Name = "txtCidade";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // pbTempoIcone
            // 
            resources.ApplyResources(this.pbTempoIcone, "pbTempoIcone");
            this.pbTempoIcone.BackColor = System.Drawing.Color.Transparent;
            this.pbTempoIcone.Name = "pbTempoIcone";
            this.pbTempoIcone.TabStop = false;
            // 
            // btnProcurarCidade
            // 
            resources.ApplyResources(this.btnProcurarCidade, "btnProcurarCidade");
            this.btnProcurarCidade.BackColor = System.Drawing.Color.Transparent;
            this.btnProcurarCidade.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProcurarCidade.Name = "btnProcurarCidade";
            this.btnProcurarCidade.UseVisualStyleBackColor = false;
            this.btnProcurarCidade.Click += new System.EventHandler(this.btnProcurarCidade_Click);
            // 
            // lbDescricao
            // 
            resources.ApplyResources(this.lbDescricao, "lbDescricao");
            this.lbDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lbDescricao.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDescricao.Name = "lbDescricao";
            // 
            // lbTemperatura
            // 
            resources.ApplyResources(this.lbTemperatura, "lbTemperatura");
            this.lbTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.lbTemperatura.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTemperatura.Name = "lbTemperatura";
            // 
            // lbSensacaoTermica
            // 
            resources.ApplyResources(this.lbSensacaoTermica, "lbSensacaoTermica");
            this.lbSensacaoTermica.BackColor = System.Drawing.Color.Transparent;
            this.lbSensacaoTermica.ForeColor = System.Drawing.SystemColors.Control;
            this.lbSensacaoTermica.Name = "lbSensacaoTermica";
            // 
            // lbTemperaturaMinMax
            // 
            resources.ApplyResources(this.lbTemperaturaMinMax, "lbTemperaturaMinMax");
            this.lbTemperaturaMinMax.BackColor = System.Drawing.Color.Transparent;
            this.lbTemperaturaMinMax.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTemperaturaMinMax.Name = "lbTemperaturaMinMax";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Name = "label2";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::PrevisaoTempo.Properties.Resources.background;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTemperaturaMinMax);
            this.Controls.Add(this.lbSensacaoTermica);
            this.Controls.Add(this.lbTemperatura);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.btnProcurarCidade);
            this.Controls.Add(this.pbTempoIcone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTempoIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTempoIcone;
        private System.Windows.Forms.Button btnProcurarCidade;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbTemperatura;
        private System.Windows.Forms.Label lbSensacaoTermica;
        private System.Windows.Forms.Label lbTemperaturaMinMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
    }
}

