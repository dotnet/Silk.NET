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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE")]
    public unsafe partial struct VideoEncoderSequenceGopStructure
    {
        public VideoEncoderSequenceGopStructure
        (
            uint? dataSize = null,
            VideoEncoderSequenceGopStructureUnion? anonymous = null,
            VideoEncoderSequenceGopStructureH264* pH264GroupOfPictures = null,
            VideoEncoderSequenceGopStructureHevc* pHEVCGroupOfPictures = null,
            VideoEncoderAV1SequenceStructure* pAV1SequenceStructure = null
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

            if (pH264GroupOfPictures is not null)
            {
                PH264GroupOfPictures = pH264GroupOfPictures;
            }

            if (pHEVCGroupOfPictures is not null)
            {
                PHEVCGroupOfPictures = pHEVCGroupOfPictures;
            }

            if (pAV1SequenceStructure is not null)
            {
                PAV1SequenceStructure = pAV1SequenceStructure;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L7520_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderSequenceGopStructureUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderSequenceGopStructureH264* PH264GroupOfPictures
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PH264GroupOfPictures;
        }
#else
        public VideoEncoderSequenceGopStructureH264* PH264GroupOfPictures
        {
            get => Anonymous.PH264GroupOfPictures;
            set => Anonymous.PH264GroupOfPictures = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderSequenceGopStructureHevc* PHEVCGroupOfPictures
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PHEVCGroupOfPictures;
        }
#else
        public VideoEncoderSequenceGopStructureHevc* PHEVCGroupOfPictures
        {
            get => Anonymous.PHEVCGroupOfPictures;
            set => Anonymous.PHEVCGroupOfPictures = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderAV1SequenceStructure* PAV1SequenceStructure
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PAV1SequenceStructure;
        }
#else
        public VideoEncoderAV1SequenceStructure* PAV1SequenceStructure
        {
            get => Anonymous.PAV1SequenceStructure;
            set => Anonymous.PAV1SequenceStructure = value;
        }
#endif

    }
}
