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
	public partial class FormKoltukSec : Form  
	{

		private kullanicilar _girisYapanKullanici;





		private SeferDetay _secilenSefer;
		

		public FormKoltukSec(SeferDetay sefer, kullanicilar girisYapanKullanici)
		{
			InitializeComponent();
			_secilenSefer = sefer;
			_girisYapanKullanici = girisYapanKullanici;
			
		}

		private void FormKoltukSec_Load(object sender, EventArgs e)
		{
			
			

			KoltuklariYerlestir();
		}
		
		private void KoltuklariYerlestir()
		{
			
			Panel allSeatsPanel = new Panel
			{
				Size = new Size(1017, 397),
				Location = new Point(150, 38),
			


			};
			this.Controls.Add(allSeatsPanel);

			Panel topSeatsPanel = new Panel
			{
				Size = new Size(961, 200), 
				Location = new Point(14, 18),
			
			};

			Panel bottomSeatsPanel = new Panel
			{
				Size = new Size(959, 100),
				Location = new Point(16, 252),
			

			};

			allSeatsPanel.Controls.Add(topSeatsPanel);
			allSeatsPanel.Controls.Add(bottomSeatsPanel); // bu kodlarda sorun yok bu seferde sadece 1 tane koltuk var  




			using (var db = new otobusbiletDBEntities())
			{
				var koltukList = db.koltuklar
								//.Where(k => k.seyahat_id == _secilenSefer.seyahat_id)
								.OrderBy(k => k.koltuk_numarasi)
								.ToList();
				List<koltuklar> topSeatList = koltukList
	.Where(k => (k.koltuk_numarasi - 1) % 3 != 0)
	.Select(k => {
		k.kat = "üst";
		return k;
	}).ToList();

				List<koltuklar> bottomSeatList = koltukList
					.Where(k => (k.koltuk_numarasi - 1) % 3 == 0)
					.Select(k => {
						k.kat = "alt";
						return k;
					}).ToList();



				//MessageBox.Show("Toplam koltuk sayısı: " + koltukList.Count);
				var topSeats = koltukList.Where(k => (k.koltuk_numarasi - 1) % 3 != 0);
				var bottomSeats = koltukList.Where(k => (k.koltuk_numarasi - 1) % 3 == 0);


				int bottomX = 0;
				foreach (var kol in bottomSeats)
				{
					var btn = new Button
					{
						Size = new Size(45, 45),
						Location = new Point(bottomX, 0),
						BackgroundImage = biletalproje.Properties.Resources.resim_2025_04_28_204506178_Photoroom1,
						BackgroundImageLayout = ImageLayout.Stretch,
						Text = kol.koltuk_numarasi.ToString(),
						TextAlign = ContentAlignment.MiddleCenter,
						Tag = kol,
						ForeColor = kol.isEmpty == true ? Color.Red : Color.Green,
					};
					btn.Click += Koltuk_Click;
					bottomSeatsPanel.Controls.Add(btn);

					bottomX += 60; 
				}
				int grupX = 0;
				int solY = 0;
				int sagY1 = 0;
				int sagY2 = 60;


				for (int i = 0; i < topSeatList.Count; i += 3)
				{
				
					if (i < topSeatList.Count)
					{
						var koltukSol = topSeatList[i];
						Button btnSol = new Button
						{
							Size = new Size(45, 45),
							Location = new Point(grupX, solY),
							BackgroundImage = biletalproje.Properties.Resources.resim_2025_04_28_204506178_Photoroom1,
							BackgroundImageLayout = ImageLayout.Stretch,
							Text = koltukSol.koltuk_numarasi.ToString(),
							TextAlign = ContentAlignment.MiddleCenter,
							Tag = koltukSol,
							ForeColor = koltukSol.isEmpty == true ? Color.Red : Color.Green,
						};
						btnSol.Click += Koltuk_Click;
						topSeatsPanel.Controls.Add(btnSol);
					}

					if (i + 1 < topSeatList.Count)
					{
						var koltukSag1 = topSeatList[i + 1];
						Button btnSag1 = new Button
						{
							Size = new Size(45, 45),
							Location = new Point(grupX + 70, sagY1),
							BackgroundImage = biletalproje.Properties.Resources.resim_2025_04_28_204506178_Photoroom1,
							BackgroundImageLayout = ImageLayout.Stretch,
							Text = koltukSag1.koltuk_numarasi.ToString(),
							TextAlign = ContentAlignment.MiddleCenter,
							Tag = koltukSag1,
							ForeColor = koltukSag1.isEmpty == true ? Color.Red : Color.Green,
						};
						btnSag1.Click += Koltuk_Click;
						topSeatsPanel.Controls.Add(btnSag1);
					}

					if (i + 2 < topSeatList.Count)
					{
						var koltukSag2 = topSeatList[i + 2];
						Button btnSag2 = new Button
						{
							Size = new Size(45, 45),
							Location = new Point(grupX + 70, sagY2),
							BackgroundImage = biletalproje.Properties.Resources.resim_2025_04_28_204506178_Photoroom1,
							BackgroundImageLayout = ImageLayout.Stretch,
							Text = koltukSag2.koltuk_numarasi.ToString(),
							TextAlign = ContentAlignment.MiddleCenter,
							Tag = koltukSag2,
							ForeColor = koltukSag2.isEmpty == true ? Color.Red : Color.Green,
						};
						btnSag2.Click += Koltuk_Click;
						topSeatsPanel.Controls.Add(btnSag2);
					}

					grupX += 120; 
				}

			

			}
		}


		private void Koltuk_Click(object sender, EventArgs e)
		{
			Button tiklananButon = sender as Button;
			if (tiklananButon == null) return;

			var secilenKoltuk = tiklananButon.Tag as koltuklar;
			if (secilenKoltuk == null)
			{
				MessageBox.Show("Koltuk bilgisi alınamadı!");
				return;
			}

			using (var db = new otobusbiletDBEntities())
			{
				var koltuk = db.koltuklar.FirstOrDefault(k => k.koltuk_id == secilenKoltuk.koltuk_id);
				if (koltuk == null)
				{
					MessageBox.Show("Koltuk verisi bulunamadı!");
					return;
				}

				if (koltuk.isEmpty == false)
				{
					MessageBox.Show("Bu koltuk başka bir kullanıcı tarafından seçildi! Lütfen başka bir koltuk seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

			
				FormSatinAl satinAlForm = new FormSatinAl(_secilenSefer, koltuk.koltuk_numarasi.ToString(), _girisYapanKullanici);
				satinAlForm.Show();
				this.Hide();
			}
		}

		private void btnClose_Click(object sender, EventArgs e) 
		{
			this.Close();
		}

		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnClose_Click_1(object sender, EventArgs e)
		{

		}
	}
}
