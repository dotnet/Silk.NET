// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFacialSimulationModeBD")]
    public enum FacialSimulationModeBD : int
    {
        [Obsolete("Deprecated in favour of \"DefaultBD\"")]
        [NativeName("Name", "XR_FACIAL_SIMULATION_MODE_DEFAULT_BD")]
        FacialSimulationModeDefaultBD = 0,
        [Obsolete("Deprecated in favour of \"CombinedAudioBD\"")]
        [NativeName("Name", "XR_FACIAL_SIMULATION_MODE_COMBINED_AUDIO_BD")]
        FacialSimulationModeCombinedAudioBD = 1,
        [Obsolete("Deprecated in favour of \"CombinedAudioWithLipBD\"")]
        [NativeName("Name", "XR_FACIAL_SIMULATION_MODE_COMBINED_AUDIO_WITH_LIP_BD")]
        FacialSimulationModeCombinedAudioWithLipBD = 2,
        [Obsolete("Deprecated in favour of \"OnlyAudioWithLipBD\"")]
        [NativeName("Name", "XR_FACIAL_SIMULATION_MODE_ONLY_AUDIO_WITH_LIP_BD")]
        FacialSimulationModeOnlyAudioWithLipBD = 3,
        [NativeName("Name", "XR_FACIAL_SIMULATION_MODE_DEFAULT_BD")]
        DefaultBD = 0,
        [NativeName("Name", "XR_FACIAL_SIMULATION_MODE_COMBINED_AUDIO_BD")]
        CombinedAudioBD = 1,
        [NativeName("Name", "XR_FACIAL_SIMULATION_MODE_COMBINED_AUDIO_WITH_LIP_BD")]
        CombinedAudioWithLipBD = 2,
        [NativeName("Name", "XR_FACIAL_SIMULATION_MODE_ONLY_AUDIO_WITH_LIP_BD")]
        OnlyAudioWithLipBD = 3,
    }
}
