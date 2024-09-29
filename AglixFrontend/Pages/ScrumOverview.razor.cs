using Microsoft.AspNetCore.Components;

namespace AglixFrontend.Pages
{
    public partial class ScrumOverview
    {
        [Inject]
        public NavigationManager Navigation { get; set; }

        private void GoBack()
        {
            Navigation.NavigateTo("/guide");
        }
    }
}
