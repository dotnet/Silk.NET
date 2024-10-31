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
    [NativeName("Name", "VkPhysicalDeviceExtendedDynamicState2FeaturesEXT")]
    public unsafe partial struct PhysicalDeviceExtendedDynamicState2FeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceExtendedDynamicState2FeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceExtendedDynamicState2FeaturesExt,
            void* pNext = null,
            Bool32? extendedDynamicState2 = null,
            Bool32? extendedDynamicState2LogicOp = null,
            Bool32? extendedDynamicState2PatchControlPoints = null
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

            if (extendedDynamicState2 is not null)
            {
                ExtendedDynamicState2 = extendedDynamicState2.Value;
            }

            if (extendedDynamicState2LogicOp is not null)
            {
                ExtendedDynamicState2LogicOp = extendedDynamicState2LogicOp.Value;
            }

            if (extendedDynamicState2PatchControlPoints is not null)
            {
                ExtendedDynamicState2PatchControlPoints = extendedDynamicState2PatchControlPoints.Value;
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
        [NativeName("Name", "extendedDynamicState2")]
        public Bool32 ExtendedDynamicState2;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState2LogicOp")]
        public Bool32 ExtendedDynamicState2LogicOp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState2PatchControlPoints")]
        public Bool32 ExtendedDynamicState2PatchControlPoints;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceExtendedDynamicState2FeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
