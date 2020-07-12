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
        public override string Linux => "libopenxr_loader.so.1";

        /// <inheritdoc />
        public override string MacOS => "null";

        /// <inheritdoc />
        public override string Android => "libopenxr_loader.so.1";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "openxr_loader.dll";

        /// <inheritdoc />
        public override string Windows86 => "openxr_loader.dll";
    }
}
