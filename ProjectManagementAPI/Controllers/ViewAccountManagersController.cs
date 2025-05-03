using EFCoreExample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagment.Data.Entities;


[ApiController]
[Route("api/[controller]")]
public class AccountManagersController : ControllerBase
{
    private readonly AppDbContext _context;

    public AccountManagersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ViewAccountManagers>>> Get()
    {
        var managers = await _context.AccountManagersView.ToListAsync();

        foreach (var AccountMan in managers)
        {
            Console.WriteLine($"ID: {AccountMan.Id}, FullName: ¨{AccountMan.Full_Name}");

        }

        return Ok(managers);
    }
}