using EFCoreExample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagment.Data.Entities;


[ApiController]
[Route("api/[controller]")]

    public class ViewProjectStatusController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ViewProjectStatusController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewProjectStatusController>>> Get()
        {
            var projects = await _context.ProjectStatusView.ToListAsync();

            foreach (var project in projects)
            {
                Console.WriteLine($"ProjName: {project.ProjectName}, Start: ¨{project.ProjectStart}, percante {project.PercentageComplete}");

            }

            return Ok(projects);
        }

    }

