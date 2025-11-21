// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ShaderBinaryFormat : uint
{
    ShaderBinaryFormatSpirV = unchecked((uint)0x9551),
    MaliShaderBinaryARM = unchecked((uint)0x8F60),
    ShaderBinaryDMP = unchecked((uint)0x9250),
    GccsoShaderBinaryFJ = unchecked((uint)0x9260),
    SgxBinaryIMG = unchecked((uint)0x8C0A),
    ShaderBinaryVIV = unchecked((uint)0x8FC4),
}
