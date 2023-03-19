// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrActionType")]
    public enum ActionType : int
    {
        [NativeName("Name", "XR_ACTION_TYPE_BOOLEAN_INPUT")]
        BooleanInput = 1,
        [NativeName("Name", "XR_ACTION_TYPE_FLOAT_INPUT")]
        FloatInput = 2,
        [NativeName("Name", "XR_ACTION_TYPE_VECTOR2F_INPUT")]
        Vector2fInput = 3,
        [NativeName("Name", "XR_ACTION_TYPE_POSE_INPUT")]
        PoseInput = 4,
        [NativeName("Name", "XR_ACTION_TYPE_VIBRATION_OUTPUT")]
        VibrationOutput = 100,
    }
}
