using Microsoft.AspNetCore.Mvc;
using TeamMembers.Data;
using TeamMembers.Data.Models;

namespace TeamMembers.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController(ILogger<PeopleController> logger, AppDbContext context) : ControllerBase
{
    [HttpGet]
    public IEnumerable<Person> Get()
    {
        return context.People;
    }
}
