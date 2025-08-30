// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_FORMAT_COMPONENT_INTERPRETATION")]
    public enum D3DFormatComponentInterpretation : int
    {
        [Obsolete("Deprecated in favour of \"Typeless\"")]
        [NativeName("Name", "D3DFCI_TYPELESS")]
        D3DfciTypeless = 0x0,
        [Obsolete("Deprecated in favour of \"Float\"")]
        [NativeName("Name", "D3DFCI_FLOAT")]
        D3DfciFloat = unchecked((int) 0xFFFFFFFFFFFFFFFC),
        [Obsolete("Deprecated in favour of \"SNorm\"")]
        [NativeName("Name", "D3DFCI_SNORM")]
        D3DfciSNorm = unchecked((int) 0xFFFFFFFFFFFFFFFD),
        [Obsolete("Deprecated in favour of \"Unorm\"")]
        [NativeName("Name", "D3DFCI_UNORM")]
        D3DfciUnorm = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [Obsolete("Deprecated in favour of \"Sint\"")]
        [NativeName("Name", "D3DFCI_SINT")]
        D3DfciSint = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Uint\"")]
        [NativeName("Name", "D3DFCI_UINT")]
        D3DfciUint = 0x1,
        [Obsolete("Deprecated in favour of \"UnormSrgb\"")]
        [NativeName("Name", "D3DFCI_UNORM_SRGB")]
        D3DfciUnormSrgb = 0x2,
        [Obsolete("Deprecated in favour of \"BiasedFixed28\"")]
        [NativeName("Name", "D3DFCI_BIASED_FIXED_2_8")]
        D3DfciBiasedFixed28 = 0x3,
        [NativeName("Name", "D3DFCI_TYPELESS")]
        Typeless = 0x0,
        [NativeName("Name", "D3DFCI_FLOAT")]
        Float = unchecked((int) 0xFFFFFFFFFFFFFFFC),
        [NativeName("Name", "D3DFCI_SNORM")]
        SNorm = unchecked((int) 0xFFFFFFFFFFFFFFFD),
        [NativeName("Name", "D3DFCI_UNORM")]
        Unorm = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "D3DFCI_SINT")]
        Sint = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3DFCI_UINT")]
        Uint = 0x1,
        [NativeName("Name", "D3DFCI_UNORM_SRGB")]
        UnormSrgb = 0x2,
        [NativeName("Name", "D3DFCI_BIASED_FIXED_2_8")]
        BiasedFixed28 = 0x3,
    }
}
