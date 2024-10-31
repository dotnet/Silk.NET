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
    [NativeName("Name", "VkPhysicalDeviceCooperativeMatrix2FeaturesNV")]
    public unsafe partial struct PhysicalDeviceCooperativeMatrix2FeaturesNV : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceCooperativeMatrix2FeaturesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceCooperativeMatrix2FeaturesNV,
            void* pNext = null,
            Bool32? cooperativeMatrixWorkgroupScope = null,
            Bool32? cooperativeMatrixFlexibleDimensions = null,
            Bool32? cooperativeMatrixReductions = null,
            Bool32? cooperativeMatrixConversions = null,
            Bool32? cooperativeMatrixPerElementOperations = null,
            Bool32? cooperativeMatrixTensorAddressing = null,
            Bool32? cooperativeMatrixBlockLoads = null
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

            if (cooperativeMatrixWorkgroupScope is not null)
            {
                CooperativeMatrixWorkgroupScope = cooperativeMatrixWorkgroupScope.Value;
            }

            if (cooperativeMatrixFlexibleDimensions is not null)
            {
                CooperativeMatrixFlexibleDimensions = cooperativeMatrixFlexibleDimensions.Value;
            }

            if (cooperativeMatrixReductions is not null)
            {
                CooperativeMatrixReductions = cooperativeMatrixReductions.Value;
            }

            if (cooperativeMatrixConversions is not null)
            {
                CooperativeMatrixConversions = cooperativeMatrixConversions.Value;
            }

            if (cooperativeMatrixPerElementOperations is not null)
            {
                CooperativeMatrixPerElementOperations = cooperativeMatrixPerElementOperations.Value;
            }

            if (cooperativeMatrixTensorAddressing is not null)
            {
                CooperativeMatrixTensorAddressing = cooperativeMatrixTensorAddressing.Value;
            }

            if (cooperativeMatrixBlockLoads is not null)
            {
                CooperativeMatrixBlockLoads = cooperativeMatrixBlockLoads.Value;
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
        [NativeName("Name", "cooperativeMatrixWorkgroupScope")]
        public Bool32 CooperativeMatrixWorkgroupScope;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "cooperativeMatrixFlexibleDimensions")]
        public Bool32 CooperativeMatrixFlexibleDimensions;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "cooperativeMatrixReductions")]
        public Bool32 CooperativeMatrixReductions;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "cooperativeMatrixConversions")]
        public Bool32 CooperativeMatrixConversions;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "cooperativeMatrixPerElementOperations")]
        public Bool32 CooperativeMatrixPerElementOperations;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "cooperativeMatrixTensorAddressing")]
        public Bool32 CooperativeMatrixTensorAddressing;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "cooperativeMatrixBlockLoads")]
        public Bool32 CooperativeMatrixBlockLoads;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceCooperativeMatrix2FeaturesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
