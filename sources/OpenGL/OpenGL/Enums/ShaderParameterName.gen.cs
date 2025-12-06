// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ShaderParameterName : uint
{
    ShaderType = unchecked((uint)0x8B4F),
    DeleteStatus = unchecked((uint)0x8B80),
    CompileStatus = unchecked((uint)0x8B81),
    InfoLogLength = unchecked((uint)0x8B84),
    ShaderSourceLength = unchecked((uint)0x8B88),
}
