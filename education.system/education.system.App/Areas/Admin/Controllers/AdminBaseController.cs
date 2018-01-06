namespace education.system.App.Areas.Admin.Controllers
{
    using Infrastructure;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = Roles.Administrator)]
    public abstract class AdminBaseController : Controller
    {
    }
}
