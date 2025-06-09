// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using Silk.NET.Core;
global using static Silk.NET.Core.DSL;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct AntiLagDataAMD
{
    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    public void* PNext;

    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    public AntiLagModeAMD Mode;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    public uint MaxFPS;

    [NativeTypeName("const VkAntiLagPresentationInfoAMD *")]
    [SupportedApiProfile("vulkan", ["VK_AMD_anti_lag"])]
    public AntiLagPresentationInfoAMD* PPresentationInfo;
}
