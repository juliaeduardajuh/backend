
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _17_CRUD.Models;


namespace _17_CRUD.Controllers
{

    public class TarefaController : Controller
    {
        private static List<Tarefa> _tarefas = new List<Tarefa>();
        public IActionResult Index()
        {
            return View(_tarefas);
        }
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Tarefa novaTarefa)
        {
            novaTarefa.Id = _tarefas.Count +1;
            _tarefas.Add(novaTarefa);
            return RedirectToAction("Index");
        }
        public IActionResult Editar (int Id)
        {
            Tarefa tarefaBD = _tarefas.FirstOrDefault(t => t.Id ==Id);
            if (tarefaBD == null)
                return NotFound();

            return View(tarefaBD);
        }
        [HttpPost]
        public IActionResult Editar (Tarefa tarefaEditando)
        {
             Tarefa tarefaBD = _tarefas.Find(t => t.Id == tarefaEditando.Id);
            if (tarefaBD == null)
                return NotFound();
            
            tarefaBD.Descricao = tarefaEditando.Descricao;
            tarefaBD.Concluida = tarefaEditando.Concluida;
            return RedirectToAction("Index");
        }
        public IActionResult Deletar (int Id)
        {
            Tarefa tarefaBD = _tarefas.FirstOrDefault(t => t.Id ==Id);
            if (tarefaBD == null)
                return NotFound();

            return View(tarefaBD);
        }
        [HttpPost]
        public IActionResult Deletar (Tarefa tarefaDeletando)
        {
             Tarefa tarefaDB = _tarefas.Find(t => t.Id == tarefaDeletando.Id);
            if (tarefaDB == null)
                return NotFound();
            _tarefas.Remove(tarefaDB);
            return RedirectToAction("Index");
        }

    }
}