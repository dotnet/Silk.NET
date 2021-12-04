// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "TexStorageAttribs")]
    public enum TexStorageAttribs : int
    {
        [NativeName("Name", "GL_SURFACE_COMPRESSION_EXT")]
        SurfaceCompressionExt = 0x96C0,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
        SurfaceCompressionFixedRateDefaultExt = 0x96C2,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_1BPC_EXT")]
        SurfaceCompressionFixedRate1BpcExt = 0x96C4,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_2BPC_EXT")]
        SurfaceCompressionFixedRate2BpcExt = 0x96C5,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_3BPC_EXT")]
        SurfaceCompressionFixedRate3BpcExt = 0x96C6,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_4BPC_EXT")]
        SurfaceCompressionFixedRate4BpcExt = 0x96C7,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_5BPC_EXT")]
        SurfaceCompressionFixedRate5BpcExt = 0x96C8,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_6BPC_EXT")]
        SurfaceCompressionFixedRate6BpcExt = 0x96C9,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_7BPC_EXT")]
        SurfaceCompressionFixedRate7BpcExt = 0x96CA,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_8BPC_EXT")]
        SurfaceCompressionFixedRate8BpcExt = 0x96CB,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_9BPC_EXT")]
        SurfaceCompressionFixedRate9BpcExt = 0x96CC,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_10BPC_EXT")]
        SurfaceCompressionFixedRate10BpcExt = 0x96CD,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_11BPC_EXT")]
        SurfaceCompressionFixedRate11BpcExt = 0x96CE,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_12BPC_EXT")]
        SurfaceCompressionFixedRate12BpcExt = 0x96CF,
    }
}
