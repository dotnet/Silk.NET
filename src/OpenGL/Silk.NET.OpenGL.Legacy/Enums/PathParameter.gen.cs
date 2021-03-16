// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PathParameter")]
    public enum PathParameter : int
    {
        [NativeName("Name", "GL_PATH_STROKE_WIDTH_NV")]
        PathStrokeWidthNV = 0x9075,
        [NativeName("Name", "GL_PATH_END_CAPS_NV")]
        PathEndCapsNV = 0x9076,
        [NativeName("Name", "GL_PATH_INITIAL_END_CAP_NV")]
        PathInitialEndCapNV = 0x9077,
        [NativeName("Name", "GL_PATH_TERMINAL_END_CAP_NV")]
        PathTerminalEndCapNV = 0x9078,
        [NativeName("Name", "GL_PATH_JOIN_STYLE_NV")]
        PathJoinStyleNV = 0x9079,
        [NativeName("Name", "GL_PATH_MITER_LIMIT_NV")]
        PathMiterLimitNV = 0x907A,
        [NativeName("Name", "GL_PATH_DASH_CAPS_NV")]
        PathDashCapsNV = 0x907B,
        [NativeName("Name", "GL_PATH_INITIAL_DASH_CAP_NV")]
        PathInitialDashCapNV = 0x907C,
        [NativeName("Name", "GL_PATH_TERMINAL_DASH_CAP_NV")]
        PathTerminalDashCapNV = 0x907D,
        [NativeName("Name", "GL_PATH_DASH_OFFSET_NV")]
        PathDashOffsetNV = 0x907E,
        [NativeName("Name", "GL_PATH_CLIENT_LENGTH_NV")]
        PathClientLengthNV = 0x907F,
        [NativeName("Name", "GL_PATH_FILL_MODE_NV")]
        PathFillModeNV = 0x9080,
        [NativeName("Name", "GL_PATH_FILL_MASK_NV")]
        PathFillMaskNV = 0x9081,
        [NativeName("Name", "GL_PATH_FILL_COVER_MODE_NV")]
        PathFillCoverModeNV = 0x9082,
        [NativeName("Name", "GL_PATH_STROKE_COVER_MODE_NV")]
        PathStrokeCoverModeNV = 0x9083,
        [NativeName("Name", "GL_PATH_STROKE_MASK_NV")]
        PathStrokeMaskNV = 0x9084,
        [NativeName("Name", "GL_PATH_OBJECT_BOUNDING_BOX_NV")]
        PathObjectBoundingBoxNV = 0x908A,
        [NativeName("Name", "GL_PATH_COMMAND_COUNT_NV")]
        PathCommandCountNV = 0x909D,
        [NativeName("Name", "GL_PATH_COORD_COUNT_NV")]
        PathCoordCountNV = 0x909E,
        [NativeName("Name", "GL_PATH_DASH_ARRAY_COUNT_NV")]
        PathDashArrayCountNV = 0x909F,
        [NativeName("Name", "GL_PATH_COMPUTED_LENGTH_NV")]
        PathComputedLengthNV = 0x90A0,
        [NativeName("Name", "GL_PATH_FILL_BOUNDING_BOX_NV")]
        PathFillBoundingBoxNV = 0x90A1,
        [NativeName("Name", "GL_PATH_STROKE_BOUNDING_BOX_NV")]
        PathStrokeBoundingBoxNV = 0x90A2,
        [NativeName("Name", "GL_PATH_DASH_OFFSET_RESET_NV")]
        PathDashOffsetResetNV = 0x90B4,
    }
}
