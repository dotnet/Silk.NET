// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[InlineArray(15 * 2)]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH265WeightTableDeltaChromaWeightL0
{
    [SupportedApiProfile("vulkan")]
    public sbyte E0X0;
}
