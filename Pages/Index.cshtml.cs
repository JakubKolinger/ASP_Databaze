using ASP_Databáze.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ASP_Databáze.Models;

namespace ASP_databáze.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MovieDbContext _context;

        public IndexModel(
            ILogger<IndexModel> logger,
            MovieDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public List<Movie> Items { get; set; }
        public void OnGet()
        {
            _logger.LogInformation("Index page accessed.");
            Items = _context.Movies.ToList();
            _logger.LogInformation("Retrieved {Count} movies from the database.", Items.Count);
        }
    }
}
