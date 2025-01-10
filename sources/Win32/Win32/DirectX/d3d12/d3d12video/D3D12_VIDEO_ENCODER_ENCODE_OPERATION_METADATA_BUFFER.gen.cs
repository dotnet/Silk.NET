// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER
{
    public ID3D12Resource pBuffer;

    [NativeTypeName("UINT64")]
    public ulong Offset;
}
