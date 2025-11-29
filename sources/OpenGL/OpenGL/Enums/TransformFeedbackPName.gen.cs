// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TransformFeedbackPName : uint
{
    BufferStart = unchecked((uint)0x8C84),
    BufferSize = unchecked((uint)0x8C85),
    BufferBinding = unchecked((uint)0x8C8F),
    Active = unchecked((uint)0x8E24),
    Paused = unchecked((uint)0x8E23),
}
