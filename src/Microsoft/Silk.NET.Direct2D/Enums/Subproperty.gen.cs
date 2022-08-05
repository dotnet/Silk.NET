// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SUBPROPERTY")]
    public enum Subproperty : int
    {
        [Obsolete("Deprecated in favour of \"Displayname\"")]
        [NativeName("Name", "D2D1_SUBPROPERTY_DISPLAYNAME")]
        SubpropertyDisplayname = unchecked((int) 0xFFFFFFFF80000000),
        [Obsolete("Deprecated in favour of \"Isreadonly\"")]
        [NativeName("Name", "D2D1_SUBPROPERTY_ISREADONLY")]
        SubpropertyIsreadonly = unchecked((int) 0xFFFFFFFF80000001),
        [Obsolete("Deprecated in favour of \"Min\"")]
        [NativeName("Name", "D2D1_SUBPROPERTY_MIN")]
        SubpropertyMin = unchecked((int) 0xFFFFFFFF80000002),
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "D2D1_SUBPROPERTY_MAX")]
        SubpropertyMax = unchecked((int) 0xFFFFFFFF80000003),
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "D2D1_SUBPROPERTY_DEFAULT")]
        SubpropertyDefault = unchecked((int) 0xFFFFFFFF80000004),
        [Obsolete("Deprecated in favour of \"Fields\"")]
        [NativeName("Name", "D2D1_SUBPROPERTY_FIELDS")]
        SubpropertyFields = unchecked((int) 0xFFFFFFFF80000005),
        [Obsolete("Deprecated in favour of \"Index\"")]
        [NativeName("Name", "D2D1_SUBPROPERTY_INDEX")]
        SubpropertyIndex = unchecked((int) 0xFFFFFFFF80000006),
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SUBPROPERTY_FORCE_DWORD")]
        SubpropertyForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SUBPROPERTY_DISPLAYNAME")]
        Displayname = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "D2D1_SUBPROPERTY_ISREADONLY")]
        Isreadonly = unchecked((int) 0xFFFFFFFF80000001),
        [NativeName("Name", "D2D1_SUBPROPERTY_MIN")]
        Min = unchecked((int) 0xFFFFFFFF80000002),
        [NativeName("Name", "D2D1_SUBPROPERTY_MAX")]
        Max = unchecked((int) 0xFFFFFFFF80000003),
        [NativeName("Name", "D2D1_SUBPROPERTY_DEFAULT")]
        Default = unchecked((int) 0xFFFFFFFF80000004),
        [NativeName("Name", "D2D1_SUBPROPERTY_FIELDS")]
        Fields = unchecked((int) 0xFFFFFFFF80000005),
        [NativeName("Name", "D2D1_SUBPROPERTY_INDEX")]
        Index = unchecked((int) 0xFFFFFFFF80000006),
        [NativeName("Name", "D2D1_SUBPROPERTY_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
