﻿using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Core.Utilities.Interceptors;
using Castle.DynamicProxy;

namespace Core.Aspect.Autofac.Caching
{
    
   public class CacheRemoveAspect: MethodInterception
    {
        private string _pattern;
        ICacheManager _cacheManager;
        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }
        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }

    }
}
