// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_VIDEO_ENCODER_HEAP_DESC
{
    public uint NodeMask;
    public D3D12_VIDEO_ENCODER_HEAP_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_CODEC EncodeCodec;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC EncodeProfile;
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING EncodeLevel;
    public uint ResolutionsListCount;

    [NativeTypeName("const D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *")]
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList;
}
