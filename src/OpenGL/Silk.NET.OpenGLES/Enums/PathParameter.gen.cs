// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathParameter")]
    public enum PathParameter : int
    {
        [Obsolete("Deprecated in favour of \"StrokeWidthNV\"")]
        [NativeName("Name", "GL_PATH_STROKE_WIDTH_NV")]
        PathStrokeWidthNV = 0x9075,
        [Obsolete("Deprecated in favour of \"EndCapsNV\"")]
        [NativeName("Name", "GL_PATH_END_CAPS_NV")]
        PathEndCapsNV = 0x9076,
        [Obsolete("Deprecated in favour of \"InitialEndCapNV\"")]
        [NativeName("Name", "GL_PATH_INITIAL_END_CAP_NV")]
        PathInitialEndCapNV = 0x9077,
        [Obsolete("Deprecated in favour of \"TerminalEndCapNV\"")]
        [NativeName("Name", "GL_PATH_TERMINAL_END_CAP_NV")]
        PathTerminalEndCapNV = 0x9078,
        [Obsolete("Deprecated in favour of \"JoinStyleNV\"")]
        [NativeName("Name", "GL_PATH_JOIN_STYLE_NV")]
        PathJoinStyleNV = 0x9079,
        [Obsolete("Deprecated in favour of \"MiterLimitNV\"")]
        [NativeName("Name", "GL_PATH_MITER_LIMIT_NV")]
        PathMiterLimitNV = 0x907A,
        [Obsolete("Deprecated in favour of \"DashCapsNV\"")]
        [NativeName("Name", "GL_PATH_DASH_CAPS_NV")]
        PathDashCapsNV = 0x907B,
        [Obsolete("Deprecated in favour of \"InitialDashCapNV\"")]
        [NativeName("Name", "GL_PATH_INITIAL_DASH_CAP_NV")]
        PathInitialDashCapNV = 0x907C,
        [Obsolete("Deprecated in favour of \"TerminalDashCapNV\"")]
        [NativeName("Name", "GL_PATH_TERMINAL_DASH_CAP_NV")]
        PathTerminalDashCapNV = 0x907D,
        [Obsolete("Deprecated in favour of \"DashOffsetNV\"")]
        [NativeName("Name", "GL_PATH_DASH_OFFSET_NV")]
        PathDashOffsetNV = 0x907E,
        [Obsolete("Deprecated in favour of \"ClientLengthNV\"")]
        [NativeName("Name", "GL_PATH_CLIENT_LENGTH_NV")]
        PathClientLengthNV = 0x907F,
        [Obsolete("Deprecated in favour of \"FillModeNV\"")]
        [NativeName("Name", "GL_PATH_FILL_MODE_NV")]
        PathFillModeNV = 0x9080,
        [Obsolete("Deprecated in favour of \"FillMaskNV\"")]
        [NativeName("Name", "GL_PATH_FILL_MASK_NV")]
        PathFillMaskNV = 0x9081,
        [Obsolete("Deprecated in favour of \"FillCoverModeNV\"")]
        [NativeName("Name", "GL_PATH_FILL_COVER_MODE_NV")]
        PathFillCoverModeNV = 0x9082,
        [Obsolete("Deprecated in favour of \"StrokeCoverModeNV\"")]
        [NativeName("Name", "GL_PATH_STROKE_COVER_MODE_NV")]
        PathStrokeCoverModeNV = 0x9083,
        [Obsolete("Deprecated in favour of \"StrokeMaskNV\"")]
        [NativeName("Name", "GL_PATH_STROKE_MASK_NV")]
        PathStrokeMaskNV = 0x9084,
        [Obsolete("Deprecated in favour of \"ObjectBoundingBoxNV\"")]
        [NativeName("Name", "GL_PATH_OBJECT_BOUNDING_BOX_NV")]
        PathObjectBoundingBoxNV = 0x908A,
        [Obsolete("Deprecated in favour of \"CommandCountNV\"")]
        [NativeName("Name", "GL_PATH_COMMAND_COUNT_NV")]
        PathCommandCountNV = 0x909D,
        [Obsolete("Deprecated in favour of \"CoordCountNV\"")]
        [NativeName("Name", "GL_PATH_COORD_COUNT_NV")]
        PathCoordCountNV = 0x909E,
        [Obsolete("Deprecated in favour of \"DashArrayCountNV\"")]
        [NativeName("Name", "GL_PATH_DASH_ARRAY_COUNT_NV")]
        PathDashArrayCountNV = 0x909F,
        [Obsolete("Deprecated in favour of \"ComputedLengthNV\"")]
        [NativeName("Name", "GL_PATH_COMPUTED_LENGTH_NV")]
        PathComputedLengthNV = 0x90A0,
        [Obsolete("Deprecated in favour of \"FillBoundingBoxNV\"")]
        [NativeName("Name", "GL_PATH_FILL_BOUNDING_BOX_NV")]
        PathFillBoundingBoxNV = 0x90A1,
        [Obsolete("Deprecated in favour of \"StrokeBoundingBoxNV\"")]
        [NativeName("Name", "GL_PATH_STROKE_BOUNDING_BOX_NV")]
        PathStrokeBoundingBoxNV = 0x90A2,
        [Obsolete("Deprecated in favour of \"DashOffsetResetNV\"")]
        [NativeName("Name", "GL_PATH_DASH_OFFSET_RESET_NV")]
        PathDashOffsetResetNV = 0x90B4,
        [NativeName("Name", "GL_PATH_STROKE_WIDTH_NV")]
        StrokeWidthNV = 0x9075,
        [NativeName("Name", "GL_PATH_END_CAPS_NV")]
        EndCapsNV = 0x9076,
        [NativeName("Name", "GL_PATH_INITIAL_END_CAP_NV")]
        InitialEndCapNV = 0x9077,
        [NativeName("Name", "GL_PATH_TERMINAL_END_CAP_NV")]
        TerminalEndCapNV = 0x9078,
        [NativeName("Name", "GL_PATH_JOIN_STYLE_NV")]
        JoinStyleNV = 0x9079,
        [NativeName("Name", "GL_PATH_MITER_LIMIT_NV")]
        MiterLimitNV = 0x907A,
        [NativeName("Name", "GL_PATH_DASH_CAPS_NV")]
        DashCapsNV = 0x907B,
        [NativeName("Name", "GL_PATH_INITIAL_DASH_CAP_NV")]
        InitialDashCapNV = 0x907C,
        [NativeName("Name", "GL_PATH_TERMINAL_DASH_CAP_NV")]
        TerminalDashCapNV = 0x907D,
        [NativeName("Name", "GL_PATH_DASH_OFFSET_NV")]
        DashOffsetNV = 0x907E,
        [NativeName("Name", "GL_PATH_CLIENT_LENGTH_NV")]
        ClientLengthNV = 0x907F,
        [NativeName("Name", "GL_PATH_FILL_MODE_NV")]
        FillModeNV = 0x9080,
        [NativeName("Name", "GL_PATH_FILL_MASK_NV")]
        FillMaskNV = 0x9081,
        [NativeName("Name", "GL_PATH_FILL_COVER_MODE_NV")]
        FillCoverModeNV = 0x9082,
        [NativeName("Name", "GL_PATH_STROKE_COVER_MODE_NV")]
        StrokeCoverModeNV = 0x9083,
        [NativeName("Name", "GL_PATH_STROKE_MASK_NV")]
        StrokeMaskNV = 0x9084,
        [NativeName("Name", "GL_PATH_OBJECT_BOUNDING_BOX_NV")]
        ObjectBoundingBoxNV = 0x908A,
        [NativeName("Name", "GL_PATH_COMMAND_COUNT_NV")]
        CommandCountNV = 0x909D,
        [NativeName("Name", "GL_PATH_COORD_COUNT_NV")]
        CoordCountNV = 0x909E,
        [NativeName("Name", "GL_PATH_DASH_ARRAY_COUNT_NV")]
        DashArrayCountNV = 0x909F,
        [NativeName("Name", "GL_PATH_COMPUTED_LENGTH_NV")]
        ComputedLengthNV = 0x90A0,
        [NativeName("Name", "GL_PATH_FILL_BOUNDING_BOX_NV")]
        FillBoundingBoxNV = 0x90A1,
        [NativeName("Name", "GL_PATH_STROKE_BOUNDING_BOX_NV")]
        StrokeBoundingBoxNV = 0x90A2,
        [NativeName("Name", "GL_PATH_DASH_OFFSET_RESET_NV")]
        DashOffsetResetNV = 0x90B4,
    }
}
