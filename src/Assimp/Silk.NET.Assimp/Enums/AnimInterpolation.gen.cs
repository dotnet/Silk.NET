// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiAnimInterpolation")]
    public enum AnimInterpolation : int
    {
        [NativeName("Name", "aiAnimInterpolation_Step")]
        AnimInterpolationStep = 0x0,
        [NativeName("Name", "aiAnimInterpolation_Linear")]
        AnimInterpolationLinear = 0x1,
        [NativeName("Name", "aiAnimInterpolation_Spherical_Linear")]
        AnimInterpolationSphericalLinear = 0x2,
        [NativeName("Name", "aiAnimInterpolation_Cubic_Spline")]
        AnimInterpolationCubicSpline = 0x3,
        [NativeName("Name", "_aiAnimInterpolation_Force32Bit")]
        AnimInterpolationForce32Bit = 0x7FFFFFFF,
    }
}
