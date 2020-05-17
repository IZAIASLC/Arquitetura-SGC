using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SCG.ApplicationCore.Entity;
using SCG.ApplicationCore.Interfaces.Services;
using SCG.Infrastructure.Transaction.Interfaces;
using SGC.UI.Web.Controllers.Base;

namespace SGC.UI.Web.Controllers
{
 
    [Route("[controller]")]
    public class WeatherForecastController : BaseController
    {
        private readonly IClienteService _clienteService;
  

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IClienteService clienteService, IUnitOfWork unitOfWork):base(unitOfWork)
        {
            _logger = logger;
            _clienteService = clienteService;
        }

        [HttpGet]
        public async  Task<IActionResult> Get()
        {
            try { 

            Cliente c = new Cliente("Manoel","03403028607");

            c.Contato.Add(new Contato() { Nome = "jose",Email="jose@gmail.com", Telefone="959454-02155" });

            c.Contato.Add(new Contato() { Nome = "maria", Email = "maria@gmail.com", Telefone = "45844-1244" });

            c.Contato.Add(new Contato() { Nome = "silvia", Email = "silvia@gmail.com", Telefone = "87554-1244" });

             _clienteService.Adicionar(c); 



            var clietne = _clienteService.ObterTodos();


            var rng = new Random();
            var range = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();



            return await  ResponseAsync(clietne, _clienteService);
            }
            catch (Exception e)
            {
                return await ResponseExceptionAsync(e);
            }
        }
    }
}
