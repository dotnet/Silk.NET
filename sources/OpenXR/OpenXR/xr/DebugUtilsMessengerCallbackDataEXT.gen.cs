// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrDebugUtilsMessengerCallbackDataEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct DebugUtilsMessengerCallbackDataEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public StructureType Type = StructureType.DebugUtilsMessengerCallbackDataEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public void* Next;

    [NativeName("messageId")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public sbyte* MessageId;

    [NativeName("functionName")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public sbyte* FunctionName;

    [NativeName("message")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public sbyte* Message;

    [NativeName("objectCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public uint ObjectCount;

    [NativeName("objects")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public DebugUtilsObjectNameInfoEXT* Objects;

    [NativeName("sessionLabelCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public uint SessionLabelCount;

    [NativeName("sessionLabels")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public DebugUtilsLabelEXT* SessionLabels;

    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public DebugUtilsMessengerCallbackDataEXT() { }
}
