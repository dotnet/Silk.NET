// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TransformFeedbackPName : uint
{
    BufferStart = 0x8C84,
    BufferSize = 0x8C85,
    BufferBinding = 0x8C8F,
    Active = 0x8E24,
    Paused = 0x8E23
}
