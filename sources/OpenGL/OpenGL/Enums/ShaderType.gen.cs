// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ShaderType : uint
{
    FragmentShader = unchecked((uint)0x8B30),
    VertexShader = unchecked((uint)0x8B31),
    GeometryShader = unchecked((uint)0x8DD9),
    TessEvaluationShader = unchecked((uint)0x8E87),
    TessControlShader = unchecked((uint)0x8E88),
    ComputeShader = unchecked((uint)0x91B9),
    FragmentShaderARB = unchecked((uint)0x8B30),
    VertexShaderARB = unchecked((uint)0x8B31),
}
