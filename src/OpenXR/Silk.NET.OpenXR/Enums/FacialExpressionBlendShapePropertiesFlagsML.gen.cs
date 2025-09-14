// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrFacialExpressionBlendShapePropertiesFlagsML")]
    public enum FacialExpressionBlendShapePropertiesFlagsML : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ValidBitML\"")]
        [NativeName("Name", "XR_FACIAL_EXPRESSION_BLEND_SHAPE_PROPERTIES_VALID_BIT_ML")]
        FacialExpressionBlendShapePropertiesValidBitML = 1,
        [Obsolete("Deprecated in favour of \"TrackedBitML\"")]
        [NativeName("Name", "XR_FACIAL_EXPRESSION_BLEND_SHAPE_PROPERTIES_TRACKED_BIT_ML")]
        FacialExpressionBlendShapePropertiesTrackedBitML = 2,
        [NativeName("Name", "XR_FACIAL_EXPRESSION_BLEND_SHAPE_PROPERTIES_VALID_BIT_ML")]
        ValidBitML = 1,
        [NativeName("Name", "XR_FACIAL_EXPRESSION_BLEND_SHAPE_PROPERTIES_TRACKED_BIT_ML")]
        TrackedBitML = 2,
    }
}
