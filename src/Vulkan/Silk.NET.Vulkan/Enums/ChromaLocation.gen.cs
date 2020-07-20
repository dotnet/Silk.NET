// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkChromaLocation")]
    public enum ChromaLocation
    {
        [NativeName("Name", "VK_CHROMA_LOCATION_COSITED_EVEN")]
        CositedEven = 0,
        [NativeName("Name", "VK_CHROMA_LOCATION_MIDPOINT")]
        Midpoint = 1,
    }
}
