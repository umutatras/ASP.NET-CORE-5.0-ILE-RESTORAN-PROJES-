using Microsoft.AspNetCore.Mvc;
using RestaturanProje.Data;
using System.Linq;

namespace RestaturanProje.ViewComponents
{
    public class Comment:ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public Comment(ApplicationDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var values = _db.Blogs.Where(i=>i.Status).ToList();
            return View(values);
        }
    }
}
