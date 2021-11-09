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
    [NativeName("Name", "VkPhysicalDeviceRayTracingPipelinePropertiesKHR")]
    public unsafe partial struct PhysicalDeviceRayTracingPipelinePropertiesKHR : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceRayTracingPipelinePropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceRayTracingPipelinePropertiesKhr,
            void* pNext = null,
            uint? shaderGroupHandleSize = null,
            uint? maxRayRecursionDepth = null,
            uint? maxShaderGroupStride = null,
            uint? shaderGroupBaseAlignment = null,
            uint? shaderGroupHandleCaptureReplaySize = null,
            uint? maxRayDispatchInvocationCount = null,
            uint? shaderGroupHandleAlignment = null,
            uint? maxRayHitAttributeSize = null
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

            if (shaderGroupHandleSize is not null)
            {
                ShaderGroupHandleSize = shaderGroupHandleSize.Value;
            }

            if (maxRayRecursionDepth is not null)
            {
                MaxRayRecursionDepth = maxRayRecursionDepth.Value;
            }

            if (maxShaderGroupStride is not null)
            {
                MaxShaderGroupStride = maxShaderGroupStride.Value;
            }

            if (shaderGroupBaseAlignment is not null)
            {
                ShaderGroupBaseAlignment = shaderGroupBaseAlignment.Value;
            }

            if (shaderGroupHandleCaptureReplaySize is not null)
            {
                ShaderGroupHandleCaptureReplaySize = shaderGroupHandleCaptureReplaySize.Value;
            }

            if (maxRayDispatchInvocationCount is not null)
            {
                MaxRayDispatchInvocationCount = maxRayDispatchInvocationCount.Value;
            }

            if (shaderGroupHandleAlignment is not null)
            {
                ShaderGroupHandleAlignment = shaderGroupHandleAlignment.Value;
            }

            if (maxRayHitAttributeSize is not null)
            {
                MaxRayHitAttributeSize = maxRayHitAttributeSize.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shaderGroupHandleSize")]
        public uint ShaderGroupHandleSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxRayRecursionDepth")]
        public uint MaxRayRecursionDepth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxShaderGroupStride")]
        public uint MaxShaderGroupStride;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shaderGroupBaseAlignment")]
        public uint ShaderGroupBaseAlignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shaderGroupHandleCaptureReplaySize")]
        public uint ShaderGroupHandleCaptureReplaySize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxRayDispatchInvocationCount")]
        public uint MaxRayDispatchInvocationCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shaderGroupHandleAlignment")]
        public uint ShaderGroupHandleAlignment;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxRayHitAttributeSize")]
        public uint MaxRayHitAttributeSize;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceRayTracingPipelinePropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
