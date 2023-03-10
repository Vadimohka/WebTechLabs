using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private List<ListDemo> _listDemos = new List<ListDemo>()
        {
            new ListDemo() {ListItemValue = 1, ListItemText = "Item1"},
            new ListDemo() {ListItemValue = 2, ListItemText = "Item2"},
            new ListDemo() {ListItemValue = 3, ListItemText = "Item3"},
        };
        public IActionResult Index()
        {
            ViewBag.Text = "Лабораторная работа 2";
            ViewBag.List = new SelectList(_listDemos, "ListItemValue", "ListItemText");
            return View();
        }
        public class ListDemo
        {
            public int ListItemValue { get; set; }
            public string ListItemText { get; set; }
        }
    }
}
