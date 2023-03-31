// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Loader
{
    /// <summary>
    ///     Represents a native shared library opened by the operating system.
    ///     This type can be used to load native function pointers by name.
    /// </summary>
    public class UnmanagedLibrary : IDisposable
    {
        private static readonly LibraryLoader SPlatformDefaultLoader = LibraryLoader.GetPlatformDefaultLoader();
        private readonly LibraryLoader _loader;

        /// <summary>
        ///     Constructs a new NativeLibrary using the platform's default library loader.
        /// </summary>
        /// <param name="name">The name of the library to load.</param>
        public UnmanagedLibrary(string name) : this(name, SPlatformDefaultLoader, PathResolver.Default)
        {
        }

        /// <summary>
        ///     Constructs a new NativeLibrary using the platform's default library loader.
        /// </summary>
        /// <param name="names">An ordered list of names to attempt to load.</param>
        public UnmanagedLibrary(string[] names) : this(names, SPlatformDefaultLoader, PathResolver.Default)
        {
        }

        /// <summary>
        ///     Constructs a new NativeLibrary using the specified library loader.
        /// </summary>
        /// <param name="name">The name of the library to load.</param>
        /// <param name="loader">The loader used to open and close the library, and to load function pointers.</param>
        public UnmanagedLibrary(string name, LibraryLoader loader) : this(name, loader, PathResolver.Default)
        {
        }

        /// <summary>
        ///     Constructs a new NativeLibrary using the specified library loader.
        /// </summary>
        /// <param name="names">An ordered list of names to attempt to load.</param>
        /// <param name="loader">The loader used to open and close the library, and to load function pointers.</param>
        public UnmanagedLibrary(string[] names, LibraryLoader loader) : this(names, loader, PathResolver.Default)
        {
        }

        /// <summary>
        ///     Constructs a new UnmanagedLibrary with only a loader and handle specified
        /// </summary>
        private UnmanagedLibrary(LibraryLoader loader, nint handle)
        {
            _loader = loader;
            Handle = handle;
        }

        /// <summary>
        ///     Tries to create a new UnmanagedLibrary, safely failing
        /// </summary>
        public static bool TryCreate(string name, LibraryLoader loader, PathResolver pathResolver, out UnmanagedLibrary library)
        {
            if(!loader.TryLoadNativeLibrary(name, pathResolver, out nint handle))
            {
                library = null;
                return false;
            }

            library = new UnmanagedLibrary(loader, handle);
            return true;
        }

        /// <summary>
        ///     Constructs a new NativeLibrary using the specified library loader.
        /// </summary>
        /// <param name="name">The name of the library to load.</param>
        /// <param name="loader">The loader used to open and close the library, and to load function pointers.</param>
        /// <param name="pathResolver">The path resolver, used to identify possible load targets for the library.</param>
        public UnmanagedLibrary(string name, LibraryLoader loader, PathResolver pathResolver)
        {
            _loader = loader;
            Handle = _loader.LoadNativeLibrary(name, pathResolver);
        }

        /// <summary>
        ///     Constructs a new NativeLibrary using the specified library loader.
        /// </summary>
        /// <param name="names">An ordered list of names to attempt to load.</param>
        /// <param name="loader">The loader used to open and close the library, and to load function pointers.</param>
        /// <param name="pathResolver">The path resolver, used to identify possible load targets for the library.</param>
        public UnmanagedLibrary(string[] names, LibraryLoader loader, PathResolver pathResolver)
        {
            _loader = loader;
            Handle = _loader.LoadNativeLibrary(names, pathResolver);
        }

        /// <summary>
        ///     The operating system handle of the loaded library.
        /// </summary>
        public nint Handle { get; }

        /// <summary>
        ///     Frees the native library. Function pointers retrieved from this library will be void.
        /// </summary>
        public void Dispose()
        {
            _loader.FreeNativeLibrary(Handle);
        }

        /// <summary>
        ///     Loads a function whose signature matches the given delegate type's signature.
        /// </summary>
        /// <typeparam name="T">The type of delegate to return.</typeparam>
        /// <param name="name">The name of the native export.</param>
        /// <returns>A delegate wrapping the native function.</returns>
        /// <exception cref="InvalidOperationException">
        ///     Thrown when no function with the given name
        ///     is exported from the native library.
        /// </exception>
        public T LoadFunction<T>(string name)
        {
            var functionPtr = _loader.LoadFunctionPointer(Handle, name);
            if (functionPtr == 0)
            {
                throw new InvalidOperationException($"No function was found with the name {name}.");
            }

            return Marshal.GetDelegateForFunctionPointer<T>(functionPtr);
        }

#nullable enable
        /// <summary>
        ///     Attempts to load a function whose signature matches the given delegate type's signature.
        /// </summary>
        /// <typeparam name="T">The type of delegate to return.</typeparam>
        /// <param name="name">The name of the native export.</param>
        /// <param name="pfn">A delegate wrapping the native function.</param>
        /// <returns>Whether the load operation was successful or not.</returns>
        public bool TryLoadFunction<T>(string name, out T? pfn) where T : Delegate
        {
            var functionPtr = _loader.LoadFunctionPointer(Handle, name);
            if (functionPtr == 0)
            {
                pfn = null;
                return false;
            }

            pfn = Marshal.GetDelegateForFunctionPointer<T>(functionPtr);
            return true;
        }
#nullable disable

        /// <summary>
        ///     Loads a function pointer with the given name.
        /// </summary>
        /// <param name="name">The name of the native export.</param>
        /// <returns>A function pointer for the given name.</returns>
        public nint LoadFunction(string name)
        {
            return _loader.LoadFunctionPointer(Handle, name);
        }

        /// <summary>
        ///     Attempts to load a function pointer with the given name.
        /// </summary>
        /// <param name="name">The name of the native export.</param>
        /// <param name="pfn">A function pointer for the given name, or 0 if no function with that name exists.</param>
        /// <returns>Whether the load was successful or not.</returns>
        public bool TryLoadFunction(string name, out nint pfn)
        {
            return _loader.TryLoadFunctionPointer(Handle, name, out pfn);
        }
    }
}
