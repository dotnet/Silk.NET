// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC1
{
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS SupportFlags;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MinLumaCodingUnitSize;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MaxLumaCodingUnitSize;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MinLumaTransformUnitSize;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MaxLumaTransformUnitSize;

    [NativeTypeName("UCHAR")]
    public byte max_transform_hierarchy_depth_inter;

    [NativeTypeName("UCHAR")]
    public byte max_transform_hierarchy_depth_intra;
    public uint allowed_diff_cu_chroma_qp_offset_depth_values;
    public uint allowed_log2_sao_offset_scale_luma_values;
    public uint allowed_log2_sao_offset_scale_chroma_values;
    public uint allowed_log2_max_transform_skip_block_size_minus2_values;
    public uint allowed_chroma_qp_offset_list_len_minus1_values;

    [NativeTypeName("UINT[6]")]
    public _allowed_cb_qp_offset_list_values_e__FixedBuffer allowed_cb_qp_offset_list_values;

    [NativeTypeName("UINT[6]")]
    public _allowed_cr_qp_offset_list_values_e__FixedBuffer allowed_cr_qp_offset_list_values;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS1 SupportFlags1;

    [InlineArray(6)]
    public partial struct _allowed_cb_qp_offset_list_values_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(6)]
    public partial struct _allowed_cr_qp_offset_list_values_e__FixedBuffer
    {
        public uint e0;
    }
}
