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
    [NativeName("Name", "StdVideoDecodeAV1PictureInfo")]
    public unsafe partial struct StdVideoDecodeAV1PictureInfo
    {
        public StdVideoDecodeAV1PictureInfo
        (
            StdVideoDecodeAV1PictureInfoFlags? flags = null,
            StdVideoAV1FrameType? frameType = null,
            uint? currentFrameId = null,
            byte? orderHint = null,
            byte? primaryRefFrame = null,
            byte? refreshFrameFlags = null,
            byte? reserved1 = null,
            StdVideoAV1InterpolationFilter? interpolationFilter = null,
            StdVideoAV1TxMode? txMode = null,
            byte? deltaQRes = null,
            byte? deltaLfRes = null,
            byte? codedDenom = null,
            StdVideoAV1TileInfo* pTileInfo = null,
            StdVideoAV1Quantization* pQuantization = null,
            StdVideoAV1Segmentation* pSegmentation = null,
            StdVideoAV1LoopFilter* pLoopFilter = null,
            StdVideoAV1CDEF* pCDEF = null,
            StdVideoAV1LoopRestoration* pLoopRestoration = null,
            StdVideoAV1GlobalMotion* pGlobalMotion = null,
            StdVideoAV1FilmGrain* pFilmGrain = null
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

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
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

            if (codedDenom is not null)
            {
                CodedDenom = codedDenom.Value;
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

            if (pFilmGrain is not null)
            {
                PFilmGrain = pFilmGrain;
            }
        }


        [NativeName("Type", "StdVideoDecodeAV1PictureInfoFlags")]
        [NativeName("Type.Name", "StdVideoDecodeAV1PictureInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoDecodeAV1PictureInfoFlags Flags;

        [NativeName("Type", "StdVideoAV1FrameType")]
        [NativeName("Type.Name", "StdVideoAV1FrameType")]
        [NativeName("Name", "frame_type")]
        public StdVideoAV1FrameType FrameType;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "current_frame_id")]
        public uint CurrentFrameId;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "OrderHint")]
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
        [NativeName("Name", "reserved1")]
        public byte Reserved1;

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
        [NativeName("Type", "uint8_t[2]")]
        [NativeName("Type.Name", "uint8_t[2]")]
        [NativeName("Name", "SkipModeFrame")]
        public fixed byte SkipModeFrame[2];

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "coded_denom")]
        public byte CodedDenom;
        [NativeName("Type", "uint8_t[3]")]
        [NativeName("Type.Name", "uint8_t[3]")]
        [NativeName("Name", "reserved2")]
        public fixed byte Reserved2[3];
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "OrderHints")]
        public fixed byte OrderHints[8];
        [NativeName("Type", "uint32_t[8]")]
        [NativeName("Type.Name", "uint32_t[8]")]
        [NativeName("Name", "expectedFrameId")]
        public fixed uint ExpectedFrameId[8];

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

        [NativeName("Type", "const StdVideoAV1FilmGrain *")]
        [NativeName("Type.Name", "const StdVideoAV1FilmGrain *")]
        [NativeName("Name", "pFilmGrain")]
        public StdVideoAV1FilmGrain* PFilmGrain;
    }
}
