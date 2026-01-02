// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TextureGenParameter : uint
{
    TextureGenMode = unchecked((uint)0x2500),
    ObjectPlane = unchecked((uint)0x2501),
    EyePlane = unchecked((uint)0x2502),
    EyePointSGIS = unchecked((uint)0x81F4),
    ObjectPointSGIS = unchecked((uint)0x81F5),
    EyeLineSGIS = unchecked((uint)0x81F6),
    ObjectLineSGIS = unchecked((uint)0x81F7),
    TextureGenModeOES = unchecked((uint)0x2500),
}
