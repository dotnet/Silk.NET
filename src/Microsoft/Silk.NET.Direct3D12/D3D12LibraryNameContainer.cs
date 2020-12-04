// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.Direct3D12
{
    /// <summary>
    /// Contains the library name of D3D12.
    /// </summary>
    internal class D3D12LibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libD3D12.so";

        /// <inheritdoc />
        public override string MacOS => "libD3D12.dylib";

        /// <inheritdoc />
        public override string Android => "libD3D12.so";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "D3D12.dll";

        /// <inheritdoc />
        public override string Windows86 => "D3D12.dll";
    }
}
