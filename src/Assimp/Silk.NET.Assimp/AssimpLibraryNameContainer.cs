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
        public override string[] Linux => new[] { "libassimp.so.5" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libassimp.5.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libassimp.so.5" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "Assimp64.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "Assimp32.dll" };
    }
}
