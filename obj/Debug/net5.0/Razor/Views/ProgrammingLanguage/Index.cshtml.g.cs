#pragma checksum "C:\Projects\SignalRSample\Views\ProgrammingLanguage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8565de5dcd3de5db82ac61f71e5874ed529078bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProgrammingLanguage_Index), @"mvc.1.0.view", @"/Views/ProgrammingLanguage/Index.cshtml")]
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
#line 1 "C:\Projects\SignalRSample\Views\_ViewImports.cshtml"
using SignalR_Sample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\SignalRSample\Views\_ViewImports.cshtml"
using SignalR_Sample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\SignalRSample\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.SignalR;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8565de5dcd3de5db82ac61f71e5874ed529078bc", @"/Views/ProgrammingLanguage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8534fc0115a388f5eabdca0be0211da4f077b73f", @"/Views/_ViewImports.cshtml")]
    public class Views_ProgrammingLanguage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProgrammingLanguage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\SignalRSample\Views\ProgrammingLanguage\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    <table class=""table table-bordered"" style=""width:100%;"">
        <thead>
            <tr>
                <td>
                    Name
                </td>
                <td>
                    Description
                </td>
                <td>
                    Actions
                </td>
            </tr>
        </thead>
        <tbody id=""dashboard_table"">
");
#nullable restore
#line 21 "C:\Projects\SignalRSample\Views\ProgrammingLanguage\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=\"", 712, "\"", 729, 2);
            WriteAttributeValue("", 717, "row_", 717, 4, true);
#nullable restore
#line 23 "C:\Projects\SignalRSample\Views\ProgrammingLanguage\Index.cshtml"
WriteAttributeValue("", 721, item.Id, 721, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        ");
#nullable restore
#line 25 "C:\Projects\SignalRSample\Views\ProgrammingLanguage\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 28 "C:\Projects\SignalRSample\Views\ProgrammingLanguage\Index.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <button class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1005, "\"", 1035, 3);
            WriteAttributeValue("", 1015, "removeItem(", 1015, 11, true);
#nullable restore
#line 31 "C:\Projects\SignalRSample\Views\ProgrammingLanguage\Index.cshtml"
WriteAttributeValue("", 1026, item.Id, 1026, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1034, ")", 1034, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Remove</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Projects\SignalRSample\Views\ProgrammingLanguage\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8565de5dcd3de5db82ac61f71e5874ed529078bc6583", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    function removeItem(itemId) {\r\n        var confirmation = confirm(\"Are you sure you want to remove the item?\");\r\n        if (confirmation) {\r\n            var params = { id: itemId };\r\n            $.ajax({\r\n                url: \"");
#nullable restore
#line 45 "C:\Projects\SignalRSample\Views\ProgrammingLanguage\Index.cshtml"
                 Write(Url.Action("Remove"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                method: ""post"",
                dataType: ""json"",
                data: params,
                success: function (response, status, jqXHR) {
                    if (response.success) {
                        alert(""Success"");
                    }
                }
            });
        }
    }
    var connection = new signalR.HubConnectionBuilder().withUrl(""/dashboardHub"").build();
    connection.start();
    connection.on(""GetProgrammingLanguages"", function (programmingLanguages) {
        var table = document.getElementById(""dashboard_table"");
        programmingLanguages.forEach(function (item, index, array) {
            let row = document.createElement(""tr"");
            row.id = ""row_""+item.id;
            let td = document.createElement(""td"");
            td.textContent = item.name;
            row.appendChild(td);
            let td2 = document.createElement(""td"");
            td2.textContent = item.description;
            row.appendChild(td2);
       ");
            WriteLiteral(@"     let td3 = document.createElement(""td"");
            let removeAction = document.createElement(""button"");
            removeAction.classList.add(""btn"");
            removeAction.classList.add(""btn-sm"");
            removeAction.classList.add(""btn-danger"");
            removeAction.textContent = ""Remove"";
            removeAction.onclick = function () { removeItem(item.id); };
            td3.appendChild(removeAction);
            row.appendChild(td3);
            table.appendChild(row);
        });
    });
    connection.on(""RemoveProgrammingLanguage"", function (programmingLanguageId) {
        var table = document.getElementById(""dashboard_table"");
        var row = document.getElementById(""row_"" + programmingLanguageId);
        if (row != undefined) {
            table.removeChild(row);
        }
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProgrammingLanguage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
