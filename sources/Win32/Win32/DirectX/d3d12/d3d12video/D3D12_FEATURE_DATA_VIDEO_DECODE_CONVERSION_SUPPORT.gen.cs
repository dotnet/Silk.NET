// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT
{
    public uint NodeIndex;
    public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
    public D3D12_VIDEO_SAMPLE DecodeSample;
    public D3D12_VIDEO_FORMAT OutputFormat;
    public DXGI_RATIONAL FrameRate;
    public uint BitRate;
    public D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAGS SupportFlags;
    public D3D12_VIDEO_SCALE_SUPPORT ScaleSupport;
}
