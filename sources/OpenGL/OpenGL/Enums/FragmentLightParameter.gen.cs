// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FragmentLightParameter : uint
{
    Ambient = unchecked((uint)0x1200),
    Diffuse = unchecked((uint)0x1201),
    Specular = unchecked((uint)0x1202),
    Position = unchecked((uint)0x1203),
    SpotDirection = unchecked((uint)0x1204),
    SpotExponent = unchecked((uint)0x1205),
    SpotCutoff = unchecked((uint)0x1206),
    ConstantAttenuation = unchecked((uint)0x1207),
    LinearAttenuation = unchecked((uint)0x1208),
    QuadraticAttenuation = unchecked((uint)0x1209),
}
