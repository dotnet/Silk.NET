// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [Flags]
    [NativeName("Name", "SpvMemoryAccessMask_")]
    public enum MemoryAccessMask : int
    {
        [NativeName("Name", "SpvMemoryAccessMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvMemoryAccessVolatileMask")]
        VolatileMask = 0x1,
        [NativeName("Name", "SpvMemoryAccessAlignedMask")]
        AlignedMask = 0x2,
        [NativeName("Name", "SpvMemoryAccessNontemporalMask")]
        NontemporalMask = 0x4,
        [NativeName("Name", "SpvMemoryAccessMakePointerAvailableMask")]
        MakePointerAvailableMask = 0x8,
        [NativeName("Name", "SpvMemoryAccessMakePointerAvailableKHRMask")]
        MakePointerAvailableKhrmask = 0x8,
        [NativeName("Name", "SpvMemoryAccessMakePointerVisibleMask")]
        MakePointerVisibleMask = 0x10,
        [NativeName("Name", "SpvMemoryAccessMakePointerVisibleKHRMask")]
        MakePointerVisibleKhrmask = 0x10,
        [NativeName("Name", "SpvMemoryAccessNonPrivatePointerMask")]
        NonPrivatePointerMask = 0x20,
        [NativeName("Name", "SpvMemoryAccessNonPrivatePointerKHRMask")]
        NonPrivatePointerKhrmask = 0x20,
        [NativeName("Name", "SpvMemoryAccessAliasScopeINTELMaskMask")]
        AliasScopeIntelmaskMask = 0x10000,
        [NativeName("Name", "SpvMemoryAccessNoAliasINTELMaskMask")]
        NoAliasIntelmaskMask = 0x20000,
    }
}
