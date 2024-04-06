// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum UseProgramStageMask
{
    VertexShaderBit = 0x00000001,
    FragmentShaderBit = 0x00000002,
    GeometryShaderBit = 0x00000004,
    TessControlShaderBit = 0x00000008,
    TessEvaluationShaderBit = 0x00000010,
    AllShaderBits = 0xFFFFFFFF,
    ComputeShaderBit = 0x00000020,
    MeshShaderBitNV = 0x00000040,
    TaskShaderBitNV = 0x00000080,
    GeometryShaderBitOES = 0x00000004,
    TessControlShaderBitOES = 0x00000008,
    TessEvaluationShaderBitOES = 0x00000010,
    GeometryShaderBitEXT = 0x00000004,
    VertexShaderBitEXT = 0x00000001,
    FragmentShaderBitEXT = 0x00000002,
    AllShaderBitsEXT = 0xFFFFFFFF,
    TessControlShaderBitEXT = 0x00000008,
    TessEvaluationShaderBitEXT = 0x00000010
}
