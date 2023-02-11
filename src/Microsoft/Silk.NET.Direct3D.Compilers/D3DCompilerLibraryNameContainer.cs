// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Direct3D.Compilers
{
    /// <summary>
    /// Contains the library name of D3DCompiler.
    /// </summary>
    internal class D3DCompilerLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libd3dcompile_vkd3d.so";

        /// <inheritdoc />
        public override string MacOS => "libD3DCompiler_47.dylib";

        /// <inheritdoc />
        public override string Android => "libD3DCompiler_47.so";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "D3DCompiler_47.dll";

        /// <inheritdoc />
        public override string Windows86 => "D3DCompiler_47.dll";
    }
}
