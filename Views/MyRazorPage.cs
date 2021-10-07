using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace SimpleInjectorIssue928.Views
{
    public abstract class MyRazorPage<TModel> : RazorPage<TModel>
    {
        [RazorInject] public SomeDependency SomeDependency { get; set; }
    }
}
