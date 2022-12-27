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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DADAPTER_IDENTIFIER9")]
    public unsafe partial struct AdapterIdentifier9
    {
        public AdapterIdentifier9
        (
            long? driverVersion = null,
            uint? vendorId = null,
            uint? deviceId = null,
            uint? subSysId = null,
            uint? revision = null,
            Guid? deviceIdentifier = null,
            uint? wHQLLevel = null
        ) : this()
        {
            if (driverVersion is not null)
            {
                DriverVersion = driverVersion.Value;
            }

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

            if (deviceIdentifier is not null)
            {
                DeviceIdentifier = deviceIdentifier.Value;
            }

            if (wHQLLevel is not null)
            {
                WHQLLevel = wHQLLevel.Value;
            }
        }

        [NativeName("Type", "char[512]")]
        [NativeName("Type.Name", "char[512]")]
        [NativeName("Name", "Driver")]
        public fixed byte Driver[512];
        [NativeName("Type", "char[512]")]
        [NativeName("Type.Name", "char[512]")]
        [NativeName("Name", "Description")]
        public fixed byte Description[512];
        [NativeName("Type", "char[32]")]
        [NativeName("Type.Name", "char[32]")]
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
