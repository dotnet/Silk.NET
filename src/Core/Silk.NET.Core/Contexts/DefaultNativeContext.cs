// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Loader;

namespace Silk.NET.Core.Contexts
{
    /// <summary>
    /// A native context that uses an <see cref="UnmanagedLibrary" /> for native library/function loading.
    /// </summary>
    public class DefaultNativeContext : INativeContext
    {
        /// <summary>
        /// Creates a new native context for the given underlying library.
        /// </summary>
        /// <param name="library">The library to use.</param>
        public DefaultNativeContext(UnmanagedLibrary library)
        {
            Library = library;
        }

        /// <summary>
        /// Loads a native library using the given name and creates a new native context from it.
        /// </summary>
        /// <param name="name">The name of the underlying library.</param>
        public DefaultNativeContext(string name) : this(new UnmanagedLibrary(name))
        {
        }

        /// <summary>
        /// Loads a native library using the given possible names and creates a new native context from it.
        /// </summary>
        /// <param name="names">The possible names of the underlying library.</param>
        public DefaultNativeContext(string[] names) : this(new UnmanagedLibrary(names))
        {
        }

        /// <summary>
        /// Loads a native library using the given name and a custom loader, then creates a new native context from it.
        /// </summary>
        /// <param name="name">The name of the underlying library.</param>
        /// <param name="loader">The custom loader to use.</param>
        public DefaultNativeContext(string name, LibraryLoader loader) : this(new UnmanagedLibrary(name, loader))
        {
        }

        /// <summary>
        /// Loads a native library using the given possible names and a custom loader, then creates a new native
        /// context from it.
        /// </summary>
        /// <param name="names">The possible names of the underlying library.</param>
        /// <param name="loader">The custom loader to use.</param>
        public DefaultNativeContext(string[] names, LibraryLoader loader) : this(new UnmanagedLibrary(names, loader))
        {
        }

        /// <summary>
        /// Loads a native library using the given name, custom loader, and path resolver; then creates a new native
        /// context from it.
        /// </summary>
        /// <param name="name">The name of the underlying library.</param>
        /// <param name="loader">The custom loader to use.</param>
        /// <param name="pathResolver">The path resolver to use.</param>
        public DefaultNativeContext(string name, LibraryLoader loader, PathResolver pathResolver) : this
            (new UnmanagedLibrary(name, loader, pathResolver))
        {
        }

        /// <summary>
        /// Loads a native library using the given possible names, custom loader, and path resolver; then creates a
        /// new native context from it.
        /// </summary>
        /// <param name="names">The possible names of the underlying library.</param>
        /// <param name="loader">The custom loader to use.</param>
        /// <param name="pathResolver">The path resolver to use.</param>
        public DefaultNativeContext(string[] names, LibraryLoader loader, PathResolver pathResolver) : this
            (new UnmanagedLibrary(names, loader, pathResolver))
        {
        }

        public UnmanagedLibrary Library { get; }

        /// <inheritdoc />
        public IntPtr GetProcAddress(string proc, int? slot = default)
        {
            return Library.LoadFunction(proc);
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Library?.Dispose();
        }
    }
}
