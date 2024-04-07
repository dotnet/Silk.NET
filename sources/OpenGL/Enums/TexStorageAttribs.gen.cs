// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TexStorageAttribs : uint
{
    SurfaceCompressionEXT = 0x96C0,
    SurfaceCompressionFixedRateNoneEXT = 0x96C1,
    SurfaceCompressionFixedRateDefaultEXT = 0x96C2,
    SurfaceCompressionFixedRate1BpcEXT = 0x96C4,
    SurfaceCompressionFixedRate2BpcEXT = 0x96C5,
    SurfaceCompressionFixedRate3BpcEXT = 0x96C6,
    SurfaceCompressionFixedRate4BpcEXT = 0x96C7,
    SurfaceCompressionFixedRate5BpcEXT = 0x96C8,
    SurfaceCompressionFixedRate6BpcEXT = 0x96C9,
    SurfaceCompressionFixedRate7BpcEXT = 0x96CA,
    SurfaceCompressionFixedRate8BpcEXT = 0x96CB,
    SurfaceCompressionFixedRate9BpcEXT = 0x96CC,
    SurfaceCompressionFixedRate10BpcEXT = 0x96CD,
    SurfaceCompressionFixedRate11BpcEXT = 0x96CE,
    SurfaceCompressionFixedRate12BpcEXT = 0x96CF
}
