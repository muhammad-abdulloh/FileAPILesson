namespace FileAPILesson.Services
{
    public interface IProfileService
    {
        public ValueTask<string> CreateAvatarAsync(IFormFile formFile);
    }
}
