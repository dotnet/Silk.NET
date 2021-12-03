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
    [NativeName("Name", "VkPhysicalDeviceShaderAtomicInt64Features")]
    [NativeName("Aliases", "VkPhysicalDeviceShaderAtomicInt64FeaturesKHR")]
    public unsafe partial struct PhysicalDeviceShaderAtomicInt64Features : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceShaderAtomicInt64Features
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderAtomicInt64Features,
            void* pNext = null,
            Bool32? shaderBufferInt64Atomics = null,
            Bool32? shaderSharedInt64Atomics = null
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

            if (shaderBufferInt64Atomics is not null)
            {
                ShaderBufferInt64Atomics = shaderBufferInt64Atomics.Value;
            }

            if (shaderSharedInt64Atomics is not null)
            {
                ShaderSharedInt64Atomics = shaderSharedInt64Atomics.Value;
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
        [NativeName("Name", "shaderBufferInt64Atomics")]
        public Bool32 ShaderBufferInt64Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedInt64Atomics")]
        public Bool32 ShaderSharedInt64Atomics;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderAtomicInt64Features;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
