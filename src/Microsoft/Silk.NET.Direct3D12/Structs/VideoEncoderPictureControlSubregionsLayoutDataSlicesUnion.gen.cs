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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12video_L7550_C5")]
    public unsafe partial struct VideoEncoderPictureControlSubregionsLayoutDataSlicesUnion
    {
        public VideoEncoderPictureControlSubregionsLayoutDataSlicesUnion
        (
            uint? maxBytesPerSlice = null,
            uint? numberOfCodingUnitsPerSlice = null,
            uint? numberOfRowsPerSlice = null,
            uint? numberOfSlicesPerFrame = null
        ) : this()
        {
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


        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxBytesPerSlice")]
        public uint MaxBytesPerSlice;

        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumberOfCodingUnitsPerSlice")]
        public uint NumberOfCodingUnitsPerSlice;

        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumberOfRowsPerSlice")]
        public uint NumberOfRowsPerSlice;

        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumberOfSlicesPerFrame")]
        public uint NumberOfSlicesPerFrame;
    }
}
