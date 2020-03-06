using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dost.Patiler.Barinak.Models;
using Dost.Patiler.Barinak.Models.Database;

namespace Dost.Patiler.Barinak.Controllers
{
    public class IletisimController : Controller
    {
        BarinakContext _db;
        public IletisimController(BarinakContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Kullanici model)
        {
            try
            {
                _db.kullanici.Add(model);//kullaniciyi kaydet
                _db.SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/iletisim");
            }
            catch (System.Exception ex)
            {
                
                throw;
            }
        }
    }
}
