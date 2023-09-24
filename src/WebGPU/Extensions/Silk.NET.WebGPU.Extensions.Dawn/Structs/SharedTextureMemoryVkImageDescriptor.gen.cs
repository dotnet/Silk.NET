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
    [NativeName("Name", "WGPUSharedTextureMemoryVkImageDescriptor")]
    public unsafe partial struct SharedTextureMemoryVkImageDescriptor
    {
        public SharedTextureMemoryVkImageDescriptor
        (
            ChainedStruct? chain = null,
            int? vkFormat = null,
            int? vkUsageFlags = null,
            Extent3D? vkExtent3D = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (vkFormat is not null)
            {
                VkFormat = vkFormat.Value;
            }

            if (vkUsageFlags is not null)
            {
                VkUsageFlags = vkUsageFlags.Value;
            }

            if (vkExtent3D is not null)
            {
                VkExtent3D = vkExtent3D.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "vkFormat")]
        public int VkFormat;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "vkUsageFlags")]
        public int VkUsageFlags;

        [NativeName("Type", "WGPUExtent3D")]
        [NativeName("Type.Name", "WGPUExtent3D")]
        [NativeName("Name", "vkExtent3D")]
        public Extent3D VkExtent3D;
    }
}
