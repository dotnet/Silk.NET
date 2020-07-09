// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPerformanceValueINTEL")]
    public unsafe struct PerformanceValueINTEL
    {
        public PerformanceValueINTEL
        (
            PerformanceValueTypeINTEL type = default,
            PerformanceValueDataINTEL data = default
        )
        {
           Type = type;
           Data = data;
        }

/// <summary></summary>
        [NativeName("Type", "VkPerformanceValueTypeINTEL")]
        [NativeName("Type.Name", "VkPerformanceValueTypeINTEL")]
        [NativeName("Name", "type")]
        public PerformanceValueTypeINTEL Type;
/// <summary></summary>
        [NativeName("Type", "VkPerformanceValueDataINTEL")]
        [NativeName("Type.Name", "VkPerformanceValueDataINTEL")]
        [NativeName("Name", "data")]
        public PerformanceValueDataINTEL Data;
    }
}
