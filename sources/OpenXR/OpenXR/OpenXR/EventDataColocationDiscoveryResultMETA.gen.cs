// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataColocationDiscoveryResultMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataColocationDiscoveryResultMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public StructureType Type = StructureType.TypeEventDataColocationDiscoveryResultMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public void* Next;

    [NativeName("discoveryRequestId")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public ulong DiscoveryRequestId;

    [NativeName("advertisementUuid")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public Uuid AdvertisementUuid;

    [NativeName("bufferSize")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public uint BufferSize;

    [NativeName("buffer")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public EventDataColocationDiscoveryResultMETABuffer Buffer;

    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public EventDataColocationDiscoveryResultMETA() { }
}
