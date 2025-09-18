// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH264WeightTableFlags
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint LumaWeightL0Flag;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ChromaWeightL0Flag;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint LumaWeightL1Flag;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ChromaWeightL1Flag;
}
