using Microsoft.AspNetCore.Mvc;

namespace HamyarApp.Controllers
{
    public class FirstController 
    {

        [Route("url1")]
        public string test1()
        {


            return "Hello everybody";


        }
    }
}
