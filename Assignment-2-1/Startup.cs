﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_2_1.Startup))]
namespace Assignment_2_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
