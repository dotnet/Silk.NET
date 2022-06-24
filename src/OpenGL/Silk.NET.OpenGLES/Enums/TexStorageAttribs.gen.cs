// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TexStorageAttribs")]
    public enum TexStorageAttribs : int
    {
        [Obsolete("Deprecated in favour of \"Ext\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_EXT")]
        SurfaceCompressionExt = 0x96C0,
        [Obsolete("Deprecated in favour of \"FixedRateNoneExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_NONE_EXT")]
        SurfaceCompressionFixedRateNoneExt = 0x96C1,
        [Obsolete("Deprecated in favour of \"FixedRateDefaultExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
        SurfaceCompressionFixedRateDefaultExt = 0x96C2,
        [Obsolete("Deprecated in favour of \"FixedRate1BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_1BPC_EXT")]
        SurfaceCompressionFixedRate1BpcExt = 0x96C4,
        [Obsolete("Deprecated in favour of \"FixedRate2BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_2BPC_EXT")]
        SurfaceCompressionFixedRate2BpcExt = 0x96C5,
        [Obsolete("Deprecated in favour of \"FixedRate3BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_3BPC_EXT")]
        SurfaceCompressionFixedRate3BpcExt = 0x96C6,
        [Obsolete("Deprecated in favour of \"FixedRate4BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_4BPC_EXT")]
        SurfaceCompressionFixedRate4BpcExt = 0x96C7,
        [Obsolete("Deprecated in favour of \"FixedRate5BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_5BPC_EXT")]
        SurfaceCompressionFixedRate5BpcExt = 0x96C8,
        [Obsolete("Deprecated in favour of \"FixedRate6BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_6BPC_EXT")]
        SurfaceCompressionFixedRate6BpcExt = 0x96C9,
        [Obsolete("Deprecated in favour of \"FixedRate7BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_7BPC_EXT")]
        SurfaceCompressionFixedRate7BpcExt = 0x96CA,
        [Obsolete("Deprecated in favour of \"FixedRate8BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_8BPC_EXT")]
        SurfaceCompressionFixedRate8BpcExt = 0x96CB,
        [Obsolete("Deprecated in favour of \"FixedRate9BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_9BPC_EXT")]
        SurfaceCompressionFixedRate9BpcExt = 0x96CC,
        [Obsolete("Deprecated in favour of \"FixedRate10BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_10BPC_EXT")]
        SurfaceCompressionFixedRate10BpcExt = 0x96CD,
        [Obsolete("Deprecated in favour of \"FixedRate11BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_11BPC_EXT")]
        SurfaceCompressionFixedRate11BpcExt = 0x96CE,
        [Obsolete("Deprecated in favour of \"FixedRate12BpcExt\"")]
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_12BPC_EXT")]
        SurfaceCompressionFixedRate12BpcExt = 0x96CF,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_EXT")]
        Ext = 0x96C0,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_NONE_EXT")]
        FixedRateNoneExt = 0x96C1,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
        FixedRateDefaultExt = 0x96C2,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_1BPC_EXT")]
        FixedRate1BpcExt = 0x96C4,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_2BPC_EXT")]
        FixedRate2BpcExt = 0x96C5,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_3BPC_EXT")]
        FixedRate3BpcExt = 0x96C6,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_4BPC_EXT")]
        FixedRate4BpcExt = 0x96C7,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_5BPC_EXT")]
        FixedRate5BpcExt = 0x96C8,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_6BPC_EXT")]
        FixedRate6BpcExt = 0x96C9,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_7BPC_EXT")]
        FixedRate7BpcExt = 0x96CA,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_8BPC_EXT")]
        FixedRate8BpcExt = 0x96CB,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_9BPC_EXT")]
        FixedRate9BpcExt = 0x96CC,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_10BPC_EXT")]
        FixedRate10BpcExt = 0x96CD,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_11BPC_EXT")]
        FixedRate11BpcExt = 0x96CE,
        [NativeName("Name", "GL_SURFACE_COMPRESSION_FIXED_RATE_12BPC_EXT")]
        FixedRate12BpcExt = 0x96CF,
    }
}
