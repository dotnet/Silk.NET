// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemAnchorPropertiesHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemAnchorPropertiesHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public StructureType Type = StructureType.SystemAnchorPropertiesHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public void* Next;

    [NativeName("supportsAnchor")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public MaybeBool<uint> SupportsAnchor;

    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public SystemAnchorPropertiesHTC() { }
}
