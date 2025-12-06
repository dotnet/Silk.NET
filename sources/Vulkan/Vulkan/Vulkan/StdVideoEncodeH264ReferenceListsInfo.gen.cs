// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH264ReferenceListsInfo")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeH264ReferenceListsInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264ReferenceListsInfoFlags Flags;

    [NativeName("num_ref_idx_l0_active_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte NumRefIdxL0ActiveMinus1;

    [NativeName("num_ref_idx_l1_active_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte NumRefIdxL1ActiveMinus1;

    [NativeName("RefPicList0")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264ReferenceListsInfoRefPicList0 RefPicList0;

    [NativeName("RefPicList1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264ReferenceListsInfoRefPicList1 RefPicList1;

    [NativeName("refList0ModOpCount")]
    [SupportedApiProfile("vulkan")]
    public byte RefList0ModOpCount;

    [NativeName("refList1ModOpCount")]
    [SupportedApiProfile("vulkan")]
    public byte RefList1ModOpCount;

    [NativeName("refPicMarkingOpCount")]
    [SupportedApiProfile("vulkan")]
    public byte RefPicMarkingOpCount;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264ReferenceListsInfoReserved1 Reserved1;

    [NativeName("pRefList0ModOperations")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264RefListModEntry* PRefList0ModOperations;

    [NativeName("pRefList1ModOperations")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264RefListModEntry* PRefList1ModOperations;

    [NativeName("pRefPicMarkingOperations")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH264RefPicMarkingEntry* PRefPicMarkingOperations;
}
