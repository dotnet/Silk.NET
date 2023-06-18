// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDepthBiasRepresentationEXT")]
    public enum DepthBiasRepresentationEXT : int
    {
        [Obsolete("Deprecated in favour of \"LeastRepresentableValueFormatExt\"")]
        [NativeName("Name", "VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORMAT_EXT")]
        DepthBiasRepresentationLeastRepresentableValueFormatExt = 0,
        [Obsolete("Deprecated in favour of \"LeastRepresentableValueForceUnormExt\"")]
        [NativeName("Name", "VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORCE_UNORM_EXT")]
        DepthBiasRepresentationLeastRepresentableValueForceUnormExt = 1,
        [Obsolete("Deprecated in favour of \"FloatExt\"")]
        [NativeName("Name", "VK_DEPTH_BIAS_REPRESENTATION_FLOAT_EXT")]
        DepthBiasRepresentationFloatExt = 2,
        [NativeName("Name", "VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORMAT_EXT")]
        LeastRepresentableValueFormatExt = 0,
        [NativeName("Name", "VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORCE_UNORM_EXT")]
        LeastRepresentableValueForceUnormExt = 1,
        [NativeName("Name", "VK_DEPTH_BIAS_REPRESENTATION_FLOAT_EXT")]
        FloatExt = 2,
    }
}
