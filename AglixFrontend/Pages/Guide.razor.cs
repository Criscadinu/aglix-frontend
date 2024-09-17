using AglixFrontend.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace AglixFrontend.Pages
{
    public partial class Guide : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        private List<Agile> agileTopics;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                agileTopics = await Http.GetFromJsonAsync<List<Agile>>("https://localhost:7060/api/agile");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data: {ex.Message}");
            }
        }
    }
}
