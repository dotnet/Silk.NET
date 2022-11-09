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
        public override string Linux => "libglfw.so.3.3";

        /// <inheritdoc />
        public override string MacOS => "libglfw.3.dylib";

        /// <inheritdoc />
        public override string Android => Linux;

        /// <inheritdoc />
        public override string IOS => MacOS;

        /// <inheritdoc />
        public override string Windows64 => "glfw3.dll";

        /// <inheritdoc />
        public override string Windows86 => "glfw3.dll";

        /// <inheritdoc />
        public override string Browser => "glfw3";
    }
}
