using biletalproje.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace biletalproje
{
	public partial class FormSatinAl : Form
	{
		private SeferDetay _secilenSefer;
		private string _koltukNo;
		private kullanicilar _girisYapanKullanici;


		public FormSatinAl(SeferDetay sefer, string koltukNo, kullanicilar girisYapanKullanici)
		{
			InitializeComponent();
			_secilenSefer = sefer;
			_koltukNo = koltukNo;
			_girisYapanKullanici = girisYapanKullanici;
		}

		private void FormSatinAl_Load(object sender, EventArgs e)
		{
	
			lblAdSoyad.Text = $"Adı Soyadı (Koltuk No: {_koltukNo})";
			txtAdSoyad.Text = _girisYapanKullanici.ad_soyad;
			txtAdSoyad.ReadOnly = false;


			lblFirmaAdi.Text = _secilenSefer.firma_adi;
			lblKalkisYeri.Text = _secilenSefer.kalkis;
			lblVarisYeri.Text = _secilenSefer.varis;

			if (_secilenSefer.kalkis_zamani.HasValue)
				lblKalkisZamani.Text = _secilenSefer.kalkis_zamani.Value.ToString("dd MMMM yyyy dddd HH:mm");

			lblKoltukNo.Text = _koltukNo;
			btnSatinalma.Text = $"Satın Al - {_secilenSefer.bilet_fiyat:0.00} TL";



		}
		private void guna2GroupBox1_Click(object sender, EventArgs e)
		{

		}

		private void btnSatinalma_Click(object sender, EventArgs e)
		{
			string adSoyad = txtAdSoyad.Text.Trim();
			string tc = txtTC.Text.Trim();
			string email = txtEmail.Text.Trim();
			string telefon = txtTel.Text.Trim();
			string cinsiyet = radioErkek.Checked ? "Erkek" : radioKadin.Checked ? "Kadın" : "";

			if (string.IsNullOrEmpty(adSoyad) || string.IsNullOrEmpty(tc) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(cinsiyet))
			{
				MessageBox.Show("Lütfen tüm yolcu bilgilerini eksiksiz doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}


			if (tc.Length != 11 || !long.TryParse(tc, out _))
			{
				MessageBox.Show("Geçerli bir 11 haneli TC Kimlik Numarası giriniz.", "Hatalı TC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

		
			if (!email.Contains("@") || !email.Contains("."))
			{
				MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "Hatalı E-posta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			
			if (!long.TryParse(telefon, out _) || telefon.Length < 10)
			{
				MessageBox.Show("Telefon numarası yalnızca rakamlardan oluşmalı ve en az 10 hane olmalıdır.", "Hatalı Telefon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string kartIsim = txtKartİsim.Text.Trim();
			string kartNo = txtKartNo.Text.Replace(" ", "").Trim();
			string skt = txtSKT.Text.Trim(); 
			string cvv = txtCVV.Text.Trim();

			if (string.IsNullOrEmpty(kartIsim) || kartNo.Length != 16 || cvv.Length != 3 || string.IsNullOrEmpty(skt))
			{
				MessageBox.Show("Lütfen tüm kart bilgilerini eksiksiz ve doğru giriniz.", "Hatalı Kart Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}



			using (var db = new otobusbiletDBEntities())
			{
			
				var yeniBilet = new biletler
				{
					kullanici_id = _girisYapanKullanici.kullanici_id,
					seyahat_id = _secilenSefer.seyahat_id,
					koltuk_no = int.Parse(_koltukNo),
					cinsiyet = cinsiyet,
					tc = tc,
					email = email,
					tel = telefon,
					isEmpty = true
				};
				db.biletler.Add(yeniBilet);

		
				var koltuk = db.koltuklar
					.FirstOrDefault(k => k.seyahat_id == _secilenSefer.seyahat_id && k.koltuk_numarasi == int.Parse(_koltukNo));
				if (koltuk != null)
				{
					koltuk.isEmpty = false;
				}

				db.SaveChanges();
			}

			MessageBox.Show("Bilet satın alma işlemi başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.Close();
		}

	}
}
