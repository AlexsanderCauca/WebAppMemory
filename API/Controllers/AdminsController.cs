using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Entitties;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{


[Route("api/admins")]
[ApiController]
public class AdminsController : ControllerBase
{
    private readonly AdminDbContext _context;

    public AdminsController(AdminDbContext context)
    {
        _context = context;
    }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppAdmins>>> GetAdmins()
        {
            var admins = await _context.Admins.ToListAsync();

            return admins;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppAdmins>>GetAdmin(int id)
        {
            return await _context.Admins.FindAsync(id);
        }

    // // Добавить другие методы для выполнения операций CRUD
}


}