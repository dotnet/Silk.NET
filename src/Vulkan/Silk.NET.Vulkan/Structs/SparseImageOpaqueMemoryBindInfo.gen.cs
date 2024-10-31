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
    [NativeName("Name", "VkSparseImageOpaqueMemoryBindInfo")]
    public unsafe partial struct SparseImageOpaqueMemoryBindInfo
    {
        public SparseImageOpaqueMemoryBindInfo
        (
            Image? image = null,
            uint? bindCount = null,
            SparseMemoryBind* pBinds = null
        ) : this()
        {
            if (image is not null)
            {
                Image = image.Value;
            }

            if (bindCount is not null)
            {
                BindCount = bindCount.Value;
            }

            if (pBinds is not null)
            {
                PBinds = pBinds;
            }
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
