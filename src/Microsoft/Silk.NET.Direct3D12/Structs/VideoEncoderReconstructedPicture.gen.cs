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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE")]
    public unsafe partial struct VideoEncoderReconstructedPicture
    {
        public VideoEncoderReconstructedPicture
        (
            ID3D12Resource* pReconstructedPicture = null,
            uint? reconstructedPictureSubresource = null
        ) : this()
        {
            if (pReconstructedPicture is not null)
            {
                PReconstructedPicture = pReconstructedPicture;
            }

            if (reconstructedPictureSubresource is not null)
            {
                ReconstructedPictureSubresource = reconstructedPictureSubresource.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pReconstructedPicture")]
        public ID3D12Resource* PReconstructedPicture;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ReconstructedPictureSubresource")]
        public uint ReconstructedPictureSubresource;
    }
}
