// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataStartColocationAdvertisementCompleteMETA")]
public unsafe partial struct EventDataStartColocationAdvertisementCompleteMETA
{
    [NativeName("type")]
    public StructureType Type = StructureType.EventDataStartColocationAdvertisementCompleteMETA;

    [NativeName("next")]
    public void* Next;

    [NativeName("advertisementRequestId")]
    public ulong AdvertisementRequestId;

    [NativeName("result")]
    public Result Result;

    [NativeName("advertisementUuid")]
    public Uuid AdvertisementUuid;

    public EventDataStartColocationAdvertisementCompleteMETA() { }
}
