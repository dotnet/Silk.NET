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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT")]
    public unsafe partial struct VideoEncoderAV1CodecConfigurationSupport
    {
        public VideoEncoderAV1CodecConfigurationSupport
        (
            VideoEncoderAV1FeatureFlags? supportedFeatureFlags = null,
            VideoEncoderAV1FeatureFlags? requiredFeatureFlags = null,
            VideoEncoderAV1InterpolationFiltersFlags? supportedInterpolationFilters = null,
            VideoEncoderAV1SegmentationModeFlags? supportedSegmentationModes = null,
            VideoEncoderAV1SegmentationBlockSize? segmentationBlockSize = null,
            VideoEncoderAV1PostEncodeValuesFlags? postEncodeValuesFlags = null,
            uint? maxTemporalLayers = null,
            uint? maxSpatialLayers = null
        ) : this()
        {
            if (supportedFeatureFlags is not null)
            {
                SupportedFeatureFlags = supportedFeatureFlags.Value;
            }

            if (requiredFeatureFlags is not null)
            {
                RequiredFeatureFlags = requiredFeatureFlags.Value;
            }

            if (supportedInterpolationFilters is not null)
            {
                SupportedInterpolationFilters = supportedInterpolationFilters.Value;
            }

            if (supportedSegmentationModes is not null)
            {
                SupportedSegmentationModes = supportedSegmentationModes.Value;
            }

            if (segmentationBlockSize is not null)
            {
                SegmentationBlockSize = segmentationBlockSize.Value;
            }

            if (postEncodeValuesFlags is not null)
            {
                PostEncodeValuesFlags = postEncodeValuesFlags.Value;
            }

            if (maxTemporalLayers is not null)
            {
                MaxTemporalLayers = maxTemporalLayers.Value;
            }

            if (maxSpatialLayers is not null)
            {
                MaxSpatialLayers = maxSpatialLayers.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS")]
        [NativeName("Name", "SupportedFeatureFlags")]
        public VideoEncoderAV1FeatureFlags SupportedFeatureFlags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS")]
        [NativeName("Name", "RequiredFeatureFlags")]
        public VideoEncoderAV1FeatureFlags RequiredFeatureFlags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS")]
        [NativeName("Name", "SupportedInterpolationFilters")]
        public VideoEncoderAV1InterpolationFiltersFlags SupportedInterpolationFilters;
        
        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS[3][3]")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS[3][3]")]
        [NativeName("Name", "SupportedRestorationParams")]
        public SupportedRestorationParamsBuffer SupportedRestorationParams;

        public struct SupportedRestorationParamsBuffer
        {
            public VideoEncoderAV1RestorationSupportFlags* Element0;
            public VideoEncoderAV1RestorationSupportFlags* Element1;
            public VideoEncoderAV1RestorationSupportFlags* Element2;
            public VideoEncoderAV1RestorationSupportFlags* Element3;
            public VideoEncoderAV1RestorationSupportFlags* Element4;
            public VideoEncoderAV1RestorationSupportFlags* Element5;
            public VideoEncoderAV1RestorationSupportFlags* Element6;
            public VideoEncoderAV1RestorationSupportFlags* Element7;
            public VideoEncoderAV1RestorationSupportFlags* Element8;
            public ref VideoEncoderAV1RestorationSupportFlags* this[int index]
            {
                get
                {
                    if (index > 8 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoEncoderAV1RestorationSupportFlags** ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS")]
        [NativeName("Name", "SupportedSegmentationModes")]
        public VideoEncoderAV1SegmentationModeFlags SupportedSegmentationModes;
        
        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS[4]")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS[4]")]
        [NativeName("Name", "SupportedTxModes")]
        public SupportedTxModesBuffer SupportedTxModes;

        public struct SupportedTxModesBuffer
        {
            public VideoEncoderAV1TXModeFlags Element0;
            public VideoEncoderAV1TXModeFlags Element1;
            public VideoEncoderAV1TXModeFlags Element2;
            public VideoEncoderAV1TXModeFlags Element3;
            public ref VideoEncoderAV1TXModeFlags this[int index]
            {
                get
                {
                    if (index > 3 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoEncoderAV1TXModeFlags* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoEncoderAV1TXModeFlags> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 4);
#endif
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE")]
        [NativeName("Name", "SegmentationBlockSize")]
        public VideoEncoderAV1SegmentationBlockSize SegmentationBlockSize;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAGS")]
        [NativeName("Name", "PostEncodeValuesFlags")]
        public VideoEncoderAV1PostEncodeValuesFlags PostEncodeValuesFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxTemporalLayers")]
        public uint MaxTemporalLayers;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxSpatialLayers")]
        public uint MaxSpatialLayers;
    }
}
