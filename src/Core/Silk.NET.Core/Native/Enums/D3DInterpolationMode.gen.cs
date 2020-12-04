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
    public enum D3DInterpolationMode
    {
        [NativeName("Name", "D3D_INTERPOLATION_UNDEFINED")]
        D3DInterpolationUndefined = 0x0,
        [NativeName("Name", "D3D_INTERPOLATION_CONSTANT")]
        D3DInterpolationConstant = 0x1,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR")]
        D3DInterpolationLinear = 0x2,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_CENTROID")]
        D3DInterpolationLinearCentroid = 0x3,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE")]
        D3DInterpolationLinearNoperspective = 0x4,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID")]
        D3DInterpolationLinearNoperspectiveCentroid = 0x5,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_SAMPLE")]
        D3DInterpolationLinearSample = 0x6,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE")]
        D3DInterpolationLinearNoperspectiveSample = 0x7,
    }
}
