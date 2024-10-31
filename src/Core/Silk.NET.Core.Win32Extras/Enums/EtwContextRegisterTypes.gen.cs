// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "ETW_CONTEXT_REGISTER_TYPES")]
    public enum EtwContextRegisterTypes : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "EtwContextRegisterTypeNone")]
        EtwContextRegisterTypeNone = 0x0,
        [Obsolete("Deprecated in favour of \"Control\"")]
        [NativeName("Name", "EtwContextRegisterTypeControl")]
        EtwContextRegisterTypeControl = 0x1,
        [Obsolete("Deprecated in favour of \"Integer\"")]
        [NativeName("Name", "EtwContextRegisterTypeInteger")]
        EtwContextRegisterTypeInteger = 0x2,
        [NativeName("Name", "EtwContextRegisterTypeNone")]
        None = 0x0,
        [NativeName("Name", "EtwContextRegisterTypeControl")]
        Control = 0x1,
        [NativeName("Name", "EtwContextRegisterTypeInteger")]
        Integer = 0x2,
    }
}
