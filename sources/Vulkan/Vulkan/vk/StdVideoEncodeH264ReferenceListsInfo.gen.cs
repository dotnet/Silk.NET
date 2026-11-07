// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH264ReferenceListsInfo")]
public unsafe partial struct StdVideoEncodeH264ReferenceListsInfo
{
    [NativeName("flags")]
    public StdVideoEncodeH264ReferenceListsInfoFlags Flags;

    [NativeName("num_ref_idx_l0_active_minus1")]
    public byte NumRefIdxL0ActiveMinus1;

    [NativeName("num_ref_idx_l1_active_minus1")]
    public byte NumRefIdxL1ActiveMinus1;

    [NativeName("RefPicList0")]
    public StdVideoEncodeH264ReferenceListsInfoRefPicList0 RefPicList0;

    [NativeName("RefPicList1")]
    public StdVideoEncodeH264ReferenceListsInfoRefPicList1 RefPicList1;

    [NativeName("refList0ModOpCount")]
    public byte RefList0ModOpCount;

    [NativeName("refList1ModOpCount")]
    public byte RefList1ModOpCount;

    [NativeName("refPicMarkingOpCount")]
    public byte RefPicMarkingOpCount;

    [NativeName("reserved1")]
    public StdVideoEncodeH264ReferenceListsInfoReserved1 Reserved1;

    [NativeName("pRefList0ModOperations")]
    public StdVideoEncodeH264RefListModEntry* PRefList0ModOperations;

    [NativeName("pRefList1ModOperations")]
    public StdVideoEncodeH264RefListModEntry* PRefList1ModOperations;

    [NativeName("pRefPicMarkingOperations")]
    public StdVideoEncodeH264RefPicMarkingEntry* PRefPicMarkingOperations;
}
