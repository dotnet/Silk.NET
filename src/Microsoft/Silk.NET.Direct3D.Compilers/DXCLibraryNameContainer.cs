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
        public override string Linux => "libdxcompiler.so";

        /// <inheritdoc />
        public override string MacOS => "libdxcompiler.dylib";

        /// <inheritdoc />
        public override string Android => "libdxcompiler.so";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "dxcompiler.dll";

        /// <inheritdoc />
        public override string Windows86 => "dxcompiler.dll";
    }
}
