// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrReferenceSpaceType")]
public enum ReferenceSpaceType : uint
{
    [NativeName("XR_REFERENCE_SPACE_TYPE_VIEW")]
    View = 1,

    [NativeName("XR_REFERENCE_SPACE_TYPE_LOCAL")]
    Local = 2,

    [NativeName("XR_REFERENCE_SPACE_TYPE_STAGE")]
    Stage = 3,

    [NativeName("XR_REFERENCE_SPACE_TYPE_LOCAL_FLOOR")]
    LocalFloor = 1000426000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_UNBOUNDED_MSFT")]
    UnboundedMSFT = 1000038000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_COMBINED_EYE_VARJO")]
    CombinedEyeVARJO = 1000121000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_LOCALIZATION_MAP_ML")]
    LocalizationMapML = 1000139000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_UNBOUNDED_ANDROID")]
    UnboundedANDROID = 1000467000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_STATIONARY_EXT")]
    StationaryEXT = 1000742000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_LOCAL_FLOOR_EXT")]
    LocalFloorEXT = LocalFloor,
}
