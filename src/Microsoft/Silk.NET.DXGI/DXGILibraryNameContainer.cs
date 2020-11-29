// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.DXGI
{
    /// <summary>
    /// Contains the library name of DXGI.
    /// </summary>
    internal class DXGILibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libDXGI.so";

        /// <inheritdoc />
        public override string MacOS => "libDXGI.dylib";

        /// <inheritdoc />
        public override string Android => "libDXGI.so";

        /// <inheritdoc />
        public override string IOS => "__Internal"; // __Internal relies on a SilkTouch override.

        /// <inheritdoc />
        public override string Windows64 => "DXGI.dll";

        /// <inheritdoc />
        public override string Windows86 => "DXGI.dll";
    }
}
