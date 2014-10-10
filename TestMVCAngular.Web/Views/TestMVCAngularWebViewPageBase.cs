using Abp.Web.Mvc.Views;

namespace TestMVCAngular.Web.Views
{
    public abstract class TestMVCAngularWebViewPageBase : TestMVCAngularWebViewPageBase<dynamic>
    {

    }

    public abstract class TestMVCAngularWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TestMVCAngularWebViewPageBase()
        {
            LocalizationSourceName = "TestMVCAngular";
        }
    }
}