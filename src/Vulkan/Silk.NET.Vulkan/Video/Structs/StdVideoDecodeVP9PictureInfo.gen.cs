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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoDecodeVP9PictureInfo")]
    public unsafe partial struct StdVideoDecodeVP9PictureInfo
    {
        public StdVideoDecodeVP9PictureInfo
        (
            StdVideoDecodeVP9PictureInfoFlags? flags = null,
            StdVideoVP9Profile? profile = null,
            StdVideoVP9FrameType? frameType = null,
            byte? frameContextIdx = null,
            byte? resetFrameContext = null,
            byte? refreshFrameFlags = null,
            byte? refFrameSignBiasMask = null,
            StdVideoVP9InterpolationFilter? interpolationFilter = null,
            byte? baseQIdx = null,
            byte? deltaQYDc = null,
            byte? deltaQUvDc = null,
            byte? deltaQUvAc = null,
            byte? tileColsLog2 = null,
            byte? tileRowsLog2 = null,
            StdVideoVP9ColorConfig* pColorConfig = null,
            StdVideoVP9LoopFilter* pLoopFilter = null,
            StdVideoVP9Segmentation* pSegmentation = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (profile is not null)
            {
                Profile = profile.Value;
            }

            if (frameType is not null)
            {
                FrameType = frameType.Value;
            }

            if (frameContextIdx is not null)
            {
                FrameContextIdx = frameContextIdx.Value;
            }

            if (resetFrameContext is not null)
            {
                ResetFrameContext = resetFrameContext.Value;
            }

            if (refreshFrameFlags is not null)
            {
                RefreshFrameFlags = refreshFrameFlags.Value;
            }

            if (refFrameSignBiasMask is not null)
            {
                RefFrameSignBiasMask = refFrameSignBiasMask.Value;
            }

            if (interpolationFilter is not null)
            {
                InterpolationFilter = interpolationFilter.Value;
            }

            if (baseQIdx is not null)
            {
                BaseQIdx = baseQIdx.Value;
            }

            if (deltaQYDc is not null)
            {
                DeltaQYDc = deltaQYDc.Value;
            }

            if (deltaQUvDc is not null)
            {
                DeltaQUvDc = deltaQUvDc.Value;
            }

            if (deltaQUvAc is not null)
            {
                DeltaQUvAc = deltaQUvAc.Value;
            }

            if (tileColsLog2 is not null)
            {
                TileColsLog2 = tileColsLog2.Value;
            }

            if (tileRowsLog2 is not null)
            {
                TileRowsLog2 = tileRowsLog2.Value;
            }

            if (pColorConfig is not null)
            {
                PColorConfig = pColorConfig;
            }

            if (pLoopFilter is not null)
            {
                PLoopFilter = pLoopFilter;
            }

            if (pSegmentation is not null)
            {
                PSegmentation = pSegmentation;
            }
        }


        [NativeName("Type", "StdVideoDecodeVP9PictureInfoFlags")]
        [NativeName("Type.Name", "StdVideoDecodeVP9PictureInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoDecodeVP9PictureInfoFlags Flags;

        [NativeName("Type", "StdVideoVP9Profile")]
        [NativeName("Type.Name", "StdVideoVP9Profile")]
        [NativeName("Name", "profile")]
        public StdVideoVP9Profile Profile;

        [NativeName("Type", "StdVideoVP9FrameType")]
        [NativeName("Type.Name", "StdVideoVP9FrameType")]
        [NativeName("Name", "frame_type")]
        public StdVideoVP9FrameType FrameType;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "frame_context_idx")]
        public byte FrameContextIdx;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reset_frame_context")]
        public byte ResetFrameContext;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refresh_frame_flags")]
        public byte RefreshFrameFlags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "ref_frame_sign_bias_mask")]
        public byte RefFrameSignBiasMask;

        [NativeName("Type", "StdVideoVP9InterpolationFilter")]
        [NativeName("Type.Name", "StdVideoVP9InterpolationFilter")]
        [NativeName("Name", "interpolation_filter")]
        public StdVideoVP9InterpolationFilter InterpolationFilter;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "base_q_idx")]
        public byte BaseQIdx;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "delta_q_y_dc")]
        public byte DeltaQYDc;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "delta_q_uv_dc")]
        public byte DeltaQUvDc;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "delta_q_uv_ac")]
        public byte DeltaQUvAc;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "tile_cols_log2")]
        public byte TileColsLog2;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "tile_rows_log2")]
        public byte TileRowsLog2;
        [NativeName("Type", "uint16_t[3]")]
        [NativeName("Type.Name", "uint16_t[3]")]
        [NativeName("Name", "reserved1")]
        public fixed ushort Reserved1[3];

        [NativeName("Type", "const StdVideoVP9ColorConfig *")]
        [NativeName("Type.Name", "const StdVideoVP9ColorConfig *")]
        [NativeName("Name", "pColorConfig")]
        public StdVideoVP9ColorConfig* PColorConfig;

        [NativeName("Type", "const StdVideoVP9LoopFilter *")]
        [NativeName("Type.Name", "const StdVideoVP9LoopFilter *")]
        [NativeName("Name", "pLoopFilter")]
        public StdVideoVP9LoopFilter* PLoopFilter;

        [NativeName("Type", "const StdVideoVP9Segmentation *")]
        [NativeName("Type.Name", "const StdVideoVP9Segmentation *")]
        [NativeName("Name", "pSegmentation")]
        public StdVideoVP9Segmentation* PSegmentation;
    }
}
