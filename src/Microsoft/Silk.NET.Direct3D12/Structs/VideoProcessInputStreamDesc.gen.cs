// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            Silk.NET.DXGI.Format? format = null,
            Silk.NET.DXGI.ColorSpaceType? colorSpace = null,
            Silk.NET.DXGI.Rational? sourceAspectRatio = null,
            Silk.NET.DXGI.Rational? destinationAspectRatio = null,
            Silk.NET.DXGI.Rational? frameRate = null,
            VideoSizeRange? sourceSizeRange = null,
            VideoSizeRange? destinationSizeRange = null,
            Silk.NET.Core.Bool32? enableOrientation = null,
            VideoProcessFilterFlags? filterFlags = null,
            VideoFrameStereoFormat? stereoFormat = null,
            VideoFieldType? fieldType = null,
            VideoProcessDeinterlaceFlags? deinterlaceMode = null,
            Silk.NET.Core.Bool32? enableAlphaBlending = null,
            VideoProcessLumaKey? lumaKey = null,
            uint? numPastFrames = null,
            uint? numFutureFrames = null,
            Silk.NET.Core.Bool32? enableAutoProcessing = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (colorSpace is not null)
            {
                ColorSpace = colorSpace.Value;
            }

            if (sourceAspectRatio is not null)
            {
                SourceAspectRatio = sourceAspectRatio.Value;
            }

            if (destinationAspectRatio is not null)
            {
                DestinationAspectRatio = destinationAspectRatio.Value;
            }

            if (frameRate is not null)
            {
                FrameRate = frameRate.Value;
            }

            if (sourceSizeRange is not null)
            {
                SourceSizeRange = sourceSizeRange.Value;
            }

            if (destinationSizeRange is not null)
            {
                DestinationSizeRange = destinationSizeRange.Value;
            }

            if (enableOrientation is not null)
            {
                EnableOrientation = enableOrientation.Value;
            }

            if (filterFlags is not null)
            {
                FilterFlags = filterFlags.Value;
            }

            if (stereoFormat is not null)
            {
                StereoFormat = stereoFormat.Value;
            }

            if (fieldType is not null)
            {
                FieldType = fieldType.Value;
            }

            if (deinterlaceMode is not null)
            {
                DeinterlaceMode = deinterlaceMode.Value;
            }

            if (enableAlphaBlending is not null)
            {
                EnableAlphaBlending = enableAlphaBlending.Value;
            }

            if (lumaKey is not null)
            {
                LumaKey = lumaKey.Value;
            }

            if (numPastFrames is not null)
            {
                NumPastFrames = numPastFrames.Value;
            }

            if (numFutureFrames is not null)
            {
                NumFutureFrames = numFutureFrames.Value;
            }

            if (enableAutoProcessing is not null)
            {
                EnableAutoProcessing = enableAutoProcessing.Value;
            }
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
        public Silk.NET.Core.Bool32 EnableOrientation;

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
        public Silk.NET.Core.Bool32 EnableAlphaBlending;

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
        public Silk.NET.Core.Bool32 EnableAutoProcessing;
    }
}
