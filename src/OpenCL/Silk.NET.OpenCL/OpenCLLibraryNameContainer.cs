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
        public override string[] Linux => new[] { "libOpenCL.so.1" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "/System/Library/Frameworks/OpenCL.framework/OpenCL" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libOpenCL.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "/System/Library/Frameworks/OpenCL.framework/OpenCL" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "opencl.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "opencl.dll" };
    }
}
