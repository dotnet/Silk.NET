// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FramebufferParameterName : uint
{
    Width = unchecked((uint)0x9310),
    Height = unchecked((uint)0x9311),
    Layers = unchecked((uint)0x9312),
    Samples = unchecked((uint)0x9313),
    FixedSampleLocations = unchecked((uint)0x9314),
}
