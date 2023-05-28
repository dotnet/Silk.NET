// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.SPIRV.Reflect
{
    /// <summary>
    /// Contains the library name of SPIRVReflect.
    /// </summary>
    internal class SPIRVReflectLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libspirv-reflect.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libspirv-reflect.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libspirv-reflect.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "spirv-reflect.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "spirv-reflect.dll" };
    }
}
