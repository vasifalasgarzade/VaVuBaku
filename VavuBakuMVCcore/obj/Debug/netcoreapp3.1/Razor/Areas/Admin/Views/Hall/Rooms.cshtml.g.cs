#pragma checksum "C:\Users\Vasif\Desktop\RestaurantApp\RestaurantApp\VavuBakuMVCcore\Areas\Admin\Views\Hall\Rooms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "872c9693a4833c2ca39db6cf3e2b202f664efc53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Hall_Rooms), @"mvc.1.0.view", @"/Areas/Admin/Views/Hall/Rooms.cshtml")]
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
#line 1 "C:\Users\Vasif\Desktop\RestaurantApp\RestaurantApp\VavuBakuMVCcore\Areas\Admin\Views\_ViewImports.cshtml"
using VavuBakuMVCcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vasif\Desktop\RestaurantApp\RestaurantApp\VavuBakuMVCcore\Areas\Admin\Views\_ViewImports.cshtml"
using VavuBakuMVCcore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vasif\Desktop\RestaurantApp\RestaurantApp\VavuBakuMVCcore\Areas\Admin\Views\_ViewImports.cshtml"
using VavuBakuMVCcore.Areas.Admin.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"872c9693a4833c2ca39db6cf3e2b202f664efc53", @"/Areas/Admin/Views/Hall/Rooms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75e0c7be5459770fb400a2e60596cfaa454131ac", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Hall_Rooms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Room>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Hall", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("no-underline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row up-halls hall-room-buttons\">\r\n    <div class=\"col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12\">\r\n        <button class=\"btn btn-outline-primary w-25 exit-button\"><i class=\"fas fa-arrow-left w-100 fa-3x\"></i></button>\r\n    </div>\r\n");
#nullable restore
#line 7 "C:\Users\Vasif\Desktop\RestaurantApp\RestaurantApp\VavuBakuMVCcore\Areas\Admin\Views\Hall\Rooms.cshtml"
     foreach (var uphall in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-xl-4 col-lg-4 col-md-4 col-sm-4 col-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "872c9693a4833c2ca39db6cf3e2b202f664efc534996", async() => {
                WriteLiteral("\r\n                <div class=\"p-3 up-hall-buttons hlfo\">\r\n                    <h2>");
#nullable restore
#line 12 "C:\Users\Vasif\Desktop\RestaurantApp\RestaurantApp\VavuBakuMVCcore\Areas\Admin\Views\Hall\Rooms.cshtml"
                   Write(uphall.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\Vasif\Desktop\RestaurantApp\RestaurantApp\VavuBakuMVCcore\Areas\Admin\Views\Hall\Rooms.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
