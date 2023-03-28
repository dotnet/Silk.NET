// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.DXVA
{
    /// <summary>
    /// Contains the library name of DXVA.
    /// </summary>
    internal class DXVA2LibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libdxva2.so" };
    
        /// <inheritdoc />
        public override string[] MacOS => new[] { "libdxva2.dylib" };
    
        /// <inheritdoc />
        public override string[] Android => new[] { "libdxva2.so" };
    
        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };
    
        /// <inheritdoc />
        public override string[] Windows64 => new[] { "dxva2.dll" };
    
        /// <inheritdoc />
        public override string[] Windows86 => new[] { "dxva2.dll" };
    }
}