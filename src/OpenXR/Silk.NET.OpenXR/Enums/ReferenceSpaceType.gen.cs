// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrReferenceSpaceType")]
    public enum ReferenceSpaceType : int
    {
        [NativeName("Name", "XR_REFERENCE_SPACE_TYPE_VIEW")]
        View = 1,
        [NativeName("Name", "XR_REFERENCE_SPACE_TYPE_LOCAL")]
        Local = 2,
        [NativeName("Name", "XR_REFERENCE_SPACE_TYPE_STAGE")]
        Stage = 3,
        [NativeName("Name", "XR_REFERENCE_SPACE_TYPE_UNBOUNDED_MSFT")]
        UnboundedMsft = 1000038000,
        [NativeName("Name", "XR_REFERENCE_SPACE_TYPE_COMBINED_EYE_VARJO")]
        CombinedEyeVarjo = 1000121000,
        [NativeName("Name", "XR_REFERENCE_SPACE_TYPE_LOCALIZATION_MAP_ML")]
        LocalizationMapML = 1000139000,
        [NativeName("Name", "XR_REFERENCE_SPACE_TYPE_LOCAL_FLOOR_EXT")]
        LocalFloorExt = 1000426000,
        [NativeName("Name", "XR_REFERENCE_SPACE_TYPE_LOCAL_FLOOR")]
        LocalFloor = 1000426000,
    }
}
