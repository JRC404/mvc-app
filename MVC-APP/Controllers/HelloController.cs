using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; // Controller is inside of MVC...
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_APP.Controllers

    /*
     * controller folder - how it is named
     * views folder - what you need to create - looking back on the controllers we
     * already have
     * render the pages
     * 3 controllers, 3 views... 3 amigos.
     */


{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
            // Index() speaks to a file with the same name as our controller in
            // the views folder.
            // Views/Hello: by default, it looks for index... just like any web server
            // View = the name of the Method - if it matches the Views/InsertNameHere
        }

        //public IActionResult About()
        //{
        //    return View();
        //    // View is looking inside of the Views/ folder - looking for About.cshtml
        //    // render it...
        //}

        /*
         * https://localhost:{PORT}/Hello/
         */

        // GET: /Hello/
        //public string Index() // our home for the Controller...
        //{
        //    return "This is my go to page for the controller, yo.";
        //}


    }
}
