namespace biletalproje
{
	partial class FormKoltukSec
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
			this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnClose.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnClose.Image = global::biletalproje.Properties.Resources.kapatma;
			this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
			this.btnClose.ImageRotate = 0F;
			this.btnClose.Location = new System.Drawing.Point(1199, 23);
			this.btnClose.Name = "btnClose";
			this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.btnClose.Size = new System.Drawing.Size(20, 16);
			this.btnClose.TabIndex = 71;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = global::biletalproje.Properties.Resources.cizgi_Photoroom__1_;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(93, 250);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(56, 157);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 70;
			this.guna2PictureBox1.TabStop = false;
			// 
			// guna2CirclePictureBox1
			// 
			this.guna2CirclePictureBox1.Image = global::biletalproje.Properties.Resources.direksiyon1;
			this.guna2CirclePictureBox1.ImageRotate = 100F;
			this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 272);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox1.Size = new System.Drawing.Size(93, 106);
			this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2CirclePictureBox1.TabIndex = 69;
			this.guna2CirclePictureBox1.TabStop = false;
			// 
			// FormKoltukSec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1250, 452);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.guna2PictureBox1);
			this.Controls.Add(this.guna2CirclePictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormKoltukSec";
			this.Text = "FormKoltukSec";
			this.Load += new System.EventHandler(this.FormKoltukSec_Load);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2ImageButton btnClose;
	}
}