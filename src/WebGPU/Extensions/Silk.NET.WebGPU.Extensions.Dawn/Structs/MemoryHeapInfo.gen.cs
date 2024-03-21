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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUMemoryHeapInfo")]
    public unsafe partial struct MemoryHeapInfo
    {
        public MemoryHeapInfo
        (
            uint? properties = null,
            ulong? size = null
        ) : this()
        {
            if (properties is not null)
            {
                Properties = properties.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }
        }


        [NativeName("Type", "WGPUHeapPropertyFlags")]
        [NativeName("Type.Name", "WGPUHeapPropertyFlags")]
        [NativeName("Name", "properties")]
        public uint Properties;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "size")]
        public ulong Size;
    }
}
