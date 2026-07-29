// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_device_pci_bus_info_khr")]
public partial struct DevicePciBusInfoKHR
{
    [NativeName("pci_domain")]
    public uint PciDomain;

    [NativeName("pci_bus")]
    public uint PciBus;

    [NativeName("pci_device")]
    public uint PciDevice;

    [NativeName("pci_function")]
    public uint PciFunction;
}
