// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TextureEnvMode : uint
{
    Blend = unchecked((uint)0x0BE2),
    Replace = unchecked((uint)0x1E01),
    Add = unchecked((uint)0x0104),
    Modulate = unchecked((uint)0x2100),
    Decal = unchecked((uint)0x2101),
    Combine = unchecked((uint)0x8570),
    ReplaceEXT = unchecked((uint)0x8062),
    TextureEnvBiasSGIX = unchecked((uint)0x80BE),
}
