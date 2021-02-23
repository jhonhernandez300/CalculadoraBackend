using CalculadoraLaboralBackend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraLaboralBackend.Controllers
{
    [Route("api/Servicio")]
    [EnableCors("CorsPolicy")]
    public class ServicioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: api/PostServicio        
        [HttpPost("PostServicio")]        
        public async Task<ActionResult<Servicio>> PostServicio([FromBody]Servicio servicio)        
        {            
             calcularHorasDiaDeLaSemana(servicio);
            servicio.Fecha = DateTime.Now;
            
            _context.Servicio.Add(servicio);
            await _context.SaveChangesAsync();
            
            return servicio;
        }
                
                
        // GET: api/GetServicio/5        
        [HttpGet("GetServicio/{tecnico}/{semanaDelAno}")]
        public async Task<IActionResult> GetServicio(string tecnico, int semanaDelAno)
        {
            var servicio = await _context.Servicio.Where(i => i.Tecnico == tecnico && i.SemanaDelAno == semanaDelAno).ToListAsync();

            if (servicio.Count == 0)
            {
                return NotFound();
            }

            return Ok(servicio);
        }

        public void calcularHorasDiaDeLaSemana(Servicio servicio)
        {
            if (servicio.HoraInicial >= 7 && servicio.HoraInicial < 20)
            {
                inicioDiurno(servicio);

            }
            else {
                inicioNocturno(servicio);
            }
        }

        public void inicioDiurno(Servicio servicio)
        {
            if (servicio.HoraFinal >= 7 && servicio.HoraFinal < 20)
            {
                //fin diurno
                servicio.HorasDiurnas = servicio.HoraFinal - servicio.HoraInicial;

            }
            else
            {
                //fin nocturno
                //Las horas son diurnas hasta las 20
                servicio.HorasDiurnas = 20 - servicio.HoraInicial;
                servicio.HorasNocturnas = servicio.HoraFinal - 20;                
            }
        }

        public void inicioNocturno(Servicio servicio)
        {
            //Terminó en la noche
            if (servicio.HoraInicial >= 20 && servicio.HoraFinal <= 24)
            {
                servicio.HorasNocturnas = servicio.HoraFinal - 20;
            }
            //Terminó en la madrugada o en las primeras horas de la mañana
            else if (servicio.HoraInicial >= 24 && servicio.HoraFinal < 7)
            {
                servicio.HorasNocturnas = servicio.HoraFinal;
            }
            //Terminó en la mañana con horas diurnas
            else
            {
                servicio.HorasDiurnas = servicio.HoraFinal - 7;
                servicio.HorasNocturnas = 7 - servicio.HoraInicial;
            }
        }

    }
}
