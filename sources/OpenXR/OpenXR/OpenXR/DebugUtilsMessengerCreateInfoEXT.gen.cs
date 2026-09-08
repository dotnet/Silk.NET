// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrDebugUtilsMessengerCreateInfoEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct DebugUtilsMessengerCreateInfoEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public StructureType Type = StructureType.DebugUtilsMessengerCreateInfoEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public void* Next;

    [NativeName("messageSeverities")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public DebugUtilsMessageSeverityFlagsEXT MessageSeverities;

    [NativeName("messageTypes")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public DebugUtilsMessageTypeFlagsEXT MessageTypes;

    [NativeName("userCallback")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public DebugUtilsMessengerCallbackEXT UserCallback;

    [NativeName("userData")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public void* UserData;

    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public DebugUtilsMessengerCreateInfoEXT() { }
}
