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
    [NativeName("Name", "VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT")]
    public unsafe partial struct PhysicalDeviceShaderAtomicFloat2FeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceShaderAtomicFloat2FeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderAtomicFloat2FeaturesExt,
            void* pNext = null,
            Bool32? shaderBufferFloat16Atomics = null,
            Bool32? shaderBufferFloat16AtomicAdd = null,
            Bool32? shaderBufferFloat16AtomicMinMax = null,
            Bool32? shaderBufferFloat32AtomicMinMax = null,
            Bool32? shaderBufferFloat64AtomicMinMax = null,
            Bool32? shaderSharedFloat16Atomics = null,
            Bool32? shaderSharedFloat16AtomicAdd = null,
            Bool32? shaderSharedFloat16AtomicMinMax = null,
            Bool32? shaderSharedFloat32AtomicMinMax = null,
            Bool32? shaderSharedFloat64AtomicMinMax = null,
            Bool32? shaderImageFloat32AtomicMinMax = null,
            Bool32? sparseImageFloat32AtomicMinMax = null
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

            if (shaderBufferFloat16Atomics is not null)
            {
                ShaderBufferFloat16Atomics = shaderBufferFloat16Atomics.Value;
            }

            if (shaderBufferFloat16AtomicAdd is not null)
            {
                ShaderBufferFloat16AtomicAdd = shaderBufferFloat16AtomicAdd.Value;
            }

            if (shaderBufferFloat16AtomicMinMax is not null)
            {
                ShaderBufferFloat16AtomicMinMax = shaderBufferFloat16AtomicMinMax.Value;
            }

            if (shaderBufferFloat32AtomicMinMax is not null)
            {
                ShaderBufferFloat32AtomicMinMax = shaderBufferFloat32AtomicMinMax.Value;
            }

            if (shaderBufferFloat64AtomicMinMax is not null)
            {
                ShaderBufferFloat64AtomicMinMax = shaderBufferFloat64AtomicMinMax.Value;
            }

            if (shaderSharedFloat16Atomics is not null)
            {
                ShaderSharedFloat16Atomics = shaderSharedFloat16Atomics.Value;
            }

            if (shaderSharedFloat16AtomicAdd is not null)
            {
                ShaderSharedFloat16AtomicAdd = shaderSharedFloat16AtomicAdd.Value;
            }

            if (shaderSharedFloat16AtomicMinMax is not null)
            {
                ShaderSharedFloat16AtomicMinMax = shaderSharedFloat16AtomicMinMax.Value;
            }

            if (shaderSharedFloat32AtomicMinMax is not null)
            {
                ShaderSharedFloat32AtomicMinMax = shaderSharedFloat32AtomicMinMax.Value;
            }

            if (shaderSharedFloat64AtomicMinMax is not null)
            {
                ShaderSharedFloat64AtomicMinMax = shaderSharedFloat64AtomicMinMax.Value;
            }

            if (shaderImageFloat32AtomicMinMax is not null)
            {
                ShaderImageFloat32AtomicMinMax = shaderImageFloat32AtomicMinMax.Value;
            }

            if (sparseImageFloat32AtomicMinMax is not null)
            {
                SparseImageFloat32AtomicMinMax = sparseImageFloat32AtomicMinMax.Value;
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
        [NativeName("Name", "shaderBufferFloat16Atomics")]
        public Bool32 ShaderBufferFloat16Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderBufferFloat16AtomicAdd")]
        public Bool32 ShaderBufferFloat16AtomicAdd;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderBufferFloat16AtomicMinMax")]
        public Bool32 ShaderBufferFloat16AtomicMinMax;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderBufferFloat32AtomicMinMax")]
        public Bool32 ShaderBufferFloat32AtomicMinMax;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderBufferFloat64AtomicMinMax")]
        public Bool32 ShaderBufferFloat64AtomicMinMax;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedFloat16Atomics")]
        public Bool32 ShaderSharedFloat16Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedFloat16AtomicAdd")]
        public Bool32 ShaderSharedFloat16AtomicAdd;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedFloat16AtomicMinMax")]
        public Bool32 ShaderSharedFloat16AtomicMinMax;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedFloat32AtomicMinMax")]
        public Bool32 ShaderSharedFloat32AtomicMinMax;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedFloat64AtomicMinMax")]
        public Bool32 ShaderSharedFloat64AtomicMinMax;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderImageFloat32AtomicMinMax")]
        public Bool32 ShaderImageFloat32AtomicMinMax;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseImageFloat32AtomicMinMax")]
        public Bool32 SparseImageFloat32AtomicMinMax;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderAtomicFloat2FeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
