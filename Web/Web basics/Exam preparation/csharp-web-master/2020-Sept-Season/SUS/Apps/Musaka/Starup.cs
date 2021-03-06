﻿namespace Musaka
{
    using Microsoft.EntityFrameworkCore;
    using Musaka.Data;
    using Musaka.Services;
    using SUS.HTTP;
    using SUS.MvcFramework;
    using System.Collections.Generic;
    public class Startup : IMvcApplication
    {
        public void Configure(List<Route> routeTable)
        {
            new ApplicationDbContext().Database.Migrate();
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.Add<IUsersService, UsersService>();
        }
    }
}
