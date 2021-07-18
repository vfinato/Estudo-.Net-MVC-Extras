using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VF.Store.UI.Controllers;

namespace VF.Store.Tests.UI.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod, TestCategory("Controller/HomeController")]
        public void OMetodoIndexDeveraRetornarUmaView()
        {
            //a - rrange - Estrutura necessaria
            var homeController = new HomeController();


            //a - ct - Ação para testar o resultado
            var result = homeController.Index();


            //a - ssert - Ação para validar se o resultado é o correto
            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }
    }
}
