// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_INTERPOLATION_MODE")]
    public enum D3DInterpolationMode : int
    {
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "D3D_INTERPOLATION_UNDEFINED")]
        D3DInterpolationUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Constant\"")]
        [NativeName("Name", "D3D_INTERPOLATION_CONSTANT")]
        D3DInterpolationConstant = 0x1,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR")]
        D3DInterpolationLinear = 0x2,
        [Obsolete("Deprecated in favour of \"LinearCentroid\"")]
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_CENTROID")]
        D3DInterpolationLinearCentroid = 0x3,
        [Obsolete("Deprecated in favour of \"LinearNoperspective\"")]
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE")]
        D3DInterpolationLinearNoperspective = 0x4,
        [Obsolete("Deprecated in favour of \"LinearNoperspectiveCentroid\"")]
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID")]
        D3DInterpolationLinearNoperspectiveCentroid = 0x5,
        [Obsolete("Deprecated in favour of \"LinearSample\"")]
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_SAMPLE")]
        D3DInterpolationLinearSample = 0x6,
        [Obsolete("Deprecated in favour of \"LinearNoperspectiveSample\"")]
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE")]
        D3DInterpolationLinearNoperspectiveSample = 0x7,
        [NativeName("Name", "D3D_INTERPOLATION_UNDEFINED")]
        Undefined = 0x0,
        [NativeName("Name", "D3D_INTERPOLATION_CONSTANT")]
        Constant = 0x1,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR")]
        Linear = 0x2,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_CENTROID")]
        LinearCentroid = 0x3,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE")]
        LinearNoperspective = 0x4,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID")]
        LinearNoperspectiveCentroid = 0x5,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_SAMPLE")]
        LinearSample = 0x6,
        [NativeName("Name", "D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE")]
        LinearNoperspectiveSample = 0x7,
    }
}
