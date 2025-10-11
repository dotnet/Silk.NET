// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TextureMinFilter : uint
{
    Nearest = unchecked((uint)0x2600),
    Linear = unchecked((uint)0x2601),
    NearestMipmapNearest = unchecked((uint)0x2700),
    LinearMipmapNearest = unchecked((uint)0x2701),
    NearestMipmapLinear = unchecked((uint)0x2702),
    LinearMipmapLinear = unchecked((uint)0x2703),
    Filter4Sgis = unchecked((uint)0x8146),
    LinearClipmapLinearSGIX = unchecked((uint)0x8170),
    NearestClipmapNearestSGIX = unchecked((uint)0x844D),
    NearestClipmapLinearSGIX = unchecked((uint)0x844E),
    LinearClipmapNearestSGIX = unchecked((uint)0x844F),
}
