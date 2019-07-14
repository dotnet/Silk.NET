// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenGL
{
    /// <summary>
    /// Contains the library name of OpenGL.
    /// </summary>
    internal class GLCoreLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libGL.so.1";

        /// <inheritdoc />
        public override string MacOS => "/System/Library/Frameworks/OpenGL.framework/OpenGL";

        /// <inheritdoc />
        public override string Android => "libGL.so.1";

        /// <inheritdoc />
        public override string IOS => "/System/Library/Frameworks/OpenGL.framework/OpenGL";

        /// <inheritdoc />
        public override string Windows64 => "opengl32.dll";

        /// <inheritdoc />
        public override string Windows86 => "opengl32.dll";
    }
}
