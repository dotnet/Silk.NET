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
    [NativeName("Name", "WGPUAdapterInfo")]
    public unsafe partial struct AdapterInfo
    {
        public AdapterInfo
        (
            ChainedStruct* nextInChain = null,
            StringView? vendor = null,
            StringView? architecture = null,
            StringView? device = null,
            StringView? description = null,
            BackendType? backendType = null,
            AdapterType? adapterType = null,
            uint? vendorID = null,
            uint? deviceID = null,
            uint? subgroupMinSize = null,
            uint? subgroupMaxSize = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (vendor is not null)
            {
                Vendor = vendor.Value;
            }

            if (architecture is not null)
            {
                Architecture = architecture.Value;
            }

            if (device is not null)
            {
                Device = device.Value;
            }

            if (description is not null)
            {
                Description = description.Value;
            }

            if (backendType is not null)
            {
                BackendType = backendType.Value;
            }

            if (adapterType is not null)
            {
                AdapterType = adapterType.Value;
            }

            if (vendorID is not null)
            {
                VendorID = vendorID.Value;
            }

            if (deviceID is not null)
            {
                DeviceID = deviceID.Value;
            }

            if (subgroupMinSize is not null)
            {
                SubgroupMinSize = subgroupMinSize.Value;
            }

            if (subgroupMaxSize is not null)
            {
                SubgroupMaxSize = subgroupMaxSize.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct *")]
        [NativeName("Type.Name", "WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "vendor")]
        public StringView Vendor;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "architecture")]
        public StringView Architecture;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "device")]
        public StringView Device;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "description")]
        public StringView Description;

        [NativeName("Type", "WGPUBackendType")]
        [NativeName("Type.Name", "WGPUBackendType")]
        [NativeName("Name", "backendType")]
        public BackendType BackendType;

        [NativeName("Type", "WGPUAdapterType")]
        [NativeName("Type.Name", "WGPUAdapterType")]
        [NativeName("Name", "adapterType")]
        public AdapterType AdapterType;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vendorID")]
        public uint VendorID;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceID")]
        public uint DeviceID;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subgroupMinSize")]
        public uint SubgroupMinSize;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subgroupMaxSize")]
        public uint SubgroupMaxSize;
    }
}
