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
    [NativeName("Name", "VkSwapchainPresentModeInfoEXT")]
    public unsafe partial struct SwapchainPresentModeInfoEXT : IExtendsChain<PresentInfoKHR>
    {
        public SwapchainPresentModeInfoEXT
        (
            StructureType? sType = StructureType.SwapchainPresentModeInfoExt,
            void* pNext = null,
            uint? swapchainCount = null,
            PresentModeKHR* pPresentModes = null
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

            if (swapchainCount is not null)
            {
                SwapchainCount = swapchainCount.Value;
            }

            if (pPresentModes is not null)
            {
                PPresentModes = pPresentModes;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "swapchainCount")]
        public uint SwapchainCount;
/// <summary></summary>
        [NativeName("Type", "VkPresentModeKHR*")]
        [NativeName("Type.Name", "VkPresentModeKHR")]
        [NativeName("Name", "pPresentModes")]
        public PresentModeKHR* PPresentModes;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SwapchainPresentModeInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
