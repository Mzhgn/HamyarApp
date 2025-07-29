using Microsoft.AspNetCore.Mvc;

namespace HamyarApp.Controllers
{
    public class FirstController
    {

        [Route("Home")]
        [Route("/")]

        public string test1()
        {


            return "Home Page";


        }

        [Route("About")]
        public string test2()
        {


            return "Abou us";


        }
        [Route("Contact")]
        public string test3()
        {


            return "Contact Us";


        }
    }
}
