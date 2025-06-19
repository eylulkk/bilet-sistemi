using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biletalproje.Models
{
	public class SeferDetay
	{
		public int seyahat_id { get; set; }
		public string kalkis { get; set; }
		public string varis { get; set; }
		public DateTime? kalkis_zamani { get; set; }
		public decimal? bilet_fiyat { get; set; }
		public int? otobus_id { get; set; }
		public string firma_adi { get; set; }
	}
}
