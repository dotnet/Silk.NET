// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264PictureParameterSet")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH264PictureParameterSet
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264PpsFlags Flags;

    [NativeName("seq_parameter_set_id")]
    [SupportedApiProfile("vulkan")]
    public byte SeqParameterSetId;

    [NativeName("pic_parameter_set_id")]
    [SupportedApiProfile("vulkan")]
    public byte PicParameterSetId;

    [NativeName("num_ref_idx_l0_default_active_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte NumRefIdxL0DefaultActiveMinus1;

    [NativeName("num_ref_idx_l1_default_active_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte NumRefIdxL1DefaultActiveMinus1;

    [NativeName("weighted_bipred_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264WeightedBipredIdc WeightedBipredIdc;

    [NativeName("pic_init_qp_minus26")]
    [SupportedApiProfile("vulkan")]
    public sbyte PicInitQpMinus26;

    [NativeName("pic_init_qs_minus26")]
    [SupportedApiProfile("vulkan")]
    public sbyte PicInitQsMinus26;

    [NativeName("chroma_qp_index_offset")]
    [SupportedApiProfile("vulkan")]
    public sbyte ChromaQpIndexOffset;

    [NativeName("second_chroma_qp_index_offset")]
    [SupportedApiProfile("vulkan")]
    public sbyte SecondChromaQpIndexOffset;

    [NativeName("pScalingLists")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264ScalingLists* PScalingLists;
}
