// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.MediaFoundation
{
    /// <summary>
    /// Contains the library name of MediaFoundation.
    /// </summary>
    internal class MediaFoundationLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libMediaFoundation.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libMediaFoundation.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libMediaFoundation.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "MediaFoundation.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "MediaFoundation.dll" };
    }
}
