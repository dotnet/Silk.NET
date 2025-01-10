// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC
{
    public uint NodeMask;
    public DXGI_FORMAT InputFormat;
    public D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE BlockSize;
    public D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION Precision;
    public D3D12_VIDEO_SIZE_RANGE SizeRange;
}
