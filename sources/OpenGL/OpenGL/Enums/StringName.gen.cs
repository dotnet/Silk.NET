// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum StringName : uint
{
    Vendor = unchecked((uint)0x1F00),
    Renderer = unchecked((uint)0x1F01),
    Version = unchecked((uint)0x1F02),
    Extensions = unchecked((uint)0x1F03),
    ShadingLanguageVersion = unchecked((uint)0x8B8C),
}
