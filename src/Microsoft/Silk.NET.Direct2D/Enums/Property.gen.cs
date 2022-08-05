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
        [Obsolete("Deprecated in favour of \"Clsid\"")]
        [NativeName("Name", "D2D1_PROPERTY_CLSID")]
        PropertyClsid = unchecked((int) 0xFFFFFFFF80000000),
        [Obsolete("Deprecated in favour of \"Displayname\"")]
        [NativeName("Name", "D2D1_PROPERTY_DISPLAYNAME")]
        PropertyDisplayname = unchecked((int) 0xFFFFFFFF80000001),
        [Obsolete("Deprecated in favour of \"Author\"")]
        [NativeName("Name", "D2D1_PROPERTY_AUTHOR")]
        PropertyAuthor = unchecked((int) 0xFFFFFFFF80000002),
        [Obsolete("Deprecated in favour of \"Category\"")]
        [NativeName("Name", "D2D1_PROPERTY_CATEGORY")]
        PropertyCategory = unchecked((int) 0xFFFFFFFF80000003),
        [Obsolete("Deprecated in favour of \"Description\"")]
        [NativeName("Name", "D2D1_PROPERTY_DESCRIPTION")]
        PropertyDescription = unchecked((int) 0xFFFFFFFF80000004),
        [Obsolete("Deprecated in favour of \"Inputs\"")]
        [NativeName("Name", "D2D1_PROPERTY_INPUTS")]
        PropertyInputs = unchecked((int) 0xFFFFFFFF80000005),
        [Obsolete("Deprecated in favour of \"Cached\"")]
        [NativeName("Name", "D2D1_PROPERTY_CACHED")]
        PropertyCached = unchecked((int) 0xFFFFFFFF80000006),
        [Obsolete("Deprecated in favour of \"Precision\"")]
        [NativeName("Name", "D2D1_PROPERTY_PRECISION")]
        PropertyPrecision = unchecked((int) 0xFFFFFFFF80000007),
        [Obsolete("Deprecated in favour of \"MinInputs\"")]
        [NativeName("Name", "D2D1_PROPERTY_MIN_INPUTS")]
        PropertyMinInputs = unchecked((int) 0xFFFFFFFF80000008),
        [Obsolete("Deprecated in favour of \"MaxInputs\"")]
        [NativeName("Name", "D2D1_PROPERTY_MAX_INPUTS")]
        PropertyMaxInputs = unchecked((int) 0xFFFFFFFF80000009),
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_PROPERTY_FORCE_DWORD")]
        PropertyForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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
