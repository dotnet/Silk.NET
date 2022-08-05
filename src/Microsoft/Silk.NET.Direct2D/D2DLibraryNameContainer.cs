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
        public override string Linux => "libd2d1.so";

        /// <inheritdoc />
        public override string MacOS => "libd2d1.dylib";

        /// <inheritdoc />
        public override string Android => "libd2d1.so";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "d2d1.dll";

        /// <inheritdoc />
        public override string Windows86 => "d2d1.dll";
    }
}
