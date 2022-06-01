using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reo.RoutesCalculation.Constants;

namespace RiderSourceGenBug;

[Authorize(PermissionConstants.RouteRead)]
public class TestController : ControllerBase
{
    // GET
    public int Index()
    {
        return 1;
    }
}