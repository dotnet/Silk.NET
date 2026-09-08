// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRenderModelFlagsFB")]
[Flags]
public enum RenderModelFlagsFB : ulong
{
    None = 0x0,

    [NativeName("XR_RENDER_MODEL_SUPPORTS_GLTF_2_0_SUBSET_1_BIT_FB")]
    Subset1Bit = 0x1,

    [NativeName("XR_RENDER_MODEL_SUPPORTS_GLTF_2_0_SUBSET_2_BIT_FB")]
    Subset2Bit = 0x2,
}
