// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum CombinerStageNV : uint
{
    Combiner0 = unchecked((uint)0x8550),
    Combiner1 = unchecked((uint)0x8551),
    Combiner2 = unchecked((uint)0x8552),
    Combiner3 = unchecked((uint)0x8553),
    Combiner4 = unchecked((uint)0x8554),
    Combiner5 = unchecked((uint)0x8555),
    Combiner6 = unchecked((uint)0x8556),
    Combiner7 = unchecked((uint)0x8557),
}
