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
