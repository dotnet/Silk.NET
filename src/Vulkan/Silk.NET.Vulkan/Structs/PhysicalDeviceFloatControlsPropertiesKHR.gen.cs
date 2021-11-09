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
    [NativeName("Name", "VkPhysicalDeviceFloatControlsPropertiesKHR")]
    [NativeName("AliasOf", "VkPhysicalDeviceFloatControlsProperties")]
    public unsafe partial struct PhysicalDeviceFloatControlsPropertiesKHR : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceFloatControlsPropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceFloatControlsProperties,
            void* pNext = null,
            ShaderFloatControlsIndependence? denormBehaviorIndependence = null,
            ShaderFloatControlsIndependence? roundingModeIndependence = null,
            Bool32? shaderSignedZeroInfNanPreserveFloat16 = null,
            Bool32? shaderSignedZeroInfNanPreserveFloat32 = null,
            Bool32? shaderSignedZeroInfNanPreserveFloat64 = null,
            Bool32? shaderDenormPreserveFloat16 = null,
            Bool32? shaderDenormPreserveFloat32 = null,
            Bool32? shaderDenormPreserveFloat64 = null,
            Bool32? shaderDenormFlushToZeroFloat16 = null,
            Bool32? shaderDenormFlushToZeroFloat32 = null,
            Bool32? shaderDenormFlushToZeroFloat64 = null,
            Bool32? shaderRoundingModeRtefloat16 = null,
            Bool32? shaderRoundingModeRtefloat32 = null,
            Bool32? shaderRoundingModeRtefloat64 = null,
            Bool32? shaderRoundingModeRtzfloat16 = null,
            Bool32? shaderRoundingModeRtzfloat32 = null,
            Bool32? shaderRoundingModeRtzfloat64 = null
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

            if (denormBehaviorIndependence is not null)
            {
                DenormBehaviorIndependence = denormBehaviorIndependence.Value;
            }

            if (roundingModeIndependence is not null)
            {
                RoundingModeIndependence = roundingModeIndependence.Value;
            }

            if (shaderSignedZeroInfNanPreserveFloat16 is not null)
            {
                ShaderSignedZeroInfNanPreserveFloat16 = shaderSignedZeroInfNanPreserveFloat16.Value;
            }

            if (shaderSignedZeroInfNanPreserveFloat32 is not null)
            {
                ShaderSignedZeroInfNanPreserveFloat32 = shaderSignedZeroInfNanPreserveFloat32.Value;
            }

            if (shaderSignedZeroInfNanPreserveFloat64 is not null)
            {
                ShaderSignedZeroInfNanPreserveFloat64 = shaderSignedZeroInfNanPreserveFloat64.Value;
            }

            if (shaderDenormPreserveFloat16 is not null)
            {
                ShaderDenormPreserveFloat16 = shaderDenormPreserveFloat16.Value;
            }

            if (shaderDenormPreserveFloat32 is not null)
            {
                ShaderDenormPreserveFloat32 = shaderDenormPreserveFloat32.Value;
            }

            if (shaderDenormPreserveFloat64 is not null)
            {
                ShaderDenormPreserveFloat64 = shaderDenormPreserveFloat64.Value;
            }

            if (shaderDenormFlushToZeroFloat16 is not null)
            {
                ShaderDenormFlushToZeroFloat16 = shaderDenormFlushToZeroFloat16.Value;
            }

            if (shaderDenormFlushToZeroFloat32 is not null)
            {
                ShaderDenormFlushToZeroFloat32 = shaderDenormFlushToZeroFloat32.Value;
            }

            if (shaderDenormFlushToZeroFloat64 is not null)
            {
                ShaderDenormFlushToZeroFloat64 = shaderDenormFlushToZeroFloat64.Value;
            }

            if (shaderRoundingModeRtefloat16 is not null)
            {
                ShaderRoundingModeRtefloat16 = shaderRoundingModeRtefloat16.Value;
            }

            if (shaderRoundingModeRtefloat32 is not null)
            {
                ShaderRoundingModeRtefloat32 = shaderRoundingModeRtefloat32.Value;
            }

            if (shaderRoundingModeRtefloat64 is not null)
            {
                ShaderRoundingModeRtefloat64 = shaderRoundingModeRtefloat64.Value;
            }

            if (shaderRoundingModeRtzfloat16 is not null)
            {
                ShaderRoundingModeRtzfloat16 = shaderRoundingModeRtzfloat16.Value;
            }

            if (shaderRoundingModeRtzfloat32 is not null)
            {
                ShaderRoundingModeRtzfloat32 = shaderRoundingModeRtzfloat32.Value;
            }

            if (shaderRoundingModeRtzfloat64 is not null)
            {
                ShaderRoundingModeRtzfloat64 = shaderRoundingModeRtzfloat64.Value;
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
        [NativeName("Type", "VkShaderFloatControlsIndependence")]
        [NativeName("Type.Name", "VkShaderFloatControlsIndependence")]
        [NativeName("Name", "denormBehaviorIndependence")]
        public ShaderFloatControlsIndependence DenormBehaviorIndependence;
/// <summary></summary>
        [NativeName("Type", "VkShaderFloatControlsIndependence")]
        [NativeName("Type.Name", "VkShaderFloatControlsIndependence")]
        [NativeName("Name", "roundingModeIndependence")]
        public ShaderFloatControlsIndependence RoundingModeIndependence;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSignedZeroInfNanPreserveFloat16")]
        public Bool32 ShaderSignedZeroInfNanPreserveFloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSignedZeroInfNanPreserveFloat32")]
        public Bool32 ShaderSignedZeroInfNanPreserveFloat32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSignedZeroInfNanPreserveFloat64")]
        public Bool32 ShaderSignedZeroInfNanPreserveFloat64;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormPreserveFloat16")]
        public Bool32 ShaderDenormPreserveFloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormPreserveFloat32")]
        public Bool32 ShaderDenormPreserveFloat32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormPreserveFloat64")]
        public Bool32 ShaderDenormPreserveFloat64;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormFlushToZeroFloat16")]
        public Bool32 ShaderDenormFlushToZeroFloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormFlushToZeroFloat32")]
        public Bool32 ShaderDenormFlushToZeroFloat32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDenormFlushToZeroFloat64")]
        public Bool32 ShaderDenormFlushToZeroFloat64;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTEFloat16")]
        public Bool32 ShaderRoundingModeRtefloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTEFloat32")]
        public Bool32 ShaderRoundingModeRtefloat32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTEFloat64")]
        public Bool32 ShaderRoundingModeRtefloat64;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTZFloat16")]
        public Bool32 ShaderRoundingModeRtzfloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTZFloat32")]
        public Bool32 ShaderRoundingModeRtzfloat32;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderRoundingModeRTZFloat64")]
        public Bool32 ShaderRoundingModeRtzfloat64;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceFloatControlsProperties;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
