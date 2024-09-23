using APITekrar.Data;
using APITekrar.DTOs;
using APITekrar.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APITekrar.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public FoodController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("{chefId}")]
        public async Task<IActionResult> AddFood(FoodDTO foodDTO, int chefId)
        {
            foodDTO.ChefId = chefId;
            await _context.Foods.AddAsync(_mapper.Map<Food>(foodDTO));
            await _context.SaveChangesAsync();
            return Ok(foodDTO);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFoods()
        {
            var foods = await _context.Foods.ToListAsync();
            var getFood = _mapper.Map<List<FoodDTO>>(foods);
            return Ok(getFood);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFood(int id, FoodDTO foodDTO)
        {
            var food = await _context.Foods.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }
            food.Name = foodDTO.Name;
            food.PreperationTime = foodDTO.PreperationTime;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdFood(int id)
        {
            var food = await _context.Foods.Include(x => x.Chef).FirstOrDefaultAsync(x => x.Id == id);
            return Ok(_mapper.Map<FoodListDTO>(food));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFood(int id)
        {
            var food = await _context.Foods.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }
            _context.Foods.Remove(food);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
