# IdentityManagement

First off, thanks to [ByteBlocks](http://www.byteblocks.com/) for creating the [nuget package](https://www.nuget.org/packages/IdentityManagement/): Asp.Net Identity Manager Dashboard 1.0.1, I've forked the Nuget package source code from there.  My goal is to make this Identity Management Dashboard portable so that it can easily plug into an existing web application.

### Getting Started

Install the nuget package and it will create an Area named IdentityManagement and add these three example user and role configurations to the Models folder:

ApplicationUserManager.cs

ApplicationRoleManager.cs

IdentitySettings.cs

In your App_Start\Startup.Auth.cs file you need to ensure you create the user and role context:
```javascript
app.CreatePerOwinContext(ApplicationDbContext.Create);
app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
app.CreatePerOwinContext<ApplicationRoleManager>(ApplicationRoleManager.Create);
```

You will also need to update your App_Start\IdentityConfig.cs and Controllers\AccountController.cs to use the new ApplicationUserManager instead of the default ApplicationUser

You're all good to go.  Check the Areas/IdentityManager section of your MVC site to extend and customize the various management screens.

### Gotchas

If you try and access the area in a browser and receive a 404 not found error, add AreaRegistration.RegisterAllAreas(); to your App_Start/RouteConfig.cs

```javascript
public class RouteConfig
{
    public static void RegisterRoutes(RouteCollection routes)
    {
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
        AreaRegistration.RegisterAllAreas();

        routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        );
    }
}
```

### Building the Nuget packaage from source
The Nuget package project's contents folder is populating using grunt and transforming all the classes to .cs.pp files, so that they can easily be used in different projects.  There is a gruntfile.js file in the root of the IdentityManagement.Web project and running the default grunt task, the files from the IdentityManagement.Web/Areas/IdentityManagement and the 3 Model files will be copied and trasnformed to the Nuget package.