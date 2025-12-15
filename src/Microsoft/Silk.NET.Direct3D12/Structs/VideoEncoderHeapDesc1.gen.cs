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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_HEAP_DESC1")]
    public unsafe partial struct VideoEncoderHeapDesc1
    {
        public VideoEncoderHeapDesc1
        (
            uint? nodeMask = null,
            VideoEncoderHeapFlags? flags = null,
            VideoEncoderCodec? encodeCodec = null,
            VideoEncoderProfileDesc? encodeProfile = null,
            VideoEncoderLevelSetting? encodeLevel = null,
            uint? resolutionsListCount = null,
            VideoEncoderPictureResolutionDesc* pResolutionList = null,
            uint? pow2DownscaleFactor = null
        ) : this()
        {
            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (encodeCodec is not null)
            {
                EncodeCodec = encodeCodec.Value;
            }

            if (encodeProfile is not null)
            {
                EncodeProfile = encodeProfile.Value;
            }

            if (encodeLevel is not null)
            {
                EncodeLevel = encodeLevel.Value;
            }

            if (resolutionsListCount is not null)
            {
                ResolutionsListCount = resolutionsListCount.Value;
            }

            if (pResolutionList is not null)
            {
                PResolutionList = pResolutionList;
            }

            if (pow2DownscaleFactor is not null)
            {
                Pow2DownscaleFactor = pow2DownscaleFactor.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_HEAP_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_HEAP_FLAGS")]
        [NativeName("Name", "Flags")]
        public VideoEncoderHeapFlags Flags;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_CODEC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_CODEC")]
        [NativeName("Name", "EncodeCodec")]
        public VideoEncoderCodec EncodeCodec;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
        [NativeName("Name", "EncodeProfile")]
        public VideoEncoderProfileDesc EncodeProfile;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_LEVEL_SETTING")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_LEVEL_SETTING")]
        [NativeName("Name", "EncodeLevel")]
        public VideoEncoderLevelSetting EncodeLevel;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ResolutionsListCount")]
        public uint ResolutionsListCount;

        [NativeName("Type", "const D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *")]
        [NativeName("Name", "pResolutionList")]
        public VideoEncoderPictureResolutionDesc* PResolutionList;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Pow2DownscaleFactor")]
        public uint Pow2DownscaleFactor;
    }
}
