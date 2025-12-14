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
    [NativeName("Name", "VkSwapchainImageCreateInfoOHOS")]
    public unsafe partial struct SwapchainImageCreateInfoOHOS : IExtendsChain<ImageCreateInfo>
    {
        public SwapchainImageCreateInfoOHOS
        (
            StructureType? sType = StructureType.SwapchainImageCreateInfoOhos,
            void* pNext = null,
            SwapchainImageUsageFlagsOHOS? usage = null
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

            if (usage is not null)
            {
                Usage = usage.Value;
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
        [NativeName("Type", "VkSwapchainImageUsageFlagsOHOS")]
        [NativeName("Type.Name", "VkSwapchainImageUsageFlagsOHOS")]
        [NativeName("Name", "usage")]
        public SwapchainImageUsageFlagsOHOS Usage;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SwapchainImageCreateInfoOhos;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
