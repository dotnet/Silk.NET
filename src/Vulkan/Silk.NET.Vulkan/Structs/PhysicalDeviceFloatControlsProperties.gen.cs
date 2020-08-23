// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceFloatControlsProperties")]
    public unsafe partial struct PhysicalDeviceFloatControlsProperties
    {
        public PhysicalDeviceFloatControlsProperties
        (
            StructureType sType = StructureType.PhysicalDeviceFloatControlsProperties,
            void* pNext = default,
            ShaderFloatControlsIndependence denormBehaviorIndependence = default,
            ShaderFloatControlsIndependence roundingModeIndependence = default,
            Bool32 shaderSignedZeroInfNanPreserveFloat16 = default,
            Bool32 shaderSignedZeroInfNanPreserveFloat32 = default,
            Bool32 shaderSignedZeroInfNanPreserveFloat64 = default,
            Bool32 shaderDenormPreserveFloat16 = default,
            Bool32 shaderDenormPreserveFloat32 = default,
            Bool32 shaderDenormPreserveFloat64 = default,
            Bool32 shaderDenormFlushToZeroFloat16 = default,
            Bool32 shaderDenormFlushToZeroFloat32 = default,
            Bool32 shaderDenormFlushToZeroFloat64 = default,
            Bool32 shaderRoundingModeRtefloat16 = default,
            Bool32 shaderRoundingModeRtefloat32 = default,
            Bool32 shaderRoundingModeRtefloat64 = default,
            Bool32 shaderRoundingModeRtzfloat16 = default,
            Bool32 shaderRoundingModeRtzfloat32 = default,
            Bool32 shaderRoundingModeRtzfloat64 = default
        )
        {
            SType = sType;
            PNext = pNext;
            DenormBehaviorIndependence = denormBehaviorIndependence;
            RoundingModeIndependence = roundingModeIndependence;
            ShaderSignedZeroInfNanPreserveFloat16 = shaderSignedZeroInfNanPreserveFloat16;
            ShaderSignedZeroInfNanPreserveFloat32 = shaderSignedZeroInfNanPreserveFloat32;
            ShaderSignedZeroInfNanPreserveFloat64 = shaderSignedZeroInfNanPreserveFloat64;
            ShaderDenormPreserveFloat16 = shaderDenormPreserveFloat16;
            ShaderDenormPreserveFloat32 = shaderDenormPreserveFloat32;
            ShaderDenormPreserveFloat64 = shaderDenormPreserveFloat64;
            ShaderDenormFlushToZeroFloat16 = shaderDenormFlushToZeroFloat16;
            ShaderDenormFlushToZeroFloat32 = shaderDenormFlushToZeroFloat32;
            ShaderDenormFlushToZeroFloat64 = shaderDenormFlushToZeroFloat64;
            ShaderRoundingModeRtefloat16 = shaderRoundingModeRtefloat16;
            ShaderRoundingModeRtefloat32 = shaderRoundingModeRtefloat32;
            ShaderRoundingModeRtefloat64 = shaderRoundingModeRtefloat64;
            ShaderRoundingModeRtzfloat16 = shaderRoundingModeRtzfloat16;
            ShaderRoundingModeRtzfloat32 = shaderRoundingModeRtzfloat32;
            ShaderRoundingModeRtzfloat64 = shaderRoundingModeRtzfloat64;
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
    }
}
