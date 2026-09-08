// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialSimulationModeBD")]
[SupportedApiProfile("openxr")]
public enum FacialSimulationModeBD : uint
{
    [NativeName("XR_FACIAL_SIMULATION_MODE_DEFAULT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    Default = 0,

    [NativeName("XR_FACIAL_SIMULATION_MODE_COMBINED_AUDIO_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    CombinedAudio = 1,

    [NativeName("XR_FACIAL_SIMULATION_MODE_COMBINED_AUDIO_WITH_LIP_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    CombinedAudioWithLip = 2,

    [NativeName("XR_FACIAL_SIMULATION_MODE_ONLY_AUDIO_WITH_LIP_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    OnlyAudioWithLip = 3,
}
