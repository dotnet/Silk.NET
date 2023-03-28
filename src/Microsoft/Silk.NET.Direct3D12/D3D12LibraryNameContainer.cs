// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Direct3D12
{
    /// <summary>
    /// Contains the library name of D3D12.
    /// </summary>
    internal class D3D12LibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libD3D12.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libD3D12.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libD3D12.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "D3D12.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "D3D12.dll" };
    }
}
