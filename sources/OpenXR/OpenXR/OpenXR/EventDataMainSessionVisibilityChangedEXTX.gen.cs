// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataMainSessionVisibilityChangedEXTX")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataMainSessionVisibilityChangedEXTX
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public StructureType Type = StructureType.TypeEventDataMainSessionVisibilityChangedEXTX;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public void* Next;

    [NativeName("visible")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public MaybeBool<uint> Visible;

    [NativeName("flags")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public OverlayMainSessionFlagsEXTX Flags;

    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public EventDataMainSessionVisibilityChangedEXTX() { }
}
