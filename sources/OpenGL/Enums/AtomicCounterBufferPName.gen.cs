// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum AtomicCounterBufferPName
{
    Binding = 0x92C1,
    DataSize = 0x92C4,
    ActiveAtomicCounters = 0x92C5,
    ActiveAtomicCounterIndices = 0x92C6,
    ReferencedByVertexShader = 0x92C7,
    ReferencedByTessControlShader = 0x92C8,
    ReferencedByTessEvaluationShader = 0x92C9,
    ReferencedByGeometryShader = 0x92CA,
    ReferencedByFragmentShader = 0x92CB,
    ReferencedByComputeShader = 0x90ED
}
