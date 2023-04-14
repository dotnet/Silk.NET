// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvAccessQualifier_")]
    public enum AccessQualifier : int
    {
        [NativeName("Name", "SpvAccessQualifierReadOnly")]
        ReadOnly = 0x0,
        [NativeName("Name", "SpvAccessQualifierWriteOnly")]
        WriteOnly = 0x1,
        [NativeName("Name", "SpvAccessQualifierReadWrite")]
        ReadWrite = 0x2,
        [NativeName("Name", "SpvAccessQualifierMax")]
        Max = 0x7FFFFFFF,
    }
}
