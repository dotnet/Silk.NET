// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrActiveActionSetPriorityEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ActiveActionSetPriorityEXT
{
    [NativeName("actionSet")]
    [SupportedApiProfile("openxr", ["XR_EXT_active_action_set_priority"])]
    public ActionSetHandle ActionSet;

    [NativeName("priorityOverride")]
    [SupportedApiProfile("openxr", ["XR_EXT_active_action_set_priority"])]
    public uint PriorityOverride;
}
