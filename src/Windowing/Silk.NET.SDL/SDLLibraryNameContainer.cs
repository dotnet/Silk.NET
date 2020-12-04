// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.SDL
{
    /// <summary>
    /// Contains the library name of SDL.
    /// </summary>
    internal class SDLLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libSDL2-2.0.so";

        /// <inheritdoc />
        public override string MacOS => "libSDL2-2.0.dylib";

        /// <inheritdoc />
        public override string Android => "libSDL2.so";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "SDL2.dll";

        /// <inheritdoc />
        public override string Windows86 => "SDL2.dll";
    }
}
