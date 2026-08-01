// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEnvironmentBlendMode")]
[SupportedApiProfile("openxr")]
public enum EnvironmentBlendMode : uint
{
    [NativeName("XR_ENVIRONMENT_BLEND_MODE_OPAQUE")]
    [SupportedApiProfile("openxr")]
    Opaque = 1,

    [NativeName("XR_ENVIRONMENT_BLEND_MODE_ADDITIVE")]
    [SupportedApiProfile("openxr")]
    Additive = 2,

    [NativeName("XR_ENVIRONMENT_BLEND_MODE_ALPHA_BLEND")]
    [SupportedApiProfile("openxr")]
    AlphaBlend = 3,
}
