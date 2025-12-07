// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum LightModelParameter : uint
{
    LocalViewer = unchecked((uint)0x0B51),
    TwoSide = unchecked((uint)0x0B52),
    Ambient = unchecked((uint)0x0B53),
    ColorControl = unchecked((uint)0x81F8),
    ColorControlEXT = unchecked((uint)0x81F8),
}
