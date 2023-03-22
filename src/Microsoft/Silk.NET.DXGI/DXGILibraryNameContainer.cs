// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.DXGI
{
    /// <summary>
    /// Contains the library name of DXGI.
    /// </summary>
    internal class DXGILibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libDXGI.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libDXGI.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libDXGI.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" }; // __Internal relies on a SilkTouch override.

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "DXGI.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "DXGI.dll" };
    }
}
