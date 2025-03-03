using deneme.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace deneme.ViewComponents
{
    public class PersonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Persons> datas = new List<Persons>
            {
                new Persons {adi="Erkan", soyadi="Tanyildizi"},
                new Persons {adi="Melek", soyadi="Gün"},
                new Persons {adi="Gamze", soyadi="Erken"}
            };
            return View(datas);
        }
    }
}
