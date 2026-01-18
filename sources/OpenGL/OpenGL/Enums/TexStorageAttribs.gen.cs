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
    SurfaceCompressionEXT = 38592,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_NONE_EXT")]
    SurfaceCompressionFixedRateNoneEXT = 38593,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
    SurfaceCompressionFixedRateDefaultEXT = 38594,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_1BPC_EXT")]
    SurfaceCompressionFixedRate1BpcEXT = 38596,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_2BPC_EXT")]
    SurfaceCompressionFixedRate2BpcEXT = 38597,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_3BPC_EXT")]
    SurfaceCompressionFixedRate3BpcEXT = 38598,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_4BPC_EXT")]
    SurfaceCompressionFixedRate4BpcEXT = 38599,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_5BPC_EXT")]
    SurfaceCompressionFixedRate5BpcEXT = 38600,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_6BPC_EXT")]
    SurfaceCompressionFixedRate6BpcEXT = 38601,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_7BPC_EXT")]
    SurfaceCompressionFixedRate7BpcEXT = 38602,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_8BPC_EXT")]
    SurfaceCompressionFixedRate8BpcEXT = 38603,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_9BPC_EXT")]
    SurfaceCompressionFixedRate9BpcEXT = 38604,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_10BPC_EXT")]
    SurfaceCompressionFixedRate10BpcEXT = 38605,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_11BPC_EXT")]
    SurfaceCompressionFixedRate11BpcEXT = 38606,

    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_12BPC_EXT")]
    SurfaceCompressionFixedRate12BpcEXT = 38607,
}
