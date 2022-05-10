using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoryController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> Index()
        {
            var categories = await _context.Categories.ToListAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Show(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound("Category not found!");
            }
            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult<Category>> Create(Category request)
        {
            _context.Categories.Add(request);
            await _context.SaveChangesAsync();
            return Ok(await _context.Categories.ToListAsync());
        }

        //[HttpPut]
        //public async Task<ActionResult<Category>> Update(Category request)
        //{
            
        //}

    }
}
