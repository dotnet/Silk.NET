// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrViewConfigurationType")]
    public enum ViewConfigurationType
    {
        [NativeName("Name", "XR_VIEW_CONFIGURATION_TYPE_PRIMARY_MONO")]
        PrimaryMono = 1,
        [NativeName("Name", "XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO")]
        PrimaryStereo = 2,
        [NativeName("Name", "XR_VIEW_CONFIGURATION_TYPE_PRIMARY_QUAD_VARJO")]
        PrimaryQuadVarjo = 1000037000,
        [NativeName("Name", "XR_VIEW_CONFIGURATION_TYPE_SECONDARY_MONO_FIRST_PERSON_OBSERVER_MSFT")]
        SecondaryMonoFirstPersonObserverMsft = 1000054000,
    }
}
