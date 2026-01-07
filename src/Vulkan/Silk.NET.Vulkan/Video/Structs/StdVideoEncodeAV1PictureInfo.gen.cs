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
    [NativeName("Name", "StdVideoEncodeAV1PictureInfo")]
    public unsafe partial struct StdVideoEncodeAV1PictureInfo
    {
        public StdVideoEncodeAV1PictureInfo
        (
            StdVideoEncodeAV1PictureInfoFlags? flags = null,
            StdVideoAV1FrameType? frameType = null,
            uint? framePresentationTime = null,
            uint? currentFrameId = null,
            byte? orderHint = null,
            byte? primaryRefFrame = null,
            byte? refreshFrameFlags = null,
            byte? codedDenom = null,
            ushort? renderWidthMinus1 = null,
            ushort? renderHeightMinus1 = null,
            StdVideoAV1InterpolationFilter? interpolationFilter = null,
            StdVideoAV1TxMode? txMode = null,
            byte? deltaQRes = null,
            byte? deltaLfRes = null,
            StdVideoAV1TileInfo* pTileInfo = null,
            StdVideoAV1Quantization* pQuantization = null,
            StdVideoAV1Segmentation* pSegmentation = null,
            StdVideoAV1LoopFilter* pLoopFilter = null,
            StdVideoAV1CDEF* pCDEF = null,
            StdVideoAV1LoopRestoration* pLoopRestoration = null,
            StdVideoAV1GlobalMotion* pGlobalMotion = null,
            StdVideoEncodeAV1ExtensionHeader* pExtensionHeader = null,
            uint* pBufferRemovalTimes = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (frameType is not null)
            {
                FrameType = frameType.Value;
            }

            if (framePresentationTime is not null)
            {
                FramePresentationTime = framePresentationTime.Value;
            }

            if (currentFrameId is not null)
            {
                CurrentFrameId = currentFrameId.Value;
            }

            if (orderHint is not null)
            {
                OrderHint = orderHint.Value;
            }

            if (primaryRefFrame is not null)
            {
                PrimaryRefFrame = primaryRefFrame.Value;
            }

            if (refreshFrameFlags is not null)
            {
                RefreshFrameFlags = refreshFrameFlags.Value;
            }

            if (codedDenom is not null)
            {
                CodedDenom = codedDenom.Value;
            }

            if (renderWidthMinus1 is not null)
            {
                RenderWidthMinus1 = renderWidthMinus1.Value;
            }

            if (renderHeightMinus1 is not null)
            {
                RenderHeightMinus1 = renderHeightMinus1.Value;
            }

            if (interpolationFilter is not null)
            {
                InterpolationFilter = interpolationFilter.Value;
            }

            if (txMode is not null)
            {
                TxMode = txMode.Value;
            }

            if (deltaQRes is not null)
            {
                DeltaQRes = deltaQRes.Value;
            }

            if (deltaLfRes is not null)
            {
                DeltaLfRes = deltaLfRes.Value;
            }

            if (pTileInfo is not null)
            {
                PTileInfo = pTileInfo;
            }

            if (pQuantization is not null)
            {
                PQuantization = pQuantization;
            }

            if (pSegmentation is not null)
            {
                PSegmentation = pSegmentation;
            }

            if (pLoopFilter is not null)
            {
                PLoopFilter = pLoopFilter;
            }

            if (pCDEF is not null)
            {
                PCDEF = pCDEF;
            }

            if (pLoopRestoration is not null)
            {
                PLoopRestoration = pLoopRestoration;
            }

            if (pGlobalMotion is not null)
            {
                PGlobalMotion = pGlobalMotion;
            }

            if (pExtensionHeader is not null)
            {
                PExtensionHeader = pExtensionHeader;
            }

            if (pBufferRemovalTimes is not null)
            {
                PBufferRemovalTimes = pBufferRemovalTimes;
            }
        }


        [NativeName("Type", "StdVideoEncodeAV1PictureInfoFlags")]
        [NativeName("Type.Name", "StdVideoEncodeAV1PictureInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeAV1PictureInfoFlags Flags;

        [NativeName("Type", "StdVideoAV1FrameType")]
        [NativeName("Type.Name", "StdVideoAV1FrameType")]
        [NativeName("Name", "frame_type")]
        public StdVideoAV1FrameType FrameType;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frame_presentation_time")]
        public uint FramePresentationTime;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "current_frame_id")]
        public uint CurrentFrameId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "order_hint")]
        public byte OrderHint;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "primary_ref_frame")]
        public byte PrimaryRefFrame;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refresh_frame_flags")]
        public byte RefreshFrameFlags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "coded_denom")]
        public byte CodedDenom;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "render_width_minus_1")]
        public ushort RenderWidthMinus1;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "render_height_minus_1")]
        public ushort RenderHeightMinus1;

        [NativeName("Type", "StdVideoAV1InterpolationFilter")]
        [NativeName("Type.Name", "StdVideoAV1InterpolationFilter")]
        [NativeName("Name", "interpolation_filter")]
        public StdVideoAV1InterpolationFilter InterpolationFilter;

        [NativeName("Type", "StdVideoAV1TxMode")]
        [NativeName("Type.Name", "StdVideoAV1TxMode")]
        [NativeName("Name", "TxMode")]
        public StdVideoAV1TxMode TxMode;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "delta_q_res")]
        public byte DeltaQRes;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "delta_lf_res")]
        public byte DeltaLfRes;
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "ref_order_hint")]
        public fixed byte RefOrderHint[8];
        [NativeName("Type", "int8_t[7]")]
        [NativeName("Type.Name", "int8_t[7]")]
        [NativeName("Name", "ref_frame_idx")]
        public fixed byte RefFrameIdx[7];
        [NativeName("Type", "uint8_t[3]")]
        [NativeName("Type.Name", "uint8_t[3]")]
        [NativeName("Name", "reserved1")]
        public fixed byte Reserved1[3];
        [NativeName("Type", "uint32_t[7]")]
        [NativeName("Type.Name", "uint32_t[7]")]
        [NativeName("Name", "delta_frame_id_minus_1")]
        public fixed uint DeltaFrameIdMinus1[7];

        [NativeName("Type", "const StdVideoAV1TileInfo *")]
        [NativeName("Type.Name", "const StdVideoAV1TileInfo *")]
        [NativeName("Name", "pTileInfo")]
        public StdVideoAV1TileInfo* PTileInfo;

        [NativeName("Type", "const StdVideoAV1Quantization *")]
        [NativeName("Type.Name", "const StdVideoAV1Quantization *")]
        [NativeName("Name", "pQuantization")]
        public StdVideoAV1Quantization* PQuantization;

        [NativeName("Type", "const StdVideoAV1Segmentation *")]
        [NativeName("Type.Name", "const StdVideoAV1Segmentation *")]
        [NativeName("Name", "pSegmentation")]
        public StdVideoAV1Segmentation* PSegmentation;

        [NativeName("Type", "const StdVideoAV1LoopFilter *")]
        [NativeName("Type.Name", "const StdVideoAV1LoopFilter *")]
        [NativeName("Name", "pLoopFilter")]
        public StdVideoAV1LoopFilter* PLoopFilter;

        [NativeName("Type", "const StdVideoAV1CDEF *")]
        [NativeName("Type.Name", "const StdVideoAV1CDEF *")]
        [NativeName("Name", "pCDEF")]
        public StdVideoAV1CDEF* PCDEF;

        [NativeName("Type", "const StdVideoAV1LoopRestoration *")]
        [NativeName("Type.Name", "const StdVideoAV1LoopRestoration *")]
        [NativeName("Name", "pLoopRestoration")]
        public StdVideoAV1LoopRestoration* PLoopRestoration;

        [NativeName("Type", "const StdVideoAV1GlobalMotion *")]
        [NativeName("Type.Name", "const StdVideoAV1GlobalMotion *")]
        [NativeName("Name", "pGlobalMotion")]
        public StdVideoAV1GlobalMotion* PGlobalMotion;

        [NativeName("Type", "const StdVideoEncodeAV1ExtensionHeader *")]
        [NativeName("Type.Name", "const StdVideoEncodeAV1ExtensionHeader *")]
        [NativeName("Name", "pExtensionHeader")]
        public StdVideoEncodeAV1ExtensionHeader* PExtensionHeader;

        [NativeName("Type", "const uint32_t *")]
        [NativeName("Type.Name", "const uint32_t *")]
        [NativeName("Name", "pBufferRemovalTimes")]
        public uint* PBufferRemovalTimes;
    }
}
