// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSemanticLabelMETA")]
[SupportedApiProfile("openxr")]
public enum SemanticLabelMETA : uint
{
    [NativeName("XR_SEMANTIC_LABEL_UNKNOWN_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_semantic_label"])]
    Unknown = 0,

    [NativeName("XR_SEMANTIC_LABEL_FLOOR_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_semantic_label"])]
    Floor = 1,

    [NativeName("XR_SEMANTIC_LABEL_CEILING_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_semantic_label"])]
    Ceiling = 2,

    [NativeName("XR_SEMANTIC_LABEL_WALL_FACE_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_semantic_label"])]
    WallFace = 3,

    [NativeName("XR_SEMANTIC_LABEL_INNER_WALL_FACE_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_semantic_label"])]
    InnerWallFace = 4,

    [NativeName("XR_SEMANTIC_LABEL_INVISIBLE_WALL_FACE_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_semantic_label"])]
    InvisibleWallFace = 5,

    [NativeName("XR_SEMANTIC_LABEL_DOOR_FRAME_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_semantic_label"])]
    DoorFrame = 6,

    [NativeName("XR_SEMANTIC_LABEL_WINDOW_FRAME_META")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_semantic_label"])]
    WindowFrame = 7,
}
