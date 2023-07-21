// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS"]/*' />
public partial struct D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS
{
    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.AverageQP"]/*' />
    [NativeTypeName("UINT64")]
    public ulong AverageQP;

    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.IntraCodingUnitsCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong IntraCodingUnitsCount;

    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.InterCodingUnitsCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong InterCodingUnitsCount;

    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.SkipCodingUnitsCount"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SkipCodingUnitsCount;

    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.AverageMotionEstimationXDirection"]/*' />
    [NativeTypeName("UINT64")]
    public ulong AverageMotionEstimationXDirection;

    /// <include file='D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS.AverageMotionEstimationYDirection"]/*' />
    [NativeTypeName("UINT64")]
    public ulong AverageMotionEstimationYDirection;
}
