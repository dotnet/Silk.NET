// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
[Flags]
public enum UseProgramStageMask : uint
{
    VertexShaderBit = unchecked((uint)0x00000001),
    FragmentShaderBit = unchecked((uint)0x00000002),
    GeometryShaderBit = unchecked((uint)0x00000004),
    TessControlShaderBit = unchecked((uint)0x00000008),
    TessEvaluationShaderBit = unchecked((uint)0x00000010),
    AllShaderBits = unchecked((uint)0xFFFFFFFF),
    ComputeShaderBit = unchecked((uint)0x00000020),
    MeshShaderBitNV = unchecked((uint)0x00000040),
    TaskShaderBitNV = unchecked((uint)0x00000080),
    GeometryShaderBitOES = unchecked((uint)0x00000004),
    TessControlShaderBitOES = unchecked((uint)0x00000008),
    TessEvaluationShaderBitOES = unchecked((uint)0x00000010),
    GeometryShaderBitEXT = unchecked((uint)0x00000004),
    VertexShaderBitEXT = unchecked((uint)0x00000001),
    FragmentShaderBitEXT = unchecked((uint)0x00000002),
    AllShaderBitsEXT = unchecked((uint)0xFFFFFFFF),
    TessControlShaderBitEXT = unchecked((uint)0x00000008),
    TessEvaluationShaderBitEXT = unchecked((uint)0x00000010),
}
