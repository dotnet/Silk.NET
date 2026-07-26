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
    [NativeName("Name", "VkPhysicalDevicePresentTimingFeaturesEXT")]
    public unsafe partial struct PhysicalDevicePresentTimingFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDevicePresentTimingFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDevicePresentTimingFeaturesExt,
            void* pNext = null,
            Bool32? presentTiming = null,
            Bool32? presentAtAbsoluteTime = null,
            Bool32? presentAtRelativeTime = null
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

            if (presentTiming is not null)
            {
                PresentTiming = presentTiming.Value;
            }

            if (presentAtAbsoluteTime is not null)
            {
                PresentAtAbsoluteTime = presentAtAbsoluteTime.Value;
            }

            if (presentAtRelativeTime is not null)
            {
                PresentAtRelativeTime = presentAtRelativeTime.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "presentTiming")]
        public Bool32 PresentTiming;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "presentAtAbsoluteTime")]
        public Bool32 PresentAtAbsoluteTime;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "presentAtRelativeTime")]
        public Bool32 PresentAtRelativeTime;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDevicePresentTimingFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
