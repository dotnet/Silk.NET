// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDrmPropertiesEXT")]
public unsafe partial struct PhysicalDeviceDrmPropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDrmPropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("hasPrimary")]
    public MaybeBool<uint> HasPrimary;

    [NativeName("hasRender")]
    public MaybeBool<uint> HasRender;

    [NativeName("primaryMajor")]
    public long PrimaryMajor;

    [NativeName("primaryMinor")]
    public long PrimaryMinor;

    [NativeName("renderMajor")]
    public long RenderMajor;

    [NativeName("renderMinor")]
    public long RenderMinor;

    public PhysicalDeviceDrmPropertiesEXT() { }
}
