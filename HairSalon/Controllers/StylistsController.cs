using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Contollers
{
  public class StylistsController : Contoller
  {
    private readonly HairSalonContext _db;
    
    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }
  }
}