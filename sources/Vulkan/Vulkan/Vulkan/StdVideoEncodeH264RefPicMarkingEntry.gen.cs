// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH264RefPicMarkingEntry
{
    [SupportedApiProfile("vulkan")]
    public StdVideoH264MemMgmtControlOp MemoryManagementControlOperation;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort DifferenceOfPicNumsMinus1;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort LongTermPicNum;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort LongTermFrameIdx;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort MaxLongTermFrameIdxPlus1;
}
