// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrAttenuationCurvePointBD")]
[SupportedApiProfile("openxr")]
public partial struct AttenuationCurvePointBD
{
    [NativeName("distance")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float Distance;

    [NativeName("gain")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_audio_rendering"])]
    public float Gain;
}
