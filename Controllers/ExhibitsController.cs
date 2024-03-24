using Microsoft.AspNetCore.Mvc;
using Museum.Models;
using System.Collections.Generic;

public class ExhibitsController : Controller
{
    private static List<Exhibit> exhibits = new List<Exhibit>();

    public IActionResult Index()
    {
        return View(exhibits);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Exhibit exhibit)
    {
        // Логика добавления новой экспозиции
        exhibit.Id = exhibits.Count + 1;
        exhibits.Add(exhibit);

        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        // Найти экспозицию по id и передать в представление для редактирования
        Exhibit exhibit = exhibits.Find(e => e.Id == id);
        return View(exhibit);
    }

    [HttpPost]
    public IActionResult Edit(Exhibit exhibit)
    {
        // Логика редактирования экспозиции
        int index = exhibits.FindIndex(e => e.Id == exhibit.Id);
        exhibits[index] = exhibit;

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        // Найти экспозицию по id и передать в представление для подтверждения удаления
        Exhibit exhibit = exhibits.Find(e => e.Id == id);
        return View(exhibit);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        // Логика удаления экспозиции
        exhibits.RemoveAll(e => e.Id == id);

        return RedirectToAction("Index");
    }
}
