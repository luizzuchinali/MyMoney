using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace MyMoney.Api.Controllers
{
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        protected Guid GetCurrentUserId() => Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
    }
}