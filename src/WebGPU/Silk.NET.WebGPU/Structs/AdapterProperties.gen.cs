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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUAdapterProperties")]
    public unsafe partial struct AdapterProperties
    {
        public AdapterProperties
        (
            ChainedStructOut* nextInChain = null,
            uint? vendorID = null,
            byte* vendorName = null,
            byte* architecture = null,
            uint? deviceID = null,
            byte* name = null,
            byte* driverDescription = null,
            AdapterType? adapterType = null,
            BackendType? backendType = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (vendorID is not null)
            {
                VendorID = vendorID.Value;
            }

            if (vendorName is not null)
            {
                VendorName = vendorName;
            }

            if (architecture is not null)
            {
                Architecture = architecture;
            }

            if (deviceID is not null)
            {
                DeviceID = deviceID.Value;
            }

            if (name is not null)
            {
                Name = name;
            }

            if (driverDescription is not null)
            {
                DriverDescription = driverDescription;
            }

            if (adapterType is not null)
            {
                AdapterType = adapterType.Value;
            }

            if (backendType is not null)
            {
                BackendType = backendType.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut *")]
        [NativeName("Type.Name", "WGPUChainedStructOut *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStructOut* NextInChain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vendorID")]
        public uint VendorID;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "vendorName")]
        public byte* VendorName;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "architecture")]
        public byte* Architecture;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceID")]
        public uint DeviceID;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "name")]
        public byte* Name;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "driverDescription")]
        public byte* DriverDescription;

        [NativeName("Type", "WGPUAdapterType")]
        [NativeName("Type.Name", "WGPUAdapterType")]
        [NativeName("Name", "adapterType")]
        public AdapterType AdapterType;

        [NativeName("Type", "WGPUBackendType")]
        [NativeName("Type.Name", "WGPUBackendType")]
        [NativeName("Name", "backendType")]
        public BackendType BackendType;
    }
}
