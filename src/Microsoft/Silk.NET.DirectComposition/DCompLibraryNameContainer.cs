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
        public override string Linux => "libDComp.so";

        /// <inheritdoc />
        public override string MacOS => "libDComp.dylib";

        /// <inheritdoc />
        public override string Android => "libDComp.so";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "DComp.dll";

        /// <inheritdoc />
        public override string Windows86 => "DComp.dll";
    }
}
