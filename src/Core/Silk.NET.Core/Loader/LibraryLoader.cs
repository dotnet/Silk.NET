// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Reflection;
using AdvancedDLSupport;
using AdvancedDLSupport.Loaders;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Native;

namespace Silk.NET.Core.Loader
{
    public static class LibraryLoader
    {
        public const ImplementationOptions Options = ImplementationOptions.UseIndirectCalls |
                                                     ImplementationOptions.SuppressSecurity |
                                                     ImplementationOptions.UseLazyBinding |
                                                     ImplementationOptions.EnableOptimizations;
        
        private static Dictionary<Type, NativeLibraryBuilder> _builders = new Dictionary<Type, NativeLibraryBuilder>();

        public static T1 Load<T1>(SearchPathContainer nameContainer) where T1 : NativeAPI
        {
            CreateBuilder<T1>();
            return _builders[typeof(T1)].ActivateClass<T1>(nameContainer.GetLibraryName());
        }

        public static T1 Load<T1, T2>(T2 baseApi, SearchPathContainer paths = null)
            where T1 : NativeExtension<T2> where T2 : NativeAPI
        {
            CreateBuilder<T2>();
            return baseApi.IsExtensionPresent(GetExtensionAttribute(typeof(T1)).Name)
                ? _builders[typeof(T2)].ActivateClass<T1>((paths ?? baseApi.SearchPaths).GetLibraryName())
                : null;
        }

        public static void CreateBuilder<T1>(ISymbolLoader loader = null) where T1:NativeAPI
        {
            if (!_builders.ContainsKey(typeof(T1)) || loader != null)
            {
                _builders[typeof(T1)] = new NativeLibraryBuilder(Options)
                    .WithSymbolLoader(x => loader ?? x);
            }
        }

        private static ExtensionAttribute GetExtensionAttribute(MemberInfo type)
        {
            return type.GetCustomAttribute<ExtensionAttribute>();
        }
    }
}
