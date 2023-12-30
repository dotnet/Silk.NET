// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_INPUT.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_INPUT"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12_VIDEO_MOTION_ESTIMATOR_INPUT
{
    /// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_INPUT.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_INPUT.pInputTexture2D"]/*'/>

    public ID3D12Resource* pInputTexture2D;

    /// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_INPUT.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_INPUT.InputSubresourceIndex"]/*'/>

    public uint InputSubresourceIndex;

    /// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_INPUT.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_INPUT.pReferenceTexture2D"]/*'/>

    public ID3D12Resource* pReferenceTexture2D;

    /// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_INPUT.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_INPUT.ReferenceSubresourceIndex"]/*'/>

    public uint ReferenceSubresourceIndex;

    /// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_INPUT.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_INPUT.pHintMotionVectorHeap"]/*'/>

    public ID3D12VideoMotionVectorHeap* pHintMotionVectorHeap;
}
