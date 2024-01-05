// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public enum D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE
{
    /// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE.D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_8X8"]/*'/>

    D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_8X8 = 0,

    /// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE.D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_16X16"]/*'/>

    D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_16X16 = 1,
}
