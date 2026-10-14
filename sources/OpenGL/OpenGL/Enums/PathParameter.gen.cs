// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathParameter")]
public enum PathParameter : uint
{
    [NativeName("GL_PATH_STROKE_WIDTH_NV")]
    StrokeWidthNV = 36981,

    [NativeName("GL_PATH_END_CAPS_NV")]
    EndCapsNV = 36982,

    [NativeName("GL_PATH_INITIAL_END_CAP_NV")]
    InitialEndCapNV = 36983,

    [NativeName("GL_PATH_TERMINAL_END_CAP_NV")]
    TerminalEndCapNV = 36984,

    [NativeName("GL_PATH_JOIN_STYLE_NV")]
    JoinStyleNV = 36985,

    [NativeName("GL_PATH_MITER_LIMIT_NV")]
    MiterLimitNV = 36986,

    [NativeName("GL_PATH_DASH_CAPS_NV")]
    DashCapsNV = 36987,

    [NativeName("GL_PATH_INITIAL_DASH_CAP_NV")]
    InitialDashCapNV = 36988,

    [NativeName("GL_PATH_TERMINAL_DASH_CAP_NV")]
    TerminalDashCapNV = 36989,

    [NativeName("GL_PATH_DASH_OFFSET_NV")]
    DashOffsetNV = 36990,

    [NativeName("GL_PATH_CLIENT_LENGTH_NV")]
    ClientLengthNV = 36991,

    [NativeName("GL_PATH_FILL_MODE_NV")]
    FillModeNV = 36992,

    [NativeName("GL_PATH_FILL_MASK_NV")]
    FillMaskNV = 36993,

    [NativeName("GL_PATH_FILL_COVER_MODE_NV")]
    FillCoverModeNV = 36994,

    [NativeName("GL_PATH_STROKE_COVER_MODE_NV")]
    StrokeCoverModeNV = 36995,

    [NativeName("GL_PATH_STROKE_MASK_NV")]
    StrokeMaskNV = 36996,

    [NativeName("GL_PATH_OBJECT_BOUNDING_BOX_NV")]
    ObjectBoundingBoxNV = 37002,

    [NativeName("GL_PATH_COMMAND_COUNT_NV")]
    CommandCountNV = 37021,

    [NativeName("GL_PATH_COORD_COUNT_NV")]
    CoordCountNV = 37022,

    [NativeName("GL_PATH_DASH_ARRAY_COUNT_NV")]
    DashArrayCountNV = 37023,

    [NativeName("GL_PATH_COMPUTED_LENGTH_NV")]
    ComputedLengthNV = 37024,

    [NativeName("GL_PATH_FILL_BOUNDING_BOX_NV")]
    FillBoundingBoxNV = 37025,

    [NativeName("GL_PATH_STROKE_BOUNDING_BOX_NV")]
    StrokeBoundingBoxNV = 37026,

    [NativeName("GL_PATH_DASH_OFFSET_RESET_NV")]
    DashOffsetResetNV = 37044,
}
