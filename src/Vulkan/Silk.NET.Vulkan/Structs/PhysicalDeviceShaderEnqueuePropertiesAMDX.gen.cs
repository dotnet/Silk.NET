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
    [NativeName("Name", "VkPhysicalDeviceShaderEnqueuePropertiesAMDX")]
    public unsafe partial struct PhysicalDeviceShaderEnqueuePropertiesAMDX : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceShaderEnqueuePropertiesAMDX
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderEnqueuePropertiesAmdx,
            void* pNext = null,
            uint? maxExecutionGraphDepth = null,
            uint? maxExecutionGraphShaderOutputNodes = null,
            uint? maxExecutionGraphShaderPayloadSize = null,
            uint? maxExecutionGraphShaderPayloadCount = null,
            uint? executionGraphDispatchAddressAlignment = null,
            uint? maxExecutionGraphWorkgroups = null
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

            if (maxExecutionGraphDepth is not null)
            {
                MaxExecutionGraphDepth = maxExecutionGraphDepth.Value;
            }

            if (maxExecutionGraphShaderOutputNodes is not null)
            {
                MaxExecutionGraphShaderOutputNodes = maxExecutionGraphShaderOutputNodes.Value;
            }

            if (maxExecutionGraphShaderPayloadSize is not null)
            {
                MaxExecutionGraphShaderPayloadSize = maxExecutionGraphShaderPayloadSize.Value;
            }

            if (maxExecutionGraphShaderPayloadCount is not null)
            {
                MaxExecutionGraphShaderPayloadCount = maxExecutionGraphShaderPayloadCount.Value;
            }

            if (executionGraphDispatchAddressAlignment is not null)
            {
                ExecutionGraphDispatchAddressAlignment = executionGraphDispatchAddressAlignment.Value;
            }

            if (maxExecutionGraphWorkgroups is not null)
            {
                MaxExecutionGraphWorkgroups = maxExecutionGraphWorkgroups.Value;
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
        [NativeName("Name", "maxExecutionGraphDepth")]
        public uint MaxExecutionGraphDepth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxExecutionGraphShaderOutputNodes")]
        public uint MaxExecutionGraphShaderOutputNodes;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxExecutionGraphShaderPayloadSize")]
        public uint MaxExecutionGraphShaderPayloadSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxExecutionGraphShaderPayloadCount")]
        public uint MaxExecutionGraphShaderPayloadCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "executionGraphDispatchAddressAlignment")]
        public uint ExecutionGraphDispatchAddressAlignment;
        /// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxExecutionGraphWorkgroupCount")]
        public fixed uint MaxExecutionGraphWorkgroupCount[3];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxExecutionGraphWorkgroups")]
        public uint MaxExecutionGraphWorkgroups;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderEnqueuePropertiesAmdx;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
