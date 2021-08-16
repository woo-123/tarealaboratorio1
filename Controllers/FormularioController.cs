using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
namespace demomvc.Controllers
{
    public class FormularioController : Controller
    {

        public IActionResult registroProducto()
        {

            return View();
        }

        [HttpPost]
        public IActionResult calcularTotal(Formulario obj)
        {

            ViewData["producto"] = obj.nombre;
            decimal subtotal = obj.precio * obj.cantidad;
            ViewData["Message"] = "El Subtotal es " + subtotal + " Soles";
            decimal total = subtotal + ((subtotal * 18) / 100);
            ViewData["total"] = "El Total con IGV es " + total + " Soles";

            return View("registroProducto");
        }

    }

}