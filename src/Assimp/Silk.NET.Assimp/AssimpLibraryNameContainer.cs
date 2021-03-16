// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Assimp
{
    /// <summary>
    /// Contains the library name of Assimp.
    /// </summary>
    internal class AssimpLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libassimp.so.5";

        /// <inheritdoc />
        public override string MacOS => "libassimp.5.dylib";

        /// <inheritdoc />
        public override string Android => "libassimp.so.5";

        /// <inheritdoc />
        public override string IOS => "__Internal";

        /// <inheritdoc />
        public override string Windows64 => "Assimp64.dll";

        /// <inheritdoc />
        public override string Windows86 => "Assimp32.dll";
    }
}
