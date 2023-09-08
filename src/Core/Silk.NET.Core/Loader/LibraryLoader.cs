// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NETCOREAPP3_1 || NET5_0_OR_GREATER
using System.Reflection;
using NativeLibrary3 = System.Runtime.InteropServices.NativeLibrary;
#else
using System.Runtime.InteropServices;
#endif
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Silk.NET.Core.Loader
{
    /// <summary>
    ///     Exposes functionality for loading native libraries and function pointers.
    /// </summary>
    public abstract class LibraryLoader
    {
        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="name">The name of the library to open.</param>
        /// <returns>The operating system handle for the shared library.</returns>
        public nint LoadNativeLibrary(string name)
        {
            return LoadNativeLibrary(name, PathResolver.Default);
        }
        
        public void RegisterDependencies(params string[] names)
        {
            foreach (var name in names)
            {
                    LoadNativeLibrary(name);
            }
        }

        private static void ThrowLibNotFound(string name, PathResolver resolver)
        {
            throw new FileNotFoundException($"Could not find or load the native library: {name} Attempted: {string.Join(", ", resolver.EnumeratePossibleLibraryLoadTargets(name).Select(x => "\"" + x + "\""))}",
                name);
        }

        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="name">The name of the library to open.</param>
        /// <param name="result">A pointer to the loaded library.</param>
        /// <returns>The operating system handle for the shared library.</returns>
        public bool TryLoadNativeLibrary(string name, out nint result)
        {
            return TryLoadNativeLibrary(new[] {name}, PathResolver.Default, out result);
        }

        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="names">
        ///     An ordered list of names. Each name is tried in turn, until the library is successfully loaded.
        /// </param>
        /// <returns>The operating system handle for the shared library.</returns>
        public nint LoadNativeLibrary(string[] names)
        {
            return LoadNativeLibrary(names, PathResolver.Default);
        }

        private static void ThrowLibNotFoundAny(string[] names, PathResolver pathResolver)
        {
            throw new FileNotFoundException
                ($"Could not find or load the native library from any name: [ {string.Join(", ", names.Select(x => x + " Attempted: (" + string.Join(", ", pathResolver.EnumeratePossibleLibraryLoadTargets(x).Select(x2 => "\"" + x2 + "\"")) + ")"))} ]",
                names[0]);
        }

        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="names">
        ///     An ordered list of names. Each name is tried in turn, until the library is successfully loaded.
        /// </param>
        /// <param name="result">A pointer to the loaded library.</param>
        /// <returns>The operating system handle for the shared library.</returns>
        public bool TryLoadNativeLibrary(string[] names, out nint result)
        {
            return TryLoadNativeLibrary(names, PathResolver.Default, out result);
        }

        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="name">The name of the library to open.</param>
        /// <param name="pathResolver">The path resolver to use.</param>
        /// <returns>The operating system handle for the shared library.</returns>
        public nint LoadNativeLibrary(string name, PathResolver pathResolver)
        {
            if (string.IsNullOrEmpty(name))
            {
                ThrowParameterNotNullOrEmpty(nameof(name));
                return default;
            }

            var success = TryLoadNativeLibrary(name, pathResolver, out var result);

            if (!success)
            {
                ThrowLibNotFound(name, pathResolver);
                return default;
            }

            return result;
        }

        private static void ThrowParameterNotNullOrEmpty(string param)
        {
            throw new ArgumentException("Parameter must not be null or empty.", param);
        }

        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="name">The name of the library to open.</param>
        /// <param name="pathResolver">The path resolver to use.</param>
        /// <param name="result">A pointer to the loaded library.</param>
        /// <returns>The operating system handle for the shared library.</returns>
        public bool TryLoadNativeLibrary(string name, PathResolver pathResolver, out nint result)
        {
            var success = TryLoadNativeLibrary(new[] {name}, pathResolver, out var libPtr);
            result = libPtr;

            return success;
        }

        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="names">
        ///     An ordered list of names. Each name is tried in turn, until the library is successfully loaded.
        /// </param>
        /// <param name="pathResolver">The path resolver to use.</param>
        /// <returns>The operating system handle for the shared library.</returns>
        public nint LoadNativeLibrary(string[] names, PathResolver pathResolver)
        {
            if (names == null || names.Length == 0)
            {
                ThrowParameterNotNullOrEmpty(nameof(names));
                return default;
            }

            var success = TryLoadNativeLibrary(names, pathResolver, out var result);

            if (!success)
            {
                ThrowLibNotFoundAny(names, pathResolver);
                return default;
            }

            return result;
        }

        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="names">
        ///     An ordered list of names. Each name is tried in turn, until the library is successfully loaded.
        /// </param>
        /// <param name="pathResolver">The path resolver to use.</param>
        /// <param name="result">A pointer to the loaded library.</param>
        /// <returns>The operating system handle for the shared library.</returns>
        public bool TryLoadNativeLibrary(string[] names, PathResolver pathResolver, out nint result)
        {
            result = 0;

            if (names == null || names.Length == 0)
            {
                return false;
            }

            foreach (var name in names)
            {
                result = LoadWithResolver(name, pathResolver);
                if (result != 0)
                {
                    break;
                }
            }

            return result != 0;
        }

        private nint LoadWithResolver(string name, PathResolver pathResolver)
        {
            if (name == "__Internal")
            {
                return CoreLoadNativeLibrary(null);
            }

            if (Path.IsPathRooted(name))
            {
                return CoreLoadNativeLibrary(name);
            }

            foreach (var loadTarget in pathResolver.EnumeratePossibleLibraryLoadTargets(name))
            {
                try
                {
                    var ret = CoreLoadNativeLibrary(loadTarget);
                    if (ret != 0)
                    {
                        return ret;
                    }
                }
                catch (FileNotFoundException)
                {
                    // do nothing
                }
            }

            return 0;
        }

        /// <summary>
        ///     Loads a function pointer out of the given library by name.
        /// </summary>
        /// <param name="handle">The operating system handle of the opened shared library.</param>
        /// <param name="functionName">The name of the exported function to load.</param>
        /// <returns>A pointer to the loaded function.</returns>
        public nint LoadFunctionPointer(nint handle, string functionName)
        {
            if (string.IsNullOrEmpty(functionName))
            {
                ThrowParameterNotNullOrEmpty(nameof(functionName));
                return default;
            }

            var ret = CoreLoadFunctionPointer(handle, functionName);
            if (ret == 0)
            {
                ThrowSymbolLoading(functionName);
                return default;
            }

            return ret;
        }

        /// <summary>
        ///     Attempts a function pointer out of the given library by name.
        /// </summary>
        /// <param name="handle">The operating system handle of the opened shared library.</param>
        /// <param name="functionName">The name of the exported function to load.</param>
        /// <param name="pfn">A pointer to the loaded function, or 0 if it failed to load.</param>
        /// <returns>Whether the load was successful or not.</returns>
        public bool TryLoadFunctionPointer(nint handle, string functionName, out nint pfn)
        {
            pfn = default;
            if (string.IsNullOrEmpty(functionName))
            {
                ThrowParameterNotNullOrEmpty(nameof(functionName));
                return false;
            }

            var ret = CoreLoadFunctionPointer(handle, functionName);
            if (ret == 0)
            {
                return false;
            }

            pfn = ret;
            return true;
        }

        private static void ThrowSymbolLoading(string functionName)
        {
            throw new SymbolLoadingException(functionName);
        }

        /// <summary>
        ///     Frees the library represented by the given operating system handle.
        /// </summary>
        /// <param name="handle">The handle of the open shared library.</param>
        public void FreeNativeLibrary(nint handle)
        {
            if (handle == 0)
            {
                throw new ArgumentException("Parameter must not be zero.", nameof(handle));
            }

            CoreFreeNativeLibrary(handle);
        }

        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="name">The name of the library to open. This parameter must not be null or empty.</param>
        /// <returns>
        ///     The operating system handle for the shared library.
        ///     If the library cannot be loaded, IntPtr.Zero should be returned.
        /// </returns>
        protected abstract nint CoreLoadNativeLibrary(string name);

        /// <summary>
        ///     Frees the library represented by the given operating system handle.
        /// </summary>
        /// <param name="handle">The handle of the open shared library. This must not be zero.</param>
        protected abstract void CoreFreeNativeLibrary(nint handle);

        /// <summary>
        ///     Loads a function pointer out of the given library by name.
        /// </summary>
        /// <param name="handle">The operating system handle of the opened shared library. This must not be zero.</param>
        /// <param name="functionName">The name of the exported function to load. This must not be null or empty.</param>
        /// <returns>A pointer to the loaded function.</returns>
        protected abstract nint CoreLoadFunctionPointer(nint handle, string functionName);

        /// <summary>
        ///     Returns a default library loader for the running operating system.
        /// </summary>
        /// <returns>A LibraryLoader suitable for loading libraries.</returns>
        public static LibraryLoader GetPlatformDefaultLoader()
        {
#if NETCOREAPP3_1 || NET5_0_OR_GREATER
            return new NetNextNativeLibraryLoader();
#else

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return new Win32LibraryLoader();
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return new UnixLibraryLoader();
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ||
                RuntimeInformation.OSDescription.ToUpper().Contains("BSD"))
            {
                return new BsdLibraryLoader();
            }

            PlatformNotSupported();
            return default;
