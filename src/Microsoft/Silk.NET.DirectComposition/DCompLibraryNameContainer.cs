// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.DirectComposition
{
    /// <summary>
    /// Contains the library name of DirectComposition.
    /// </summary>
    internal class DCompLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libDComp.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libDComp.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libDComp.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "DComp.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "DComp.dll" };
    }
}
