// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoSessionParametersCreateFlagsKHR")]
    public enum VideoSessionParametersCreateFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"QuantizationMapCompatibleBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_SESSION_PARAMETERS_CREATE_QUANTIZATION_MAP_COMPATIBLE_BIT_KHR")]
        VideoSessionParametersCreateQuantizationMapCompatibleBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_SESSION_PARAMETERS_CREATE_QUANTIZATION_MAP_COMPATIBLE_BIT_KHR")]
        QuantizationMapCompatibleBitKhr = 1,
    }
}
