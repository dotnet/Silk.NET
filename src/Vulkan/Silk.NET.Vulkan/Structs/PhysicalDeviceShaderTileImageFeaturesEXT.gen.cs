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
    [NativeName("Name", "VkPhysicalDeviceShaderTileImageFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceShaderTileImageFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceShaderTileImageFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderTileImageFeaturesExt,
            void* pNext = null,
            Bool32? shaderTileImageColorReadAccess = null,
            Bool32? shaderTileImageDepthReadAccess = null,
            Bool32? shaderTileImageStencilReadAccess = null
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

            if (shaderTileImageColorReadAccess is not null)
            {
                ShaderTileImageColorReadAccess = shaderTileImageColorReadAccess.Value;
            }

            if (shaderTileImageDepthReadAccess is not null)
            {
                ShaderTileImageDepthReadAccess = shaderTileImageDepthReadAccess.Value;
            }

            if (shaderTileImageStencilReadAccess is not null)
            {
                ShaderTileImageStencilReadAccess = shaderTileImageStencilReadAccess.Value;
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
        [NativeName("Name", "shaderTileImageColorReadAccess")]
        public Bool32 ShaderTileImageColorReadAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderTileImageDepthReadAccess")]
        public Bool32 ShaderTileImageDepthReadAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderTileImageStencilReadAccess")]
        public Bool32 ShaderTileImageStencilReadAccess;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderTileImageFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
