// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public enum PerformanceCounterScopeKHR
    {
        PerformanceCounterScopeCommandBufferKhr = 0,
        PerformanceCounterScopeRenderPassKhr = 1,
        PerformanceCounterScopeCommandKhr = 2,
        QueryScopeCommandBufferKhr = 0,
        QueryScopeRenderPassKhr = 1,
        QueryScopeCommandKhr = 2,
    }
}
