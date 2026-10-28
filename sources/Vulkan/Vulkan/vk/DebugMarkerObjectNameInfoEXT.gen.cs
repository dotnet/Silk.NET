// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugMarkerObjectNameInfoEXT")]
public unsafe partial struct DebugMarkerObjectNameInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DebugMarkerObjectNameInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("objectType")]
    public DebugReportObjectTypeEXT ObjectType;

    [NativeName("@object")]
    public ulong @object;

    [NativeName("pObjectName")]
    public sbyte* PObjectName;

    public DebugMarkerObjectNameInfoEXT() { }
}
