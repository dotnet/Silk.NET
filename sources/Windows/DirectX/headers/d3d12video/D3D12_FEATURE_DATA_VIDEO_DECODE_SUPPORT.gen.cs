// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT"]/*'/>
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.NodeIndex"]/*'/>
    public uint NodeIndex;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.Configuration"]/*'/>
    public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.Width"]/*'/>
    public uint Width;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.Height"]/*'/>
    public uint Height;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.DecodeFormat"]/*'/>
    public DXGI_FORMAT DecodeFormat;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.FrameRate"]/*'/>
    public DXGI_RATIONAL FrameRate;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.BitRate"]/*'/>
    public uint BitRate;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.SupportFlags"]/*'/>
    public D3D12_VIDEO_DECODE_SUPPORT_FLAGS SupportFlags;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.ConfigurationFlags"]/*'/>
    public D3D12_VIDEO_DECODE_CONFIGURATION_FLAGS ConfigurationFlags;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT.DecodeTier"]/*'/>
    public D3D12_VIDEO_DECODE_TIER DecodeTier;
}