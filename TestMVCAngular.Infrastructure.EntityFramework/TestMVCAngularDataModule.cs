﻿using System;
using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.Startup;
using Abp.Startup.Infrastructure.EntityFramework;

namespace TestMVCAngular
{
    public class TestMVCAngularDataModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(AbpEntityFrameworkModule),
                       typeof(TestMVCAngularCoreModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
