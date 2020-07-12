// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.Assimp
{
    /// <summary>
    /// Contains the library name of Assimp.
    /// </summary>
    internal class AssimpLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libassimp.so.5";

        /// <inheritdoc />
        public override string MacOS => "libassimp.5.dylib";

        /// <inheritdoc />
        public override string Android => "libassimp.so.5";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "Assimp32.dll";

        /// <inheritdoc />
        public override string Windows86 => "Assimp32.dll";
    }
}
