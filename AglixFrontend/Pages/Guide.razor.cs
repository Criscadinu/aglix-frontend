using AglixFrontend.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace AglixFrontend.Pages
{
    public partial class Guide
    {
        [Inject]
        public required HttpClient Http { get; set; }

        [Inject]
        public required NavigationManager Navigation { get; set; }

        private List<Agile>? agileTopics;

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

        private void NavigateToOverview(string agileName)
        {
            switch (agileName)
            {
                case "Agile":
                    Navigation.NavigateTo("/agile-overview");
                    break;
                case "Team Topologies":
                    Navigation.NavigateTo("/team-topologies-overview");
                    break;
                case "DevOps":
                    Navigation.NavigateTo("/devops-overview");
                    break;
                default:
                    Console.WriteLine("Unknown topic");
                    break;
            }
        }
    }
}
