using ZiLinToolkit.App.Models;
using ZiLinToolkit.CoreModules.App.Controllers;

namespace ZiLinToolkit.App.Controllers
{
    public class TestController : Controller<Test>
    {
        public static void Create(string name) => new Test { Name = name }.Create();
    }
}
