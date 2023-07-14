// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_PROPERTY")]
    public enum Property : int
    {
        [NativeName("Name", "D2D1_PROPERTY_CLSID")]
        Clsid = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "D2D1_PROPERTY_DISPLAYNAME")]
        Displayname = unchecked((int) 0xFFFFFFFF80000001),
        [NativeName("Name", "D2D1_PROPERTY_AUTHOR")]
        Author = unchecked((int) 0xFFFFFFFF80000002),
        [NativeName("Name", "D2D1_PROPERTY_CATEGORY")]
        Category = unchecked((int) 0xFFFFFFFF80000003),
        [NativeName("Name", "D2D1_PROPERTY_DESCRIPTION")]
        Description = unchecked((int) 0xFFFFFFFF80000004),
        [NativeName("Name", "D2D1_PROPERTY_INPUTS")]
        Inputs = unchecked((int) 0xFFFFFFFF80000005),
        [NativeName("Name", "D2D1_PROPERTY_CACHED")]
        Cached = unchecked((int) 0xFFFFFFFF80000006),
        [NativeName("Name", "D2D1_PROPERTY_PRECISION")]
        Precision = unchecked((int) 0xFFFFFFFF80000007),
        [NativeName("Name", "D2D1_PROPERTY_MIN_INPUTS")]
        MinInputs = unchecked((int) 0xFFFFFFFF80000008),
        [NativeName("Name", "D2D1_PROPERTY_MAX_INPUTS")]
        MaxInputs = unchecked((int) 0xFFFFFFFF80000009),
        [NativeName("Name", "D2D1_PROPERTY_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
