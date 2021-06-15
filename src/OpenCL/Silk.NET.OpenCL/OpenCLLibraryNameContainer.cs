// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenCL
{
    /// <summary>
    /// Contains the library name of OpenCL.
    /// </summary>
    internal class OpenCLLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Linux => "libOpenCL.so.1";

        /// <inheritdoc />
        public override string MacOS => "/System/Library/Frameworks/OpenCL.framework/OpenCL";

        /// <inheritdoc />
        public override string Android => "libOpenCL.so";

        /// <inheritdoc />
        public override string IOS => "/System/Library/Frameworks/OpenCL.framework/OpenCL";

        /// <inheritdoc />
        public override string Windows64 => "opencl.dll";

        /// <inheritdoc />
        public override string Windows86 => "opencl.dll";
    }
}
