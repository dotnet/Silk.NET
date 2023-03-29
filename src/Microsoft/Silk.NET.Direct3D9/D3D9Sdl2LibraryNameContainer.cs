// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using Silk.NET.Core.Loader;

namespace Silk.NET.Direct3D9
{
    /// <summary>
    /// Contains the library name of D3D9.
    /// </summary>
    internal class D3D9Sdl2LibraryNameContainer : D3D9LibraryNameContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "sdl2-libdxvk_d3d9.so" }.Concat(base.Linux).ToArray();
    }
}
