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
	public partial class FormÜyeol : Form
	{
		public FormÜyeol()
		{
			InitializeComponent();
		}
		otobusbiletDBEntities db=new otobusbiletDBEntities();

		private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			string email = txtEmail.Text;
			var mevcut=db.kullanicilar.FirstOrDefault(x=>x.email == email);
			if (mevcut==null)
			{
				string sifre=txtSifre.Text;

				if (sifre.Length < 5)
				{
					MessageBox.Show("Şİfre en az 5 karakter olmalıdır");
					return;
				}
				if (!sifre.All(char.IsDigit))
				{
					MessageBox.Show("Şİfre sadece sayılardan oluşmalıdır");
					return;
				}
				kullanicilar yeni = new kullanicilar();
				yeni.ad_soyad=txtadSoyad.Text;
				yeni.sifre_guvenlik = sifre;
				yeni.email= email;
				yeni.tel=txtTel.Text;
				yeni.tc = txtKimliknumara.Text;

				db.kullanicilar.Add(yeni);
				db.SaveChanges();

				MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz");
				this.Close();

			}
			else
			{
				MessageBox.Show("Bu email zaten kayıtlı");
			}

		}

		private void FormÜyeol_Load(object sender, EventArgs e)
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

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
