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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_device_pci_bus_info_khr")]
    public unsafe partial struct DevicePciBusInfoKhr
    {
        public DevicePciBusInfoKhr
        (
            uint? pciDomain = null,
            uint? pciBus = null,
            uint? pciDevice = null,
            uint? pciFunction = null
        ) : this()
        {
            if (pciDomain is not null)
            {
                PciDomain = pciDomain.Value;
            }

            if (pciBus is not null)
            {
                PciBus = pciBus.Value;
            }

            if (pciDevice is not null)
            {
                PciDevice = pciDevice.Value;
            }

            if (pciFunction is not null)
            {
                PciFunction = pciFunction.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "pci_domain")]
        public uint PciDomain;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "pci_bus")]
        public uint PciBus;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "pci_device")]
        public uint PciDevice;
/// <summary></summary>
        [NativeName("Type", "cl_uint")]
        [NativeName("Type.Name", "cl_uint")]
        [NativeName("Name", "pci_function")]
        public uint PciFunction;
    }
}
