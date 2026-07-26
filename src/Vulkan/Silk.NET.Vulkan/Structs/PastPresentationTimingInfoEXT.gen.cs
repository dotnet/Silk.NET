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
    [NativeName("Name", "VkPastPresentationTimingInfoEXT")]
    public unsafe partial struct PastPresentationTimingInfoEXT : IChainable
    {
        public PastPresentationTimingInfoEXT
        (
            StructureType? sType = StructureType.PastPresentationTimingInfoExt,
            void* pNext = null,
            PastPresentationTimingFlagsEXT? flags = null,
            SwapchainKHR? swapchain = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (swapchain is not null)
            {
                Swapchain = swapchain.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkPastPresentationTimingFlagsEXT")]
        [NativeName("Type.Name", "VkPastPresentationTimingFlagsEXT")]
        [NativeName("Name", "flags")]
        public PastPresentationTimingFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "VkSwapchainKHR")]
        [NativeName("Type.Name", "VkSwapchainKHR")]
        [NativeName("Name", "swapchain")]
        public SwapchainKHR Swapchain;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PastPresentationTimingInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
