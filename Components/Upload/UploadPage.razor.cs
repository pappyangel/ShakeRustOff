using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using ShakeRustOff.Services;

namespace ShakeRustOff.Components.Upload;

public partial class UploadPage
{
    [Inject]
    private IFileUploadService FileUploadService { get; set; } = default!;

    [Inject]
    private IJSRuntime JS { get; set; } = default!;

    private IBrowserFile? selectedFile;
    public string? SelectedFileName { get; private set; }
    public string? ImagePreviewUrl { get; private set; }
    public bool CanUpload { get; private set; }
    public string? UploadMessage { get; private set; }

    private async Task OnFileSelected(InputFileChangeEventArgs e)
    {
        selectedFile = e.File;
        SelectedFileName = selectedFile?.Name;
        CanUpload = selectedFile != null;

        if (selectedFile != null && selectedFile.ContentType.StartsWith("image/"))
        {
            using var stream = selectedFile.OpenReadStream(maxAllowedSize: 10 * 1024 * 1024); // 10MB limit
            using var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream);
            var bytes = memoryStream.ToArray();
            ImagePreviewUrl = $"data:{selectedFile.ContentType};base64,{Convert.ToBase64String(bytes)}";
        }
        else
        {
            ImagePreviewUrl = null;
        }

        StateHasChanged();
    }

    private async Task OnUpload()
    {
        await JS.InvokeVoidAsync("bootstrapInterop.showModal", "uploadModal");
    }

    private async Task OnConfirmUpload()
    {
        UploadMessage = "Nice try! The upload API hasn’t been invented yet — but your image looks great.";
        // Modal closes via data-bs-dismiss
    }
}