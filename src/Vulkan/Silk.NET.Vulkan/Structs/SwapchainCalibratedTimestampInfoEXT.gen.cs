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
    [NativeName("Name", "VkSwapchainCalibratedTimestampInfoEXT")]
    public unsafe partial struct SwapchainCalibratedTimestampInfoEXT : IExtendsChain<CalibratedTimestampInfoKHR>, IExtendsChain<CalibratedTimestampInfoEXT>
    {
        public SwapchainCalibratedTimestampInfoEXT
        (
            StructureType? sType = StructureType.SwapchainCalibratedTimestampInfoExt,
            void* pNext = null,
            SwapchainKHR? swapchain = null,
            PresentStageFlagsEXT? presentStage = null,
            ulong? timeDomainId = null
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

            if (swapchain is not null)
            {
                Swapchain = swapchain.Value;
            }

            if (presentStage is not null)
            {
                PresentStage = presentStage.Value;
            }

            if (timeDomainId is not null)
            {
                TimeDomainId = timeDomainId.Value;
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
        [NativeName("Type", "VkSwapchainKHR")]
        [NativeName("Type.Name", "VkSwapchainKHR")]
        [NativeName("Name", "swapchain")]
        public SwapchainKHR Swapchain;
/// <summary></summary>
        [NativeName("Type", "VkPresentStageFlagsEXT")]
        [NativeName("Type.Name", "VkPresentStageFlagsEXT")]
        [NativeName("Name", "presentStage")]
        public PresentStageFlagsEXT PresentStage;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "timeDomainId")]
        public ulong TimeDomainId;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SwapchainCalibratedTimestampInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
