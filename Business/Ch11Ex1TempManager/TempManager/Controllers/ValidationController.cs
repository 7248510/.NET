using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempManager.Models;
namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private TempManagerContext data { get; set; }
        public ValidationController(TempManagerContext ctx) => data = ctx;
        public JsonResult CheckDate(string date)
        {
            DateTime dt = DateTime.Parse(date);
            Temp temp = data.Temps.FirstOrDefault(t => t.Date == dt);

            if (temp == null)
                return Json(true);
            else
                return Json($"duplicate date {date} is already in the database.");
        }
    }
}
