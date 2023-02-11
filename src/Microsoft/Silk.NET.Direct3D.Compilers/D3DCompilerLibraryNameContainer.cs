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
        public override string[] Linux => new[] { "libd3dcompile_vkd3d.so", "libD3DCompiler_47.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libD3DCompiler_47.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libD3DCompiler_47.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "D3DCompiler_47.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "D3DCompiler_47.dll" };
    }
}
