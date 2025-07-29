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
        [Route("Download")]
        public VirtualFileResult DownloadFile()
        {


            return new VirtualFileResult("/nature.jpg", "image/png");


        }
    }
}
