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
    [NativeName("Name", "_DXVA2_VideoProcessorCaps")]
    public unsafe partial struct DXVA2VideoProcessorCaps
    {
        public DXVA2VideoProcessorCaps
        (
            uint? deviceCaps = null,
            Silk.NET.Direct3D9.Pool? inputPool = null,
            uint? numForwardRefSamples = null,
            uint? numBackwardRefSamples = null,
            uint? reserved = null,
            uint? deinterlaceTechnology = null,
            uint? procAmpControlCaps = null,
            uint? videoProcessorOperations = null,
            uint? noiseFilterTechnology = null,
            uint? detailFilterTechnology = null
        ) : this()
        {
            if (deviceCaps is not null)
            {
                DeviceCaps = deviceCaps.Value;
            }

            if (inputPool is not null)
            {
                InputPool = inputPool.Value;
            }

            if (numForwardRefSamples is not null)
            {
                NumForwardRefSamples = numForwardRefSamples.Value;
            }

            if (numBackwardRefSamples is not null)
            {
                NumBackwardRefSamples = numBackwardRefSamples.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }

            if (deinterlaceTechnology is not null)
            {
                DeinterlaceTechnology = deinterlaceTechnology.Value;
            }

            if (procAmpControlCaps is not null)
            {
                ProcAmpControlCaps = procAmpControlCaps.Value;
            }

            if (videoProcessorOperations is not null)
            {
                VideoProcessorOperations = videoProcessorOperations.Value;
            }

            if (noiseFilterTechnology is not null)
            {
                NoiseFilterTechnology = noiseFilterTechnology.Value;
            }

            if (detailFilterTechnology is not null)
            {
                DetailFilterTechnology = detailFilterTechnology.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DeviceCaps")]
        public uint DeviceCaps;

        [NativeName("Type", "D3DPOOL")]
        [NativeName("Type.Name", "D3DPOOL")]
        [NativeName("Name", "InputPool")]
        public Silk.NET.Direct3D9.Pool InputPool;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumForwardRefSamples")]
        public uint NumForwardRefSamples;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumBackwardRefSamples")]
        public uint NumBackwardRefSamples;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Reserved")]
        public uint Reserved;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DeinterlaceTechnology")]
        public uint DeinterlaceTechnology;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ProcAmpControlCaps")]
        public uint ProcAmpControlCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "VideoProcessorOperations")]
        public uint VideoProcessorOperations;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NoiseFilterTechnology")]
        public uint NoiseFilterTechnology;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DetailFilterTechnology")]
        public uint DetailFilterTechnology;
    }
}
