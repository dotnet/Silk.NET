// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCubicFilterWeightsQCOM")]
    public enum CubicFilterWeightsQCOM : int
    {
        [Obsolete("Deprecated in favour of \"CatmullRomQCom\"")]
        [NativeName("Name", "VK_CUBIC_FILTER_WEIGHTS_CATMULL_ROM_QCOM")]
        CubicFilterWeightsCatmullRomQCom = 0,
        [Obsolete("Deprecated in favour of \"ZeroTangentCardinalQCom\"")]
        [NativeName("Name", "VK_CUBIC_FILTER_WEIGHTS_ZERO_TANGENT_CARDINAL_QCOM")]
        CubicFilterWeightsZeroTangentCardinalQCom = 1,
        [Obsolete("Deprecated in favour of \"BSplineQCom\"")]
        [NativeName("Name", "VK_CUBIC_FILTER_WEIGHTS_B_SPLINE_QCOM")]
        CubicFilterWeightsBSplineQCom = 2,
        [Obsolete("Deprecated in favour of \"MitchellNetravaliQCom\"")]
        [NativeName("Name", "VK_CUBIC_FILTER_WEIGHTS_MITCHELL_NETRAVALI_QCOM")]
        CubicFilterWeightsMitchellNetravaliQCom = 3,
        [NativeName("Name", "VK_CUBIC_FILTER_WEIGHTS_CATMULL_ROM_QCOM")]
        CatmullRomQCom = 0,
        [NativeName("Name", "VK_CUBIC_FILTER_WEIGHTS_ZERO_TANGENT_CARDINAL_QCOM")]
        ZeroTangentCardinalQCom = 1,
        [NativeName("Name", "VK_CUBIC_FILTER_WEIGHTS_B_SPLINE_QCOM")]
        BSplineQCom = 2,
        [NativeName("Name", "VK_CUBIC_FILTER_WEIGHTS_MITCHELL_NETRAVALI_QCOM")]
        MitchellNetravaliQCom = 3,
    }
}
