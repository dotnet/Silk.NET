// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    public enum PipelineBindPoint
    {
        Graphics = 0,
        Compute = 1,
        RayTracingKhr = 1000165000,
        RayTracingNV = 1000165000,
    }
}
