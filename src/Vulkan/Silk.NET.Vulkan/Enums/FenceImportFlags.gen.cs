// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkFenceImportFlags")]
    public enum FenceImportFlags : int
    {
        [NativeName("Name", "VK_FENCE_IMPORT_TEMPORARY_BIT")]
        FenceImportTemporaryBit = 1,
    }
}
