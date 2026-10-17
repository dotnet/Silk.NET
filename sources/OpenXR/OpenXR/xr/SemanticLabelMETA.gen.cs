// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSemanticLabelMETA")]
public enum SemanticLabelMETA : uint
{
    [NativeName("XR_SEMANTIC_LABEL_UNKNOWN_META")]
    Unknown = 0,

    [NativeName("XR_SEMANTIC_LABEL_FLOOR_META")]
    Floor = 1,

    [NativeName("XR_SEMANTIC_LABEL_CEILING_META")]
    Ceiling = 2,

    [NativeName("XR_SEMANTIC_LABEL_WALL_FACE_META")]
    WallFace = 3,

    [NativeName("XR_SEMANTIC_LABEL_INNER_WALL_FACE_META")]
    InnerWallFace = 4,

    [NativeName("XR_SEMANTIC_LABEL_INVISIBLE_WALL_FACE_META")]
    InvisibleWallFace = 5,

    [NativeName("XR_SEMANTIC_LABEL_DOOR_FRAME_META")]
    DoorFrame = 6,

    [NativeName("XR_SEMANTIC_LABEL_WINDOW_FRAME_META")]
    WindowFrame = 7,
}
