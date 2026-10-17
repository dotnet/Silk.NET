// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRoomLayoutFB")]
public unsafe partial struct RoomLayoutFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.RoomLayoutFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("floorUuid")]
    public Uuid FloorUuid;

    [NativeName("ceilingUuid")]
    public Uuid CeilingUuid;

    [NativeName("wallUuidCapacityInput")]
    public uint WallUuidCapacityInput;

    [NativeName("wallUuidCountOutput")]
    public uint WallUuidCountOutput;

    [NativeName("wallUuids")]
    public Uuid* WallUuids;

    public RoomLayoutFB() { }
}
