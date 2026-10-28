// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeH264RefListModEntry")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeH264RefListModEntry
{
    [NativeName("modification_of_pic_nums_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264ModificationOfPicNumsIdc ModificationOfPicNumsIdc;

    [NativeName("abs_diff_pic_num_minus1")]
    [SupportedApiProfile("vulkan")]
    public ushort AbsDiffPicNumMinus1;

    [NativeName("long_term_pic_num")]
    [SupportedApiProfile("vulkan")]
    public ushort LongTermPicNum;
}
