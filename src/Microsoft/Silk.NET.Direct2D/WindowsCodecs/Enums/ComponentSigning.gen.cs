// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICComponentSigning")]
    public enum ComponentSigning : int
    {
        [NativeName("Name", "")]
        None = 0,
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
