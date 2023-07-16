// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC"]/*'/>
public partial struct D3D12_VIDEO_ENCODER_DESC
{
    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.NodeMask"]/*'/>
    public uint NodeMask;
    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.Flags"]/*'/>
    public D3D12_VIDEO_ENCODER_FLAGS Flags;
    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.EncodeCodec"]/*'/>
    public D3D12_VIDEO_ENCODER_CODEC EncodeCodec;
    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.EncodeProfile"]/*'/>
    public D3D12_VIDEO_ENCODER_PROFILE_DESC EncodeProfile;
    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.InputFormat"]/*'/>
    public DXGI_FORMAT InputFormat;
    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.CodecConfiguration"]/*'/>
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;
    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.MaxMotionEstimationPrecision"]/*'/>
    public D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE MaxMotionEstimationPrecision;
}