// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.EGL
{
    public class EGLLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libEGL.so";

        /// <inheritdoc />
        public override string MacOS => "libEGL.dylib";

        /// <inheritdoc />
        public override string Android => Linux;

        /// <inheritdoc />
        public override string IOS => MacOS;

        /// <inheritdoc />
        public override string Windows64 => "libEGL.dll";

        /// <inheritdoc />
        public override string Windows86 => "libEGL.dll";
    }
}
