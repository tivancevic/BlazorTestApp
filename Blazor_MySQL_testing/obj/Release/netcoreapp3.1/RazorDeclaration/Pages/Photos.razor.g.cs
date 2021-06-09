// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_MySQL_testing.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\_Imports.razor"
using Blazor_MySQL_testing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\_Imports.razor"
using Blazor_MySQL_testing.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\Pages\Photos.razor"
using Blazor_MySQL_testing.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\Pages\Photos.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\Pages\Photos.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\Pages\Photos.razor"
using Blazor_MySQL_testing.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/photos")]
    public partial class Photos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\teo\Source\Repos\BlazorTestApp\Blazor_MySQL_testing\Pages\Photos.razor"
       
	List<PhotoModel> photos;
	List<PersonModel> people;

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
	//		string sql = "select * from photos";
//		photos = await _data.LoadData<PhotoModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));

//		sql = "select * from people";
//		people = await _data.LoadData<PersonModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));

		string sql = "select people.first_name, people.last_name, photos.id photo_id, photos.url from people join photos on people.id = photos.person_id";
		var peoplePhos = await _data.LoadData<PeoplePhotos, dynamic>(sql, new {}, _config.GetConnectionString("default"));


	//		var myresult = await _data.LoadData(_config.GetConnectionString("default")con.Query<PeoplePhotos>("SELECT * FROM photos").ToList()));
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591