// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvHostAccessQualifier_")]
    public enum HostAccessQualifier : int
    {
        [NativeName("Name", "SpvHostAccessQualifierNoneINTEL")]
        NoneIntel = 0x0,
        [NativeName("Name", "SpvHostAccessQualifierReadINTEL")]
        ReadIntel = 0x1,
        [NativeName("Name", "SpvHostAccessQualifierWriteINTEL")]
        WriteIntel = 0x2,
        [NativeName("Name", "SpvHostAccessQualifierReadWriteINTEL")]
        ReadWriteIntel = 0x3,
        [NativeName("Name", "SpvHostAccessQualifierMax")]
        Max = 0x7FFFFFFF,
    }
}
