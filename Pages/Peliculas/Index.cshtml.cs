using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TiendaPelicula.Data;
using TiendaPelicula.Modelos;

namespace TiendaPelicula.Pages.Peliculas
{
    public class IndexModel : PageModel
    {
        private readonly TiendaPelicula.Data.TiendaPeliculaContext _context;

        public IndexModel(TiendaPelicula.Data.TiendaPeliculaContext context)
        {
            _context = context;
        }

        public IList<Pelicula> Pelicula { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pelicula != null)
            {
                Pelicula = await _context.Pelicula.ToListAsync();
            }
        }
    }
}
