// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialMeshConfigFlagsBD")]
[Flags]
public enum SpatialMeshConfigFlagsBD : ulong
{
    None = 0x0,

    [NativeName("XR_SPATIAL_MESH_CONFIG_SEMANTIC_BIT_BD")]
    SemanticBit = 0x1,

    [NativeName("XR_SPATIAL_MESH_CONFIG_ALIGN_SEMANTIC_WITH_VERTEX_BIT_BD")]
    AlignSemanticWithVertexBit = 0x2,
}
