using Microsoft.AspNetCore.Components;

namespace AglixFrontend.Pages
{
    public partial class TeamTopologiesOverview
    {
        [Inject]
        public NavigationManager Navigation { get; set; }

        private void GoBack()
        {
            Navigation.NavigateTo("/guide");
        }
    }
}
