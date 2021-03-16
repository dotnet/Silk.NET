// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FILTER")]
    public enum Filter : int
    {
        [NativeName("Name", "D3D11_FILTER_MIN_MAG_MIP_POINT")]
        FilterMinMagMipPoint = 0x0,
        [NativeName("Name", "D3D11_FILTER_MIN_MAG_POINT_MIP_LINEAR")]
        FilterMinMagPointMipLinear = 0x1,
        [NativeName("Name", "D3D11_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        FilterMinPointMagLinearMipPoint = 0x4,
        [NativeName("Name", "D3D11_FILTER_MIN_POINT_MAG_MIP_LINEAR")]
        FilterMinPointMagMipLinear = 0x5,
        [NativeName("Name", "D3D11_FILTER_MIN_LINEAR_MAG_MIP_POINT")]
        FilterMinLinearMagMipPoint = 0x10,
        [NativeName("Name", "D3D11_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        FilterMinLinearMagPointMipLinear = 0x11,
        [NativeName("Name", "D3D11_FILTER_MIN_MAG_LINEAR_MIP_POINT")]
        FilterMinMagLinearMipPoint = 0x14,
        [NativeName("Name", "D3D11_FILTER_MIN_MAG_MIP_LINEAR")]
        FilterMinMagMipLinear = 0x15,
        [NativeName("Name", "D3D11_FILTER_ANISOTROPIC")]
        FilterAnisotropic = 0x55,
        [NativeName("Name", "D3D11_FILTER_COMPARISON_MIN_MAG_MIP_POINT")]
        FilterComparisonMinMagMipPoint = 0x80,
        [NativeName("Name", "D3D11_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR")]
        FilterComparisonMinMagPointMipLinear = 0x81,
        [NativeName("Name", "D3D11_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        FilterComparisonMinPointMagLinearMipPoint = 0x84,
        [NativeName("Name", "D3D11_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR")]
        FilterComparisonMinPointMagMipLinear = 0x85,
        [NativeName("Name", "D3D11_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT")]
        FilterComparisonMinLinearMagMipPoint = 0x90,
        [NativeName("Name", "D3D11_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        FilterComparisonMinLinearMagPointMipLinear = 0x91,
        [NativeName("Name", "D3D11_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT")]
        FilterComparisonMinMagLinearMipPoint = 0x94,
        [NativeName("Name", "D3D11_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR")]
        FilterComparisonMinMagMipLinear = 0x95,
        [NativeName("Name", "D3D11_FILTER_COMPARISON_ANISOTROPIC")]
        FilterComparisonAnisotropic = 0xD5,
        [NativeName("Name", "D3D11_FILTER_MINIMUM_MIN_MAG_MIP_POINT")]
        FilterMinimumMinMagMipPoint = 0x100,
        [NativeName("Name", "D3D11_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR")]
        FilterMinimumMinMagPointMipLinear = 0x101,
        [NativeName("Name", "D3D11_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        FilterMinimumMinPointMagLinearMipPoint = 0x104,
        [NativeName("Name", "D3D11_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR")]
        FilterMinimumMinPointMagMipLinear = 0x105,
        [NativeName("Name", "D3D11_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT")]
        FilterMinimumMinLinearMagMipPoint = 0x110,
        [NativeName("Name", "D3D11_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        FilterMinimumMinLinearMagPointMipLinear = 0x111,
        [NativeName("Name", "D3D11_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT")]
        FilterMinimumMinMagLinearMipPoint = 0x114,
        [NativeName("Name", "D3D11_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR")]
        FilterMinimumMinMagMipLinear = 0x115,
        [NativeName("Name", "D3D11_FILTER_MINIMUM_ANISOTROPIC")]
        FilterMinimumAnisotropic = 0x155,
        [NativeName("Name", "D3D11_FILTER_MAXIMUM_MIN_MAG_MIP_POINT")]
        FilterMaximumMinMagMipPoint = 0x180,
        [NativeName("Name", "D3D11_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR")]
        FilterMaximumMinMagPointMipLinear = 0x181,
        [NativeName("Name", "D3D11_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        FilterMaximumMinPointMagLinearMipPoint = 0x184,
        [NativeName("Name", "D3D11_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR")]
        FilterMaximumMinPointMagMipLinear = 0x185,
        [NativeName("Name", "D3D11_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT")]
        FilterMaximumMinLinearMagMipPoint = 0x190,
        [NativeName("Name", "D3D11_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        FilterMaximumMinLinearMagPointMipLinear = 0x191,
        [NativeName("Name", "D3D11_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT")]
        FilterMaximumMinMagLinearMipPoint = 0x194,
        [NativeName("Name", "D3D11_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR")]
        FilterMaximumMinMagMipLinear = 0x195,
        [NativeName("Name", "D3D11_FILTER_MAXIMUM_ANISOTROPIC")]
        FilterMaximumAnisotropic = 0x1D5,
    }
}
