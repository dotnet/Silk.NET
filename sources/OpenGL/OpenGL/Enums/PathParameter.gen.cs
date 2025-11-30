// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathParameter")]
[Transformed]
public enum PathParameter : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STROKE_WIDTH_NV")]
    StrokeWidthnv = unchecked((uint)0x9075),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_END_CAPS_NV")]
    EndCapsnv = unchecked((uint)0x9076),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_INITIAL_END_CAP_NV")]
    InitialEndCapnv = unchecked((uint)0x9077),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_TERMINAL_END_CAP_NV")]
    TerminalEndCapnv = unchecked((uint)0x9078),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_JOIN_STYLE_NV")]
    JoinStylenv = unchecked((uint)0x9079),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_MITER_LIMIT_NV")]
    MiterLimitnv = unchecked((uint)0x907A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_DASH_CAPS_NV")]
    DashCapsnv = unchecked((uint)0x907B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_INITIAL_DASH_CAP_NV")]
    InitialDashCapnv = unchecked((uint)0x907C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_TERMINAL_DASH_CAP_NV")]
    TerminalDashCapnv = unchecked((uint)0x907D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_DASH_OFFSET_NV")]
    DashOffsetnv = unchecked((uint)0x907E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_CLIENT_LENGTH_NV")]
    ClientLengthnv = unchecked((uint)0x907F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FILL_MODE_NV")]
    FillModenv = unchecked((uint)0x9080),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FILL_MASK_NV")]
    FillMasknv = unchecked((uint)0x9081),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FILL_COVER_MODE_NV")]
    FillCoverModenv = unchecked((uint)0x9082),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STROKE_COVER_MODE_NV")]
    StrokeCoverModenv = unchecked((uint)0x9083),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STROKE_MASK_NV")]
    StrokeMasknv = unchecked((uint)0x9084),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_OBJECT_BOUNDING_BOX_NV")]
    ObjectBoundingBoxnv = unchecked((uint)0x908A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_COMMAND_COUNT_NV")]
    CommandCountnv = unchecked((uint)0x909D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_COORD_COUNT_NV")]
    CoordCountnv = unchecked((uint)0x909E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_DASH_ARRAY_COUNT_NV")]
    DashArrayCountnv = unchecked((uint)0x909F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_COMPUTED_LENGTH_NV")]
    ComputedLengthnv = unchecked((uint)0x90A0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_FILL_BOUNDING_BOX_NV")]
    FillBoundingBoxnv = unchecked((uint)0x90A1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_STROKE_BOUNDING_BOX_NV")]
    StrokeBoundingBoxnv = unchecked((uint)0x90A2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_PATH_DASH_OFFSET_RESET_NV")]
    DashOffsetResetnv = unchecked((uint)0x90B4),
}
