// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TexStorageAttribs")]
public enum TexStorageAttribs : uint
{
    [NativeName("GL_SURFACE_COMPRESSION_EXT")]
    SurfaceCompressionEXT = unchecked((uint)0x96C0),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_NONE_EXT")]
    SurfaceCompressionFixedRateNoneEXT = unchecked((uint)0x96C1),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
    SurfaceCompressionFixedRateDefaultEXT = unchecked((uint)0x96C2),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_1BPC_EXT")]
    SurfaceCompressionFixedRate1BpcEXT = unchecked((uint)0x96C4),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_2BPC_EXT")]
    SurfaceCompressionFixedRate2BpcEXT = unchecked((uint)0x96C5),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_3BPC_EXT")]
    SurfaceCompressionFixedRate3BpcEXT = unchecked((uint)0x96C6),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_4BPC_EXT")]
    SurfaceCompressionFixedRate4BpcEXT = unchecked((uint)0x96C7),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_5BPC_EXT")]
    SurfaceCompressionFixedRate5BpcEXT = unchecked((uint)0x96C8),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_6BPC_EXT")]
    SurfaceCompressionFixedRate6BpcEXT = unchecked((uint)0x96C9),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_7BPC_EXT")]
    SurfaceCompressionFixedRate7BpcEXT = unchecked((uint)0x96CA),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_8BPC_EXT")]
    SurfaceCompressionFixedRate8BpcEXT = unchecked((uint)0x96CB),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_9BPC_EXT")]
    SurfaceCompressionFixedRate9BpcEXT = unchecked((uint)0x96CC),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_10BPC_EXT")]
    SurfaceCompressionFixedRate10BpcEXT = unchecked((uint)0x96CD),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_11BPC_EXT")]
    SurfaceCompressionFixedRate11BpcEXT = unchecked((uint)0x96CE),

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_12BPC_EXT")]
    SurfaceCompressionFixedRate12BpcEXT = unchecked((uint)0x96CF),
}
