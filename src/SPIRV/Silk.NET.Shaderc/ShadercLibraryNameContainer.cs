// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Shaderc
{
    /// <summary>
    /// Contains the library name of shaderc.
    /// </summary>
    internal class ShadercLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libshaderc_shared.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libshaderc_shared.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libshaderc_shared.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "shaderc_shared.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "shaderc_shared.dll" };
    }
}
