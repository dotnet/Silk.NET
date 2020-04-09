// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum DescriptorSetLayoutCreateFlags
    {
        DescriptorSetLayoutCreatePushDescriptorBitKhr = 1,
        DescriptorSetLayoutCreateUpdateAfterBindPoolBitExt = 2,
        DescriptorSetLayoutCreateUpdateAfterBindPoolBit = 2,
    }
}
