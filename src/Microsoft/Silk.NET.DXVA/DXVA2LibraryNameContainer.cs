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
        public override string Linux => "libdxva2.so";
    
        /// <inheritdoc />
        public override string MacOS => "libdxva2.dylib";
    
        /// <inheritdoc />
        public override string Android => "libdxva2.so";
    
        /// <inheritdoc />
        public override string IOS => "__Internal";
    
        /// <inheritdoc />
        public override string Windows64 => "dxva2.dll";
    
        /// <inheritdoc />
        public override string Windows86 => "dxva2.dll";
    }
}