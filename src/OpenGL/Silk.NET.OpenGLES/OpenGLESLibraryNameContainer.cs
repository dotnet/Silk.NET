// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenGLES
{
    /// <summary>
    /// Contains the library name of GLES.
    /// </summary>
    internal class OpenGLESLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libGLESv2.so";

        /// <inheritdoc />
        public override string MacOS => "/System/Library/Frameworks/OpenGLES.framework/OpenGLES";

        /// <inheritdoc />
        public override string Android => "libGLESv2.so";

        /// <inheritdoc />
        public override string IOS => "/System/Library/Frameworks/OpenGLES.framework/OpenGLES";

        /// <inheritdoc />
        public override string Windows64 => "libGLESv2.dll";

        /// <inheritdoc />
        public override string Windows86 => "libGLESv2.dll";
    }
}
