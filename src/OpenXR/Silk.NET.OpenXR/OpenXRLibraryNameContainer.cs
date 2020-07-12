// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenXR
{
    /// <summary>
    /// Contains the library name of OpenXR.
    /// </summary>
    internal class OpenXRLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "null";

        /// <inheritdoc />
        public override string MacOS => "null";

        /// <inheritdoc />
        public override string Android => "null";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "null";

        /// <inheritdoc />
        public override string Windows86 => "null";
    }
}
