// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandTrackerCreateInfoEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HandTrackerCreateInfoEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public StructureType Type = StructureType.TypeHandTrackerCreateInfoEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public void* Next;

    [NativeName("hand")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public HandEXT Hand;

    [NativeName("handJointSet")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public HandJointSetEXT HandJointSet;

    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public HandTrackerCreateInfoEXT() { }
}
