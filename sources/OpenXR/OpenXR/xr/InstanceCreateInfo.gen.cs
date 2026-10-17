// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrInstanceCreateInfo")]
public unsafe partial struct InstanceCreateInfo
{
    [NativeName("type")]
    public StructureType Type = StructureType.InstanceCreateInfo;

    [NativeName("next")]
    public void* Next;

    [NativeName("createFlags")]
    public InstanceCreateFlags CreateFlags;

    [NativeName("applicationInfo")]
    public ApplicationInfo ApplicationInfo;

    [NativeName("enabledApiLayerCount")]
    public uint EnabledApiLayerCount;

    [NativeName("enabledApiLayerNames")]
    public sbyte** EnabledApiLayerNames;

    [NativeName("enabledExtensionCount")]
    public uint EnabledExtensionCount;

    [NativeName("enabledExtensionNames")]
    public sbyte** EnabledExtensionNames;

    public InstanceCreateInfo() { }
}
