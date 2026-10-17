// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMeshComputeLodMSFT")]
public enum MeshComputeLodMSFT : uint
{
    [NativeName("XR_MESH_COMPUTE_LOD_COARSE_MSFT")]
    Coarse = 1,

    [NativeName("XR_MESH_COMPUTE_LOD_MEDIUM_MSFT")]
    Medium = 2,

    [NativeName("XR_MESH_COMPUTE_LOD_FINE_MSFT")]
    Fine = 3,

    [NativeName("XR_MESH_COMPUTE_LOD_UNLIMITED_MSFT")]
    Unlimited = 4,
}
