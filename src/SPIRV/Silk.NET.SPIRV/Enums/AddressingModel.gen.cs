// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvAddressingModel_")]
    public enum AddressingModel : int
    {
        [NativeName("Name", "SpvAddressingModelLogical")]
        Logical = 0x0,
        [NativeName("Name", "SpvAddressingModelPhysical32")]
        Physical32 = 0x1,
        [NativeName("Name", "SpvAddressingModelPhysical64")]
        Physical64 = 0x2,
        [NativeName("Name", "SpvAddressingModelPhysicalStorageBuffer64")]
        PhysicalStorageBuffer64 = 0x14E4,
        [NativeName("Name", "SpvAddressingModelPhysicalStorageBuffer64EXT")]
        PhysicalStorageBuffer64Ext = 0x14E4,
        [NativeName("Name", "SpvAddressingModelMax")]
        Max = 0x7FFFFFFF,
    }
}
