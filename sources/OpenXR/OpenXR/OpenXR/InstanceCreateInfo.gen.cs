// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrInstanceCreateInfo")]
[SupportedApiProfile("openxr")]
public unsafe partial struct InstanceCreateInfo
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.TypeInstanceCreateInfo;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("createFlags")]
    [SupportedApiProfile("openxr")]
    public InstanceCreateFlags CreateFlags;

    [NativeName("applicationInfo")]
    [SupportedApiProfile("openxr")]
    public ApplicationInfo ApplicationInfo;

    [NativeName("enabledApiLayerCount")]
    [SupportedApiProfile("openxr")]
    public uint EnabledApiLayerCount;

    [NativeName("enabledApiLayerNames")]
    [SupportedApiProfile("openxr")]
    public sbyte** EnabledApiLayerNames;

    [NativeName("enabledExtensionCount")]
    [SupportedApiProfile("openxr")]
    public uint EnabledExtensionCount;

    [NativeName("enabledExtensionNames")]
    [SupportedApiProfile("openxr")]
    public sbyte** EnabledExtensionNames;

    [SupportedApiProfile("openxr")]
    public InstanceCreateInfo() { }
}
