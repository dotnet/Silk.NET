// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Direct3D11
{
    /// <summary>
    /// Contains the library name of D3D11.
    /// </summary>
    internal class D3D11Sdl2LibraryNameContainer : D3D11LibraryNameContainer
    {
        /// <inheritdoc />
        public override string Linux => "sdl2-libdxvk_d3d11.so";
    }
}
