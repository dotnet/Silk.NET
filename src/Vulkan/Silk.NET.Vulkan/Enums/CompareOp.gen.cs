// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCompareOp")]
    public enum CompareOp
    {
        [NativeName("Name", "VK_COMPARE_OP_NEVER")]
        Never = 0,
        [NativeName("Name", "VK_COMPARE_OP_LESS")]
        Less = 1,
        [NativeName("Name", "VK_COMPARE_OP_EQUAL")]
        Equal = 2,
        [NativeName("Name", "VK_COMPARE_OP_LESS_OR_EQUAL")]
        LessOrEqual = 3,
        [NativeName("Name", "VK_COMPARE_OP_GREATER")]
        Greater = 4,
        [NativeName("Name", "VK_COMPARE_OP_NOT_EQUAL")]
        NotEqual = 5,
        [NativeName("Name", "VK_COMPARE_OP_GREATER_OR_EQUAL")]
        GreaterOrEqual = 6,
        [NativeName("Name", "VK_COMPARE_OP_ALWAYS")]
        Always = 7,
    }
}
