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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES")]
    public unsafe partial struct VideoEncoderPictureControlSubregionsLayoutDataSlices
    {
        public VideoEncoderPictureControlSubregionsLayoutDataSlices
        (
            VideoEncoderPictureControlSubregionsLayoutDataSlicesUnion? anonymous = null,
            uint? maxBytesPerSlice = null,
            uint? numberOfCodingUnitsPerSlice = null,
            uint? numberOfRowsPerSlice = null,
            uint? numberOfSlicesPerFrame = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (maxBytesPerSlice is not null)
            {
                MaxBytesPerSlice = maxBytesPerSlice.Value;
            }

            if (numberOfCodingUnitsPerSlice is not null)
            {
                NumberOfCodingUnitsPerSlice = numberOfCodingUnitsPerSlice.Value;
            }

            if (numberOfRowsPerSlice is not null)
            {
                NumberOfRowsPerSlice = numberOfRowsPerSlice.Value;
            }

            if (numberOfSlicesPerFrame is not null)
            {
                NumberOfSlicesPerFrame = numberOfSlicesPerFrame.Value;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L7550_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderPictureControlSubregionsLayoutDataSlicesUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint MaxBytesPerSlice
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].MaxBytesPerSlice;
        }
#else
        public uint MaxBytesPerSlice
        {
            get => Anonymous.MaxBytesPerSlice;
            set => Anonymous.MaxBytesPerSlice = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint NumberOfCodingUnitsPerSlice
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].NumberOfCodingUnitsPerSlice;
        }
#else
        public uint NumberOfCodingUnitsPerSlice
        {
            get => Anonymous.NumberOfCodingUnitsPerSlice;
            set => Anonymous.NumberOfCodingUnitsPerSlice = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint NumberOfRowsPerSlice
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].NumberOfRowsPerSlice;
        }
#else
        public uint NumberOfRowsPerSlice
        {
            get => Anonymous.NumberOfRowsPerSlice;
            set => Anonymous.NumberOfRowsPerSlice = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint NumberOfSlicesPerFrame
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].NumberOfSlicesPerFrame;
        }
#else
        public uint NumberOfSlicesPerFrame
        {
            get => Anonymous.NumberOfSlicesPerFrame;
            set => Anonymous.NumberOfSlicesPerFrame = value;
        }
#endif

    }
}
