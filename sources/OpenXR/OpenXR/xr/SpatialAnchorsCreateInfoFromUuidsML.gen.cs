// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorsCreateInfoFromUuidsML")]
public unsafe partial struct SpatialAnchorsCreateInfoFromUuidsML
{
    [NativeName("type")]
    public StructureType Type = StructureType.SpatialAnchorsCreateInfoFromUuidsML;

    [NativeName("next")]
    public void* Next;

    [NativeName("storage")]
    public SpatialAnchorsStorageHandleML Storage;

    [NativeName("uuidCount")]
    public uint UuidCount;

    [NativeName("uuids")]
    public Uuid* Uuids;

    public SpatialAnchorsCreateInfoFromUuidsML() { }
}
