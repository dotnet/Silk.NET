// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkValidationCheckEXT")]
    public enum ValidationCheckEXT
    {
        [NativeName("Name", "VK_VALIDATION_CHECK_ALL_EXT")]
        ValidationCheckAllExt = 0,
        [NativeName("Name", "VK_VALIDATION_CHECK_SHADERS_EXT")]
        ValidationCheckShadersExt = 1,
    }
}
