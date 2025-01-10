// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG
{
    [NativeTypeName("UINT64")]
    public ulong UpdateMap;

    [NativeTypeName("UINT64")]
    public ulong TemporalUpdate;

    [NativeTypeName("UINT64")]
    public ulong UpdateData;

    [NativeTypeName("UINT64")]
    public ulong NumSegments;

    [NativeTypeName("D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA[8]")]
    public _SegmentsData_e__FixedBuffer SegmentsData;

    [InlineArray(8)]
    public partial struct _SegmentsData_e__FixedBuffer
    {
        public D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA e0;
    }
}
