// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkApplicationInfo")]
public unsafe partial struct ApplicationInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ApplicationInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("pApplicationName")]
    public sbyte* PApplicationName;

    [NativeName("applicationVersion")]
    public uint ApplicationVersion;

    [NativeName("pEngineName")]
    public sbyte* PEngineName;

    [NativeName("engineVersion")]
    public uint EngineVersion;

    [NativeName("apiVersion")]
    public uint ApiVersion;

    public ApplicationInfo() { }
}
