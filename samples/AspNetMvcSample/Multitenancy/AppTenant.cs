﻿namespace AspNetMvcSample.Multitenancy
{
    public class AppTenant
    {
        public string Name { get; set; }
        public string[] Hostnames { get; set; }
    }
}
