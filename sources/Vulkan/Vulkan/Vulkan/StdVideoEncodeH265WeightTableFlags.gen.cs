// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH265WeightTableFlags
{
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort LumaWeightL0Flag;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort ChromaWeightL0Flag;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort LumaWeightL1Flag;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort ChromaWeightL1Flag;
}
