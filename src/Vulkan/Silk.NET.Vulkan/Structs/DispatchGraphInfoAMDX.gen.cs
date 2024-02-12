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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDispatchGraphInfoAMDX")]
    public unsafe partial struct DispatchGraphInfoAMDX
    {
        public DispatchGraphInfoAMDX
        (
            uint? nodeIndex = null,
            uint? payloadCount = null,
            DeviceOrHostAddressConstAMDX? payloads = null,
            ulong? payloadStride = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (payloadCount is not null)
            {
                PayloadCount = payloadCount.Value;
            }

            if (payloads is not null)
            {
                Payloads = payloads.Value;
            }

            if (payloadStride is not null)
            {
                PayloadStride = payloadStride.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "nodeIndex")]
        public uint NodeIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "payloadCount")]
        public uint PayloadCount;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstAMDX")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstAMDX")]
        [NativeName("Name", "payloads")]
        public DeviceOrHostAddressConstAMDX Payloads;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "payloadStride")]
        public ulong PayloadStride;
    }
}
