// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Contains the library name of GLFW.
    /// </summary>
    internal class GlfwLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libglfw.so.3.3" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libglfw.3.dylib" };

        /// <inheritdoc />
        public override string[] Android => Linux;

        /// <inheritdoc />
        public override string[] IOS => MacOS;

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "glfw3.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "glfw3.dll" };
    }
}