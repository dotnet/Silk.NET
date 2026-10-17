// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEnvironmentBlendMode")]
public enum EnvironmentBlendMode : uint
{
    [NativeName("XR_ENVIRONMENT_BLEND_MODE_OPAQUE")]
    Opaque = 1,

    [NativeName("XR_ENVIRONMENT_BLEND_MODE_ADDITIVE")]
    Additive = 2,

    [NativeName("XR_ENVIRONMENT_BLEND_MODE_ALPHA_BLEND")]
    AlphaBlend = 3,
}
