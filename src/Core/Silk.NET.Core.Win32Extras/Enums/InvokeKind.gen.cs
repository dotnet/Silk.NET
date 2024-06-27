// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagINVOKEKIND")]
    public enum InvokeKind : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Func\"")]
        [NativeName("Name", "INVOKE_FUNC")]
        InvokeFunc = 0x1,
        [Obsolete("Deprecated in favour of \"Propertyget\"")]
        [NativeName("Name", "INVOKE_PROPERTYGET")]
        InvokePropertyget = 0x2,
        [Obsolete("Deprecated in favour of \"Propertyput\"")]
        [NativeName("Name", "INVOKE_PROPERTYPUT")]
        InvokePropertyput = 0x4,
        [Obsolete("Deprecated in favour of \"Propertyputref\"")]
        [NativeName("Name", "INVOKE_PROPERTYPUTREF")]
        InvokePropertyputref = 0x8,
        [NativeName("Name", "INVOKE_FUNC")]
        Func = 0x1,
        [NativeName("Name", "INVOKE_PROPERTYGET")]
        Propertyget = 0x2,
        [NativeName("Name", "INVOKE_PROPERTYPUT")]
        Propertyput = 0x4,
        [NativeName("Name", "INVOKE_PROPERTYPUTREF")]
        Propertyputref = 0x8,
    }
}
