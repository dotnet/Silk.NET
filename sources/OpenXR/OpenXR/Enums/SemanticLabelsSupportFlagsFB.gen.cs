// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSemanticLabelsSupportFlagsFB")]
[Flags]
public enum SemanticLabelsSupportFlagsFB : ulong
{
    None = 0x0,

    [NativeName("XR_SEMANTIC_LABELS_SUPPORT_MULTIPLE_SEMANTIC_LABELS_BIT_FB")]
    MultipleSemanticLabelsBit = 0x1,

    [NativeName("XR_SEMANTIC_LABELS_SUPPORT_ACCEPT_DESK_TO_TABLE_MIGRATION_BIT_FB")]
    AcceptDeskToTableMigrationBit = 0x2,

    [NativeName("XR_SEMANTIC_LABELS_SUPPORT_ACCEPT_INVISIBLE_WALL_FACE_BIT_FB")]
    AcceptInvisibleWallFaceBit = 0x4,
}
