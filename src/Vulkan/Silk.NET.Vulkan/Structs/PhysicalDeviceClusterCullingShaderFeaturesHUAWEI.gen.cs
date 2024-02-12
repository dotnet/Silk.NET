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
    [NativeName("Name", "VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI")]
    public unsafe partial struct PhysicalDeviceClusterCullingShaderFeaturesHUAWEI : IChainStart, IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceClusterCullingShaderFeaturesHUAWEI
        (
            StructureType? sType = StructureType.PhysicalDeviceClusterCullingShaderFeaturesHuawei,
            void* pNext = null,
            Bool32? clustercullingShader = null,
            Bool32? multiviewClusterCullingShader = null
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

            if (clustercullingShader is not null)
            {
                ClustercullingShader = clustercullingShader.Value;
            }

            if (multiviewClusterCullingShader is not null)
            {
                MultiviewClusterCullingShader = multiviewClusterCullingShader.Value;
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
        [NativeName("Name", "clustercullingShader")]
        public Bool32 ClustercullingShader;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multiviewClusterCullingShader")]
        public Bool32 MultiviewClusterCullingShader;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceClusterCullingShaderFeaturesHuawei;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref PhysicalDeviceClusterCullingShaderFeaturesHUAWEI Chain(
            out PhysicalDeviceClusterCullingShaderFeaturesHUAWEI capture)
        {
            capture = new PhysicalDeviceClusterCullingShaderFeaturesHUAWEI(StructureType.PhysicalDeviceClusterCullingShaderFeaturesHuawei);
            return ref capture;
        }
    }
}
