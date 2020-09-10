// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_INTERPOLATION_MODE")]
    public enum InterpolationMode
    {
        [NativeName("Name", "D3D_INTERPOLATION_UNDEFINED")]
        InterpolationUndefined = 0x0,
        [NativeName("Name", "D3D_INTERPOLATION_CONSTANT")]
        InterpolationConstant = 0x1,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR")]
        InterpolationLinear = 0x2,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_CENTROID")]
        InterpolationLinearCentroid = 0x3,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE")]
        InterpolationLinearNoperspective = 0x4,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID")]
        InterpolationLinearNoperspectiveCentroid = 0x5,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_SAMPLE")]
        InterpolationLinearSample = 0x6,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE")]
        InterpolationLinearNoperspectiveSample = 0x7,
    }
}
