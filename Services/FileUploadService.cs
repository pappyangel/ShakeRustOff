using Microsoft.AspNetCore.Components.Forms;

namespace ShakeRustOff.Services;

public interface IFileUploadService
{
    Task<bool> UploadFileAsync(IBrowserFile file);
}

public class FileUploadService : IFileUploadService
{
    private readonly ILogger<FileUploadService> _logger;

    public FileUploadService(ILogger<FileUploadService> logger)
    {
        _logger = logger;
    }

    public async Task<bool> UploadFileAsync(IBrowserFile file)
    {
        // Placeholder: Log the file details and simulate upload
        _logger.LogInformation("Uploading file: {FileName}, Size: {Size} bytes", file.Name, file.Size);

        // Simulate async operation
        await Task.Delay(100);

        // For now, always return true (success)
        return true;
    }
}