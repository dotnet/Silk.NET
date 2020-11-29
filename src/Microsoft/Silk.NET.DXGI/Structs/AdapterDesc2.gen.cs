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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_ADAPTER_DESC2")]
    public unsafe partial struct AdapterDesc2
    {
        public AdapterDesc2
        (
            uint? vendorId = null,
            uint? deviceId = null,
            uint? subSysId = null,
            uint? revision = null,
            uint? dedicatedVideoMemory = null,
            uint? dedicatedSystemMemory = null,
            uint? sharedSystemMemory = null,
            ValueTuple<ulong,long>? adapterLuid = null,
            uint? flags = null,
            GraphicsPreemptionGranularity? graphicsPreemptionGranularity = null,
            ComputePreemptionGranularity? computePreemptionGranularity = null
        ) : this()
        {
            if (vendorId is not null)
            {
                VendorId = vendorId.Value;
            }

            if (deviceId is not null)
            {
                DeviceId = deviceId.Value;
            }

            if (subSysId is not null)
            {
                SubSysId = subSysId.Value;
            }

            if (revision is not null)
            {
                Revision = revision.Value;
            }

            if (dedicatedVideoMemory is not null)
            {
                DedicatedVideoMemory = dedicatedVideoMemory.Value;
            }

            if (dedicatedSystemMemory is not null)
            {
                DedicatedSystemMemory = dedicatedSystemMemory.Value;
            }

            if (sharedSystemMemory is not null)
            {
                SharedSystemMemory = sharedSystemMemory.Value;
            }

            if (adapterLuid is not null)
            {
                AdapterLuid = adapterLuid.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (graphicsPreemptionGranularity is not null)
            {
                GraphicsPreemptionGranularity = graphicsPreemptionGranularity.Value;
            }

            if (computePreemptionGranularity is not null)
            {
                ComputePreemptionGranularity = computePreemptionGranularity.Value;
            }
        }

        [NativeName("Type", "WCHAR [128]")]
        [NativeName("Type.Name", "WCHAR [128]")]
        [NativeName("Name", "Description")]
        public fixed char Description[128];

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "VendorId")]
        public uint VendorId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DeviceId")]
        public uint DeviceId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SubSysId")]
        public uint SubSysId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Revision")]
        public uint Revision;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "DedicatedVideoMemory")]
        public uint DedicatedVideoMemory;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "DedicatedSystemMemory")]
        public uint DedicatedSystemMemory;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "SharedSystemMemory")]
        public uint SharedSystemMemory;

        [NativeName("Type", "LUID")]
        [NativeName("Type.Name", "LUID")]
        [NativeName("Name", "AdapterLuid")]
        public ValueTuple<ulong,long> AdapterLuid;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;

        [NativeName("Type", "DXGI_GRAPHICS_PREEMPTION_GRANULARITY")]
        [NativeName("Type.Name", "DXGI_GRAPHICS_PREEMPTION_GRANULARITY")]
        [NativeName("Name", "GraphicsPreemptionGranularity")]
        public GraphicsPreemptionGranularity GraphicsPreemptionGranularity;

        [NativeName("Type", "DXGI_COMPUTE_PREEMPTION_GRANULARITY")]
        [NativeName("Type.Name", "DXGI_COMPUTE_PREEMPTION_GRANULARITY")]
        [NativeName("Name", "ComputePreemptionGranularity")]
        public ComputePreemptionGranularity ComputePreemptionGranularity;
    }
}
