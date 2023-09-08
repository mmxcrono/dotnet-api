using Microsoft.AspNetCore.Mvc;
using ContosoPizza.Models;
using ContosoPizza.Services;

namespace dotnet_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase {

  public PizzaController() {}

  [HttpGet]
  public ActionResult<List<Pizza>> GetAll() =>
  PizzaService.GetAll();

}