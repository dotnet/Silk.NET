// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum AtomicCounterBufferPName : uint
{
    Binding = unchecked((uint)0x92C1),
    DataSize = unchecked((uint)0x92C4),
    ActiveAtomicCounters = unchecked((uint)0x92C5),
    ActiveAtomicCounterIndices = unchecked((uint)0x92C6),
    ReferencedByVertexShader = unchecked((uint)0x92C7),
    ReferencedByTessControlShader = unchecked((uint)0x92C8),
    ReferencedByTessEvaluationShader = unchecked((uint)0x92C9),
    ReferencedByGeometryShader = unchecked((uint)0x92CA),
    ReferencedByFragmentShader = unchecked((uint)0x92CB),
    ReferencedByComputeShader = unchecked((uint)0x90ED),
}
