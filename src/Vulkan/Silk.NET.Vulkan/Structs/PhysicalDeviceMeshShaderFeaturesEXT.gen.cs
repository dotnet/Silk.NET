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
    [NativeName("Name", "VkPhysicalDeviceMeshShaderFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceMeshShaderFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceMeshShaderFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceMeshShaderFeaturesExt,
            void* pNext = null,
            Bool32? taskShader = null,
            Bool32? meshShader = null,
            Bool32? multiviewMeshShader = null,
            Bool32? primitiveFragmentShadingRateMeshShader = null,
            Bool32? meshShaderQueries = null
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

            if (taskShader is not null)
            {
                TaskShader = taskShader.Value;
            }

            if (meshShader is not null)
            {
                MeshShader = meshShader.Value;
            }

            if (multiviewMeshShader is not null)
            {
                MultiviewMeshShader = multiviewMeshShader.Value;
            }

            if (primitiveFragmentShadingRateMeshShader is not null)
            {
                PrimitiveFragmentShadingRateMeshShader = primitiveFragmentShadingRateMeshShader.Value;
            }

            if (meshShaderQueries is not null)
            {
                MeshShaderQueries = meshShaderQueries.Value;
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
        [NativeName("Name", "taskShader")]
        public Bool32 TaskShader;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "meshShader")]
        public Bool32 MeshShader;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multiviewMeshShader")]
        public Bool32 MultiviewMeshShader;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "primitiveFragmentShadingRateMeshShader")]
        public Bool32 PrimitiveFragmentShadingRateMeshShader;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "meshShaderQueries")]
        public Bool32 MeshShaderQueries;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceMeshShaderFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
