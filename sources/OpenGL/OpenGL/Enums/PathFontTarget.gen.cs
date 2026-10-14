// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathFontTarget")]
public enum PathFontTarget : uint
{
    [NativeName("GL_STANDARD_FONT_NAME_NV")]
    StandardFontNameNV = 36978,

    [NativeName("GL_SYSTEM_FONT_NAME_NV")]
    SystemFontNameNV = 36979,

    [NativeName("GL_FILE_NAME_NV")]
    FileNameNV = 36980,
}
