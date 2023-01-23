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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA_VideoDesc")]
    public unsafe partial struct VideoDesc
    {
        public VideoDesc
        (
            uint? size = null,
            uint? sampleWidth = null,
            uint? sampleHeight = null,
            uint? sampleFormat = null,
            Silk.NET.Direct3D9.Format? d3dFormat = null,
            Frequency? inputSampleFreq = null,
            Frequency? outputFrameFreq = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (sampleWidth is not null)
            {
                SampleWidth = sampleWidth.Value;
            }

            if (sampleHeight is not null)
            {
                SampleHeight = sampleHeight.Value;
            }

            if (sampleFormat is not null)
            {
                SampleFormat = sampleFormat.Value;
            }

            if (d3dFormat is not null)
            {
                D3dFormat = d3dFormat.Value;
            }

            if (inputSampleFreq is not null)
            {
                InputSampleFreq = inputSampleFreq.Value;
            }

            if (outputFrameFreq is not null)
            {
                OutputFrameFreq = outputFrameFreq.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "SampleWidth")]
        public uint SampleWidth;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "SampleHeight")]
        public uint SampleHeight;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "SampleFormat")]
        public uint SampleFormat;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "d3dFormat")]
        public Silk.NET.Direct3D9.Format D3dFormat;

        [NativeName("Type", "DXVA_Frequency")]
        [NativeName("Type.Name", "DXVA_Frequency")]
        [NativeName("Name", "InputSampleFreq")]
        public Frequency InputSampleFreq;

        [NativeName("Type", "DXVA_Frequency")]
        [NativeName("Type.Name", "DXVA_Frequency")]
        [NativeName("Name", "OutputFrameFreq")]
        public Frequency OutputFrameFreq;
    }
}
