using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core;

namespace Umbraco.Cms.Api.Management.Controllers.Security;

/// <summary>
/// Provides default actions for managing back office security within the Umbraco CMS.
/// </summary>
public class BackOfficeDefaultController : Controller
{
    /// <summary>
    /// Retrieves the default back office SPA shell view.
    /// </summary>
    [HttpGet]
    [AllowAnonymous]
    [EndpointSummary("Gets the back office default configuration.")]
    [EndpointDescription("Gets the default configuration and settings for the Umbraco back office.")]
    public IActionResult Index()
    {
        return DefaultView();
    }

    /// <summary>
    ///     Returns the default view for the BackOffice
    /// </summary>
    /// <returns>The default view currently /umbraco/UmbracoBackOffice/Default.cshtml</returns>
    public ViewResult DefaultView()
    {
        var viewPath = Path.Combine(Constants.SystemDirectories.Umbraco, Constants.Web.Mvc.BackOfficeArea, nameof(Index) + ".cshtml")
            .Replace("\\", "/"); // convert to forward slashes since it's a virtual path
        return View(viewPath);
    }
}
