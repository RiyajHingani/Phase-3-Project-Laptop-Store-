using LaptopStore1.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using LaptopStore1.Models;

namespace LaptopStore1.Controllers
{
    public class PagesController : Controller
    {
        private readonly LaptopContext context;
        public PagesController(LaptopContext context)
        {
            this.context = context;
        }
        // GET / or /slug
        public async Task<IActionResult> Page(string slug)
        {
            if (slug == null)
            {
                return View(await context.Pages.Where(x => x.Slug == "home").FirstOrDefaultAsync());
            }

            Page page = await context.Pages.Where(x => x.Slug == slug).FirstOrDefaultAsync();

            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }
    }
}
