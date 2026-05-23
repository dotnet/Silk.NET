// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH265ReferenceListsInfo")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH265ReferenceListsInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265ReferenceListsInfoFlags Flags;

    [NativeName("num_ref_idx_l0_active_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte NumRefIdxL0ActiveMinus1;

    [NativeName("num_ref_idx_l1_active_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte NumRefIdxL1ActiveMinus1;

    [NativeName("RefPicList0")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265ReferenceListsInfoRefPicList0 RefPicList0;

    [NativeName("RefPicList1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265ReferenceListsInfoRefPicList1 RefPicList1;

    [NativeName("list_entry_l0")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265ReferenceListsInfoListEntryL0 ListEntryL0;

    [NativeName("list_entry_l1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeH265ReferenceListsInfoListEntryL1 ListEntryL1;
}
