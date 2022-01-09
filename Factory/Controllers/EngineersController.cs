using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Engineers.ToList());
    }

    public ActionResult Details(int id)
    {
      var thisEngineer = _db.Engineers
          .Include(Engineer => Engineer.JoinEntities)
          .ThenInclude(join => join.Machine)
          .FirstOrDefault(Engineer => Engineer.EngineerId == id);
      return View(thisEngineer);
    }

  }
}
