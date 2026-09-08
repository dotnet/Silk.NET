// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrDebugUtilsObjectNameInfoEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct DebugUtilsObjectNameInfoEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public StructureType Type = StructureType.DebugUtilsObjectNameInfoEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public void* Next;

    [NativeName("objectType")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public ObjectType ObjectType;

    [NativeName("objectHandle")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public ulong ObjectHandle;

    [NativeName("objectName")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public sbyte* ObjectName;

    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public DebugUtilsObjectNameInfoEXT() { }
}
