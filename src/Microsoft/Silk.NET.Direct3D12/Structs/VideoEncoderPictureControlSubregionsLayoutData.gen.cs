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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA")]
    public unsafe partial struct VideoEncoderPictureControlSubregionsLayoutData
    {
        public VideoEncoderPictureControlSubregionsLayoutData
        (
            uint? dataSize = null,
            VideoEncoderPictureControlSubregionsLayoutDataUnion? anonymous = null,
            VideoEncoderPictureControlSubregionsLayoutDataSlices* pSlicesPartitionH264 = null,
            VideoEncoderPictureControlSubregionsLayoutDataSlices* pSlicesPartitionHEVC = null,
            VideoEncoderAV1PictureControlSubregionsLayoutDataTiles* pTilesPartitionAV1 = null
        ) : this()
        {
            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (pSlicesPartitionH264 is not null)
            {
                PSlicesPartitionH264 = pSlicesPartitionH264;
            }

            if (pSlicesPartitionHEVC is not null)
            {
                PSlicesPartitionHEVC = pSlicesPartitionHEVC;
            }

            if (pTilesPartitionAV1 is not null)
            {
                PTilesPartitionAV1 = pTilesPartitionAV1;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L7562_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderPictureControlSubregionsLayoutDataUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderPictureControlSubregionsLayoutDataSlices* PSlicesPartitionH264
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PSlicesPartitionH264;
        }
#else
        public VideoEncoderPictureControlSubregionsLayoutDataSlices* PSlicesPartitionH264
        {
            get => Anonymous.PSlicesPartitionH264;
            set => Anonymous.PSlicesPartitionH264 = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderPictureControlSubregionsLayoutDataSlices* PSlicesPartitionHEVC
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PSlicesPartitionHEVC;
        }
#else
        public VideoEncoderPictureControlSubregionsLayoutDataSlices* PSlicesPartitionHEVC
        {
            get => Anonymous.PSlicesPartitionHEVC;
            set => Anonymous.PSlicesPartitionHEVC = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderAV1PictureControlSubregionsLayoutDataTiles* PTilesPartitionAV1
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PTilesPartitionAV1;
        }
#else
        public VideoEncoderAV1PictureControlSubregionsLayoutDataTiles* PTilesPartitionAV1
        {
            get => Anonymous.PTilesPartitionAV1;
            set => Anonymous.PTilesPartitionAV1 = value;
        }
#endif

    }
}
