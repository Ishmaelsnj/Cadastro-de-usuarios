#pragma checksum "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\Contatos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "348909bc052a5e9e86e54ba4f4b91d0622818d24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contatos_Index), @"mvc.1.0.view", @"/Views/Contatos/Index.cshtml")]
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
#line 1 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\_ViewImports.cshtml"
using ProjetoCadastro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\_ViewImports.cshtml"
using ProjetoCadastro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"348909bc052a5e9e86e54ba4f4b91d0622818d24", @"/Views/Contatos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5161eae33d0f5eafc5299204ee83b67de5076a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Contatos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoCadastro.Models.ContatoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteConfirmed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Lista de Contatos</h1>
<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Nome</th>
            <th>CPF</th>
            <th>Telefone</th>
            <th>Tipo</th>
            <th>Ações</th> <!-- Coluna para as ações (editar/excluir) -->
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\Contatos\Index.cshtml"
         foreach (var contato in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 19 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\Contatos\Index.cshtml"
   Write(contato.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 20 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\Contatos\Index.cshtml"
   Write(contato.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 21 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\Contatos\Index.cshtml"
   Write(contato.CPF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 22 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\Contatos\Index.cshtml"
   Write(contato.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 23 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\Contatos\Index.cshtml"
   Write(contato.TelefoneTipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n        <!-- Botão de Editar -->\n        <a");
            BeginWriteAttribute("href", " href=\"", 626, "\"", 689, 1);
#nullable restore
#line 26 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\Contatos\Index.cshtml"
WriteAttributeValue("", 633, Url.Action("Edit", "Contatos", new { id = contato.Id }), 633, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Editar</a>\n\n        <!-- Botão de Excluir com confirmação -->\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348909bc052a5e9e86e54ba4f4b91d0622818d246718", async() => {
                WriteLiteral("\n            <button type=\"submit\" class=\"btn btn-danger\" onclick=\"return confirm(\'Tem certeza que deseja excluir este contato?\')\">Excluir</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\Contatos\Index.cshtml"
                                             WriteLiteral(contato.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n    </td>\n</tr>");
#nullable restore
#line 35 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\Contatos\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n<div class=\"text-left\">\n    <a");
            BeginWriteAttribute("href", " href=\"", 1121, "\"", 1161, 1);
#nullable restore
#line 40 "C:\Users\ishma\Desktop\ProjetoCadastro\ProjetoCadastro\ProjetoCadastro\Views\Contatos\Index.cshtml"
WriteAttributeValue("", 1128, Url.Action("Create", "Contatos"), 1128, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Cadastrar Contato</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoCadastro.Models.ContatoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
