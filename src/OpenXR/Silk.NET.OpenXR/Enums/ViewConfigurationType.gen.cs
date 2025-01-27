// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrViewConfigurationType")]
    public enum ViewConfigurationType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "XR_VIEW_CONFIGURATION_TYPE_PRIMARY_MONO")]
        PrimaryMono = 1,
        [NativeName("Name", "XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO")]
        PrimaryStereo = 2,
        [NativeName("Name", "XR_VIEW_CONFIGURATION_TYPE_PRIMARY_QUAD_VARJO")]
        PrimaryQuadVarjo = 1000037000,
        [NativeName("Name", "XR_VIEW_CONFIGURATION_TYPE_SECONDARY_MONO_FIRST_PERSON_OBSERVER_MSFT")]
        SecondaryMonoFirstPersonObserverMsft = 1000054000,
        [NativeName("Name", "XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO_WITH_FOVEATED_INSET")]
        PrimaryStereoWithFoveatedInset = 1000037000,
    }
}
