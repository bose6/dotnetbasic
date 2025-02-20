using lotus.Controllers.Userregistration.Dto;
using lotus.Controllers.Userregistration.Services.InterFace;
using Microsoft.AspNetCore.Mvc;

namespace lotus.Controllers.Userregistration.Services;

public class UserServices: IUserServices
{
    public IActionResult Userregistrationservices(UserRegistrationDto userRegistration)
    {
        throw new NotImplementedException();
    }
}