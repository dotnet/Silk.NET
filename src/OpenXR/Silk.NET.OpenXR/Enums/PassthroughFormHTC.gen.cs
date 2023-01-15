// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPassthroughFormHTC")]
    public enum PassthroughFormHTC : int
    {
        [Obsolete("Deprecated in favour of \"PlanarHtc\"")]
        [NativeName("Name", "XR_PASSTHROUGH_FORM_PLANAR_HTC")]
        PassthroughFormPlanarHtc = 0,
        [Obsolete("Deprecated in favour of \"ProjectedHtc\"")]
        [NativeName("Name", "XR_PASSTHROUGH_FORM_PROJECTED_HTC")]
        PassthroughFormProjectedHtc = 1,
        [NativeName("Name", "XR_PASSTHROUGH_FORM_PLANAR_HTC")]
        PlanarHtc = 0,
        [NativeName("Name", "XR_PASSTHROUGH_FORM_PROJECTED_HTC")]
        ProjectedHtc = 1,
    }
}
