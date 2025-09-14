// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrFrameSynthesisInfoFlagsEXT")]
    public enum FrameSynthesisInfoFlagsEXT : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Use2DMotionVectorBitExt\"")]
        [NativeName("Name", "XR_FRAME_SYNTHESIS_INFO_USE_2D_MOTION_VECTOR_BIT_EXT")]
        FrameSynthesisInfoUse2DMotionVectorBitExt = 1,
        [Obsolete("Deprecated in favour of \"RequestRelaxedFrameIntervalBitExt\"")]
        [NativeName("Name", "XR_FRAME_SYNTHESIS_INFO_REQUEST_RELAXED_FRAME_INTERVAL_BIT_EXT")]
        FrameSynthesisInfoRequestRelaxedFrameIntervalBitExt = 2,
        [NativeName("Name", "XR_FRAME_SYNTHESIS_INFO_USE_2D_MOTION_VECTOR_BIT_EXT")]
        Use2DMotionVectorBitExt = 1,
        [NativeName("Name", "XR_FRAME_SYNTHESIS_INFO_REQUEST_RELAXED_FRAME_INTERVAL_BIT_EXT")]
        RequestRelaxedFrameIntervalBitExt = 2,
    }
}
