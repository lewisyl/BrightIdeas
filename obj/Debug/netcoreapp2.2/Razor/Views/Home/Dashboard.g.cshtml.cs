#pragma checksum "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efc4d37ad2a99cd7de6b150c9ba7770f75afc71d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas;

#line default
#line hidden
#line 5 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
using BrightIdeas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efc4d37ad2a99cd7de6b150c9ba7770f75afc71d", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dashboard>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Idea.Content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Post something witty here..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validationMsg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/new-idea"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(86, 69, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-9\">\n        <h1>Welcome back, ");
            EndContext();
            BeginContext(156, 20, false);
#line 10 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
                     Write(Model.ThisUser.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(176, 120, true);
            WriteLiteral("!</h1>\n    </div>\n    <div class=\"col-3\">\n        <a href=\"/logout\">Logout</a>\n    </div>\n</div>\n\n<div class=\"row\">\n    ");
            EndContext();
            BeginContext(296, 463, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efc4d37ad2a99cd7de6b150c9ba7770f75afc71d7305", async() => {
                BeginContext(335, 46, true);
                WriteLiteral("\n        <div class=\"form-group\">\n            ");
                EndContext();
                BeginContext(381, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efc4d37ad2a99cd7de6b150c9ba7770f75afc71d7728", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 20 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Idea.Content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(419, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(432, 145, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efc4d37ad2a99cd7de6b150c9ba7770f75afc71d9341", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 21 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Idea.Content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(577, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(590, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efc4d37ad2a99cd7de6b150c9ba7770f75afc71d11401", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 22 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Idea.Content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(659, 93, true);
                WriteLiteral("\n        </div>\n        <button type=\"submit\" class=\"btn btn-primary\">Add Idea!</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(759, 61, true);
            WriteLiteral("\n</div>\n\n<div class=\"row ideas\">\n    <ul class=\"list-group\">\n");
            EndContext();
#line 30 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
          
            foreach (var item in @Model.AllIdeas)
            {

#line default
#line hidden
            BeginContext(895, 95, true);
            WriteLiteral("                <li class=\"list-group-item\">\n                    <p>\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 990, "\"", 1019, 2);
            WriteAttributeValue("", 997, "/users/", 997, 7, true);
#line 35 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1004, item.CreatedBy, 1004, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1020, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1022, 65, false);
#line 35 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
                                                    Write(Model.AllUsers.FirstOrDefault(u=>u.UserId==@item.CreatedBy).Alias);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 84, true);
            WriteLiteral("</a> says:\n                    </p>\n                    <p>\n                        ");
            EndContext();
            BeginContext(1172, 12, false);
#line 38 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
                   Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1184, 130, true);
            WriteLiteral("\n                    </p>\n                    <p>\n                        <span class=\"likeNCount\">\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1314, "\"", 1339, 2);
            WriteAttributeValue("", 1321, "/like/", 1321, 6, true);
#line 42 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1327, item.IdeaId, 1327, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1340, 192, true);
            WriteLiteral(">Like</a>\n                            \n                        </span>\n                        <span> | </span>\n                        <span class=\"likeNCount\">\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1532, "\"", 1564, 2);
            WriteAttributeValue("", 1539, "/idea-detail/", 1539, 13, true);
#line 47 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1552, item.IdeaId, 1552, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1565, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1567, 18, false);
#line 47 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
                                                           Write(item.LikedBy.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1585, 94, true);
            WriteLiteral(" people</a> like it.\n                        </span>\n                        <span> | </span>\n");
            EndContext();
#line 50 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
                         if (@item.CreatedBy == @Model.ThisUser.UserId)
                        {

#line default
#line hidden
            BeginContext(1777, 88, true);
            WriteLiteral("                            <span class=\"likeNCount\">\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1865, "\"", 1892, 2);
            WriteAttributeValue("", 1872, "/delete/", 1872, 8, true);
#line 53 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1880, item.IdeaId, 1880, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1893, 48, true);
            WriteLiteral(">Delete</a>\n                            </span>\n");
            EndContext();
#line 55 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
                        }

#line default
#line hidden
            BeginContext(1967, 47, true);
            WriteLiteral("                    </p>\n                </li>\n");
            EndContext();
#line 58 "/Users/lewisliu/Desktop/codingDojo/dotnet/BeltExam/BrightIdeas/Views/Home/Dashboard.cshtml"
            }
        

#line default
#line hidden
            BeginContext(2038, 26, true);
            WriteLiteral("        \n    </ul>\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dashboard> Html { get; private set; }
    }
}
#pragma warning restore 1591
