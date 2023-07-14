// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Direct3D.Compilers
{
    /// <summary>
    /// Contains the library name of DXC.
    /// </summary>
    internal class DXCLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libdxcompiler.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libdxcompiler.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libdxcompiler.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "dxcompiler.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "dxcompiler.dll" };
    }
}
