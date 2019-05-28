namespace Kelime_Otomasyonu.Kelimeİslemleri
{
    partial class KelimeIslemleri2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelimeIslemleri2));
            this.cbSilIngilizce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSilincekCumle = new DevExpress.XtraEditors.TextEdit();
            this.btnKSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSilGetir = new DevExpress.XtraEditors.SimpleButton();
            this.cbSilTurkce = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSilIngilizce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSilincekCumle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSilTurkce.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSilIngilizce
            // 
            this.cbSilIngilizce.Location = new System.Drawing.Point(115, 106);
            this.cbSilIngilizce.Name = "cbSilIngilizce";
            this.cbSilIngilizce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSilIngilizce.Size = new System.Drawing.Size(204, 20);
            this.cbSilIngilizce.TabIndex = 0;
            // 
            // txtSilincekCumle
            // 
            this.txtSilincekCumle.Location = new System.Drawing.Point(115, 178);
            this.txtSilincekCumle.Name = "txtSilincekCumle";
            this.txtSilincekCumle.Size = new System.Drawing.Size(204, 20);
            this.txtSilincekCumle.TabIndex = 2;
            // 
            // btnKSil
            // 
            this.btnKSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKSil.ImageOptions.SvgImage")));
            this.btnKSil.Location = new System.Drawing.Point(115, 245);
            this.btnKSil.Name = "btnKSil";
            this.btnKSil.Size = new System.Drawing.Size(86, 34);
            this.btnKSil.TabIndex = 3;
            this.btnKSil.Text = "SİL";
            this.btnKSil.Click += new System.EventHandler(this.BtnKSil_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnkapat.ImageOptions.SvgImage")));
            this.btnkapat.Location = new System.Drawing.Point(222, 245);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(85, 34);
            this.btnkapat.TabIndex = 4;
            this.btnkapat.Text = "KAPAT";
            this.btnkapat.Click += new System.EventHandler(this.Btnkapat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "İngilizce:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(61, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Türkçe:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 181);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Cümle:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(74, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(233, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "SİLİNMEK İSTENEN KELİMEYİ SEÇİN";
            // 
            // btnSilGetir
            // 
            this.btnSilGetir.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilGetir.Appearance.Options.UseFont = true;
            this.btnSilGetir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSilGetir.ImageOptions.SvgImage")));
            this.btnSilGetir.Location = new System.Drawing.Point(156, 204);
            this.btnSilGetir.Name = "btnSilGetir";
            this.btnSilGetir.Size = new System.Drawing.Size(94, 26);
            this.btnSilGetir.TabIndex = 7;
            this.btnSilGetir.Text = "GETİR";
            this.btnSilGetir.Click += new System.EventHandler(this.BtnSilGetir_Click);
            // 
            // cbSilTurkce
            // 
            this.cbSilTurkce.Location = new System.Drawing.Point(115, 132);
            this.cbSilTurkce.Name = "cbSilTurkce";
            this.cbSilTurkce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSilTurkce.Size = new System.Drawing.Size(204, 20);
            this.cbSilTurkce.TabIndex = 8;
            // 
            // KelimeIslemleri2
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 365);
            this.Controls.Add(this.cbSilTurkce);
            this.Controls.Add(this.btnSilGetir);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.btnKSil);
            this.Controls.Add(this.txtSilincekCumle);
            this.Controls.Add(this.cbSilIngilizce);
            this.Name = "KelimeIslemleri2";
            this.Text = "KelimeIslemleri2";
            this.Load += new System.EventHandler(this.KelimeIslemleri2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbSilIngilizce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSilincekCumle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSilTurkce.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbSilIngilizce;
        private DevExpress.XtraEditors.TextEdit txtSilincekCumle;
        private DevExpress.XtraEditors.SimpleButton btnKSil;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSilGetir;
        private DevExpress.XtraEditors.ComboBoxEdit cbSilTurkce;
    }
}