// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICComponentEnumerateOptions")]
    public enum ComponentEnumerateOptions : int
    {
        [NativeName("Name", "WICComponentEnumerateDefault")]
        ComponentEnumerateDefault = 0x0,
        [NativeName("Name", "WICComponentEnumerateRefresh")]
        ComponentEnumerateRefresh = 0x1,
        [NativeName("Name", "WICComponentEnumerateDisabled")]
        ComponentEnumerateDisabled = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "WICComponentEnumerateUnsigned")]
        ComponentEnumerateUnsigned = 0x40000000,
        [NativeName("Name", "WICComponentEnumerateBuiltInOnly")]
        ComponentEnumerateBuiltInOnly = 0x20000000,
        [NativeName("Name", "WICCOMPONENTENUMERATEOPTIONS_FORCE_DWORD")]
        OmponentenumerateoptionsForceDword = 0x7FFFFFFF,
    }
}
