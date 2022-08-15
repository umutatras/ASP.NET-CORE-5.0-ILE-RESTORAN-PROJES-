using Microsoft.AspNetCore.Mvc;
using RestaturanProje.Data;
using System.Linq;

namespace RestaturanProje.ViewComponents
{
    public class CategoryList:ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public CategoryList(ApplicationDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var values = _db.Categories.ToList();
            return View(values);
        }
    }
}
