using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListEvaluacion.Models;


namespace TodoListEvaluacion.Controllers
{
    public class TareaController : Controller
    {

        Data.ApplicationDbContext ctx;

        public TareaController(Data.ApplicationDbContext context)
        {
            ctx = context;
        
        }

        public IActionResult ListadoTareas()
        {
            List<Tarea>listado  = ctx.Tareas.OrderByDescending(x=> x.idPrioridad).ThenByDescending(x=> x.fecharegistro).ToList();
            foreach (Tarea item in listado)
            {
                item.Prioridad = ctx.Prioridads.Where(x => x.id == item.idPrioridad).FirstOrDefault();

            }

            ViewBag.Tareas = listado;
            return View();
        }


        public IActionResult Index()
        {
            ViewBag.Prioridad = ctx.Prioridads.ToList();
            return View();
        }

        [BindProperty]
        public Tarea tarea { get; set; }
        public IActionResult SaveTarea() 
        {
            //Tareas entity = new Tareas() {
            //    Nombre = tarea.Nombre,
            //    Detalle = tarea.Detalle,
            //    fecharegistro = tarea.fecharegistro,
            //    idPrioridad = 1
            //};
            ctx.Tareas.Add(tarea);
            ctx.SaveChanges();
            return RedirectToAction("Index");            
        }

    }
}
