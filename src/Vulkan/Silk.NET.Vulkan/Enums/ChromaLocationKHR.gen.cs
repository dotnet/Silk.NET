// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkChromaLocationKHR")]
    public enum ChromaLocationKHR : int
    {
        [Obsolete("Deprecated in favour of \"CositedEven\"")]
        [NativeName("Name", "VK_CHROMA_LOCATION_COSITED_EVEN")]
        ChromaLocationCositedEven = 0,
        [Obsolete("Deprecated in favour of \"Midpoint\"")]
        [NativeName("Name", "VK_CHROMA_LOCATION_MIDPOINT")]
        ChromaLocationMidpoint = 1,
        [NativeName("Name", "VK_CHROMA_LOCATION_COSITED_EVEN")]
        CositedEven = 0,
        [NativeName("Name", "VK_CHROMA_LOCATION_MIDPOINT")]
        Midpoint = 1,
    }
}
