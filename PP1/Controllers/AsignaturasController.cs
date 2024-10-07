using Microsoft.AspNetCore.Mvc;
using PP1.Models;

namespace PP1.Controllers
{
    public class AsignaturasController : Controller
    {
        public IActionResult Index()
        {
            // Asegúrate de que la lista esté correctamente inicializada
            List<Asignatura> asignaturas = new List<Asignatura>
        {
            new Asignatura { NombreAsignatura = "Matemáticas II", NombreProfesor = "Dr. Pérez", Creditos = 4, Cuatrimestre = 3 },
            new Asignatura { NombreAsignatura = "Programación Avanzada", NombreProfesor = "Ing. García", Creditos = 5, Cuatrimestre = 4 },
            new Asignatura { NombreAsignatura = "Física II", NombreProfesor = "Dr. López", Creditos = 4, Cuatrimestre = 3 },
            new Asignatura { NombreAsignatura = "Bases de Datos", NombreProfesor = "Lic. Hernández", Creditos = 4, Cuatrimestre = 4 }
        };

            // Pasa la lista a la vista
            return View(asignaturas);
        }
    }

}

