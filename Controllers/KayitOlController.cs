using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dost.Patiler.Barinak.Models;
using Dost.Patiler.Barinak.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Dost.Patiler.Barinak.Controllers
{
    public class KayitOlController : Controller
    {
        BarinakContext _db;
        public KayitOlController(BarinakContext db)
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
                return Redirect("/Barinak");// barinak adresine yönlendir.
            }
            catch (System.Exception ex)
            {
                
                throw;
            }
        }
        public async Task<IActionResult> GirisYap(string email,string sifre){
            var kullanici = await _db.kullanici.FirstOrDefaultAsync(w=> w.email==email && w.sifre == sifre);
            if(kullanici==null){
                return Redirect("/");
            }
            HttpContext.Session.SetInt32("id",kullanici.kullanici_id);
            HttpContext.Session.SetString("kullanici_adi",kullanici.ad);
            if(kullanici.admin){
            HttpContext.Session.SetString("admin","true");
            }else{
            HttpContext.Session.SetString("admin","false");
            }
            return Redirect("/");
        }
        public IActionResult cikisYap(){
            HttpContext.Session.Clear();
            return Redirect("/");
        }
    }
}
