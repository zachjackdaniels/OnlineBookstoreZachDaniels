using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookstoreZachDaniels.Infrastructure;
using OnlineBookstoreZachDaniels.Models;

namespace OnlineBookstoreZachDaniels.Pages
{
    public class CartModel : PageModel
    {
        private IBookstoreRepo repository;
        public CartModel (IBookstoreRepo repo)
        {
            repository = repo;
        }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        
        public void OnGet(string returnUrl)
        {
            ReturnUrl = ReturnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }
        //add to cart method
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(x => x.BookId == bookId);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(book, 1);

            HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        //delete from cart method
        public IActionResult OnPostDelete(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(x => x.BookId == bookId);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.RemoveLine(book);

            HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
