#pragma checksum "D:\Net-core\TodoListEvaluacion\TodoListEvaluacion\Views\Tarea\ListadoTareas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70b7603e251cbe4481012bdeda33f116f7cbd8ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarea_ListadoTareas), @"mvc.1.0.view", @"/Views/Tarea/ListadoTareas.cshtml")]
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
#line 1 "D:\Net-core\TodoListEvaluacion\TodoListEvaluacion\Views\_ViewImports.cshtml"
using TodoListEvaluacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Net-core\TodoListEvaluacion\TodoListEvaluacion\Views\_ViewImports.cshtml"
using TodoListEvaluacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b7603e251cbe4481012bdeda33f116f7cbd8ed", @"/Views/Tarea/ListadoTareas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a7c1258f72ad9d62396b62ad4a20a9e5ab6cd27", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarea_ListadoTareas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Net-core\TodoListEvaluacion\TodoListEvaluacion\Views\Tarea\ListadoTareas.cshtml"
  
    ViewData["Title"] = "Listado de Tareas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listado de Tareas</h1>\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th scope=\"col\">Nombre</th>\r\n            <th scope=\"col\">Detalle</th>\r\n            <th scope=\"col\">Prioridad</th>\r\n            <th scope=\"col\">Fecha de registro</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 21 "D:\Net-core\TodoListEvaluacion\TodoListEvaluacion\Views\Tarea\ListadoTareas.cshtml"
         foreach (Tarea t in ViewBag.tareas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 25 "D:\Net-core\TodoListEvaluacion\TodoListEvaluacion\Views\Tarea\ListadoTareas.cshtml"
           Write(t.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\Net-core\TodoListEvaluacion\TodoListEvaluacion\Views\Tarea\ListadoTareas.cshtml"
           Write(t.Detalle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\Net-core\TodoListEvaluacion\TodoListEvaluacion\Views\Tarea\ListadoTareas.cshtml"
           Write(t.Prioridad.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\Net-core\TodoListEvaluacion\TodoListEvaluacion\Views\Tarea\ListadoTareas.cshtml"
           Write(t.fecharegistro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 31 "D:\Net-core\TodoListEvaluacion\TodoListEvaluacion\Views\Tarea\ListadoTareas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n<ul>\r\n   \r\n\r\n</ul>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
