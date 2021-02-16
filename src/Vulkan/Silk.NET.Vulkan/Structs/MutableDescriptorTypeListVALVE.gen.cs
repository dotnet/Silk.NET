// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkMutableDescriptorTypeListVALVE")]
    public unsafe partial struct MutableDescriptorTypeListVALVE
    {
        public MutableDescriptorTypeListVALVE
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