#endif
        }

        private static void PlatformNotSupported()
        {
            throw new PlatformNotSupportedException("This platform cannot load native libraries.");
        }

#if NETCOREAPP3_1 || NET5_0_OR_GREATER
        private class NetNextNativeLibraryLoader : LibraryLoader
        {
            protected override nint CoreLoadNativeLibrary(string name)
            {
                if (NativeLibrary3.TryLoad(name, out var lib))
                {
                    return lib;
                }
                
                return 0;
            }

            protected override void CoreFreeNativeLibrary(nint handle)
            {
                if (handle != 0)
                {
                    NativeLibrary3.Free(handle);
                }
            }

            protected override nint CoreLoadFunctionPointer(nint handle, string functionName)
            {
                if (NativeLibrary3.TryGetExport(handle, functionName, out var ptr))
                {
                    return ptr;
                }
                
                return 0;
            }
        }
#endif

        private class BsdLibraryLoader : LibraryLoader
        {
            protected override void CoreFreeNativeLibrary(nint handle)
            {
                Libc.dlclose(handle);
            }

            protected override nint CoreLoadFunctionPointer(nint handle, string functionName)
            {
                return Libc.dlsym(handle, functionName);
            }

            protected override nint CoreLoadNativeLibrary(string name)
            {
                return Libc.dlopen(name, Libc.RtldNow);
            }
        }

        private class Win32LibraryLoader : LibraryLoader
        {
            protected override void CoreFreeNativeLibrary(nint handle)
            {
                Kernel32.FreeLibrary(handle);
            }

            protected override nint CoreLoadFunctionPointer(nint handle, string functionName)
            {
                return Kernel32.GetProcAddress(handle, functionName);
            }

            protected override nint CoreLoadNativeLibrary(string name)
            {
                return Kernel32.LoadLibrary(name);
            }
        }

        private class UnixLibraryLoader : LibraryLoader
        {
            protected override void CoreFreeNativeLibrary(nint handle)
            {
                Libdl.dlclose(handle);
            }

            protected override nint CoreLoadFunctionPointer(nint handle, string functionName)
            {
                return Libdl.dlsym(handle, functionName);
            }

            protected override nint CoreLoadNativeLibrary(string name)
            {
                return Libdl.dlopen(name, Libdl.RtldNow);
            }
        }
    }
}
