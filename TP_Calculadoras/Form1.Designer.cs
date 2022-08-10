namespace TP_Calculadoras
{
    partial class FrmIMC_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIMC_Load));
            this.text_entrada_peso = new System.Windows.Forms.TextBox();
            this.text_entrada_altura = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.labl_peso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.img_abertura = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_kg = new System.Windows.Forms.Label();
            this.lbl_cm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_abertura)).BeginInit();
            this.SuspendLayout();
            // 
            // text_entrada_peso
            // 
            this.text_entrada_peso.Location = new System.Drawing.Point(223, 155);
            this.text_entrada_peso.Multiline = true;
            this.text_entrada_peso.Name = "text_entrada_peso";
            this.text_entrada_peso.Size = new System.Drawing.Size(236, 34);
            this.text_entrada_peso.TabIndex = 1;
            // 
            // text_entrada_altura
            // 
            this.text_entrada_altura.Location = new System.Drawing.Point(223, 208);
            this.text_entrada_altura.Multiline = true;
            this.text_entrada_altura.Name = "text_entrada_altura";
            this.text_entrada_altura.Size = new System.Drawing.Size(236, 34);
            this.text_entrada_altura.TabIndex = 2;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_calcular.Location = new System.Drawing.Point(223, 269);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(94, 29);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // labl_peso
            // 
            this.labl_peso.AutoSize = true;
            this.labl_peso.Location = new System.Drawing.Point(161, 155);
            this.labl_peso.Name = "labl_peso";
            this.labl_peso.Size = new System.Drawing.Size(46, 40);
            this.labl_peso.TabIndex = 5;
            this.labl_peso.Text = "Peso :\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_info.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_info.Location = new System.Drawing.Point(223, 341);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 25);
            this.lbl_info.TabIndex = 15;
            // 
            // img_abertura
            // 
            this.img_abertura.Image = ((System.Drawing.Image)(resources.GetObject("img_abertura.Image")));
            this.img_abertura.Location = new System.Drawing.Point(295, 2);
            this.img_abertura.Name = "img_abertura";
            this.img_abertura.Size = new System.Drawing.Size(98, 89);
            this.img_abertura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_abertura.TabIndex = 9;
            this.img_abertura.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(213, 104);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(262, 28);
            this.lbl_titulo.TabIndex = 16;
            this.lbl_titulo.Text = "Sistema de Cálculo de IMC";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_limpar.Location = new System.Drawing.Point(365, 269);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(94, 29);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(151, 195);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(56, 40);
            this.lbl_altura.TabIndex = 18;
            this.lbl_altura.Text = "\r\nAltura :";
            // 
            // lbl_kg
            // 
            this.lbl_kg.AutoSize = true;
            this.lbl_kg.Location = new System.Drawing.Point(465, 158);
            this.lbl_kg.Name = "lbl_kg";
            this.lbl_kg.Size = new System.Drawing.Size(25, 20);
            this.lbl_kg.TabIndex = 19;
            this.lbl_kg.Text = "kg";
            // 
            // lbl_cm
            // 
            this.lbl_cm.AutoSize = true;
            this.lbl_cm.Location = new System.Drawing.Point(465, 211);
            this.lbl_cm.Name = "lbl_cm";
            this.lbl_cm.Size = new System.Drawing.Size(29, 20);
            this.lbl_cm.TabIndex = 20;
            this.lbl_cm.Text = "cm";
            // 
            // FrmIMC_Load
            // 
            this.AcceptButton = this.btn_calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.lbl_cm);
            this.Controls.Add(this.lbl_kg);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.img_abertura);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labl_peso);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.text_entrada_altura);
            this.Controls.Add(this.text_entrada_peso);
            this.MinimizeBox = false;
            this.Name = "FrmIMC_Load";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_abertura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text_entrada_peso;
        private TextBox text_entrada_altura;
        private Button btn_calcular;
        private Label labl_peso;
        private Label label1;
        private Label lbl_info;
        private PictureBox img_abertura;
        private Label lbl_titulo;
        private Button btn_limpar;
        private Label lbl_altura;
        private Label lbl_kg;
        private Label lbl_cm;
    }
}