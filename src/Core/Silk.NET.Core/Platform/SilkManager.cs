// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.Core.Platform
{
    /// <summary>
    /// Contains properties and methods for resolving platform locals.
    /// </summary>
    public static class SilkManager
    {
        private static readonly Dictionary<Type, object> PlatformObjects = new Dictionary<Type, object>();
        
        /// <summary>
        /// Register a new platform object.
        /// </summary>
        /// <param name="instance">An instance of the platform object.</param>
        /// <typeparam name="T">The type of the platform object.</typeparam>
        public static void Register<T>(T instance)
        {
            PlatformObjects[typeof(T)] = instance;
        }
        
        /// <summary>
        /// Get the instance of a platform object.
        /// </summary>
        /// <typeparam name="T">The type of the platform object.</typeparam>
        /// <returns>The platform object.</returns>
        public static T Get<T>()
        {
            return (T)PlatformObjects[typeof(T)];
        }

        /// <summary>
        /// Get the instance of a platform object, or a default if it doesn't exist.
        /// </summary>
        /// <typeparam name="T">The type of the platform object.</typeparam>
        /// <returns>The platform object, or a default if it doesn't exist.</returns>
        public static T GetOrDefault<T>()
        {
            return PlatformObjects.ContainsKey(typeof(T)) ? Get<T>() : default;
        }

        /// <summary>
        /// Unregister this platform.
        /// </summary>
        /// <typeparam name="T">The platform type.</typeparam>
        public static void Unregister<T>()
        {
            PlatformObjects.Remove(typeof(T));
        }

        /// <summary>
        /// Check whether or not the platform is registered.
        /// </summary>
        /// <typeparam name="T">The platform type to check.</typeparam>
        /// <returns>Whether or not the platform is registered.</returns>
        public static bool IsRegistered<T>()
        {
            return PlatformObjects.ContainsKey(typeof(T));
        }
    }
}