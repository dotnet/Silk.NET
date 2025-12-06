// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum CopyImageSubDataTarget : uint
{
    Texture1D = unchecked((uint)0x0DE0),
    Texture2D = unchecked((uint)0x0DE1),
    Texture3D = unchecked((uint)0x806F),
    TextureCubeMap = unchecked((uint)0x8513),
    Texture1DArray = unchecked((uint)0x8C18),
    Texture2DArray = unchecked((uint)0x8C1A),
    Renderbuffer = unchecked((uint)0x8D41),
    TextureRectAngle = unchecked((uint)0x84F5),
    Texture2DMultisample = unchecked((uint)0x9100),
    Texture2DMultisampleArray = unchecked((uint)0x9102),
    TextureCubeMapArray = unchecked((uint)0x9009),
}
