// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrViewConfigurationType")]
public enum ViewConfigurationType : uint
{
    [NativeName("XR_VIEW_CONFIGURATION_TYPE_PRIMARY_MONO")]
    PrimaryMono = 1,

    [NativeName("XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO")]
    PrimaryStereo = 2,

    [NativeName("XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO_WITH_FOVEATED_INSET")]
    PrimaryStereoWithFoveatedInset = 1000037000,

    [NativeName("XR_VIEW_CONFIGURATION_TYPE_SECONDARY_MONO_FIRST_PERSON_OBSERVER_MSFT")]
    SecondaryMonoFirstPersonObserverMSFT = 1000054000,

    [NativeName("XR_VIEW_CONFIGURATION_TYPE_PRIMARY_QUAD_VARJO")]
    PrimaryQuadVARJO = PrimaryStereoWithFoveatedInset,
}
