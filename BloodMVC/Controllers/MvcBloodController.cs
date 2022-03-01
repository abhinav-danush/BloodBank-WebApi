using BloodMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BloodMVC.Controllers
{
    public class MvcBloodController : Controller
    {   
        private IEnumerable<MvcBloodDetails> empList;

        public IActionResult Index()
        {
            IEnumerable<MvcBloodDetails> bloodlist;
            HttpResponseMessage response = GlobalVariables.webapiClient.GetAsync("Blood").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<MvcBloodDetails>>().Result;


            return View(empList);
        }
    }
}
