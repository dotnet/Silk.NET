// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.DirectStorage
{
    /// <summary>
    /// Contains the library name of DirectStorage.
    /// </summary>
    internal class DStorageLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libdstorage.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libdstorage.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libdstorage.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "dstorage.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "dstorage.dll" };
    }
}
