#pragma checksum "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\Components\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b88a59fc49cb293c80889f657ab0dddb160111c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemoApp.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\_Imports.razor"
using BlazorDemoApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\_Imports.razor"
using BlazorDemoApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\Components\AddEmployee.razor"
using BlazorDemoApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddEmployee</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "<div class=\"card-header\">\r\n        Add an Employee\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\Components\AddEmployee.razor"
                          employeeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label for=\"empnoInput\">EmpNo</label>\r\n                ");
                __Blazor.BlazorDemoApp.Client.Components.AddEmployee.TypeInference.CreateInputNumber_0(__builder2, 16, 17, "form-control", 18, "empnoInput", 19, 
#nullable restore
#line 16 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\Components\AddEmployee.razor"
                                                                               employeeModel.EmpNo

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employeeModel.EmpNo = __value, employeeModel.EmpNo)), 21, () => employeeModel.EmpNo);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "<label for=\"empnameInput\">EmpName</label>\r\n                ");
                __Blazor.BlazorDemoApp.Client.Components.AddEmployee.TypeInference.CreateInputNumber_1(__builder2, 26, 27, "form-control", 28, "empnameInput", 29, 
#nullable restore
#line 21 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\Components\AddEmployee.razor"
                                                                                 employeeModel.EmpName

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employeeModel.EmpName = __value, employeeModel.EmpName)), 31, () => employeeModel.EmpName);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label for=\"dateInput\">HireDate</label>\r\n                ");
                __Blazor.BlazorDemoApp.Client.Components.AddEmployee.TypeInference.CreateInputNumber_2(__builder2, 36, 37, "form-control", 38, "dateInput", 39, 
#nullable restore
#line 26 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\Components\AddEmployee.razor"
                                                                              employeeModel.HireDate

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employeeModel.HireDate = __value, employeeModel.HireDate)), 41, () => employeeModel.HireDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label for=\"salaryInput\">Salary</label>\r\n                ");
                __Blazor.BlazorDemoApp.Client.Components.AddEmployee.TypeInference.CreateInputNumber_3(__builder2, 46, 47, "form-control", 48, "salaryInput", 49, 
#nullable restore
#line 31 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\Components\AddEmployee.razor"
                                                                                employeeModel.Salary

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => employeeModel.Salary = __value, employeeModel.Salary)), 51, () => employeeModel.Salary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n            ");
                __builder2.AddMarkupContent(53, "<div><button type=\"submit\" class=\"btn btn-primary\">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Pratik\Documents\MASTEK\Pratik14851_.NETLayer\BlazorDemoApp\BlazorDemoApp\Client\Components\AddEmployee.razor"
       
    private EmployeeModel employeeModel = new EmployeeModel() { HireDate = DateTime.Today };

    public async Task HandleValidSubmit()
    {
        await Http.PostAsJsonAsync<EmployeeModel>("api/Employee", employeeModel);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.BlazorDemoApp.Client.Components.AddEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
