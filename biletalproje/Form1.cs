using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biletalproje
{
	public partial class frmlogin : Form
	{

		public frmlogin()
		{
			InitializeComponent();
		}
		otobusbiletDBEntities db = new otobusbiletDBEntities();

		private void Form1_Load(object sender, EventArgs e)
		{
			int radius = 30; 
			GraphicsPath path = new GraphicsPath();
			path.StartFigure();
			path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
			path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
			path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
			path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
			path.CloseFigure();
			this.Region = new Region(path);
		}

		private void btnGirisYap_Click(object sender, EventArgs e)
		{
			string email = txtEmail.Text;
			string sifre = txtSifre.Text;

			var kullanici = db.kullanicilar
				.FirstOrDefault(x => x.email == email && x.sifre_guvenlik == sifre);
			if (kullanici != null)
			{

				List<seferler> anasayfam = db.seferler.ToList();
				List<otobusler> otobusListesi = db.otobusler.ToList();

				FormAnasayfa ana = new FormAnasayfa(anasayfam, otobusListesi, kullanici);

				ana.Show();
				this.Hide();
			}

			else
			{
				MessageBox.Show("Email veya şifre yanlış!");
			}
		}

		private void linkSifreunutma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormŞifreYenile frm = new FormŞifreYenile();
			frm.Show();
		}

		private void linkUyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormÜyeol frm = new FormÜyeol();
			frm.Show();
		}

		private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
		{

		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void txtSifre_TextChanged(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			
		}
	}
}
