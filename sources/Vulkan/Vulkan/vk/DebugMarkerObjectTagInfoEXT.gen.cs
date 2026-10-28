// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugMarkerObjectTagInfoEXT")]
public unsafe partial struct DebugMarkerObjectTagInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DebugMarkerObjectTagInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("objectType")]
    public DebugReportObjectTypeEXT ObjectType;

    [NativeName("@object")]
    public ulong @object;

    [NativeName("tagName")]
    public ulong TagName;

    [NativeName("tagSize")]
    public nuint TagSize;

    [NativeName("pTag")]
    public void* PTag;

    public DebugMarkerObjectTagInfoEXT() { }
}
