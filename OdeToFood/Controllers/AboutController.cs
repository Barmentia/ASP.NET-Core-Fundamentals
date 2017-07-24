using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "1+5555-5555-5555";
        }

        public string Address()
        {
            return "USA";
        }
    }
}
