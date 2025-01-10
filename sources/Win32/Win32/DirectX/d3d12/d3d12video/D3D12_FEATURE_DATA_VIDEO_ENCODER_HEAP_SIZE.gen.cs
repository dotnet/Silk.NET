// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_HEAP_SIZE
{
    public D3D12_VIDEO_ENCODER_HEAP_DESC HeapDesc;
    public BOOL IsSupported;

    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL0Size;

    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL1Size;
}
