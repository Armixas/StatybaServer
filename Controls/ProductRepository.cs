using StatybaServer.Controls;
//using Connect_Postgresql_Blazor.Data;
using StatybaServer.Models;

namespace StatybaServer.Controls
{
	public class ProductRepository: IProductRepository
	{
		protected readonly PostgresContext _dbcontext;

		private List<Preke> products;
		public ProductRepository(PostgresContext _db) 
		{
			products = new List<Preke>();
			
			_dbcontext = _db;
			

			/*public string? Pavadinimas { get; set; }

		public string? Kategorija { get; set; }

		public decimal? VienetoKaina { get; set; }

		public int? Kiekis { get; set; }

		public string? Aprasymas { get; set; }

		public string? TrumpasAprasymas { get; set; }

		public string? Nuotrauka { get; set; }

		public int IdPreke { get; set; }*/
			/*products = new List<Preke>
			{
				new Preke {Pavadinimas = "Arminas", Kategorija="Zmogas", VienetoKaina = (decimal?)0.1, Kiekis = 1, Aprasymas = "Arminas, nei pridesi, nei atimsi.", TrumpasAprasymas = "Arminas", IdPreke=1, Nuotrauka = "https://cdn.discordapp.com/attachments/1016597762000818261/1041398117309874338/unknown.png"},
				new Preke {Pavadinimas = "Heisenburgeris", Kategorija="Zmogas", VienetoKaina=(decimal?)0.1, Kiekis=1, Aprasymas="Heisenburgeris krc", TrumpasAprasymas="burger", Nuotrauka="https://cdn.discordapp.com/attachments/1016597762000818261/1041389951956295700/image.png", IdPreke=2}
			};*/
		}

		/*public IEnumerable<Preke> GetProducts()
		{
			return products;
		}*/

		public Preke GetPreke(int id)
		{
			//Preke = new Preke
			//products = _dbcontext.preke.ToList();
			products = _dbcontext.Prekes.ToList();
			return products.FirstOrDefault(x => x.IdPreke == id);
		}

		public IEnumerable<Preke> GetPrekes(string filter)
		{
			//products = _dbcontext.preke.ToList();
			products = _dbcontext.Prekes.ToList();
			if (string.IsNullOrWhiteSpace(filter)) return products;

			return products.Where(x => x.Pavadinimas.ToLower().Contains(filter.ToLower()));
		}

		public void AddPreke(Preke preke)
		{
			_dbcontext.Prekes.Add(preke);
			_dbcontext.SaveChanges();
		}

		public void UpdatePreke(Preke preke)
		{
			_dbcontext.Entry(preke).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			_dbcontext.SaveChanges();
		}

		public void DeletePreke(int id) 
		{
			Preke? preke = _dbcontext.Prekes.Find(id);
			if (preke != null)
			{
				_dbcontext.Prekes.Remove(preke);
				_dbcontext.SaveChanges();
			}
		}
	}
}