namespace biletalproje
{
	partial class frmlogin
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
			this.linkSifreunutma = new System.Windows.Forms.LinkLabel();
			this.btnGirisYap = new Guna.UI2.WinForms.Guna2Button();
			this.linkUyeol = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
			this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.guna2CustomGradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.BorderColor = System.Drawing.Color.Gray;
			this.txtEmail.BorderRadius = 20;
			this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEmail.DefaultText = "";
			this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.FillColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Location = new System.Drawing.Point(403, 176);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.txtEmail.PlaceholderText = "Email";
			this.txtEmail.SelectedText = "";
			this.txtEmail.Size = new System.Drawing.Size(213, 36);
			this.txtEmail.TabIndex = 1;
			// 
			// txtSifre
			// 
			this.txtSifre.BorderColor = System.Drawing.Color.Gray;
			this.txtSifre.BorderRadius = 20;
			this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSifre.DefaultText = "";
			this.txtSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSifre.FillColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSifre.Location = new System.Drawing.Point(403, 234);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.PasswordChar = '*';
			this.txtSifre.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.txtSifre.PlaceholderText = "Şifre";
			this.txtSifre.SelectedText = "";
			this.txtSifre.Size = new System.Drawing.Size(213, 36);
			this.txtSifre.TabIndex = 2;
			this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
			// 
			// linkSifreunutma
			// 
			this.linkSifreunutma.ActiveLinkColor = System.Drawing.Color.Blue;
			this.linkSifreunutma.AutoSize = true;
			this.linkSifreunutma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.linkSifreunutma.LinkColor = System.Drawing.Color.Silver;
			this.linkSifreunutma.Location = new System.Drawing.Point(479, 273);
			this.linkSifreunutma.Name = "linkSifreunutma";
			this.linkSifreunutma.Size = new System.Drawing.Size(137, 16);
			this.linkSifreunutma.TabIndex = 3;
			this.linkSifreunutma.TabStop = true;
			this.linkSifreunutma.Text = "Şifrenizi mi Unuttunuz?";
			this.linkSifreunutma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSifreunutma_LinkClicked);
			// 
			// btnGirisYap
			// 
			this.btnGirisYap.BorderRadius = 20;
			this.btnGirisYap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnGirisYap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnGirisYap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnGirisYap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnGirisYap.FillColor = System.Drawing.Color.Blue;
			this.btnGirisYap.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnGirisYap.ForeColor = System.Drawing.Color.White;
			this.btnGirisYap.Location = new System.Drawing.Point(440, 308);
			this.btnGirisYap.Name = "btnGirisYap";
			this.btnGirisYap.Size = new System.Drawing.Size(148, 45);
			this.btnGirisYap.TabIndex = 4;
			this.btnGirisYap.Text = "GİRİŞ YAP";
			this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
			// 
			// linkUyeol
			// 
			this.linkUyeol.ActiveLinkColor = System.Drawing.Color.Blue;
			this.linkUyeol.AutoSize = true;
			this.linkUyeol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.linkUyeol.LinkColor = System.Drawing.Color.Silver;
			this.linkUyeol.Location = new System.Drawing.Point(494, 356);
			this.linkUyeol.Name = "linkUyeol";
			this.linkUyeol.Size = new System.Drawing.Size(48, 16);
			this.linkUyeol.TabIndex = 5;
			this.linkUyeol.TabStop = true;
			this.linkUyeol.Text = "Üye Ol";
			this.linkUyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUyeol_LinkClicked);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(85, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 27);
			this.label1.TabIndex = 7;
			this.label1.Text = "JetBilet";
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(460, 144);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(82, 26);
			this.guna2HtmlLabel1.TabIndex = 8;
			this.guna2HtmlLabel1.Text = "Üye Girişi";
			// 
			// guna2CustomGradientPanel1
			// 
			this.guna2CustomGradientPanel1.Controls.Add(this.guna2ImageButton1);
			this.guna2CustomGradientPanel1.Controls.Add(this.guna2CirclePictureBox4);
			this.guna2CustomGradientPanel1.Controls.Add(this.label1);
			this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
			this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(655, 80);
			this.guna2CustomGradientPanel1.TabIndex = 10;
			// 
			// guna2ImageButton1
			// 
			this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.Image = global::biletalproje.Properties.Resources.kapatma;
			this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
			this.guna2ImageButton1.ImageRotate = 0F;
			this.guna2ImageButton1.Location = new System.Drawing.Point(610, 12);
			this.guna2ImageButton1.Name = "guna2ImageButton1";
			this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.guna2ImageButton1.Size = new System.Drawing.Size(20, 16);
			this.guna2ImageButton1.TabIndex = 11;
			this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
			// 
			// guna2CirclePictureBox4
			// 
			this.guna2CirclePictureBox4.Image = global::biletalproje.Properties.Resources.buss;
			this.guna2CirclePictureBox4.ImageRotate = 0F;
			this.guna2CirclePictureBox4.Location = new System.Drawing.Point(0, 3);
			this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
			this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox4.Size = new System.Drawing.Size(88, 74);
			this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2CirclePictureBox4.TabIndex = 13;
			this.guna2CirclePictureBox4.TabStop = false;
			this.guna2CirclePictureBox4.Click += new System.EventHandler(this.guna2CirclePictureBox4_Click);
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = global::biletalproje.Properties.Resources.resimm;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(-5, 36);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(402, 420);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 9;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
			// 
			// guna2CirclePictureBox1
			// 
			this.guna2CirclePictureBox1.Image = global::biletalproje.Properties.Resources.Baixar_moderno_turismo_ônibus_logotipo_Projeto_em_branco_fundo_gratuitamente_Photoroom;
			this.guna2CirclePictureBox1.ImageRotate = 0F;
			this.guna2CirclePictureBox1.Location = new System.Drawing.Point(177, 190);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox1.Size = new System.Drawing.Size(99, 99);
			this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2CirclePictureBox1.TabIndex = 6;
			this.guna2CirclePictureBox1.TabStop = false;
			// 
			// frmlogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(655, 423);
			this.Controls.Add(this.guna2CustomGradientPanel1);
			this.Controls.Add(this.guna2PictureBox1);
			this.Controls.Add(this.guna2HtmlLabel1);
			this.Controls.Add(this.guna2CirclePictureBox1);
			this.Controls.Add(this.linkUyeol);
			this.Controls.Add(this.btnGirisYap);
			this.Controls.Add(this.linkSifreunutma);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.txtEmail);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmlogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giriş Yap";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.guna2CustomGradientPanel1.ResumeLayout(false);
			this.guna2CustomGradientPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2TextBox txtEmail;
		private Guna.UI2.WinForms.Guna2TextBox txtSifre;
		private System.Windows.Forms.LinkLabel linkSifreunutma;
		private Guna.UI2.WinForms.Guna2Button btnGirisYap;
		private System.Windows.Forms.LinkLabel linkUyeol;
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
		private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
	}
}

