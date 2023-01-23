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

namespace Silk.NET.DXGI
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "DXGI_ADAPTER_DESC1")]
    public unsafe partial struct AdapterDesc1
    {
        public AdapterDesc1
        (
            uint? vendorId = null,
            uint? deviceId = null,
            uint? subSysId = null,
            uint? revision = null,
            nuint? dedicatedVideoMemory = null,
            nuint? dedicatedSystemMemory = null,
            nuint? sharedSystemMemory = null,
            Luid? adapterLuid = null,
            uint? flags = null
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
        }

        [NativeName("Type", "WCHAR[128]")]
        [NativeName("Type.Name", "WCHAR[128]")]
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
        public nuint DedicatedVideoMemory;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "DedicatedSystemMemory")]
        public nuint DedicatedSystemMemory;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "SharedSystemMemory")]
        public nuint SharedSystemMemory;

        [NativeName("Type", "LUID")]
        [NativeName("Type.Name", "LUID")]
        [NativeName("Name", "AdapterLuid")]
        public Luid AdapterLuid;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;
    }
}
