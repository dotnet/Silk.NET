// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Loader
{
    /// <summary>
    /// The symbol-loader for OpenGL
    /// </summary>
    public abstract class GLSymbolLoader : Ultz.SuperInvoke.Loader.LibraryLoader
    {
        // pass-through class for dependency injection
        /// <summary>
        /// The platform-specific OpenGL loader.
        /// </summary>
        protected Ultz.SuperInvoke.Loader.LibraryLoader UnderlyingLoader { get; } = GetPlatformDefaultLoader();

        /// <summary>
        /// Load a native library.
        /// </summary>
        /// <param name="name">The name of the library to load.</param>
        /// <returns>Pointer to the library.</returns>
        protected override IntPtr CoreLoadNativeLibrary(string name)
        {
            UnderlyingLoader.TryLoadNativeLibrary(name, out var ret);
            return ret;
        }

        /// <summary>
        /// Free a native library.
        /// </summary>
        /// <param name="handle">The library to free.</param>
        protected override void CoreFreeNativeLibrary(IntPtr handle) => UnderlyingLoader.FreeNativeLibrary(handle);
    }
}
