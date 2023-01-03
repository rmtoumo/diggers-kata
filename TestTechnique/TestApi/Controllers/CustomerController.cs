using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Dto;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly TestApiDbContext _testApiDbContext;
        public CustomerController(TestApiDbContext testApiDbContext)
        {
            _testApiDbContext = testApiDbContext;
        }
        // nom p^renim , @

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var customersDb = await _testApiDbContext.Customers.FirstOrDefaultAsync(c => c.Id.Equals(id));
            if(customersDb is null)
            {
                return NotFound();
            }
            else
            {
                var resutl = new CustomerDto { Email = customersDb.Email, Firstname = customersDb.Firstname, Lastname = customersDb.Lastname, Id = customersDb.Id };
                return Ok(resutl);
            }
        }


        [HttpGet("GetCustomersByProductId/{id}")]
        public async Task<IActionResult> GetCustomersByProductId(int id)
        {
            var t = await _testApiDbContext.SalesOrders.Where(so => so.OrderItems.Any(oi => oi.ProductId.Equals(id))).Include(c => c.Customer).ToListAsync();
            
            var tt = t.Select(c => c.Customer).ToList();
            var result = tt.Select(t => new CustomerDto { Email = t.Email, Firstname = t.Firstname, Lastname = t.Lastname });
            return Ok(result);
        }
    }
}