using AglixFrontend.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace AglixFrontend.Pages
{
    public partial class AgileOverview : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        private List<AgileImplementation> agileImplementations;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                agileImplementations = await Http.GetFromJsonAsync<List<AgileImplementation>>("https://localhost:7060/api/AgileImplementation");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data: {ex.Message}");
            }
        }
    }
}
