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
    [NativeName("Name", "VkPhysicalDeviceVulkan13Features")]
    public unsafe partial struct PhysicalDeviceVulkan13Features : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceVulkan13Features
        (
            StructureType? sType = StructureType.PhysicalDeviceVulkan13Features,
            void* pNext = null,
            Bool32? robustImageAccess = null,
            Bool32? inlineUniformBlock = null,
            Bool32? descriptorBindingInlineUniformBlockUpdateAfterBind = null,
            Bool32? pipelineCreationCacheControl = null,
            Bool32? privateData = null,
            Bool32? shaderDemoteToHelperInvocation = null,
            Bool32? shaderTerminateInvocation = null,
            Bool32? subgroupSizeControl = null,
            Bool32? computeFullSubgroups = null,
            Bool32? synchronization2 = null,
            Bool32? textureCompressionAstcHdr = null,
            Bool32? shaderZeroInitializeWorkgroupMemory = null,
            Bool32? dynamicRendering = null,
            Bool32? shaderIntegerDotProduct = null,
            Bool32? maintenance4 = null
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

            if (robustImageAccess is not null)
            {
                RobustImageAccess = robustImageAccess.Value;
            }

            if (inlineUniformBlock is not null)
            {
                InlineUniformBlock = inlineUniformBlock.Value;
            }

            if (descriptorBindingInlineUniformBlockUpdateAfterBind is not null)
            {
                DescriptorBindingInlineUniformBlockUpdateAfterBind = descriptorBindingInlineUniformBlockUpdateAfterBind.Value;
            }

            if (pipelineCreationCacheControl is not null)
            {
                PipelineCreationCacheControl = pipelineCreationCacheControl.Value;
            }

            if (privateData is not null)
            {
                PrivateData = privateData.Value;
            }

            if (shaderDemoteToHelperInvocation is not null)
            {
                ShaderDemoteToHelperInvocation = shaderDemoteToHelperInvocation.Value;
            }

            if (shaderTerminateInvocation is not null)
            {
                ShaderTerminateInvocation = shaderTerminateInvocation.Value;
            }

            if (subgroupSizeControl is not null)
            {
                SubgroupSizeControl = subgroupSizeControl.Value;
            }

            if (computeFullSubgroups is not null)
            {
                ComputeFullSubgroups = computeFullSubgroups.Value;
            }

            if (synchronization2 is not null)
            {
                Synchronization2 = synchronization2.Value;
            }

            if (textureCompressionAstcHdr is not null)
            {
                TextureCompressionAstcHdr = textureCompressionAstcHdr.Value;
            }

            if (shaderZeroInitializeWorkgroupMemory is not null)
            {
                ShaderZeroInitializeWorkgroupMemory = shaderZeroInitializeWorkgroupMemory.Value;
            }

            if (dynamicRendering is not null)
            {
                DynamicRendering = dynamicRendering.Value;
            }

            if (shaderIntegerDotProduct is not null)
            {
                ShaderIntegerDotProduct = shaderIntegerDotProduct.Value;
            }

            if (maintenance4 is not null)
            {
                Maintenance4 = maintenance4.Value;
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
        [NativeName("Name", "robustImageAccess")]
        public Bool32 RobustImageAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "inlineUniformBlock")]
        public Bool32 InlineUniformBlock;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "descriptorBindingInlineUniformBlockUpdateAfterBind")]
        public Bool32 DescriptorBindingInlineUniformBlockUpdateAfterBind;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "pipelineCreationCacheControl")]
        public Bool32 PipelineCreationCacheControl;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "privateData")]
        public Bool32 PrivateData;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDemoteToHelperInvocation")]
        public Bool32 ShaderDemoteToHelperInvocation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderTerminateInvocation")]
        public Bool32 ShaderTerminateInvocation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "subgroupSizeControl")]
        public Bool32 SubgroupSizeControl;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "computeFullSubgroups")]
        public Bool32 ComputeFullSubgroups;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "synchronization2")]
        public Bool32 Synchronization2;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "textureCompressionASTC_HDR")]
        public Bool32 TextureCompressionAstcHdr;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderZeroInitializeWorkgroupMemory")]
        public Bool32 ShaderZeroInitializeWorkgroupMemory;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dynamicRendering")]
        public Bool32 DynamicRendering;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderIntegerDotProduct")]
        public Bool32 ShaderIntegerDotProduct;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "maintenance4")]
        public Bool32 Maintenance4;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceVulkan13Features;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
