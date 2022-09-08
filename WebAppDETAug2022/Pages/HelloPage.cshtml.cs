using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Service;

namespace WebAppDETAug2022.Pages
{
    public class HelloPageModel : PageModel
    {
        public IHello ob { get; set; }

        public string Message { get; set; }

        public HelloPageModel(IHello i)
        {
            ob = i;
        }
        public void OnGet() =>
            //ob = new Hello2();
            Message = ob.SayHello("nithya");
    }
}
