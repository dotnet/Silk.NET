// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.DirectWrite
{
    /// <summary>
    /// Contains the library name of DirectWrite.
    /// </summary>
    internal class DWriteLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libdwrite.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libdwrite.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libdwrite.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "DWrite.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "DWrite.dll" };
    }
}
