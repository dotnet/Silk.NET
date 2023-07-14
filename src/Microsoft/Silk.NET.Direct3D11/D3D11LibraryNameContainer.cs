// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Direct3D11
{
    /// <summary>
    /// Contains the library name of D3D11.
    /// </summary>
    internal class D3D11LibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libd3d11.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libd3d11.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libd3d11.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "d3d11.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "d3d11.dll" };
    }
}
