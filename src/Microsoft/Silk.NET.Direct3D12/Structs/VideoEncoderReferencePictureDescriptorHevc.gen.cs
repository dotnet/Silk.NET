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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC")]
    public unsafe partial struct VideoEncoderReferencePictureDescriptorHevc
    {
        public VideoEncoderReferencePictureDescriptorHevc
        (
            uint? reconstructedPictureResourceIndex = null,
            Silk.NET.Core.Bool32? isRefUsedByCurrentPic = null,
            Silk.NET.Core.Bool32? isLongTermReference = null,
            uint? pictureOrderCountNumber = null,
            uint? temporalLayerIndex = null
        ) : this()
        {
            if (reconstructedPictureResourceIndex is not null)
            {
                ReconstructedPictureResourceIndex = reconstructedPictureResourceIndex.Value;
            }

            if (isRefUsedByCurrentPic is not null)
            {
                IsRefUsedByCurrentPic = isRefUsedByCurrentPic.Value;
            }

            if (isLongTermReference is not null)
            {
                IsLongTermReference = isLongTermReference.Value;
            }

            if (pictureOrderCountNumber is not null)
            {
                PictureOrderCountNumber = pictureOrderCountNumber.Value;
            }

            if (temporalLayerIndex is not null)
            {
                TemporalLayerIndex = temporalLayerIndex.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ReconstructedPictureResourceIndex")]
        public uint ReconstructedPictureResourceIndex;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IsRefUsedByCurrentPic")]
        public Silk.NET.Core.Bool32 IsRefUsedByCurrentPic;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IsLongTermReference")]
        public Silk.NET.Core.Bool32 IsLongTermReference;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PictureOrderCountNumber")]
        public uint PictureOrderCountNumber;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TemporalLayerIndex")]
        public uint TemporalLayerIndex;
    }
}
