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
        public override string Linux => "libdwrite.so";

        /// <inheritdoc />
        public override string MacOS => "libdwrite.dylib";

        /// <inheritdoc />
        public override string Android => "libdwrite.so";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "DWrite.dll";

        /// <inheritdoc />
        public override string Windows86 => "DWrite.dll";
    }
}
