// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct RayTracingShaderGroupCreateInfoKHR
    {
        public RayTracingShaderGroupCreateInfoKHR
        (
            StructureType sType = StructureType.RayTracingShaderGroupCreateInfoKhr,
            void* pNext = default,
            RayTracingShaderGroupTypeKHR type = default,
            uint generalShader = default,
            uint closestHitShader = default,
            uint anyHitShader = default,
            uint intersectionShader = default,
            void* pShaderGroupCaptureReplayHandle = default
        )
        {
           SType = sType;
           PNext = pNext;
           Type = type;
           GeneralShader = generalShader;
           ClosestHitShader = closestHitShader;
           AnyHitShader = anyHitShader;
           IntersectionShader = intersectionShader;
           PShaderGroupCaptureReplayHandle = pShaderGroupCaptureReplayHandle;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public RayTracingShaderGroupTypeKHR Type;
/// <summary></summary>
        public uint GeneralShader;
/// <summary></summary>
        public uint ClosestHitShader;
/// <summary></summary>
        public uint AnyHitShader;
/// <summary></summary>
        public uint IntersectionShader;
/// <summary></summary>
        public void* PShaderGroupCaptureReplayHandle;
    }
}
