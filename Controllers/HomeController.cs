using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineBookstoreZachDaniels.Models;
using OnlineBookstoreZachDaniels.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreZachDaniels.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBookstoreRepo _repo;
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBookstoreRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult Index(int page = 1)
        {
            return View(new ProjectListViewModel
            {
                Books = _repo.Books
                .OrderBy(p => p.BookId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repo.Books.Count()
                }
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
