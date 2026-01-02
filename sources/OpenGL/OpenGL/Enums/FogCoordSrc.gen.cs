// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FogCoordSrc : uint
{
    FogCoordinate = unchecked((uint)0x8451),
    FragmentDepth = unchecked((uint)0x8452),
    FogCoord = unchecked((uint)0x8451),
    FogCoordinateEXT = unchecked((uint)0x8451),
    FragmentDepthEXT = unchecked((uint)0x8452),
}
