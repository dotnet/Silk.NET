// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP"]/*'/>
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.ConstantQP_FullIntracodedFrame"]/*'/>

    public uint ConstantQP_FullIntracodedFrame;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.ConstantQP_InterPredictedFrame_PrevRefOnly"]/*'/>

    public uint ConstantQP_InterPredictedFrame_PrevRefOnly;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP.ConstantQP_InterPredictedFrame_BiDirectionalRef"]/*'/>

    public uint ConstantQP_InterPredictedFrame_BiDirectionalRef;
}
