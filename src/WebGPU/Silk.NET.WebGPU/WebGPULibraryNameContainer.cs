// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.WebGPU
{
    /// <summary>
    /// Contains the library name of webgpu.
    /// </summary>
    internal class WebGPULibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libwgpu_native.so" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libwgpu_native.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libwgpu_native.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "wgpu_native.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "wgpu_native.dll" };
    }
}
