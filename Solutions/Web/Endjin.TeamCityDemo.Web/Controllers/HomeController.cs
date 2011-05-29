namespace Endjin.TeamCityDemo.Web.Controllers
{
    #region Using Directives

    using System.Web.Mvc;

    using Endjin.TeamCityDemo.Domain;
    using Endjin.TeamCityDemo.Tasks;

    #endregion

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var domainObject = new MyDomainObject();
            var task = new MyTask();

            task.DoSomething(domainObject);

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}