// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC
{
    public DXGI_FORMAT Format;
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
    public DXGI_RATIONAL SourceAspectRatio;
    public DXGI_RATIONAL DestinationAspectRatio;
    public DXGI_RATIONAL FrameRate;
    public D3D12_VIDEO_SIZE_RANGE SourceSizeRange;
    public D3D12_VIDEO_SIZE_RANGE DestinationSizeRange;
    public BOOL EnableOrientation;
    public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterFlags;
    public D3D12_VIDEO_FRAME_STEREO_FORMAT StereoFormat;
    public D3D12_VIDEO_FIELD_TYPE FieldType;
    public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode;
    public BOOL EnableAlphaBlending;
    public D3D12_VIDEO_PROCESS_LUMA_KEY LumaKey;
    public uint NumPastFrames;
    public uint NumFutureFrames;
    public BOOL EnableAutoProcessing;
}
