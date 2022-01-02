// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TexStorageAttribss")]
    public enum TexStorageAttribss : int
    {
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_NONE_EXT")]
        SurfaceCompressionFixedRateNoneExt = 0x96C1,
    }
}
