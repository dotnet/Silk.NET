// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT")]
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
