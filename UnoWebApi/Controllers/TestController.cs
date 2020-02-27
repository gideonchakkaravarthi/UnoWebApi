using System.Web.Mvc;

namespace UnoWebApi.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            CarRentalEntities objCR = new CarRentalEntities();
            //objCR.Accounts
            return View();
        }
    }
}