// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.Direct3D11
{
    /// <summary>
    /// Contains the library name of D3D11.
    /// </summary>
    internal class D3D11LibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libd3d11.so";

        /// <inheritdoc />
        public override string MacOS => "libd3d11.dylib";

        /// <inheritdoc />
        public override string Android => "libd3d11.so";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "d3d11.dll";

        /// <inheritdoc />
        public override string Windows86 => "d3d11.dll";
    }
}
