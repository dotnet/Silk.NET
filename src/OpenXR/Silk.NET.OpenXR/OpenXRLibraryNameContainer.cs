// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenXR
{
    /// <summary>
    /// Contains the library name of OpenXR.
    /// </summary>
    internal class OpenXRLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libopenxr_loader.so.1" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "null" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libopenxr_loader.so.1" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "openxr_loader.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "openxr_loader.dll" };
    }
}
