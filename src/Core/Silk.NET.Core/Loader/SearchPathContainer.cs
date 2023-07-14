// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Microsoft.DotNet.PlatformAbstractions;
using SRRuntimeEnvironment = System.Runtime.InteropServices.RuntimeEnvironment;
using PARuntimeEnvironment = Microsoft.DotNet.PlatformAbstractions.RuntimeEnvironment;

namespace Silk.NET.Core.Loader
{
    /// <summary>
    /// Contains the platform-specific search paths and names for a native library.
    /// </summary>
    public abstract class SearchPathContainer
    {
        /// <summary>
        /// Gets or sets the underlying platform (operating system) to use for search path resolution.
        /// </summary>
#if NET6_0_OR_GREATER
        public static UnderlyingPlatform Platform { get; set; } = OperatingSystem.IsAndroid()
            ?
            UnderlyingPlatform.Android
            : OperatingSystem.IsLinux()
                ? UnderlyingPlatform.Linux
                : OperatingSystem.IsIOS()
                    ? UnderlyingPlatform.IOS
                    : OperatingSystem.IsMacOS()
                        ? UnderlyingPlatform.MacOS
                        : OperatingSystem.IsWindows()
                            ? Environment.Is64BitProcess ? UnderlyingPlatform.Windows64 : UnderlyingPlatform.Windows86
                            : UnderlyingPlatform.Unknown;
#else
        public static UnderlyingPlatform Platform { get; set; } = RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
            ? RuntimeInformation.IsOSPlatform(OSPlatform.Create("ANDROID"))
                ? UnderlyingPlatform.Android // NOTE: This seems to work inconsistently. Recommend setting manually.
                : UnderlyingPlatform.Linux
            : RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? Environment.Is64BitProcess
                    ? UnderlyingPlatform.Windows64
                    : UnderlyingPlatform.Windows86
            : RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
                ? RuntimeInformation.IsOSPlatform(OSPlatform.Create("IOS"))
                    ? UnderlyingPlatform.IOS // NOTE: This seems to work inconsistently. Recommend setting manually.
                    : UnderlyingPlatform.MacOS
            : UnderlyingPlatform.Unknown;
#endif

        /// <summary>
        /// Gets the library names to use on Windows 64-bit.
        /// </summary>
        public abstract string[] Windows64 { get; }

        /// <summary>
        /// Gets the library names to use on Windows 32-bit.
        /// </summary>
        public abstract string[] Windows86 { get; }

        /// <summary>
        /// Gets the library names to use on Linux.
        /// </summary>
        public abstract string[] Linux { get; }

        /// <summary>
        /// Gets the library names to use on MacOS.
        /// </summary>
        public abstract string[] MacOS { get; }

        /// <summary>
        /// Gets the library names to use on Android.
        /// </summary>
        public virtual string[] Android => Linux;

        /// <summary>
        /// Gets the library names to use on iOS.
        /// </summary>
        public virtual string[] IOS => MacOS;

        /// <summary>
        /// Gets the possible library names to use for the current platform.
        /// </summary>
        /// <returns>The library names.</returns>
        public string[] GetLibraryNames() => Platform switch
        {
            UnderlyingPlatform.Unknown => ThrowInvalidPlatform(),
            UnderlyingPlatform.Windows64 => Windows64,
            UnderlyingPlatform.Windows86 => Windows86,
            UnderlyingPlatform.Linux => Linux,
            UnderlyingPlatform.Android => Android,
            UnderlyingPlatform.MacOS => MacOS,
            UnderlyingPlatform.IOS => IOS,
            _ => ThrowInvalidPlatform()
        };
        
        /// <summary>
        /// Gets the library name to use on the current platform.
        /// </summary>
        /// <returns>The library name.</returns>
        [Obsolete("This method is obsolete! Use GetLibraryNames")]
        public string GetLibraryName() => GetLibraryNames()[0];

        private static string[] ThrowInvalidPlatform()
        {
            throw new PlatformNotSupportedException("Invalid/unsupported operating system.");
        }
    }
}
