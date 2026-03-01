using Microsoft.AspNetCore.Mvc;
using SumApi.Data;
using SumApi.Models;

namespace SumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SumController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddNumbers(int num1, int num2)
        {
            var result = num1 + num2;

            var record = new SumRecord
            {
                Number1 = num1,
                Number2 = num2,
                Result = result
            };

            _context.SumRecords.Add(record);
            await _context.SaveChangesAsync();

            return Ok(record);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _context.SumRecords.ToList();
            return Ok(data);
        }
    }
}