// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Loader
{
    /// <summary>
    /// Contains the platform-specific search paths and names for a native library.
    /// </summary>
    public abstract class SearchPathContainer
    {
        /// <summary>
        /// Gets the library name to use on Windows 64-bit.
        /// </summary>
        public abstract string Windows64 { get; }

        /// <summary>
        /// Gets the library name to use on Windows 32-bit.
        /// </summary>
        public abstract string Windows86 { get; }

        /// <summary>
        /// Gets the library name to use on Linux.
        /// </summary>
        public abstract string Linux { get; }

        /// <summary>
        /// Gets the library name to use on MacOS.
        /// </summary>
        public abstract string MacOS { get; }

        /// <summary>
        /// Gets the library name to use on Android.
        /// </summary>
        public virtual string Android => Linux;

        /// <summary>
        /// Gets the library name to use on iOS.
        /// </summary>
        public virtual string IOS => MacOS;

        /// <summary>
        /// Gets the library name to use on the current platform.
        /// </summary>
        /// <returns>The library name.</returns>
        public string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return RuntimeInformation.IsOSPlatform(OSPlatform.Create("ANDROID")) ? Android : Linux;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Environment.Is64BitProcess ? Windows64 : Windows86;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return RuntimeInformation.IsOSPlatform(OSPlatform.Create("IOS")) ? IOS : MacOS;
            }

            throw new NotSupportedException("Invalid/unsupported operating system.");
        }
    }
}