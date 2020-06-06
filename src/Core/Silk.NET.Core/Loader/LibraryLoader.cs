#if NETCOREAPP3_0
using System.Reflection;
using NativeLibrary3 = System.Runtime.InteropServices.NativeLibrary;
#else
using System.Runtime.InteropServices;
#endif
using System;
using System.IO;

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
        public IntPtr LoadNativeLibrary(string name)
        {
            return LoadNativeLibrary(name, PathResolver.Default);
        }

        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="names">
        ///     An ordered list of names. Each name is tried in turn, until the library is successfully loaded.
        /// </param>
        /// <returns>The operating system handle for the shared library.</returns>
        public IntPtr LoadNativeLibrary(string[] names)
        {
            return LoadNativeLibrary(names, PathResolver.Default);
        }

        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="name">The name of the library to open.</param>
        /// <param name="pathResolver">The path resolver to use.</param>
        /// <returns>The operating system handle for the shared library.</returns>
        public IntPtr LoadNativeLibrary(string name, PathResolver pathResolver)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Parameter must not be null or empty.", nameof(name));

            var ret = LoadWithResolver(name, pathResolver);

            if (ret == IntPtr.Zero)
                throw new FileNotFoundException("Could not find or load the native library: " + name);

            return ret;
        }

        /// <summary>
        ///     Loads a native library by name and returns an operating system handle to it.
        /// </summary>
        /// <param name="names">
        ///     An ordered list of names. Each name is tried in turn, until the library is successfully loaded.
        /// </param>
        /// <param name="pathResolver">The path resolver to use.</param>
        /// <returns>The operating system handle for the shared library.</returns>
        public IntPtr LoadNativeLibrary(string[] names, PathResolver pathResolver)
        {
            if (names == null || names.Length == 0)
                throw new ArgumentException("Parameter must not be null or empty.", nameof(names));

            var ret = IntPtr.Zero;
            foreach (var name in names)
            {
                ret = LoadWithResolver(name, pathResolver);
                if (ret != IntPtr.Zero) break;
            }

            if (ret == IntPtr.Zero)
                throw new FileNotFoundException(
                    $"Could not find or load the native library from any name: [ {string.Join(", ", names)} ]");

            return ret;
        }

        private IntPtr LoadWithResolver(string name, PathResolver pathResolver)
        {
            if (name == "__Internal") return CoreLoadNativeLibrary(null);

            if (Path.IsPathRooted(name)) return CoreLoadNativeLibrary(name);

            foreach (var loadTarget in pathResolver.EnumeratePossibleLibraryLoadTargets(name))
            {
                try
                {
                    var ret = CoreLoadNativeLibrary(loadTarget);
                    if (ret != IntPtr.Zero) return ret;
                }
                catch (FileNotFoundException)
                {
                    // do nothing
                }
            }

            return IntPtr.Zero;
        }

        /// <summary>
        ///     Loads a function pointer out of the given library by name.
        /// </summary>
        /// <param name="handle">The operating system handle of the opened shared library.</param>
        /// <param name="functionName">The name of the exported function to load.</param>
        /// <returns>A pointer to the loaded function.</returns>
        public IntPtr LoadFunctionPointer(IntPtr handle, string functionName)
        {
            if (string.IsNullOrEmpty(functionName))
                throw new ArgumentException("Parameter must not be null or empty.", nameof(functionName));

            var ret = CoreLoadFunctionPointer(handle, functionName);
            if (ret == IntPtr.Zero)
            {
                throw new SymbolLoadingException(functionName);
            }

            return ret;
        }

        /// <summary>
        ///     Frees the library represented by the given operating system handle.
        /// </summary>
        /// <param name="handle">The handle of the open shared library.</param>
        public void FreeNativeLibrary(IntPtr handle)
        {
            if (handle == IntPtr.Zero) throw new ArgumentException("Parameter must not be zero.", nameof(handle));

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
        protected abstract IntPtr CoreLoadNativeLibrary(string name);

        /// <summary>
        ///     Frees the library represented by the given operating system handle.
        /// </summary>
        /// <param name="handle">The handle of the open shared library. This must not be zero.</param>
        protected abstract void CoreFreeNativeLibrary(IntPtr handle);

        /// <summary>
        ///     Loads a function pointer out of the given library by name.
        /// </summary>
        /// <param name="handle">The operating system handle of the opened shared library. This must not be zero.</param>
        /// <param name="functionName">The name of the exported function to load. This must not be null or empty.</param>
        /// <returns>A pointer to the loaded function.</returns>
        protected abstract IntPtr CoreLoadFunctionPointer(IntPtr handle, string functionName);

        /// <summary>
        ///     Returns a default library loader for the running operating system.
        /// </summary>
        /// <returns>A LibraryLoader suitable for loading libraries.</returns>
        public static LibraryLoader GetPlatformDefaultLoader()
        {
#if NETCOREAPP3_0
            return new NetCoreNativeLibraryLoader();
#else

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return new Win32LibraryLoader();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return new UnixLibraryLoader();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ||
                RuntimeInformation.OSDescription.ToUpper().Contains("BSD"))
                return new BsdLibraryLoader();

            throw new PlatformNotSupportedException("This platform cannot load native libraries.");
#endif
        }

#if NETCOREAPP3_0
        private class NetCoreNativeLibraryLoader : LibraryLoader
        {
            protected override IntPtr CoreLoadNativeLibrary(string name)
            {
                return NativeLibrary3.Load(name, Assembly.GetCallingAssembly(), null);
            }

            protected override void CoreFreeNativeLibrary(IntPtr handle)
            {
                NativeLibrary3.Free(handle);
            }

            protected override IntPtr CoreLoadFunctionPointer(IntPtr handle, string functionName)
            {
                return NativeLibrary3.GetExport(handle, functionName);
            }
        }
#endif

        private class BsdLibraryLoader : LibraryLoader
        {
            protected override void CoreFreeNativeLibrary(IntPtr handle)
            {
                Libc.dlclose(handle);
            }

            protected override IntPtr CoreLoadFunctionPointer(IntPtr handle, string functionName)
            {
                return Libc.dlsym(handle, functionName);
            }

            protected override IntPtr CoreLoadNativeLibrary(string name)
            {
                return Libc.dlopen(name, Libc.RtldNow);
            }
        }

        private class Win32LibraryLoader : LibraryLoader
        {
            protected override void CoreFreeNativeLibrary(IntPtr handle)
            {
                Kernel32.FreeLibrary(handle);
            }

            protected override IntPtr CoreLoadFunctionPointer(IntPtr handle, string functionName)
            {
                return Kernel32.GetProcAddress(handle, functionName);
            }

            protected override IntPtr CoreLoadNativeLibrary(string name)
            {
                return Kernel32.LoadLibrary(name);
            }
        }

        private class UnixLibraryLoader : LibraryLoader
        {
            protected override void CoreFreeNativeLibrary(IntPtr handle)
            {
                Libdl.dlclose(handle);
            }

            protected override IntPtr CoreLoadFunctionPointer(IntPtr handle, string functionName)
            {
                return Libdl.dlsym(handle, functionName);
            }

            protected override IntPtr CoreLoadNativeLibrary(string name)
            {
                return Libdl.dlopen(name, Libdl.RtldNow);
            }
        }
    }
}