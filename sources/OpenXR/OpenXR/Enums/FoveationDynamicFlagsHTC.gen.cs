// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFoveationDynamicFlagsHTC")]
[Flags]
public enum FoveationDynamicFlagsHTC : ulong
{
    None = 0x0,

    [NativeName("XR_FOVEATION_DYNAMIC_LEVEL_ENABLED_BIT_HTC")]
    LevelEnabledBit = 0x1,

    [NativeName("XR_FOVEATION_DYNAMIC_CLEAR_FOV_ENABLED_BIT_HTC")]
    ClearFovEnabledBit = 0x2,

    [NativeName("XR_FOVEATION_DYNAMIC_FOCAL_CENTER_OFFSET_ENABLED_BIT_HTC")]
    FocalCenterOffsetEnabledBit = 0x4,
}
