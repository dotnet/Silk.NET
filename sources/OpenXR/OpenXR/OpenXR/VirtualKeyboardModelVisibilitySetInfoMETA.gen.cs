// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVirtualKeyboardModelVisibilitySetInfoMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct VirtualKeyboardModelVisibilitySetInfoMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public StructureType Type = StructureType.TypeVirtualKeyboardModelVisibilitySetInfoMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public void* Next;

    [NativeName("visible")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public MaybeBool<uint> Visible;

    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public VirtualKeyboardModelVisibilitySetInfoMETA() { }
}
