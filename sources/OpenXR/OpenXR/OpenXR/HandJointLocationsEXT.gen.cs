// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandJointLocationsEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HandJointLocationsEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public StructureType Type = StructureType.HandJointLocationsEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public void* Next;

    [NativeName("isActive")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public MaybeBool<uint> IsActive;

    [NativeName("jointCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public uint JointCount;

    [NativeName("jointLocations")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public HandJointLocationEXT* JointLocations;

    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    public HandJointLocationsEXT() { }
}
