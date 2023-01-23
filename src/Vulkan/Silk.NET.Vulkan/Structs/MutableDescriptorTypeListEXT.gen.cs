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
    [NativeName("Name", "VkMutableDescriptorTypeListEXT")]
    [NativeName("Aliases", "VkMutableDescriptorTypeListVALVE")]
    public unsafe partial struct MutableDescriptorTypeListEXT
    {
        public MutableDescriptorTypeListEXT
        (
            uint? descriptorTypeCount = null,
            DescriptorType* pDescriptorTypes = null
        ) : this()
        {
            if (descriptorTypeCount is not null)
            {
                DescriptorTypeCount = descriptorTypeCount.Value;
            }

            if (pDescriptorTypes is not null)
            {
                PDescriptorTypes = pDescriptorTypes;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptorTypeCount")]
        public uint DescriptorTypeCount;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorType*")]
        [NativeName("Type.Name", "VkDescriptorType")]
        [NativeName("Name", "pDescriptorTypes")]
        public DescriptorType* PDescriptorTypes;
    }
}
