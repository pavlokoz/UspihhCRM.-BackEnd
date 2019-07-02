using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Uspihh.DB.Setup;
using Uspihh.Infrastructure.Constants;

[assembly: OwinStartup(typeof(Uspihh.Startup))]

namespace Uspihh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.Setup(BaseConstants.ConnectionStrings.DatabaseConnectionString);
            ConfigureAuth(app);
        }
    }
}
