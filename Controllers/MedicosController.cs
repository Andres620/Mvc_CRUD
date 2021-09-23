using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCRUD_MDC.Data;
using MvcCRUD_MDC.Models;

namespace MvcCRUD_MDC.Controllers
{
    public class MedicosController : Controller
    {
        //El ApplicationDbContext que nos permite acceder a la base de datos
        private readonly ApplicationDbContext _context;


        //Inicializo el acceso a ApplicationDbContext
        public MedicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Http Get Index
        public IActionResult Index()
        {
            IEnumerable<Medico> listaMedicos = _context.Medico;
            return View(listaMedicos);
        }


        //Http Get Create
        public IActionResult Create()
        {
            return View();
        }

        //Http Post Create
        [HttpPost]
        //proteccion para los formularios
        [ValidateAntiForgeryToken]
        public IActionResult Create(Medico Medico)
        {
            /*aqui lo que hace es validar que el modelo sea valido (Si el campo es requerido,
             la longitud de caracteres, etc..) */
            if (ModelState.IsValid)
            {
                //Envio a la base de datos
                _context.Medico.Add(Medico);
                //Guardo en la base de datos
                _context.SaveChanges();
                //Muestro un mensaje despues de guardar un Medico
                TempData["mensaje"] = "El Medico se ha creado correctamente";
                //Despues de guardar retorna al Index
                return RedirectToAction("Index");
            }

            return View();
        }

        //Http Get Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener el Medico
            var Medico = _context.Medico.Find(id);

            if (Medico == null)
            {
                return NotFound();
            }

            return View(Medico);
        }


        //Http Post Edit
        [HttpPost]
        //proteccion para los formularios
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Medico Medico)
        {
            /*aqui lo que hace es validar que el modelo sea valido (Si el campo es requerido,
             la longitud de caracteres, etc..) */
            if (ModelState.IsValid)
            {
                //Envio a la base de datos
                _context.Medico.Update(Medico);
                //Guardo en la base de datos
                _context.SaveChanges();
                //Muestro un mensaje despues de guardar un Medico
                TempData["mensaje"] = "El Medico se ha actualizado correctamente";
                //Despues de guardar retorna al Index
                return RedirectToAction("Index");
            }

            return View();
        }


        //Http Get Edit
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener el Medico
            var Medico = _context.Medico.Find(id);

            if (Medico == null)
            {
                return NotFound();
            }

            return View(Medico);
        }


        //Http Post Edit
        [HttpPost]
        //proteccion para los formularios
        [ValidateAntiForgeryToken]
        public IActionResult DeleteLibro(int? id)
        {
            //Obtener el Medico por id
            var Medico = _context.Medico.Find(id);

            if (Medico == null)
            {
                return NotFound();
            }

            //Elimino de base de datos
            _context.Medico.Remove(Medico);
            //Guardo en la base de datos
            _context.SaveChanges();
            //Muestro un mensaje despues de guardar un Medico
            TempData["mensaje"] = "El Medico se ha eliminado correctamente";
            //Despues de guardar retorna al Index
            return RedirectToAction("Index");
        }


    }
}
