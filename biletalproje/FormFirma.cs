using biletalproje.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biletalproje
{
	public partial class FormFirma : Form
	{
		private List<SeferDetay> SeferListesi;
		private kullanicilar girisYapanKullanici;
		public FormFirma(List<SeferDetay> gelenSeferler, kullanicilar girisYapanKullanici)
		{

			InitializeComponent();
			SeferListesi = gelenSeferler ?? new List<SeferDetay>();
			this.girisYapanKullanici = girisYapanKullanici;
			SeferleriListele();

		}
		private void SeferleriListele()
		{

			int yOffset = 10;
			
			
			foreach (var sefer in SeferListesi)
			{
				Panel seferPanel = new Panel
				{
					Size = new Size(750, 80),
					Location = new Point(10, yOffset),
					BorderStyle = BorderStyle.FixedSingle
				};
				string busImagePath = getBusImagePath((int)sefer.otobus_id);

				PictureBox pbOtobus = new PictureBox
				{
					Size = new Size(60, 70),
					Location = new Point(10, 25),
					SizeMode = PictureBoxSizeMode.Zoom

				};

				

			
				if (!string.IsNullOrEmpty(busImagePath) && File.Exists(busImagePath))
				{
					pbOtobus.Image = Image.FromFile(busImagePath);
				}


				Label lblFirma = new Label
				{
					Text = sefer.firma_adi,
					Location = new Point(10, 10),
					Size = new Size(100, 30)

				};

				Label lblSaat = new Label
				{
					Text = sefer.kalkis_zamani.Value.ToString("HH:mm"),
					Location = new Point(120, 10),
					Font = new Font("Segoe UI", 11, FontStyle.Bold),
					Size = new Size(50, 30)
				};

				Label lblFiyat = new Label
				{
					Text = sefer.bilet_fiyat + " TL",
					Location = new Point(180, 10),
					Font = new Font("Segoe UI", 11, FontStyle.Bold),
					Size = new Size(80, 30)
				};

				Button btnKoltukSec = new Button
				{
					Text = "KOLTUK SEÇ",
					Location = new Point(650, 20),
					Size = new Size(90, 50),
					Tag = sefer,
					FlatStyle = FlatStyle.Flat,
					BackColor = Color.DodgerBlue,
					ForeColor = Color.White,
					Font = new Font("Segoe UI", 10, FontStyle.Bold)

				};
				System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
				path.AddArc(0, 0, 10, 10, 180, 90);
				path.AddArc(btnKoltukSec.Width - 10, 0, 10, 10, 270, 90);
				path.AddArc(btnKoltukSec.Width - 10, btnKoltukSec.Height - 10, 10, 10, 0, 90);
				path.AddArc(0, btnKoltukSec.Height - 10, 10, 10, 90, 90);
				path.CloseAllFigures();
				btnKoltukSec.Region = new Region(path);

				btnKoltukSec.Click += BtnKoltukSec_Click;

				seferPanel.Controls.Add(lblFirma);
				seferPanel.Controls.Add(lblSaat);
				seferPanel.Controls.Add(lblFiyat);
				seferPanel.Controls.Add(btnKoltukSec);
				seferPanel.Controls.Add(pbOtobus);				

				this.Controls.Add(seferPanel);
				yOffset += 90;
			}
		}

		private string getBusImagePath(int otobusId)
		{
			
			using (var db = new otobusbiletDBEntities())
			{
				var otobus = db.otobusler.FirstOrDefault(o => o.otobus_id == otobusId);
				if(otobus != null && !string.IsNullOrEmpty(otobus.otobus_resim))
				{
					return otobus.otobus_resim;
				}
				return null;
			}
				
		}
		private void BtnKoltukSec_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			var secilenSefer = (SeferDetay)btn.Tag;

			FormKoltukSec koltukSec = new FormKoltukSec(secilenSefer, girisYapanKullanici); // eksik parametreyi ekledik
			koltukSec.Show();
			this.Hide();
		}

		private void FormFirma_Load(object sender, EventArgs e)
		{

	


		}

		private void FormFirma_Load_1(object sender, EventArgs e)
		{

		}

	
	}

}
