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
    [NativeName("Name", "VkPhysicalDeviceSchedulingControlsPropertiesARM")]
    public unsafe partial struct PhysicalDeviceSchedulingControlsPropertiesARM : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceSchedulingControlsPropertiesARM
        (
            StructureType? sType = StructureType.PhysicalDeviceSchedulingControlsPropertiesArm,
            void* pNext = null,
            PhysicalDeviceSchedulingControlsFlagsARM? schedulingControlsFlags = null
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

            if (schedulingControlsFlags is not null)
            {
                SchedulingControlsFlags = schedulingControlsFlags.Value;
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
        [NativeName("Type", "VkPhysicalDeviceSchedulingControlsFlagsARM")]
        [NativeName("Type.Name", "VkPhysicalDeviceSchedulingControlsFlagsARM")]
        [NativeName("Name", "schedulingControlsFlags")]
        public PhysicalDeviceSchedulingControlsFlagsARM SchedulingControlsFlags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceSchedulingControlsPropertiesArm;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
