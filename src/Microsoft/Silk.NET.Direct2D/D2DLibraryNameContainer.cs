// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Direct2D
{
    /// <summary>
    /// Contains the library name of D2D.
    /// </summary>
    internal class D2DLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libd2d1.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libd2d1.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libd2d1.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "d2d1.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "d2d1.dll" };
    }
}
