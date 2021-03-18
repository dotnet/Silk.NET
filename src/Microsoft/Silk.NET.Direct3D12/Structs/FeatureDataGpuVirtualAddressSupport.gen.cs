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
    [NativeName("Name", "D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT")]
    public unsafe partial struct FeatureDataGpuVirtualAddressSupport
    {
        public FeatureDataGpuVirtualAddressSupport
        (
            uint? maxGPUVirtualAddressBitsPerResource = null,
            uint? maxGPUVirtualAddressBitsPerProcess = null
        ) : this()
        {
            if (maxGPUVirtualAddressBitsPerResource is not null)
            {
                MaxGPUVirtualAddressBitsPerResource = maxGPUVirtualAddressBitsPerResource.Value;
            }

            if (maxGPUVirtualAddressBitsPerProcess is not null)
            {
                MaxGPUVirtualAddressBitsPerProcess = maxGPUVirtualAddressBitsPerProcess.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxGPUVirtualAddressBitsPerResource")]
        public uint MaxGPUVirtualAddressBitsPerResource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxGPUVirtualAddressBitsPerProcess")]
        public uint MaxGPUVirtualAddressBitsPerProcess;
    }
}
