// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.Direct3D.Compilers
{
    /// <summary>
    /// Contains the library name of D3DCompiler.
    /// </summary>
    internal class D3DCompilerLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libD3DCompiler_47.so";

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
