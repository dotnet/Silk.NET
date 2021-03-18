// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Direct3D9
{
    /// <summary>
    /// Contains the library name of D3D9.
    /// </summary>
    internal class D3D9LibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libd3d9.so";

        /// <inheritdoc />
        public override string MacOS => "libd3d9.dylib";

        /// <inheritdoc />
        public override string Android => "libd3d9.so";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "d3d9.dll";

        /// <inheritdoc />
        public override string Windows86 => "d3d9.dll";
    }
}
