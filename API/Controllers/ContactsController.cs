using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using ContactManagementSystemwebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly DataContext _context;

        public ContactsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Contacts>>> GetContacts()
        {
            return await _context.Contacts.ToListAsync();

        }

        [HttpGet("{id")]

        public async Task<ActionResult<Contacts>> GetContact(int id)
        {
            return await _context.Contacts.FindAsync(id);

        }

    }
}