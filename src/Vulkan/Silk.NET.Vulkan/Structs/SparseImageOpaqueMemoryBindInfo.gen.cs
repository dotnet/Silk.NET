// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSparseImageOpaqueMemoryBindInfo")]
    public unsafe struct SparseImageOpaqueMemoryBindInfo
    {
        public SparseImageOpaqueMemoryBindInfo
        (
            Image image = default,
            uint bindCount = default,
            SparseMemoryBind* pBinds = default
        )
        {
           Image = image;
           BindCount = bindCount;
           PBinds = pBinds;
        }

/// <summary></summary>
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "image")]
        public Image Image;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bindCount")]
        public uint BindCount;
/// <summary></summary>
        [NativeName("Type", "VkSparseMemoryBind*")]
        [NativeName("Type.Name", "VkSparseMemoryBind")]
        [NativeName("Name", "pBinds")]
        public SparseMemoryBind* PBinds;
    }
}
