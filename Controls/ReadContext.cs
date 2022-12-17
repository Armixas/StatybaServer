using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StatybaServer.Models;
using System.Threading.Tasks;


namespace StatybaServer.Controls
{
	public class ReadContext : DbContext
	{
		public ReadContext(DbContextOptions<ReadContext> options):
			base(options)
		{

		}
		/*protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.UseSerialColumns();
		}*/
		public DbSet<Preke> preke { get; set; }
	}
}
