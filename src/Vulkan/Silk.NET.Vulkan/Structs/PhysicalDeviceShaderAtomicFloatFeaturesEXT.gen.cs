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
    [NativeName("Name", "VkPhysicalDeviceShaderAtomicFloatFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceShaderAtomicFloatFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceShaderAtomicFloatFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderAtomicFloatFeaturesExt,
            void* pNext = null,
            Bool32? shaderBufferFloat32Atomics = null,
            Bool32? shaderBufferFloat32AtomicAdd = null,
            Bool32? shaderBufferFloat64Atomics = null,
            Bool32? shaderBufferFloat64AtomicAdd = null,
            Bool32? shaderSharedFloat32Atomics = null,
            Bool32? shaderSharedFloat32AtomicAdd = null,
            Bool32? shaderSharedFloat64Atomics = null,
            Bool32? shaderSharedFloat64AtomicAdd = null,
            Bool32? shaderImageFloat32Atomics = null,
            Bool32? shaderImageFloat32AtomicAdd = null,
            Bool32? sparseImageFloat32Atomics = null,
            Bool32? sparseImageFloat32AtomicAdd = null
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

            if (shaderBufferFloat32Atomics is not null)
            {
                ShaderBufferFloat32Atomics = shaderBufferFloat32Atomics.Value;
            }

            if (shaderBufferFloat32AtomicAdd is not null)
            {
                ShaderBufferFloat32AtomicAdd = shaderBufferFloat32AtomicAdd.Value;
            }

            if (shaderBufferFloat64Atomics is not null)
            {
                ShaderBufferFloat64Atomics = shaderBufferFloat64Atomics.Value;
            }

            if (shaderBufferFloat64AtomicAdd is not null)
            {
                ShaderBufferFloat64AtomicAdd = shaderBufferFloat64AtomicAdd.Value;
            }

            if (shaderSharedFloat32Atomics is not null)
            {
                ShaderSharedFloat32Atomics = shaderSharedFloat32Atomics.Value;
            }

            if (shaderSharedFloat32AtomicAdd is not null)
            {
                ShaderSharedFloat32AtomicAdd = shaderSharedFloat32AtomicAdd.Value;
            }

            if (shaderSharedFloat64Atomics is not null)
            {
                ShaderSharedFloat64Atomics = shaderSharedFloat64Atomics.Value;
            }

            if (shaderSharedFloat64AtomicAdd is not null)
            {
                ShaderSharedFloat64AtomicAdd = shaderSharedFloat64AtomicAdd.Value;
            }

            if (shaderImageFloat32Atomics is not null)
            {
                ShaderImageFloat32Atomics = shaderImageFloat32Atomics.Value;
            }

            if (shaderImageFloat32AtomicAdd is not null)
            {
                ShaderImageFloat32AtomicAdd = shaderImageFloat32AtomicAdd.Value;
            }

            if (sparseImageFloat32Atomics is not null)
            {
                SparseImageFloat32Atomics = sparseImageFloat32Atomics.Value;
            }

            if (sparseImageFloat32AtomicAdd is not null)
            {
                SparseImageFloat32AtomicAdd = sparseImageFloat32AtomicAdd.Value;
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
        [NativeName("Name", "shaderBufferFloat32Atomics")]
        public Bool32 ShaderBufferFloat32Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderBufferFloat32AtomicAdd")]
        public Bool32 ShaderBufferFloat32AtomicAdd;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderBufferFloat64Atomics")]
        public Bool32 ShaderBufferFloat64Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderBufferFloat64AtomicAdd")]
        public Bool32 ShaderBufferFloat64AtomicAdd;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedFloat32Atomics")]
        public Bool32 ShaderSharedFloat32Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedFloat32AtomicAdd")]
        public Bool32 ShaderSharedFloat32AtomicAdd;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedFloat64Atomics")]
        public Bool32 ShaderSharedFloat64Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedFloat64AtomicAdd")]
        public Bool32 ShaderSharedFloat64AtomicAdd;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderImageFloat32Atomics")]
        public Bool32 ShaderImageFloat32Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderImageFloat32AtomicAdd")]
        public Bool32 ShaderImageFloat32AtomicAdd;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseImageFloat32Atomics")]
        public Bool32 SparseImageFloat32Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseImageFloat32AtomicAdd")]
        public Bool32 SparseImageFloat32AtomicAdd;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderAtomicFloatFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
