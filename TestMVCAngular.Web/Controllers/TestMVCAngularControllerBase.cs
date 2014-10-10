using Abp.Web.Mvc.Controllers;

namespace TestMVCAngular.Web.Controllers
{
    public abstract class TestMVCAngularControllerBase : AbpController
    {
        protected TestMVCAngularControllerBase()
        {
            LocalizationSourceName = "TestMVCAngular";
        }
    }
}