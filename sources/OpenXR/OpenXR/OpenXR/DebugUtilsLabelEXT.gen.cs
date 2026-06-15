// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrDebugUtilsLabelEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct DebugUtilsLabelEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public StructureType Type = StructureType.TypeDebugUtilsLabelEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public void* Next;

    [NativeName("labelName")]
    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public sbyte* LabelName;

    [SupportedApiProfile("openxr", ["XR_EXT_debug_utils"])]
    public DebugUtilsLabelEXT() { }
}
