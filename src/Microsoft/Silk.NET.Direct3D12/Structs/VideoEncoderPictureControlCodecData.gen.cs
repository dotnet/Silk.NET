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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA")]
    public unsafe partial struct VideoEncoderPictureControlCodecData
    {
        public VideoEncoderPictureControlCodecData
        (
            uint? dataSize = null,
            VideoEncoderPictureControlCodecDataUnion? anonymous = null,
            VideoEncoderPictureControlCodecDataH264* pH264PicData = null,
            VideoEncoderPictureControlCodecDataHevc* pHEVCPicData = null,
            VideoEncoderAV1PictureControlCodecData* pAV1PicData = null
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

            if (pH264PicData is not null)
            {
                PH264PicData = pH264PicData;
            }

            if (pHEVCPicData is not null)
            {
                PHEVCPicData = pHEVCPicData;
            }

            if (pAV1PicData is not null)
            {
                PAV1PicData = pAV1PicData;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L8363_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderPictureControlCodecDataUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderPictureControlCodecDataH264* PH264PicData
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PH264PicData;
        }
#else
        public VideoEncoderPictureControlCodecDataH264* PH264PicData
        {
            get => Anonymous.PH264PicData;
            set => Anonymous.PH264PicData = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderPictureControlCodecDataHevc* PHEVCPicData
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PHEVCPicData;
        }
#else
        public VideoEncoderPictureControlCodecDataHevc* PHEVCPicData
        {
            get => Anonymous.PHEVCPicData;
            set => Anonymous.PHEVCPicData = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderAV1PictureControlCodecData* PAV1PicData
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PAV1PicData;
        }
#else
        public VideoEncoderAV1PictureControlCodecData* PAV1PicData
        {
            get => Anonymous.PAV1PicData;
            set => Anonymous.PAV1PicData = value;
        }
#endif

    }
}
