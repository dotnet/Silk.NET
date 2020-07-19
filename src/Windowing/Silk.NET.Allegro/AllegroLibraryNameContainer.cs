// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.Allegro
{
    /// <summary>
    /// Contains the library name of Allegro.
    /// </summary>
    internal class AllegroLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "liballegro.so.5.2";

        /// <inheritdoc />
        public override string MacOS => "liballegro.5.2.dylib";

        /// <inheritdoc />
        public override string Android => "libassimp.so.5";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "allegro-5.2.dll";

        /// <inheritdoc />
        public override string Windows86 => "allegro-5.2.dll";
    }
}
