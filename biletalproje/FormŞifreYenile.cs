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
	public partial class FormŞifreYenile : Form
	{
		public FormŞifreYenile()
		{
			InitializeComponent();
		}
		otobusbiletDBEntities db = new otobusbiletDBEntities();

		private void btnKaydet_Click(object sender, EventArgs e)
		{

			string email=txtEmail.Text;
			string yeniSifre=txtYeniSifre.Text;
			
			var kullanici=db.kullanicilar.FirstOrDefault(x=>x.email== email);
			if (kullanici != null) 
			{
				kullanici.sifre_guvenlik = yeniSifre;

				sifre_sifirlama sifreKayit = new sifre_sifirlama();
				sifreKayit.kullanici_id = kullanici.kullanici_id;
				sifreKayit.sifirla = yeniSifre;
				sifreKayit.son_kullanmaTarihi = DateTime.Now.AddMinutes(30);

				db.sifre_sifirlama.Add(sifreKayit);
				db.SaveChanges();

				MessageBox.Show("Şifreniz Güncellendi");
				this.Close();
			}
			else
			{
				MessageBox.Show("Bu email sistemde kayıtlı değil");
			}

		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormŞifreYenile_Load(object sender, EventArgs e)
		{
			int radius = 30; // Köşe yarıçapı (yuvarlaklık derecesi)
			GraphicsPath path = new GraphicsPath();
			path.StartFigure();
			path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
			path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
			path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
			path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
			path.CloseFigure();
			this.Region = new Region(path);
		}

	

		private void guna2ImageButton2_Click_2(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
