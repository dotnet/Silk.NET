// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_ADAPTER_DESC")]
    public unsafe partial struct AdapterDesc
    {
        public AdapterDesc
        (
            uint vendorId = default,
            uint deviceId = default,
            uint subSysId = default,
            uint revision = default,
            uint dedicatedVideoMemory = default,
            uint dedicatedSystemMemory = default,
            uint sharedSystemMemory = default,
            ValueTuple<ulong,long> adapterLuid = default
        )
        {
            VendorId = vendorId;
            DeviceId = deviceId;
            SubSysId = subSysId;
            Revision = revision;
            DedicatedVideoMemory = dedicatedVideoMemory;
            DedicatedSystemMemory = dedicatedSystemMemory;
            SharedSystemMemory = sharedSystemMemory;
            AdapterLuid = adapterLuid;
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
    }
}
