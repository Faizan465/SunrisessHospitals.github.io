using Microsoft.AspNetCore.Mvc;
using sunrisehospital.Models;
using sunrisehospital.Helper;
namespace sunrisehospital.Controllers
{
    public class ContactController : Controller
    {

        private readonly AppDbContext _context;

      

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
         
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] 
     
        [ValidateAntiForgeryToken]         
        public IActionResult Send(Enquir enquir)


        {

   _context.Add(enquir);
            _context.SaveChanges();
ModelState.Clear();
            return View("Index");
           
          

         
        }

        
 



      
    }





    
}
