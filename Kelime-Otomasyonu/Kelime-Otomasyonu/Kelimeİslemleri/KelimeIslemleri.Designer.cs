namespace Kelime_Otomasyonu.Kelimeİslemleri
{
    partial class KelimeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelimeIslemleri));
            this.txtKingilizce = new DevExpress.XtraEditors.TextEdit();
            this.txtKtürkce = new DevExpress.XtraEditors.TextEdit();
            this.txtKcümle = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKingilizce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKtürkce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKcümle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKingilizce
            // 
            this.txtKingilizce.Location = new System.Drawing.Point(96, 100);
            this.txtKingilizce.Name = "txtKingilizce";
            this.txtKingilizce.Size = new System.Drawing.Size(187, 20);
            this.txtKingilizce.TabIndex = 0;
            // 
            // txtKtürkce
            // 
            this.txtKtürkce.Location = new System.Drawing.Point(96, 138);
            this.txtKtürkce.Name = "txtKtürkce";
            this.txtKtürkce.Size = new System.Drawing.Size(187, 20);
            this.txtKtürkce.TabIndex = 0;
            // 
            // txtKcümle
            // 
            this.txtKcümle.Location = new System.Drawing.Point(96, 175);
            this.txtKcümle.Name = "txtKcümle";
            this.txtKcümle.Size = new System.Drawing.Size(187, 20);
            this.txtKcümle.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(96, 238);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(82, 37);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(207, 238);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(76, 37);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 103);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "İngilizce:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Türkçe:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(48, 178);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Cümle:";
            // 
            // KelimeIslemleri
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 369);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKcümle);
            this.Controls.Add(this.txtKtürkce);
            this.Controls.Add(this.txtKingilizce);
            this.Location = new System.Drawing.Point(250, 20);
            this.Name = "KelimeIslemleri";
            this.Text = "KelimeIslemleri";
            this.Load += new System.EventHandler(this.KelimeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKingilizce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKtürkce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKcümle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtKingilizce;
        private DevExpress.XtraEditors.TextEdit txtKtürkce;
        private DevExpress.XtraEditors.TextEdit txtKcümle;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}