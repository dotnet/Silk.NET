// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC
{
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC FrameType;
    public uint slice_pic_parameter_set_id;
    public uint PictureOrderCountNumber;
    public uint TemporalLayerIndex;
    public uint List0ReferenceFramesCount;
    public uint* pList0ReferenceFrames;
    public uint List1ReferenceFramesCount;
    public uint* pList1ReferenceFrames;
    public uint ReferenceFramesReconPictureDescriptorsCount;
    public D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC* pReferenceFramesReconPictureDescriptors;
    public uint List0RefPicModificationsCount;
    public uint* pList0RefPicModifications;
    public uint List1RefPicModificationsCount;
    public uint* pList1RefPicModifications;
    public uint QPMapValuesCount;

    [NativeTypeName("INT8 *")]
    public sbyte* pRateControlQPMap;
}
