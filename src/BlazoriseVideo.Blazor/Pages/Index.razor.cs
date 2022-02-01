using Blazorise;
using System.Threading.Tasks;

namespace BlazoriseVideo.Blazor.Pages;

public partial class Index
{
    private Modal PreviewStreamModal { get; set; }
    VideoDto video { get; set; } = new VideoDto();

    protected override void OnInitialized()
    {
        base.OnInitialized();

           }

    Task OnButtonClicked()
    {
        video.DashUrl = "https://media.axprod.net/TestVectors/v7-MultiDRM-SingleKey/Manifest_1080p.mpd";
        video.Token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ2ZXJzaW9uIjoxLCJjb21fa2V5X2lkIjoiYjMzNjRlYjUtNTFmNi00YWUzLThjOTgtMzNjZWQ1ZTMxYzc4IiwibWVzc2FnZSI6eyJ0eXBlIjoiZW50aXRsZW1lbnRfbWVzc2FnZSIsImZpcnN0X3BsYXlfZXhwaXJhdGlvbiI6NjAsInBsYXlyZWFkeSI6eyJyZWFsX3RpbWVfZXhwaXJhdGlvbiI6dHJ1ZX0sImtleXMiOlt7ImlkIjoiOWViNDA1MGQtZTQ0Yi00ODAyLTkzMmUtMjdkNzUwODNlMjY2IiwiZW5jcnlwdGVkX2tleSI6ImxLM09qSExZVzI0Y3Iya3RSNzRmbnc9PSJ9XX19.FAbIiPxX8BHi9RwfzD7Yn-wugU19ghrkBFKsaCPrZmU";

        return PreviewStreamModal.Show();
    }

    private Task HidePreviewModal()
    {
        return PreviewStreamModal.Hide();
    }

    private Task OnModalClosing(ModalClosingEventArgs e)
    {
        // Cancel closing if mouse-clicked outside of modal window
        if (e.CloseReason == CloseReason.FocusLostClosing)
        {
            e.Cancel = true;
        }

        // Handles the X and will only cancel if it is allowed
        if (e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = false;
        }

        return Task.CompletedTask;
    }

}
