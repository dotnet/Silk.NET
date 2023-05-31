// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.SPIRV.Cross
{
    /// <summary>
    /// Contains the library name of SPIRVCross.
    /// </summary>
    internal class SPIRVCrossLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libspirv-cross.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libspirv-cross.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libspirv-cross.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "spirv-cross.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "spirv-cross.dll" };
    }
}
