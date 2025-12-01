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
    StrokeWidthNV = unchecked((uint)0x9075),

    [NativeName("GL_PATH_END_CAPS_NV")]
    EndCapsNV = unchecked((uint)0x9076),

    [NativeName("GL_PATH_INITIAL_END_CAP_NV")]
    InitialEndCapNV = unchecked((uint)0x9077),

    [NativeName("GL_PATH_TERMINAL_END_CAP_NV")]
    TerminalEndCapNV = unchecked((uint)0x9078),

    [NativeName("GL_PATH_JOIN_STYLE_NV")]
    JoinStyleNV = unchecked((uint)0x9079),

    [NativeName("GL_PATH_MITER_LIMIT_NV")]
    MiterLimitNV = unchecked((uint)0x907A),

    [NativeName("GL_PATH_DASH_CAPS_NV")]
    DashCapsNV = unchecked((uint)0x907B),

    [NativeName("GL_PATH_INITIAL_DASH_CAP_NV")]
    InitialDashCapNV = unchecked((uint)0x907C),

    [NativeName("GL_PATH_TERMINAL_DASH_CAP_NV")]
    TerminalDashCapNV = unchecked((uint)0x907D),

    [NativeName("GL_PATH_DASH_OFFSET_NV")]
    DashOffsetNV = unchecked((uint)0x907E),

    [NativeName("GL_PATH_CLIENT_LENGTH_NV")]
    ClientLengthNV = unchecked((uint)0x907F),

    [NativeName("GL_PATH_FILL_MODE_NV")]
    FillModeNV = unchecked((uint)0x9080),

    [NativeName("GL_PATH_FILL_MASK_NV")]
    FillMaskNV = unchecked((uint)0x9081),

    [NativeName("GL_PATH_FILL_COVER_MODE_NV")]
    FillCoverModeNV = unchecked((uint)0x9082),

    [NativeName("GL_PATH_STROKE_COVER_MODE_NV")]
    StrokeCoverModeNV = unchecked((uint)0x9083),

    [NativeName("GL_PATH_STROKE_MASK_NV")]
    StrokeMaskNV = unchecked((uint)0x9084),

    [NativeName("GL_PATH_OBJECT_BOUNDING_BOX_NV")]
    ObjectBoundingBoxNV = unchecked((uint)0x908A),

    [NativeName("GL_PATH_COMMAND_COUNT_NV")]
    CommandCountNV = unchecked((uint)0x909D),

    [NativeName("GL_PATH_COORD_COUNT_NV")]
    CoordCountNV = unchecked((uint)0x909E),

    [NativeName("GL_PATH_DASH_ARRAY_COUNT_NV")]
    DashArrayCountNV = unchecked((uint)0x909F),

    [NativeName("GL_PATH_COMPUTED_LENGTH_NV")]
    ComputedLengthNV = unchecked((uint)0x90A0),

    [NativeName("GL_PATH_FILL_BOUNDING_BOX_NV")]
    FillBoundingBoxNV = unchecked((uint)0x90A1),

    [NativeName("GL_PATH_STROKE_BOUNDING_BOX_NV")]
    StrokeBoundingBoxNV = unchecked((uint)0x90A2),

    [NativeName("GL_PATH_DASH_OFFSET_RESET_NV")]
    DashOffsetResetNV = unchecked((uint)0x90B4),
}
