using FileAPILesson.Data;
using FileAPILesson.Entities;
using FileAPILesson.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileAPILesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly ProfileDbContext _profileDbContext;
        private readonly IProfileService _profileService;

        public ProfileController(ProfileDbContext profileDbContext, IProfileService profileService)
        {
            _profileDbContext = profileDbContext;
            _profileService = profileService;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateProfile([FromForm] ProfileTeacher profileTeacher)
        {

            ProfileTeacher teacher = new ProfileTeacher()
            {
                Name = profileTeacher.Name,
                ImageUrl = await _profileService.CreateAvatarAsync(profileTeacher.Image)
            };

            await _profileDbContext.AddAsync(teacher);

            await _profileDbContext.SaveChangesAsync();

            return Ok(teacher);
        }

    }
}
