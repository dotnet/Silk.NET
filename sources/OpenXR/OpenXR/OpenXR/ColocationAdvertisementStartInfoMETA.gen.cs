// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrColocationAdvertisementStartInfoMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ColocationAdvertisementStartInfoMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public StructureType Type = StructureType.TypeColocationAdvertisementStartInfoMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public void* Next;

    [NativeName("bufferSize")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public uint BufferSize;

    [NativeName("buffer")]
    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public byte* Buffer;

    [SupportedApiProfile("openxr", ["XR_META_colocation_discovery"])]
    public ColocationAdvertisementStartInfoMETA() { }
}
