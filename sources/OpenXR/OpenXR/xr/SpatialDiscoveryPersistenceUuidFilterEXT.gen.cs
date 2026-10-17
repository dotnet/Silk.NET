// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialDiscoveryPersistenceUuidFilterEXT")]
public unsafe partial struct SpatialDiscoveryPersistenceUuidFilterEXT
{
    [NativeName("type")]
    public StructureType Type = StructureType.SpatialDiscoveryPersistenceUuidFilterEXT;

    [NativeName("next")]
    public void* Next;

    [NativeName("persistedUuidCount")]
    public uint PersistedUuidCount;

    [NativeName("persistedUuids")]
    public Uuid* PersistedUuids;

    public SpatialDiscoveryPersistenceUuidFilterEXT() { }
}
