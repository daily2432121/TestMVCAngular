using System.Web;
using Abp.Localization.Sources.Xml;

namespace TestMVCAngular.Web.Localization.TestMVCAngular
{
    public class TestMVCAngularLocalizationSource : XmlLocalizationSource
    {
        public TestMVCAngularLocalizationSource()
            : base("TestMVCAngular", HttpContext.Current.Server.MapPath("/Localization/TestMVCAngular"))
        {
        }
    }
}