// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSenseDataProviderTypeBD")]
    public enum SenseDataProviderTypeBD : int
    {
        [Obsolete("Deprecated in favour of \"AnchorBD\"")]
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_TYPE_ANCHOR_BD")]
        SenseDataProviderTypeAnchorBD = 1000390000,
        [Obsolete("Deprecated in favour of \"SceneBD\"")]
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_TYPE_SCENE_BD")]
        SenseDataProviderTypeSceneBD = 1000392000,
        [Obsolete("Deprecated in favour of \"MeshBD\"")]
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_TYPE_MESH_BD")]
        SenseDataProviderTypeMeshBD = 1000393000,
        [Obsolete("Deprecated in favour of \"PlaneBD\"")]
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_TYPE_PLANE_BD")]
        SenseDataProviderTypePlaneBD = 1000396000,
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_TYPE_ANCHOR_BD")]
        AnchorBD = 1000390000,
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_TYPE_SCENE_BD")]
        SceneBD = 1000392000,
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_TYPE_MESH_BD")]
        MeshBD = 1000393000,
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_TYPE_PLANE_BD")]
        PlaneBD = 1000396000,
    }
}
