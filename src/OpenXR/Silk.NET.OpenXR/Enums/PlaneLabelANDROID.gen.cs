// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPlaneLabelANDROID")]
    public enum PlaneLabelANDROID : int
    {
        [Obsolete("Deprecated in favour of \"UnknownAndroid\"")]
        [NativeName("Name", "XR_PLANE_LABEL_UNKNOWN_ANDROID")]
        PlaneLabelUnknownAndroid = 0,
        [Obsolete("Deprecated in favour of \"WallAndroid\"")]
        [NativeName("Name", "XR_PLANE_LABEL_WALL_ANDROID")]
        PlaneLabelWallAndroid = 1,
        [Obsolete("Deprecated in favour of \"FloorAndroid\"")]
        [NativeName("Name", "XR_PLANE_LABEL_FLOOR_ANDROID")]
        PlaneLabelFloorAndroid = 2,
        [Obsolete("Deprecated in favour of \"CeilingAndroid\"")]
        [NativeName("Name", "XR_PLANE_LABEL_CEILING_ANDROID")]
        PlaneLabelCeilingAndroid = 3,
        [Obsolete("Deprecated in favour of \"TableAndroid\"")]
        [NativeName("Name", "XR_PLANE_LABEL_TABLE_ANDROID")]
        PlaneLabelTableAndroid = 4,
        [NativeName("Name", "XR_PLANE_LABEL_UNKNOWN_ANDROID")]
        UnknownAndroid = 0,
        [NativeName("Name", "XR_PLANE_LABEL_WALL_ANDROID")]
        WallAndroid = 1,
        [NativeName("Name", "XR_PLANE_LABEL_FLOOR_ANDROID")]
        FloorAndroid = 2,
        [NativeName("Name", "XR_PLANE_LABEL_CEILING_ANDROID")]
        CeilingAndroid = 3,
        [NativeName("Name", "XR_PLANE_LABEL_TABLE_ANDROID")]
        TableAndroid = 4,
    }
}
