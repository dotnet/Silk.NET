// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.Versioning;
using static TerraFX.Interop.DirectX.D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS"]/*'/>
[Flags]
[SupportedOSPlatform("windows10.0.19041.0")]
public enum D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS
{
    /// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS.D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_NONE"]/*'/>
    D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_NONE = 0,
    /// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS.D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_QUARTER_PEL"]/*'/>
    D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAG_QUARTER_PEL = (1 << D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_QUARTER_PEL),
}