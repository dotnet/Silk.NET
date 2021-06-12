// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrScenePlaneAlignmentTypeMSFT")]
    public enum ScenePlaneAlignmentTypeMSFT : int
    {
        [NativeName("Name", "XR_SCENE_PLANE_ALIGNMENT_TYPE_NON_ORTHOGONAL_MSFT")]
        ScenePlaneAlignmentTypeNonOrthogonalMsft = 0,
        [NativeName("Name", "XR_SCENE_PLANE_ALIGNMENT_TYPE_HORIZONTAL_MSFT")]
        ScenePlaneAlignmentTypeHorizontalMsft = 1,
        [NativeName("Name", "XR_SCENE_PLANE_ALIGNMENT_TYPE_VERTICAL_MSFT")]
        ScenePlaneAlignmentTypeVerticalMsft = 2,
    }
}
