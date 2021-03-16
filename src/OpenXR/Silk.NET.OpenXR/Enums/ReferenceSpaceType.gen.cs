// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    }
}
