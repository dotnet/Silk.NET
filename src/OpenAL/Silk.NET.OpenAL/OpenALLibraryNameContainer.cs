//
// OpenALLibrarynameContainer.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Contains the library name of OpenAL.
    /// </summary>
    internal class OpenALLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libopenal.so.1";

        /// <inheritdoc />
        public override string MacOS => "/System/Library/Frameworks/OpenAL.framework/OpenAL";

        /// <inheritdoc />
        public override string Android => Linux;

        /// <inheritdoc />
        public override string IOS => MacOS;

        /// <inheritdoc />
        public override string Windows86 => "openal32.dll";
        
        /// <inheritdoc />
        public override string Windows64 => "openal32.dll";
    }
}
