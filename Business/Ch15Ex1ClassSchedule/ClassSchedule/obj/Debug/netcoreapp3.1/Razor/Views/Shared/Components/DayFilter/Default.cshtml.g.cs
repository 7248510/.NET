#pragma checksum "H:\Code\Github\ASP\Ch15Ex1ClassSchedule\ClassSchedule\Views\Shared\Components\DayFilter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "737a341c6f34b023ed521c2099d1241e7d36335b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DayFilter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DayFilter/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "H:\Code\Github\ASP\Ch15Ex1ClassSchedule\ClassSchedule\Views\_ViewImports.cshtml"
using ClassSchedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Code\Github\ASP\Ch15Ex1ClassSchedule\ClassSchedule\Views\_ViewImports.cshtml"
using ClassSchedule.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"737a341c6f34b023ed521c2099d1241e7d36335b", @"/Views/Shared/Components/DayFilter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e7d3d6b4babde4417946b2fed995e7a91a2739b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DayFilter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Day>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-1 mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::ClassSchedule.TagHelpers.MyLinkButtonTagHelper __ClassSchedule_TagHelpers_MyLinkButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\Code\Github\ASP\Ch15Ex1ClassSchedule\ClassSchedule\Views\Shared\Components\DayFilter\Default.cshtml"
  
    int id = Convert.ToInt32(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\Code\Github\ASP\Ch15Ex1ClassSchedule\ClassSchedule\Views\Shared\Components\DayFilter\Default.cshtml"
 foreach (Day d in Model)
{
    //Using the day object from DayFilter

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("my-link-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "737a341c6f34b023ed521c2099d1241e7d36335b4381", async() => {
#nullable restore
#line 10 "H:\Code\Github\ASP\Ch15Ex1ClassSchedule\ClassSchedule\Views\Shared\Components\DayFilter\Default.cshtml"
                                Write(d.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __ClassSchedule_TagHelpers_MyLinkButtonTagHelper = CreateTagHelper<global::ClassSchedule.TagHelpers.MyLinkButtonTagHelper>();
            __tagHelperExecutionContext.Add(__ClassSchedule_TagHelpers_MyLinkButtonTagHelper);
            __ClassSchedule_TagHelpers_MyLinkButtonTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "H:\Code\Github\ASP\Ch15Ex1ClassSchedule\ClassSchedule\Views\Shared\Components\DayFilter\Default.cshtml"
                           WriteLiteral(d.DayId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __ClassSchedule_TagHelpers_MyLinkButtonTagHelper.Id = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __ClassSchedule_TagHelpers_MyLinkButtonTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 10 "H:\Code\Github\ASP\Ch15Ex1ClassSchedule\ClassSchedule\Views\Shared\Components\DayFilter\Default.cshtml"
__ClassSchedule_TagHelpers_MyLinkButtonTagHelper.IsActive = (id == d.DayId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("is-active", __ClassSchedule_TagHelpers_MyLinkButtonTagHelper.IsActive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 11 "H:\Code\Github\ASP\Ch15Ex1ClassSchedule\ClassSchedule\Views\Shared\Components\DayFilter\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Day>> Html { get; private set; }
    }
}
#pragma warning restore 1591
