// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathFontTarget")]
[Transformed]
public enum PathFontTarget : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_STANDARD_FONT_NAME_NV")]
    StandardFontNamenv = unchecked((uint)0x9072),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SYSTEM_FONT_NAME_NV")]
    SystemFontNamenv = unchecked((uint)0x9073),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FILE_NAME_NV")]
    FileNamenv = unchecked((uint)0x9074),
}
