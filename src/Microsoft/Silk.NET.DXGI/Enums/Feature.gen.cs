// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_FEATURE")]
    public enum Feature
    {
        [NativeName("Name", "DXGI_FEATURE_PRESENT_ALLOW_TEARING")]
        FeaturePresentAllowTearing = 0x0,
    }
}
