// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Contains the library name of OpenAL.
    /// </summary>
    internal class OpenALNativeLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libopenal.so.1" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "/System/Library/Frameworks/OpenAL.framework/OpenAL" };

        /// <inheritdoc />
        public override string[] Android => Linux;

        /// <inheritdoc />
        public override string[] IOS => MacOS;

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "openal32.dll" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "openal32.dll" };
    }
}