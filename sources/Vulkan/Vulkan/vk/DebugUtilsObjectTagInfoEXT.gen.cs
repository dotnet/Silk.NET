// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugUtilsObjectTagInfoEXT")]
public unsafe partial struct DebugUtilsObjectTagInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DebugUtilsObjectTagInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("objectType")]
    public ObjectType ObjectType;

    [NativeName("objectHandle")]
    public ulong ObjectHandle;

    [NativeName("tagName")]
    public ulong TagName;

    [NativeName("tagSize")]
    public nuint TagSize;

    [NativeName("pTag")]
    public void* PTag;

    public DebugUtilsObjectTagInfoEXT() { }
}
