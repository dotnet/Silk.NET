// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.NodeIndex"]/*'/>
    public uint NodeIndex;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.InputFormat"]/*'/>
    public DXGI_FORMAT InputFormat;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.BlockSize"]/*'/>
    public D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE BlockSize;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.Precision"]/*'/>
    public D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION Precision;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.SizeRange"]/*'/>
    public D3D12_VIDEO_SIZE_RANGE SizeRange;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.Protected"]/*'/>
    public BOOL Protected;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.MotionVectorHeapMemoryPoolL0Size"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong MotionVectorHeapMemoryPoolL0Size;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.MotionVectorHeapMemoryPoolL1Size"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong MotionVectorHeapMemoryPoolL1Size;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.MotionEstimatorMemoryPoolL0Size"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong MotionEstimatorMemoryPoolL0Size;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE.MotionEstimatorMemoryPoolL1Size"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong MotionEstimatorMemoryPoolL1Size;
}