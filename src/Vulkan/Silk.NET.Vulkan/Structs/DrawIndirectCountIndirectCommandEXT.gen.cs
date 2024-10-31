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
    [NativeName("Name", "VkDrawIndirectCountIndirectCommandEXT")]
    public unsafe partial struct DrawIndirectCountIndirectCommandEXT
    {
        public DrawIndirectCountIndirectCommandEXT
        (
            ulong? bufferAddress = null,
            uint? stride = null,
            uint? commandCount = null
        ) : this()
        {
            if (bufferAddress is not null)
            {
                BufferAddress = bufferAddress.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }

            if (commandCount is not null)
            {
                CommandCount = commandCount.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "bufferAddress")]
        public ulong BufferAddress;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stride")]
        public uint Stride;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "commandCount")]
        public uint CommandCount;
    }
}
