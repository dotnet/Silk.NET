// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.WindowsCodecs
{
    /// <summary>
    /// Contains the library name of WindowsCodecs.
    /// </summary>
    internal class WICLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libwindowscodecs.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libwindowscodecs.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libwindowscodecs.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "windowscodecs.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "windowscodecs.dll" };
    }
}
