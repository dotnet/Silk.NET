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
    [NativeName("Name", "VkDispatchGraphCountInfoAMDX")]
    public unsafe partial struct DispatchGraphCountInfoAMDX
    {
        public DispatchGraphCountInfoAMDX
        (
            uint? count = null,
            DeviceOrHostAddressConstAMDX? infos = null,
            ulong? stride = null
        ) : this()
        {
            if (count is not null)
            {
                Count = count.Value;
            }

            if (infos is not null)
            {
                Infos = infos.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "count")]
        public uint Count;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstAMDX")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstAMDX")]
        [NativeName("Name", "infos")]
        public DeviceOrHostAddressConstAMDX Infos;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "stride")]
        public ulong Stride;
    }
}
