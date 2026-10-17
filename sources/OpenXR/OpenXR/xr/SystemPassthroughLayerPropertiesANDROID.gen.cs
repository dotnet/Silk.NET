// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemPassthroughLayerPropertiesANDROID")]
public unsafe partial struct SystemPassthroughLayerPropertiesANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.SystemPassthroughLayerPropertiesANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("supportsPassthroughLayer")]
    public MaybeBool<uint> SupportsPassthroughLayer;

    [NativeName("maxMeshIndexCount")]
    public uint MaxMeshIndexCount;

    [NativeName("maxMeshVertexCount")]
    public uint MaxMeshVertexCount;

    public SystemPassthroughLayerPropertiesANDROID() { }
}
