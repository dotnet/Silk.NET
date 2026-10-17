// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneMeshIndicesUint16MSFT")]
public unsafe partial struct SceneMeshIndicesUint16MSFT
{
    [NativeName("type")]
    public StructureType Type = StructureType.SceneMeshIndicesUint16MSFT;

    [NativeName("next")]
    public void* Next;

    [NativeName("indexCapacityInput")]
    public uint IndexCapacityInput;

    [NativeName("indexCountOutput")]
    public uint IndexCountOutput;

    [NativeName("indices")]
    public ushort* Indices;

    public SceneMeshIndicesUint16MSFT() { }
}
