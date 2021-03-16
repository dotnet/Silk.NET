// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenGLES
{
    /// <summary>
    /// Contains the library name of OpenGLES.
    /// </summary>
    internal class OpenGLESLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libGLESv2.so";

        /// <inheritdoc />
        public override string MacOS => "/System/Library/Frameworks/OpenGLES.framework/OpenGLES";

        /// <inheritdoc />
        public override string Android => "libGLESv2.so";

        /// <inheritdoc />
        public override string IOS => "/System/Library/Frameworks/OpenGLES.framework/OpenGLES";

        /// <inheritdoc />
        public override string Windows64 => "libGLESv2.dll";

        /// <inheritdoc />
        public override string Windows86 => "libGLESv2.dll";
    }
}
