#pragma checksum "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51014dae50a4c3075b593e176414a68e0e8573d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedores__ListaFornecedores), @"mvc.1.0.view", @"/Views/Fornecedores/_ListaFornecedores.cshtml")]
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
#line 1 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
using DevIO.App.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51014dae50a4c3075b593e176414a68e0e8573d6", @"/Views/Fornecedores/_ListaFornecedores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb39f9860e515af571e7ece4ad1b1307c76ba95b", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedores__ListaFornecedores : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevIO.App.ViewModels.FornecedorViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-group btn-light shadow p-3 bg-white rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disable-by-claim-name", "Fornecedor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disable-by-claim-value", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disable-by-claim-value", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::DevIO.App.Extensions.DesabilitaLinkByClaimTagHelper __DevIO_App_Extensions_DesabilitaLinkByClaimTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table shadow p-3 rounded\">\r\n    <thead class=\"table-light bg-light rounded\" style=\"color:#3f3593\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 8 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                CNPJ/CPF\r\n            </th>\r\n            <th>\r\n                Status\r\n            </th>\r\n            <th>\r\n\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody class=\"bg-white\">\r\n");
#nullable restore
#line 22 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
               Write(this.FormataDocumento(item.TipoFornecedor, item.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 32 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
                     if (item.Ativo == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"shadow-sm\" style=\"background-color:#4f794e; text-align:center; border-radius:25px; color:aliceblue\">\r\n                            <small>ATIVO</small>\r\n                        </div>\r\n");
#nullable restore
#line 37 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"shadow-sm\" style=\"background-color:#b25454; text-align:center; border-radius:25px; color:aliceblue\">\r\n                            <small>INATIVO</small>\r\n                        </div>\r\n");
#nullable restore
#line 43 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td class=\"text-right\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51014dae50a4c3075b593e176414a68e0e8573d68735", async() => {
                WriteLiteral("<i class=\"fas fa-search text-info\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51014dae50a4c3075b593e176414a68e0e8573d611095", async() => {
                WriteLiteral("<i class=\"fas fa-pen text-warning\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __DevIO_App_Extensions_DesabilitaLinkByClaimTagHelper = CreateTagHelper<global::DevIO.App.Extensions.DesabilitaLinkByClaimTagHelper>();
            __tagHelperExecutionContext.Add(__DevIO_App_Extensions_DesabilitaLinkByClaimTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __DevIO_App_Extensions_DesabilitaLinkByClaimTagHelper.IdentityClaimName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __DevIO_App_Extensions_DesabilitaLinkByClaimTagHelper.IdentityClaimValue = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
                                                                                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51014dae50a4c3075b593e176414a68e0e8573d614197", async() => {
                WriteLiteral("<i class=\"fas fa-trash text-danger\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __DevIO_App_Extensions_DesabilitaLinkByClaimTagHelper = CreateTagHelper<global::DevIO.App.Extensions.DesabilitaLinkByClaimTagHelper>();
            __tagHelperExecutionContext.Add(__DevIO_App_Extensions_DesabilitaLinkByClaimTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __DevIO_App_Extensions_DesabilitaLinkByClaimTagHelper.IdentityClaimName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __DevIO_App_Extensions_DesabilitaLinkByClaimTagHelper.IdentityClaimValue = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
                                                                                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 51 "C:\Dev\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_ListaFornecedores.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevIO.App.ViewModels.FornecedorViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
