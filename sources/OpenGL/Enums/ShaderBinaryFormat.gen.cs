// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum ShaderBinaryFormat
{
    ShaderBinaryFormatSpirV = 0x9551,
    MaliShaderBinaryARM = 0x8F60,
    ShaderBinaryDMP = 0x9250,
    GccsoShaderBinaryFJ = 0x9260,
    SgxBinaryIMG = 0x8C0A,
    ShaderBinaryVIV = 0x8FC4
}
