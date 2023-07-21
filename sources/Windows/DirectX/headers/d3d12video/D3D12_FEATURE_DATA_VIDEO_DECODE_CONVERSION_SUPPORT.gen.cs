// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.Configuration"]/*' />
    public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.DecodeSample"]/*' />
    public D3D12_VIDEO_SAMPLE DecodeSample;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.OutputFormat"]/*' />
    public D3D12_VIDEO_FORMAT OutputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.FrameRate"]/*' />
    public DXGI_RATIONAL FrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.BitRate"]/*' />
    public uint BitRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.SupportFlags"]/*' />
    public D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAGS SupportFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT.ScaleSupport"]/*' />
    public D3D12_VIDEO_SCALE_SUPPORT ScaleSupport;
}
