using biletalproje.Models;
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
	public partial class FormAnasayfa : Form
	{
		private kullanicilar girisYapanKullanici;
		List<seferler> Gelenseferler { get; set; }

		List<otobusler> GidenOtobusler { get; set; }
		public FormAnasayfa(List<seferler> anasayfam, List<otobusler> otobusListesi, kullanicilar girisYapanKullanici)
		{
			InitializeComponent();
			Gelenseferler = anasayfam ?? new List<seferler>();
			GidenOtobusler = otobusListesi ?? new List<otobusler>();
			this.girisYapanKullanici = girisYapanKullanici;
			this.Load += FormAnasayfa_Load;


		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			if (cmbKalkis.SelectedItem == null || cmbVaris.SelectedItem == null)
			{
				MessageBox.Show("Lütfen kalkış ve varış şehirlerini seçin.");
				return;
			}
			string secilenKalkis = cmbKalkis.SelectedItem.ToString();
			string secilenVaris = cmbVaris.SelectedItem.ToString();
			DateTime secilenTarih = guna2DateTimePicker1.Value.Date;

	

			var uygunSeferler = (from sefer in Gelenseferler
								 join otobus in GidenOtobusler on sefer.otobus_id equals otobus.otobus_id
								 let seferTarihi = sefer.kalkis_zamani.HasValue ? sefer.kalkis_zamani.Value.Date : DateTime.MinValue
								 where sefer.kalkis.ToLower() == secilenKalkis.ToLower() &&
									   sefer.varis.ToLower() == secilenVaris.ToLower() &&
									   seferTarihi == secilenTarih
								 select new SeferDetay
								 {
									 seyahat_id = sefer.seyahat_id,
									 kalkis = sefer.kalkis,
									 varis = sefer.varis,
									 kalkis_zamani = sefer.kalkis_zamani,
									 bilet_fiyat = sefer.bilet_fiyat,
									 otobus_id = sefer.otobus_id,
									 firma_adi = otobus.firma_adi
								 }).ToList();







			if (uygunSeferler != null && uygunSeferler.Count > 0)
			{
				FormFirma formFirmasec = new FormFirma(uygunSeferler,girisYapanKullanici);  
				formFirmasec.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Şuan da seçilebilecek bir sefer yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}


		}

		private void FormAnasayfa_Load(object sender, EventArgs e)
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


			var kalkisSehirleri = Gelenseferler
		.Where(s => !string.IsNullOrEmpty(s.kalkis))
		.Select(s => s.kalkis)
		.Distinct()
		.ToArray();

			var varisSehirleri = Gelenseferler
				.Where(s => !string.IsNullOrEmpty(s.varis))
				.Select(s => s.varis)
				.Distinct()
				.ToArray();

			cmbKalkis.Items.AddRange(kalkisSehirleri);
			cmbVaris.Items.AddRange(varisSehirleri);
		}

		private void guna2ImageButton2_Click(object sender, EventArgs e)
		{
			this.Close(); 
		}
	}
}
