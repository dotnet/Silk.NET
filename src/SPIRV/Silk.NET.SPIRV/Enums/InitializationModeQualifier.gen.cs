// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvInitializationModeQualifier_")]
    public enum InitializationModeQualifier : int
    {
        [NativeName("Name", "SpvInitializationModeQualifierInitOnDeviceReprogramINTEL")]
        InitOnDeviceReprogramIntel = 0x0,
        [NativeName("Name", "SpvInitializationModeQualifierInitOnDeviceResetINTEL")]
        InitOnDeviceResetIntel = 0x1,
        [NativeName("Name", "SpvInitializationModeQualifierMax")]
        Max = 0x7FFFFFFF,
    }
}
