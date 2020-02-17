// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.EGL
{
    /// <summary>
    /// Contains the library name of EGL.
    /// </summary>
    internal class EGLLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libEGL.so.1";

        /// <inheritdoc />
        public override string MacOS => "/System/Library/Frameworks/EGL.framework/EGL";

        /// <inheritdoc />
        public override string Android => "libEGL.so.1";

        /// <inheritdoc />
        public override string IOS => "/System/Library/Frameworks/EGL.framework/EGL";

        /// <inheritdoc />
        public override string Windows64 => "libEGL.dll";

        /// <inheritdoc />
        public override string Windows86 => "libEGL.dll";
    }
}
