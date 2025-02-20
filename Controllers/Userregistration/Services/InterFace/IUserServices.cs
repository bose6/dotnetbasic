using lotus.Controllers.Userregistration.Dto;
using Microsoft.AspNetCore.Mvc;

namespace lotus.Controllers.Userregistration.Services.InterFace;

public interface IUserServices
{
    IActionResult Userregistrationservices(UserRegistrationDto userRegistration);
    
}