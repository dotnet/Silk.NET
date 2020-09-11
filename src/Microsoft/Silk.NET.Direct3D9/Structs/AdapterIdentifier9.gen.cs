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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DADAPTER_IDENTIFIER9")]
    public unsafe partial struct AdapterIdentifier9
    {
        public AdapterIdentifier9
        (
            long driverVersion = default,
            uint vendorId = default,
            uint deviceId = default,
            uint subSysId = default,
            uint revision = default,
            Guid deviceIdentifier = default,
            uint wHQLLevel = default
        )
        {
            DriverVersion = driverVersion;
            VendorId = vendorId;
            DeviceId = deviceId;
            SubSysId = subSysId;
            Revision = revision;
            DeviceIdentifier = deviceIdentifier;
            WHQLLevel = wHQLLevel;
        }

        [NativeName("Type", "char [512]")]
        [NativeName("Type.Name", "char [512]")]
        [NativeName("Name", "Driver")]
        public fixed byte Driver[512];
        [NativeName("Type", "char [512]")]
        [NativeName("Type.Name", "char [512]")]
        [NativeName("Name", "Description")]
        public fixed byte Description[512];
        [NativeName("Type", "char [32]")]
        [NativeName("Type.Name", "char [32]")]
        [NativeName("Name", "DeviceName")]
        public fixed byte DeviceName[32];

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "DriverVersion")]
        public long DriverVersion;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "VendorId")]
        public uint VendorId;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DeviceId")]
        public uint DeviceId;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "SubSysId")]
        public uint SubSysId;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Revision")]
        public uint Revision;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "DeviceIdentifier")]
        public Guid DeviceIdentifier;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "WHQLLevel")]
        public uint WHQLLevel;
    }
}
