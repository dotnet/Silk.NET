// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_FORMAT_TYPE_LEVEL")]
    public enum D3DFormatTypeLevel : int
    {
        [Obsolete("Deprecated in favour of \"NoType\"")]
        [NativeName("Name", "D3DFTL_NO_TYPE")]
        D3DftlNoType = 0x0,
        [Obsolete("Deprecated in favour of \"PartialType\"")]
        [NativeName("Name", "D3DFTL_PARTIAL_TYPE")]
        D3DftlPartialType = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [Obsolete("Deprecated in favour of \"FullType\"")]
        [NativeName("Name", "D3DFTL_FULL_TYPE")]
        D3DftlFullType = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3DFTL_NO_TYPE")]
        NoType = 0x0,
        [NativeName("Name", "D3DFTL_PARTIAL_TYPE")]
        PartialType = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "D3DFTL_FULL_TYPE")]
        FullType = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
