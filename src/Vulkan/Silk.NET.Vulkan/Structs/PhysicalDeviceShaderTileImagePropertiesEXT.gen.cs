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
    [NativeName("Name", "VkPhysicalDeviceShaderTileImagePropertiesEXT")]
    public unsafe partial struct PhysicalDeviceShaderTileImagePropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceShaderTileImagePropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderTileImagePropertiesExt,
            void* pNext = null,
            Bool32? shaderTileImageCoherentReadAccelerated = null,
            Bool32? shaderTileImageReadSampleFromPixelRateInvocation = null,
            Bool32? shaderTileImageReadFromHelperInvocation = null
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

            if (shaderTileImageCoherentReadAccelerated is not null)
            {
                ShaderTileImageCoherentReadAccelerated = shaderTileImageCoherentReadAccelerated.Value;
            }

            if (shaderTileImageReadSampleFromPixelRateInvocation is not null)
            {
                ShaderTileImageReadSampleFromPixelRateInvocation = shaderTileImageReadSampleFromPixelRateInvocation.Value;
            }

            if (shaderTileImageReadFromHelperInvocation is not null)
            {
                ShaderTileImageReadFromHelperInvocation = shaderTileImageReadFromHelperInvocation.Value;
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
        [NativeName("Name", "shaderTileImageCoherentReadAccelerated")]
        public Bool32 ShaderTileImageCoherentReadAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderTileImageReadSampleFromPixelRateInvocation")]
        public Bool32 ShaderTileImageReadSampleFromPixelRateInvocation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderTileImageReadFromHelperInvocation")]
        public Bool32 ShaderTileImageReadFromHelperInvocation;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderTileImagePropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
