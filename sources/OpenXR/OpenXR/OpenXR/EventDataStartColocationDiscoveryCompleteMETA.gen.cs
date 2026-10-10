// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataStartColocationDiscoveryCompleteMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataStartColocationDiscoveryCompleteMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public StructureType Type = StructureType.EventDataStartColocationDiscoveryCompleteMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public void* Next;

    [NativeName("discoveryRequestId")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public ulong DiscoveryRequestId;

    [NativeName("result")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public Result Result;

    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public EventDataStartColocationDiscoveryCompleteMETA() { }
}
