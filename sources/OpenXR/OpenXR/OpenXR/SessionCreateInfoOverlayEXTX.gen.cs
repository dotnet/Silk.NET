// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSessionCreateInfoOverlayEXTX")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SessionCreateInfoOverlayEXTX
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public StructureType Type = StructureType.TypeSessionCreateInfoOverlayEXTX;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public void* Next;

    [NativeName("createFlags")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public OverlaySessionCreateFlagsEXTX CreateFlags;

    [NativeName("sessionLayersPlacement")]
    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public uint SessionLayersPlacement;

    [SupportedApiProfile("openxr", ["XR_EXTX_overlay"])]
    public SessionCreateInfoOverlayEXTX() { }
}
