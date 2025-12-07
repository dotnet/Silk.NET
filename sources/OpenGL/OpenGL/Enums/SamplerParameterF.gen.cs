// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum SamplerParameterF : uint
{
    BorderColor = unchecked((uint)0x1004),
    MinLod = unchecked((uint)0x813A),
    MaxLod = unchecked((uint)0x813B),
    LodBias = unchecked((uint)0x8501),
    MaxAnisotropy = unchecked((uint)0x84FE),
    UnnormalizedCoordinatesARM = unchecked((uint)0x8F6A),
}
