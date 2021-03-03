using Microsoft.AspNetCore.Mvc;
using OnlineBookstoreZachDaniels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreZachDaniels.Components
{
    public class NavigationMenuViewComponent : ViewComponent 
    {
        private IBookstoreRepo _repo;
        public NavigationMenuViewComponent(IBookstoreRepo repo)
        {
            _repo = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCat = RouteData?.Values["category"];
            return View(_repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
