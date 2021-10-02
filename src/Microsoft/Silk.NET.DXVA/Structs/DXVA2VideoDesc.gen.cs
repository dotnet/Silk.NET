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
    [NativeName("Name", "_DXVA2_VideoDesc")]
    public unsafe partial struct DXVA2VideoDesc
    {
        public DXVA2VideoDesc
        (
            uint? sampleWidth = null,
            uint? sampleHeight = null,
            DXVA2ExtendedFormat? sampleFormat = null,
            Silk.NET.Direct3D9.Format? format = null,
            DXVA2Frequency? inputSampleFreq = null,
            DXVA2Frequency? outputFrameFreq = null,
            uint? uABProtectionLevel = null,
            uint? reserved = null
        ) : this()
        {
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

            if (format is not null)
            {
                Format = format.Value;
            }

            if (inputSampleFreq is not null)
            {
                InputSampleFreq = inputSampleFreq.Value;
            }

            if (outputFrameFreq is not null)
            {
                OutputFrameFreq = outputFrameFreq.Value;
            }

            if (uABProtectionLevel is not null)
            {
                UABProtectionLevel = uABProtectionLevel.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SampleWidth")]
        public uint SampleWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SampleHeight")]
        public uint SampleHeight;

        [NativeName("Type", "DXVA2_ExtendedFormat")]
        [NativeName("Type.Name", "DXVA2_ExtendedFormat")]
        [NativeName("Name", "SampleFormat")]
        public DXVA2ExtendedFormat SampleFormat;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.Direct3D9.Format Format;

        [NativeName("Type", "DXVA2_Frequency")]
        [NativeName("Type.Name", "DXVA2_Frequency")]
        [NativeName("Name", "InputSampleFreq")]
        public DXVA2Frequency InputSampleFreq;

        [NativeName("Type", "DXVA2_Frequency")]
        [NativeName("Type.Name", "DXVA2_Frequency")]
        [NativeName("Name", "OutputFrameFreq")]
        public DXVA2Frequency OutputFrameFreq;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "UABProtectionLevel")]
        public uint UABProtectionLevel;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Reserved")]
        public uint Reserved;
    }
}
