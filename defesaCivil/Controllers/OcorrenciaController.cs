using defesaCivil.Domain.Entidades;
using defesaCivil.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace defesaCivil.Controllers
{
    public class OcorrenciaController : Controller
    {

        private IOcorrenciaService _ocorrenciaService;

        public OcorrenciaController(IOcorrenciaService ocorrenciaService)
        {
            _ocorrenciaService = ocorrenciaService;
        }

        public IActionResult Index()
        {
            var ocorrencias = _ocorrenciaService.BuscarTodas();
            ViewBag.Ocorrencias = ocorrencias;
            return View();                                                          
        }

        public IActionResult Editar(long id)
        {
            var ocorrencia = _ocorrenciaService.BuscarTodas().First(x => x.Id == id);
            return View("Form", ocorrencia);
        }

        public IActionResult Form()
        {
            var model = new Ocorrencia();
            return View(model);
        }

        [HttpPost]
        public IActionResult Form(Ocorrencia model)
        {
            var cliente = _ocorrenciaService.Salvar(model);
            return RedirectToAction("Index");
        }

        public IActionResult Remover(long id)
        {
            _ocorrenciaService.Remover(id);
            return RedirectToAction("Index");
        }
    }
}
