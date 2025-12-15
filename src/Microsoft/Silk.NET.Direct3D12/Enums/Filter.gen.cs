// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FILTER")]
    public enum Filter : int
    {
        [Obsolete("Deprecated in favour of \"MinMagMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MIN_MAG_MIP_POINT")]
        FilterMinMagMipPoint = 0x0,
        [Obsolete("Deprecated in favour of \"MinMagPointMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MIN_MAG_POINT_MIP_LINEAR")]
        FilterMinMagPointMipLinear = 0x1,
        [Obsolete("Deprecated in favour of \"MinPointMagLinearMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        FilterMinPointMagLinearMipPoint = 0x4,
        [Obsolete("Deprecated in favour of \"MinPointMagMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MIN_POINT_MAG_MIP_LINEAR")]
        FilterMinPointMagMipLinear = 0x5,
        [Obsolete("Deprecated in favour of \"MinLinearMagMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MIN_LINEAR_MAG_MIP_POINT")]
        FilterMinLinearMagMipPoint = 0x10,
        [Obsolete("Deprecated in favour of \"MinLinearMagPointMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        FilterMinLinearMagPointMipLinear = 0x11,
        [Obsolete("Deprecated in favour of \"MinMagLinearMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MIN_MAG_LINEAR_MIP_POINT")]
        FilterMinMagLinearMipPoint = 0x14,
        [Obsolete("Deprecated in favour of \"MinMagMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MIN_MAG_MIP_LINEAR")]
        FilterMinMagMipLinear = 0x15,
        [Obsolete("Deprecated in favour of \"MinMagAnisotropicMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MIN_MAG_ANISOTROPIC_MIP_POINT")]
        FilterMinMagAnisotropicMipPoint = 0x54,
        [Obsolete("Deprecated in favour of \"Anisotropic\"")]
        [NativeName("Name", "D3D12_FILTER_ANISOTROPIC")]
        FilterAnisotropic = 0x55,
        [Obsolete("Deprecated in favour of \"ComparisonMinMagMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_MAG_MIP_POINT")]
        FilterComparisonMinMagMipPoint = 0x80,
        [Obsolete("Deprecated in favour of \"ComparisonMinMagPointMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR")]
        FilterComparisonMinMagPointMipLinear = 0x81,
        [Obsolete("Deprecated in favour of \"ComparisonMinPointMagLinearMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        FilterComparisonMinPointMagLinearMipPoint = 0x84,
        [Obsolete("Deprecated in favour of \"ComparisonMinPointMagMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR")]
        FilterComparisonMinPointMagMipLinear = 0x85,
        [Obsolete("Deprecated in favour of \"ComparisonMinLinearMagMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT")]
        FilterComparisonMinLinearMagMipPoint = 0x90,
        [Obsolete("Deprecated in favour of \"ComparisonMinLinearMagPointMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        FilterComparisonMinLinearMagPointMipLinear = 0x91,
        [Obsolete("Deprecated in favour of \"ComparisonMinMagLinearMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT")]
        FilterComparisonMinMagLinearMipPoint = 0x94,
        [Obsolete("Deprecated in favour of \"ComparisonMinMagMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR")]
        FilterComparisonMinMagMipLinear = 0x95,
        [Obsolete("Deprecated in favour of \"ComparisonMinMagAnisotropicMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_MAG_ANISOTROPIC_MIP_POINT")]
        FilterComparisonMinMagAnisotropicMipPoint = 0xD4,
        [Obsolete("Deprecated in favour of \"ComparisonAnisotropic\"")]
        [NativeName("Name", "D3D12_FILTER_COMPARISON_ANISOTROPIC")]
        FilterComparisonAnisotropic = 0xD5,
        [Obsolete("Deprecated in favour of \"MinimumMinMagMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_MAG_MIP_POINT")]
        FilterMinimumMinMagMipPoint = 0x100,
        [Obsolete("Deprecated in favour of \"MinimumMinMagPointMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR")]
        FilterMinimumMinMagPointMipLinear = 0x101,
        [Obsolete("Deprecated in favour of \"MinimumMinPointMagLinearMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        FilterMinimumMinPointMagLinearMipPoint = 0x104,
        [Obsolete("Deprecated in favour of \"MinimumMinPointMagMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR")]
        FilterMinimumMinPointMagMipLinear = 0x105,
        [Obsolete("Deprecated in favour of \"MinimumMinLinearMagMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT")]
        FilterMinimumMinLinearMagMipPoint = 0x110,
        [Obsolete("Deprecated in favour of \"MinimumMinLinearMagPointMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        FilterMinimumMinLinearMagPointMipLinear = 0x111,
        [Obsolete("Deprecated in favour of \"MinimumMinMagLinearMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT")]
        FilterMinimumMinMagLinearMipPoint = 0x114,
        [Obsolete("Deprecated in favour of \"MinimumMinMagMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR")]
        FilterMinimumMinMagMipLinear = 0x115,
        [Obsolete("Deprecated in favour of \"MinimumMinMagAnisotropicMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_MAG_ANISOTROPIC_MIP_POINT")]
        FilterMinimumMinMagAnisotropicMipPoint = 0x154,
        [Obsolete("Deprecated in favour of \"MinimumAnisotropic\"")]
        [NativeName("Name", "D3D12_FILTER_MINIMUM_ANISOTROPIC")]
        FilterMinimumAnisotropic = 0x155,
        [Obsolete("Deprecated in favour of \"MaximumMinMagMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_POINT")]
        FilterMaximumMinMagMipPoint = 0x180,
        [Obsolete("Deprecated in favour of \"MaximumMinMagPointMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR")]
        FilterMaximumMinMagPointMipLinear = 0x181,
        [Obsolete("Deprecated in favour of \"MaximumMinPointMagLinearMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        FilterMaximumMinPointMagLinearMipPoint = 0x184,
        [Obsolete("Deprecated in favour of \"MaximumMinPointMagMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR")]
        FilterMaximumMinPointMagMipLinear = 0x185,
        [Obsolete("Deprecated in favour of \"MaximumMinLinearMagMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT")]
        FilterMaximumMinLinearMagMipPoint = 0x190,
        [Obsolete("Deprecated in favour of \"MaximumMinLinearMagPointMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        FilterMaximumMinLinearMagPointMipLinear = 0x191,
        [Obsolete("Deprecated in favour of \"MaximumMinMagLinearMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT")]
        FilterMaximumMinMagLinearMipPoint = 0x194,
        [Obsolete("Deprecated in favour of \"MaximumMinMagMipLinear\"")]
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR")]
        FilterMaximumMinMagMipLinear = 0x195,
        [Obsolete("Deprecated in favour of \"MaximumMinMagAnisotropicMipPoint\"")]
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_MAG_ANISOTROPIC_MIP_POINT")]
        FilterMaximumMinMagAnisotropicMipPoint = 0x1D4,
        [Obsolete("Deprecated in favour of \"MaximumAnisotropic\"")]
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_ANISOTROPIC")]
        FilterMaximumAnisotropic = 0x1D5,
        [NativeName("Name", "D3D12_FILTER_MIN_MAG_MIP_POINT")]
        MinMagMipPoint = 0x0,
        [NativeName("Name", "D3D12_FILTER_MIN_MAG_POINT_MIP_LINEAR")]
        MinMagPointMipLinear = 0x1,
        [NativeName("Name", "D3D12_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        MinPointMagLinearMipPoint = 0x4,
        [NativeName("Name", "D3D12_FILTER_MIN_POINT_MAG_MIP_LINEAR")]
        MinPointMagMipLinear = 0x5,
        [NativeName("Name", "D3D12_FILTER_MIN_LINEAR_MAG_MIP_POINT")]
        MinLinearMagMipPoint = 0x10,
        [NativeName("Name", "D3D12_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        MinLinearMagPointMipLinear = 0x11,
        [NativeName("Name", "D3D12_FILTER_MIN_MAG_LINEAR_MIP_POINT")]
        MinMagLinearMipPoint = 0x14,
        [NativeName("Name", "D3D12_FILTER_MIN_MAG_MIP_LINEAR")]
        MinMagMipLinear = 0x15,
        [NativeName("Name", "D3D12_FILTER_MIN_MAG_ANISOTROPIC_MIP_POINT")]
        MinMagAnisotropicMipPoint = 0x54,
        [NativeName("Name", "D3D12_FILTER_ANISOTROPIC")]
        Anisotropic = 0x55,
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_MAG_MIP_POINT")]
        ComparisonMinMagMipPoint = 0x80,
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_MAG_POINT_MIP_LINEAR")]
        ComparisonMinMagPointMipLinear = 0x81,
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        ComparisonMinPointMagLinearMipPoint = 0x84,
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_POINT_MAG_MIP_LINEAR")]
        ComparisonMinPointMagMipLinear = 0x85,
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_MIP_POINT")]
        ComparisonMinLinearMagMipPoint = 0x90,
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        ComparisonMinLinearMagPointMipLinear = 0x91,
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_MAG_LINEAR_MIP_POINT")]
        ComparisonMinMagLinearMipPoint = 0x94,
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_MAG_MIP_LINEAR")]
        ComparisonMinMagMipLinear = 0x95,
        [NativeName("Name", "D3D12_FILTER_COMPARISON_MIN_MAG_ANISOTROPIC_MIP_POINT")]
        ComparisonMinMagAnisotropicMipPoint = 0xD4,
        [NativeName("Name", "D3D12_FILTER_COMPARISON_ANISOTROPIC")]
        ComparisonAnisotropic = 0xD5,
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_MAG_MIP_POINT")]
        MinimumMinMagMipPoint = 0x100,
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_MAG_POINT_MIP_LINEAR")]
        MinimumMinMagPointMipLinear = 0x101,
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        MinimumMinPointMagLinearMipPoint = 0x104,
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_POINT_MAG_MIP_LINEAR")]
        MinimumMinPointMagMipLinear = 0x105,
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_MIP_POINT")]
        MinimumMinLinearMagMipPoint = 0x110,
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        MinimumMinLinearMagPointMipLinear = 0x111,
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_MAG_LINEAR_MIP_POINT")]
        MinimumMinMagLinearMipPoint = 0x114,
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_MAG_MIP_LINEAR")]
        MinimumMinMagMipLinear = 0x115,
        [NativeName("Name", "D3D12_FILTER_MINIMUM_MIN_MAG_ANISOTROPIC_MIP_POINT")]
        MinimumMinMagAnisotropicMipPoint = 0x154,
        [NativeName("Name", "D3D12_FILTER_MINIMUM_ANISOTROPIC")]
        MinimumAnisotropic = 0x155,
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_POINT")]
        MaximumMinMagMipPoint = 0x180,
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_MAG_POINT_MIP_LINEAR")]
        MaximumMinMagPointMipLinear = 0x181,
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        MaximumMinPointMagLinearMipPoint = 0x184,
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_POINT_MAG_MIP_LINEAR")]
        MaximumMinPointMagMipLinear = 0x185,
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_MIP_POINT")]
        MaximumMinLinearMagMipPoint = 0x190,
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        MaximumMinLinearMagPointMipLinear = 0x191,
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_MAG_LINEAR_MIP_POINT")]
        MaximumMinMagLinearMipPoint = 0x194,
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_MAG_MIP_LINEAR")]
        MaximumMinMagMipLinear = 0x195,
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_MIN_MAG_ANISOTROPIC_MIP_POINT")]
        MaximumMinMagAnisotropicMipPoint = 0x1D4,
        [NativeName("Name", "D3D12_FILTER_MAXIMUM_ANISOTROPIC")]
        MaximumAnisotropic = 0x1D5,
    }
}
