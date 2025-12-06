// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum LightModelColorControl : uint
{
    SingleColor = unchecked((uint)0x81F9),
    SeparateSpecularColor = unchecked((uint)0x81FA),
    SingleColorEXT = unchecked((uint)0x81F9),
    SeparateSpecularColorEXT = unchecked((uint)0x81FA),
}
