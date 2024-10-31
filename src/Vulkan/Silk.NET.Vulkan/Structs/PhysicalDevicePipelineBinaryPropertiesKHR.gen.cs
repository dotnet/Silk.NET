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
    [NativeName("Name", "VkPhysicalDevicePipelineBinaryPropertiesKHR")]
    public unsafe partial struct PhysicalDevicePipelineBinaryPropertiesKHR : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDevicePipelineBinaryPropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDevicePipelineBinaryPropertiesKhr,
            void* pNext = null,
            Bool32? pipelineBinaryInternalCache = null,
            Bool32? pipelineBinaryInternalCacheControl = null,
            Bool32? pipelineBinaryPrefersInternalCache = null,
            Bool32? pipelineBinaryPrecompiledInternalCache = null,
            Bool32? pipelineBinaryCompressedData = null
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

            if (pipelineBinaryInternalCache is not null)
            {
                PipelineBinaryInternalCache = pipelineBinaryInternalCache.Value;
            }

            if (pipelineBinaryInternalCacheControl is not null)
            {
                PipelineBinaryInternalCacheControl = pipelineBinaryInternalCacheControl.Value;
            }

            if (pipelineBinaryPrefersInternalCache is not null)
            {
                PipelineBinaryPrefersInternalCache = pipelineBinaryPrefersInternalCache.Value;
            }

            if (pipelineBinaryPrecompiledInternalCache is not null)
            {
                PipelineBinaryPrecompiledInternalCache = pipelineBinaryPrecompiledInternalCache.Value;
            }

            if (pipelineBinaryCompressedData is not null)
            {
                PipelineBinaryCompressedData = pipelineBinaryCompressedData.Value;
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
        [NativeName("Name", "pipelineBinaryInternalCache")]
        public Bool32 PipelineBinaryInternalCache;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "pipelineBinaryInternalCacheControl")]
        public Bool32 PipelineBinaryInternalCacheControl;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "pipelineBinaryPrefersInternalCache")]
        public Bool32 PipelineBinaryPrefersInternalCache;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "pipelineBinaryPrecompiledInternalCache")]
        public Bool32 PipelineBinaryPrecompiledInternalCache;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "pipelineBinaryCompressedData")]
        public Bool32 PipelineBinaryCompressedData;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDevicePipelineBinaryPropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
