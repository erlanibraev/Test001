using System;
using NFX.Wave.MVC;
using Test001.Pages;

namespace Test001.Controllers
{
    public class IndexController : Controller
    {
        [Action]
        public object Index()
        {
            return new index();
        }
    }
}
