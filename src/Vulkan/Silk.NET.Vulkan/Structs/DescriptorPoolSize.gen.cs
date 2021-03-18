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
    [NativeName("Name", "VkDescriptorPoolSize")]
    public unsafe partial struct DescriptorPoolSize
    {
        public DescriptorPoolSize
        (
            DescriptorType? type = null,
            uint? descriptorCount = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (descriptorCount is not null)
            {
                DescriptorCount = descriptorCount.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDescriptorType")]
        [NativeName("Type.Name", "VkDescriptorType")]
        [NativeName("Name", "type")]
        public DescriptorType Type;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorCount")]
        public uint DescriptorCount;
    }
}
