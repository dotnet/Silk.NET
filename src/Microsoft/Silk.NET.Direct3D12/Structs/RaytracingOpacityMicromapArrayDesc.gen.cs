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
    [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC")]
    public unsafe partial struct RaytracingOpacityMicromapArrayDesc
    {
        public RaytracingOpacityMicromapArrayDesc
        (
            uint? numOmmHistogramEntries = null,
            RaytracingOpacityMicromapHistogramEntry* pOmmHistogram = null,
            ulong? inputBuffer = null,
            GpuVirtualAddressAndStride? perOmmDescs = null
        ) : this()
        {
            if (numOmmHistogramEntries is not null)
            {
                NumOmmHistogramEntries = numOmmHistogramEntries.Value;
            }

            if (pOmmHistogram is not null)
            {
                POmmHistogram = pOmmHistogram;
            }

            if (inputBuffer is not null)
            {
                InputBuffer = inputBuffer.Value;
            }

            if (perOmmDescs is not null)
            {
                PerOmmDescs = perOmmDescs.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumOmmHistogramEntries")]
        public uint NumOmmHistogramEntries;

        [NativeName("Type", "const D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY *")]
        [NativeName("Type.Name", "const D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY *")]
        [NativeName("Name", "pOmmHistogram")]
        public RaytracingOpacityMicromapHistogramEntry* POmmHistogram;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "InputBuffer")]
        public ulong InputBuffer;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Name", "PerOmmDescs")]
        public GpuVirtualAddressAndStride PerOmmDescs;
    }
}
