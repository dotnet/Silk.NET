// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Contains the library name of OpenAL.
    /// </summary>
    internal class OpenALSoftLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libopenal.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libopenal.dylib" };

        /// <inheritdoc />
        public override string[] Android => Linux;

        /// <inheritdoc />
        public override string[] IOS => MacOS;

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "soft_oal.dll" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "soft_oal.dll" };
    }
}
