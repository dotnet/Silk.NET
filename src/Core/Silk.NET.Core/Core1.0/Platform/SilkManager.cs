// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

namespace Silk.NET.Core.Platform
{
    /// <summary>
    /// Contains properties and methods for resolving platform locals.
    /// </summary>
    [Obsolete("SilkManager is deprecated and will be removed in 2.0.")]
    public static class SilkManager
    {
        private static readonly Dictionary<Type, object> platformObjects = new Dictionary<Type, object>();
        public static void Register<T>(T instance)
        {
            platformObjects[typeof(T)] = instance;
        }

        public static T Get<T>()
        {
            return (T)platformObjects[typeof(T)];
        }

        public static T GetOrDefault<T>()
        {
            return platformObjects.ContainsKey(typeof(T)) ? Get<T>() : default;
        }

        public static void Unregister<T>()
        {
            platformObjects.Remove(typeof(T));
        }

        public static bool IsRegistered<T>()
        {
            return platformObjects.ContainsKey(typeof(T));
        }

        // Temp methods for supporting the new context-based loading systems
        public static GLSymbolLoader Get(IGLContext ctx) => new ContextLoader(ctx);
        public static Ultz.SuperInvoke.Loader.LibraryLoader Get(INativeContext ctx) => new ContextLoader(ctx);
    }
}