// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FeedbackType : uint
{
    X2D = unchecked((uint)0x0600),
    X3D = unchecked((uint)0x0601),
    X3DColor = unchecked((uint)0x0602),
    X3DColorTexture = unchecked((uint)0x0603),
    X4DColorTexture = unchecked((uint)0x0604),
}
