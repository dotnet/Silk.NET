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
    [NativeName("Name", "VkSwapchainPresentScalingCreateInfoEXT")]
    public unsafe partial struct SwapchainPresentScalingCreateInfoEXT : IExtendsChain<SwapchainCreateInfoKHR>
    {
        public SwapchainPresentScalingCreateInfoEXT
        (
            StructureType? sType = StructureType.SwapchainPresentScalingCreateInfoExt,
            void* pNext = null,
            PresentScalingFlagsEXT? scalingBehavior = null,
            PresentGravityFlagsEXT? presentGravityX = null,
            PresentGravityFlagsEXT? presentGravityY = null
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

            if (scalingBehavior is not null)
            {
                ScalingBehavior = scalingBehavior.Value;
            }

            if (presentGravityX is not null)
            {
                PresentGravityX = presentGravityX.Value;
            }

            if (presentGravityY is not null)
            {
                PresentGravityY = presentGravityY.Value;
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
        [NativeName("Type", "VkPresentScalingFlagsEXT")]
        [NativeName("Type.Name", "VkPresentScalingFlagsEXT")]
        [NativeName("Name", "scalingBehavior")]
        public PresentScalingFlagsEXT ScalingBehavior;
/// <summary></summary>
        [NativeName("Type", "VkPresentGravityFlagsEXT")]
        [NativeName("Type.Name", "VkPresentGravityFlagsEXT")]
        [NativeName("Name", "presentGravityX")]
        public PresentGravityFlagsEXT PresentGravityX;
/// <summary></summary>
        [NativeName("Type", "VkPresentGravityFlagsEXT")]
        [NativeName("Type.Name", "VkPresentGravityFlagsEXT")]
        [NativeName("Name", "presentGravityY")]
        public PresentGravityFlagsEXT PresentGravityY;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SwapchainPresentScalingCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
