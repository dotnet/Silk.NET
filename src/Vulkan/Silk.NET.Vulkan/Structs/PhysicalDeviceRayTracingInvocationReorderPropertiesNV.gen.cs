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
    [NativeName("Name", "VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV")]
    public unsafe partial struct PhysicalDeviceRayTracingInvocationReorderPropertiesNV : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceRayTracingInvocationReorderPropertiesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceRayTracingInvocationReorderPropertiesNV,
            void* pNext = null,
            RayTracingInvocationReorderModeNV? rayTracingInvocationReorderReorderingHint = null
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

            if (rayTracingInvocationReorderReorderingHint is not null)
            {
                RayTracingInvocationReorderReorderingHint = rayTracingInvocationReorderReorderingHint.Value;
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
        [NativeName("Type", "VkRayTracingInvocationReorderModeNV")]
        [NativeName("Type.Name", "VkRayTracingInvocationReorderModeNV")]
        [NativeName("Name", "rayTracingInvocationReorderReorderingHint")]
        public RayTracingInvocationReorderModeNV RayTracingInvocationReorderReorderingHint;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceRayTracingInvocationReorderPropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
