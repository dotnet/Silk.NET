// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum LightTextureMode : uint
{
    Depth = unchecked((uint)0x8452),
    DepthEXT = unchecked((uint)0x8452),
    MaterialEXT = unchecked((uint)0x8349),
    NormalEXT = unchecked((uint)0x834A),
    ColorEXT = unchecked((uint)0x834C),
}
