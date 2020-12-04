// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Reflection;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;
namespace Silk.NET.Core.Loader
{
    /// <summary>
    /// The library loader.
    /// </summary>
    public static class LibraryLoader
    {
        // This is only needed in CreateBuilder, delete it once CreateBuilder is removed.
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private static Dictionary<Type, Ultz.SuperInvoke.Loader.LibraryLoader> _loaders =
            new Dictionary<Type, Ultz.SuperInvoke.Loader.LibraryLoader>();

        [Obsolete("This method is no longer used and is pending removal (likely in 1.X or 2.0)")]
#pragma warning disable 1591
        // Documentation isn't needed because this is obsolete.
        public static void CreateBuilder<T>
#pragma warning restore 1591
            (Ultz.SuperInvoke.Loader.LibraryLoader loader) where T : NativeApiContainer => _loaders[typeof(T)] = loader;

        public static T1 Load<T1>
            (SearchPathContainer nameContainer) where T1 : NativeAPI => LibraryActivator.CreateInstance<T1>
            (nameContainer.GetLibraryName());

        public static T1 Load<T1>
            (SearchPathContainer nameContainer, Ultz.SuperInvoke.Loader.LibraryLoader loader) where T1 : NativeAPI =>
            LibraryActivator.CreateInstance<T1>(nameContainer.GetLibraryName(), loader);

        public static T1 Load<T1, T2>(T2 baseApi)
            where T1 : NativeExtension<T2> where T2 : NativeAPI
        {
            return baseApi.IsExtensionPresent(GetExtensionAttribute(typeof(T1)).Name)
                ? LibraryActivator.CreateInstance<T1>(baseApi.Library)
                : null;
        }

        private static ExtensionAttribute GetExtensionAttribute(MemberInfo type)
        {
            return type.GetCustomAttribute<ExtensionAttribute>();
        }
    }
}
