// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC")]
    public unsafe partial struct VideoProcessInputStreamDesc
    {
        public VideoProcessInputStreamDesc
        (
            Silk.NET.DXGI.Format format = default,
            Silk.NET.DXGI.ColorSpaceType colorSpace = default,
            Silk.NET.DXGI.Rational sourceAspectRatio = default,
            Silk.NET.DXGI.Rational destinationAspectRatio = default,
            Silk.NET.DXGI.Rational frameRate = default,
            VideoSizeRange sourceSizeRange = default,
            VideoSizeRange destinationSizeRange = default,
            int enableOrientation = default,
            VideoProcessFilterFlags filterFlags = default,
            VideoFrameStereoFormat stereoFormat = default,
            VideoFieldType fieldType = default,
            VideoProcessDeinterlaceFlags deinterlaceMode = default,
            int enableAlphaBlending = default,
            VideoProcessLumaKey lumaKey = default,
            uint numPastFrames = default,
            uint numFutureFrames = default,
            int enableAutoProcessing = default
        )
        {
            Format = format;
            ColorSpace = colorSpace;
            SourceAspectRatio = sourceAspectRatio;
            DestinationAspectRatio = destinationAspectRatio;
            FrameRate = frameRate;
            SourceSizeRange = sourceSizeRange;
            DestinationSizeRange = destinationSizeRange;
            EnableOrientation = enableOrientation;
            FilterFlags = filterFlags;
            StereoFormat = stereoFormat;
            FieldType = fieldType;
            DeinterlaceMode = deinterlaceMode;
            EnableAlphaBlending = enableAlphaBlending;
            LumaKey = lumaKey;
            NumPastFrames = numPastFrames;
            NumFutureFrames = numFutureFrames;
            EnableAutoProcessing = enableAutoProcessing;
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Type.Name", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Name", "ColorSpace")]
        public Silk.NET.DXGI.ColorSpaceType ColorSpace;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "SourceAspectRatio")]
        public Silk.NET.DXGI.Rational SourceAspectRatio;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "DestinationAspectRatio")]
        public Silk.NET.DXGI.Rational DestinationAspectRatio;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "FrameRate")]
        public Silk.NET.DXGI.Rational FrameRate;

        [NativeName("Type", "D3D12_VIDEO_SIZE_RANGE")]
        [NativeName("Type.Name", "D3D12_VIDEO_SIZE_RANGE")]
        [NativeName("Name", "SourceSizeRange")]
        public VideoSizeRange SourceSizeRange;

        [NativeName("Type", "D3D12_VIDEO_SIZE_RANGE")]
        [NativeName("Type.Name", "D3D12_VIDEO_SIZE_RANGE")]
        [NativeName("Name", "DestinationSizeRange")]
        public VideoSizeRange DestinationSizeRange;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "EnableOrientation")]
        public int EnableOrientation;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_FILTER_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_FILTER_FLAGS")]
        [NativeName("Name", "FilterFlags")]
        public VideoProcessFilterFlags FilterFlags;

        [NativeName("Type", "D3D12_VIDEO_FRAME_STEREO_FORMAT")]
        [NativeName("Type.Name", "D3D12_VIDEO_FRAME_STEREO_FORMAT")]
        [NativeName("Name", "StereoFormat")]
        public VideoFrameStereoFormat StereoFormat;

        [NativeName("Type", "D3D12_VIDEO_FIELD_TYPE")]
        [NativeName("Type.Name", "D3D12_VIDEO_FIELD_TYPE")]
        [NativeName("Name", "FieldType")]
        public VideoFieldType FieldType;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS")]
        [NativeName("Name", "DeinterlaceMode")]
        public VideoProcessDeinterlaceFlags DeinterlaceMode;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "EnableAlphaBlending")]
        public int EnableAlphaBlending;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_LUMA_KEY")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_LUMA_KEY")]
        [NativeName("Name", "LumaKey")]
        public VideoProcessLumaKey LumaKey;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumPastFrames")]
        public uint NumPastFrames;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumFutureFrames")]
        public uint NumFutureFrames;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "EnableAutoProcessing")]
        public int EnableAutoProcessing;
    }
}
