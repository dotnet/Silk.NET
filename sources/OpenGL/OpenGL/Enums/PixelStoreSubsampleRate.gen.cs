// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PixelStoreSubsampleRate : uint
{
    Subsample4444Sgix = unchecked((uint)0x85A2),
    Subsample2424Sgix = unchecked((uint)0x85A3),
    Subsample4242Sgix = unchecked((uint)0x85A4),
}
