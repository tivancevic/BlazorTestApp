#pragma checksum "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4b3a2721adfd34cb476073fb0337f8f0fd5421c"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_MySQL_testing.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Blazor_MySQL_testing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\_Imports.razor"
using Blazor_MySQL_testing.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
using Blazor_MySQL_testing.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/photos")]
    public partial class Photos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Photos</h1>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n\t");
            __builder.AddMarkupContent(3, "<div class=\"form-row\">\r\n\t\t<p>\r\n\r\n\t\t</p>\r\n\t</div>\r\n\t");
            __builder.AddMarkupContent(4, "<h3>Insert new photo</h3>\r\n\t");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-row");
            __builder.AddMarkupContent(7, "\r\n\t\t");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col");
            __builder.AddMarkupContent(10, "\r\n\t\t\t");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "placeholder", "Photo url");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
                                                                       url_input

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => url_input = __value, url_input));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\t\t");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col");
            __builder.AddMarkupContent(20, "\r\n\t\t\t");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "placeholder", "Person ID for photo");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
                                                                                 person_id_input

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => person_id_input = __value, person_id_input));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\t\t");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col");
            __builder.AddMarkupContent(30, "\r\n\t\t\t");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "submit");
            __builder.AddAttribute(33, "class", "btn btn-primary");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
                                                                    InsertData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Insert");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\t");
            __builder.AddMarkupContent(39, "<div class=\"form-row\">\r\n\t\t<p>\r\n\r\n\t\t</p>\r\n\t</div>\r\n\r\n\t\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n");
#nullable restore
#line 39 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
 if (photos == null) { 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "\t");
            __builder.AddMarkupContent(42, "<p>Loading...</p>\r\n");
#nullable restore
#line 41 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "\t");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "container");
            __builder.AddMarkupContent(46, "\r\n\t\t");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row row-cols-1 row-cols-md-4");
            __builder.AddMarkupContent(49, "\r\n\t\r\n");
#nullable restore
#line 47 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
             foreach (var photo in photos)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "\t\t\t\t");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col mb-4");
            __builder.AddMarkupContent(53, "\r\n\t\t\t\t\t");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "card");
            __builder.AddMarkupContent(56, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(57, "img");
            __builder.AddAttribute(58, "class", "card-img-top");
            __builder.AddAttribute(59, "src", 
#nullable restore
#line 51 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
                                                        photo.url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(60, "alt", "Image" + " ID:" + " " + (
#nullable restore
#line 51 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
                                                                                   photo.id

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "card-body");
            __builder.AddMarkupContent(64, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(65, "h5");
            __builder.AddAttribute(66, "class", "card-title");
            __builder.AddContent(67, "Id: ");
            __builder.AddContent(68, 
#nullable restore
#line 53 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
                                                        photo.id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, " by person Id: ");
            __builder.AddContent(70, 
#nullable restore
#line 53 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
                                                                                photo.person_id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(72, "p");
            __builder.AddAttribute(73, "class", "card-text");
            __builder.AddContent(74, "This is a photo with the Id of ");
            __builder.AddContent(75, 
#nullable restore
#line 54 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
                                                                                 photo.id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(76, " made by person with Id ");
            __builder.AddContent(77, 
#nullable restore
#line 54 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
                                                                                                                  photo.person_id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\t\t\t\t\t\t\t");
            __builder.AddMarkupContent(79, "<a href=\"/people\" class=\"btn btn-primary\">View people</a>\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "type", "submit");
            __builder.AddAttribute(82, "class", "btn btn-danger");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
                                                                                   (() => DeleteData(photo.id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 60 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
	
			}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(89, "\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 64 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "D:\_Teo_\C#\Blazor_MySQL_testing\Blazor_MySQL_testing\Pages\Photos.razor"
       
	List<PhotoModel> photos;

	string url_input;
	string person_id_input;

	private async Task InsertData()
	{
		string sql = "INSERT INTO photos (url, person_id) VALUES(@url, @person_id)";

		await _data.SaveData(sql, new { url = url_input, person_id = person_id_input }, _config.GetConnectionString("default"));

		await OnInitializedAsync();
	}

	private async Task InsertData2()
	{
		string sql = "INSERT INTO photos (url, person_id) VALUES(@url, @person_id)";

		await _data.SaveData(sql, new { url = url_input, person_id = person_id_input }, _config.GetConnectionString("default"));

		await OnInitializedAsync();
	}

	private async Task UpdateData()
	{
		//string sql = "UPDATE people SET first_name = 'Jovan' WHERE last_name = 'Bob'";
		string sql = "UPDATE people SET first_name = @first_name WHERE last_name = @last_name";

		await _data.SaveData(sql, new { first_name = "Jovan", last_name = "Bob" }, _config.GetConnectionString("default"));

		await OnInitializedAsync();
	}

	private async Task DeleteData(int my_id)
	{
		//ovdije stavljam id="@id" i to mi znaci da je id iz tablice jednak @id varijabli u ovoj liniji ispod toga
		//u kojoj pozivam SaveData
		string sql = "DELETE FROM photos WHERE id = @id";

		//ovdije mi ovaj "id" predstavlja @id iz linije gore, a my_id mi je vrijednost koju sam dao u funkciju
		await _data.SaveData(sql, new { id = my_id }, _config.GetConnectionString("default"));

		await OnInitializedAsync();
	}

	protected override async Task OnInitializedAsync()
	{
		string sql = "select * from photos";
		photos = await _data.LoadData<PhotoModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));

	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591