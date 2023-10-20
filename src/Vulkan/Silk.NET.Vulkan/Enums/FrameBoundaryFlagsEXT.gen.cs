// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkFrameBoundaryFlagsEXT")]
    public enum FrameBoundaryFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"FrameEndBitExt\"")]
        [NativeName("Name", "VK_FRAME_BOUNDARY_FRAME_END_BIT_EXT")]
        FrameBoundaryFrameEndBitExt = 1,
        [NativeName("Name", "VK_FRAME_BOUNDARY_FRAME_END_BIT_EXT")]
        FrameEndBitExt = 1,
    }
}
