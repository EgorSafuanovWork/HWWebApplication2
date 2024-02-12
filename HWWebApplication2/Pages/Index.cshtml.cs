using HWWebApplication2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HWWebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            var dog = new Dog();
            dog.MakeSound();

            var cat = new Cat();
            cat.MakeSound();
        }
    }
}