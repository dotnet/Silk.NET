// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceFloatControlsProperties
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ShaderFloatControlsIndependence DenormBehaviorIndependence;
/// <summary></summary>
        public ShaderFloatControlsIndependence RoundingModeIndependence;
/// <summary></summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat16;
/// <summary></summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat32;
/// <summary></summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat64;
/// <summary></summary>
        public Bool32 ShaderDenormPreserveFloat16;
/// <summary></summary>
        public Bool32 ShaderDenormPreserveFloat32;
/// <summary></summary>
        public Bool32 ShaderDenormPreserveFloat64;
/// <summary></summary>
        public Bool32 ShaderDenormFlushToZeroFloat16;
/// <summary></summary>
        public Bool32 ShaderDenormFlushToZeroFloat32;
/// <summary></summary>
        public Bool32 ShaderDenormFlushToZeroFloat64;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtefloat16;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtefloat32;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtefloat64;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtzfloat16;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtzfloat32;
/// <summary></summary>
        public Bool32 ShaderRoundingModeRtzfloat64;
    }
}
