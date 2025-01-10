// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264
{
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_FRAME_TYPE_H264 FrameType;
    public uint pic_parameter_set_id;
    public uint idr_pic_id;
    public uint PictureOrderCountNumber;
    public uint FrameDecodingOrderNumber;
    public uint TemporalLayerIndex;
    public uint List0ReferenceFramesCount;
    public uint* pList0ReferenceFrames;
    public uint List1ReferenceFramesCount;
    public uint* pList1ReferenceFrames;
    public uint ReferenceFramesReconPictureDescriptorsCount;
    public D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264* pReferenceFramesReconPictureDescriptors;

    [NativeTypeName("UCHAR")]
    public byte adaptive_ref_pic_marking_mode_flag;
    public uint RefPicMarkingOperationsCommandsCount;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_MARKING_OPERATION* pRefPicMarkingOperationsCommands;
    public uint List0RefPicModificationsCount;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION* pList0RefPicModifications;
    public uint List1RefPicModificationsCount;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION* pList1RefPicModifications;
    public uint QPMapValuesCount;

    [NativeTypeName("INT8 *")]
    public sbyte* pRateControlQPMap;
}
