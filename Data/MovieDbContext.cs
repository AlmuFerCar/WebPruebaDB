using Microsoft.EntityFrameworkCore;
using WebPrueba.Models;
namespace WebPrueba.Data;

public class MovieDBContext : DbContext
{
	public MovieDBContext()
	{
	}

	public MovieDBContext(DbContextOptions<MovieDBContext> options)
		: base(options)
	{ }

	public DbSet<Movie> Movies { get; set; }
}
