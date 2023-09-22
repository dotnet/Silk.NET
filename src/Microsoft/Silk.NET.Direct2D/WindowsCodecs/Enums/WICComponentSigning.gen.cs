// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICComponentSigning")]
    public enum WICComponentSigning : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ComponentSigned\"")]
        [NativeName("Name", "WICComponentSigned")]
        WiccomponentSigned = 0x1,
        [Obsolete("Deprecated in favour of \"ComponentUnsigned\"")]
        [NativeName("Name", "WICComponentUnsigned")]
        WiccomponentUnsigned = 0x2,
        [Obsolete("Deprecated in favour of \"ComponentSafe\"")]
        [NativeName("Name", "WICComponentSafe")]
        WiccomponentSafe = 0x4,
        [Obsolete("Deprecated in favour of \"ComponentDisabled\"")]
        [NativeName("Name", "WICComponentDisabled")]
        WiccomponentDisabled = unchecked((int) 0xFFFFFFFF80000000),
        [Obsolete("Deprecated in favour of \"OmponentsigningForceDword\"")]
        [NativeName("Name", "WICCOMPONENTSIGNING_FORCE_DWORD")]
        WiccomponentsigningForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICComponentSigned")]
        ComponentSigned = 0x1,
        [NativeName("Name", "WICComponentUnsigned")]
        ComponentUnsigned = 0x2,
        [NativeName("Name", "WICComponentSafe")]
        ComponentSafe = 0x4,
        [NativeName("Name", "WICComponentDisabled")]
        ComponentDisabled = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "WICCOMPONENTSIGNING_FORCE_DWORD")]
        OmponentsigningForceDword = 0x7FFFFFFF,
    }
}
