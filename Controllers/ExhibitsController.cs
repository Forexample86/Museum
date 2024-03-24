using Microsoft.AspNetCore.Mvc;
using Museum.Models;
using System.Collections.Generic;

public class ExhibitsController : Controller
{
    private static List<Exhibition> exhibitions = new List<Exhibition>();

    public IActionResult Index()
    {
        return View(exhibitions);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Exhibition exhibit)
    {
        // Логика добавления новой экспозиции
        exhibit.Id = exhibitions.Count + 1;
        exhibitions.Add(exhibit);

        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        // Найти экспозицию по id и передать в представление для редактирования
        Exhibition exhibit = exhibitions.Find(e => e.Id == id);
        return View(exhibit);
    }

    [HttpPost]
    public IActionResult Edit(Exhibition exhibit)
    {
        // Логика редактирования экспозиции
        int index = exhibitions.FindIndex(e => e.Id == exhibit.Id);
        exhibitions[index] = exhibit;

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        // Найти экспозицию по id и передать в представление для подтверждения удаления
        Exhibition exhibit = exhibitions.Find(e => e.Id == id);
        return View(exhibit);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        // Логика удаления экспозиции
        exhibitions.RemoveAll(e => e.Id == id);

        return RedirectToAction("Index");
    }
}
