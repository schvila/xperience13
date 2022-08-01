using Kentico.Content.Web.Mvc.Routing;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

namespace MEDIOClinic
{
    public class ApplicationConfig
    {
        public static void RegisterFeatures(IApplicationBuilder builder)
        {
            // Enable required Kentico features

            // Uncomment the following to use the Page builder feature
            builder.UsePageBuilder();

            //builder.UseScheduler();
            builder.UsePageRouting(new PageRoutingOptions
            {
                //EnableAlternativeUrls = true
            });
        }
    }
}