// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHolographicWindowAttachmentMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HolographicWindowAttachmentMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_holographic_window_attachment"])]
    public StructureType Type = StructureType.HolographicWindowAttachmentMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_holographic_window_attachment"])]
    public void* Next;

    [NativeName("holographicSpace")]
    [SupportedApiProfile("openxr", ["XR_MSFT_holographic_window_attachment"])]
    public IUnknownHandle HolographicSpace;

    [NativeName("coreWindow")]
    [SupportedApiProfile("openxr", ["XR_MSFT_holographic_window_attachment"])]
    public IUnknownHandle CoreWindow;

    [SupportedApiProfile("openxr", ["XR_MSFT_holographic_window_attachment"])]
    public HolographicWindowAttachmentMSFT() { }
}
