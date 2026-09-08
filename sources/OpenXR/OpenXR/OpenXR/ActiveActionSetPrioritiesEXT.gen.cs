// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrActiveActionSetPrioritiesEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ActiveActionSetPrioritiesEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_active_action_set_priority"])]
    public StructureType Type = StructureType.ActiveActionSetPrioritiesEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_active_action_set_priority"])]
    public void* Next;

    [NativeName("actionSetPriorityCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_active_action_set_priority"])]
    public uint ActionSetPriorityCount;

    [NativeName("actionSetPriorities")]
    [SupportedApiProfile("openxr", ["XR_EXT_active_action_set_priority"])]
    public ActiveActionSetPriorityEXT* ActionSetPriorities;

    [SupportedApiProfile("openxr", ["XR_EXT_active_action_set_priority"])]
    public ActiveActionSetPrioritiesEXT() { }
}
