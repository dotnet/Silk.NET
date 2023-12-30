// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC"]/*'/>
public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC
{
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.Format"]/*'/>

    public DXGI_FORMAT Format;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.ColorSpace"]/*'/>

    public DXGI_COLOR_SPACE_TYPE ColorSpace;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.SourceAspectRatio"]/*'/>

    public DXGI_RATIONAL SourceAspectRatio;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.DestinationAspectRatio"]/*'/>

    public DXGI_RATIONAL DestinationAspectRatio;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.FrameRate"]/*'/>

    public DXGI_RATIONAL FrameRate;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.SourceSizeRange"]/*'/>

    public D3D12_VIDEO_SIZE_RANGE SourceSizeRange;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.DestinationSizeRange"]/*'/>

    public D3D12_VIDEO_SIZE_RANGE DestinationSizeRange;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.EnableOrientation"]/*'/>

    public BOOL EnableOrientation;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.FilterFlags"]/*'/>

    public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterFlags;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.StereoFormat"]/*'/>

    public D3D12_VIDEO_FRAME_STEREO_FORMAT StereoFormat;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.FieldType"]/*'/>

    public D3D12_VIDEO_FIELD_TYPE FieldType;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.DeinterlaceMode"]/*'/>

    public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.EnableAlphaBlending"]/*'/>

    public BOOL EnableAlphaBlending;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.LumaKey"]/*'/>

    public D3D12_VIDEO_PROCESS_LUMA_KEY LumaKey;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.NumPastFrames"]/*'/>

    public uint NumPastFrames;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.NumFutureFrames"]/*'/>

    public uint NumFutureFrames;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC.EnableAutoProcessing"]/*'/>

    public BOOL EnableAutoProcessing;
}
