// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvMemoryAccessShift_")]
    public enum MemoryAccessShift : int
    {
        [NativeName("Name", "SpvMemoryAccessVolatileShift")]
        MemoryAccessVolatileShift = 0x0,
        [NativeName("Name", "SpvMemoryAccessAlignedShift")]
        MemoryAccessAlignedShift = 0x1,
        [NativeName("Name", "SpvMemoryAccessNontemporalShift")]
        MemoryAccessNontemporalShift = 0x2,
        [NativeName("Name", "SpvMemoryAccessMakePointerAvailableShift")]
        MemoryAccessMakePointerAvailableShift = 0x3,
        [NativeName("Name", "SpvMemoryAccessMakePointerAvailableKHRShift")]
        MemoryAccessMakePointerAvailableKhrshift = 0x3,
        [NativeName("Name", "SpvMemoryAccessMakePointerVisibleShift")]
        MemoryAccessMakePointerVisibleShift = 0x4,
        [NativeName("Name", "SpvMemoryAccessMakePointerVisibleKHRShift")]
        MemoryAccessMakePointerVisibleKhrshift = 0x4,
        [NativeName("Name", "SpvMemoryAccessNonPrivatePointerShift")]
        MemoryAccessNonPrivatePointerShift = 0x5,
        [NativeName("Name", "SpvMemoryAccessNonPrivatePointerKHRShift")]
        MemoryAccessNonPrivatePointerKhrshift = 0x5,
        [NativeName("Name", "SpvMemoryAccessAliasScopeINTELMaskShift")]
        MemoryAccessAliasScopeIntelmaskShift = 0x10,
        [NativeName("Name", "SpvMemoryAccessNoAliasINTELMaskShift")]
        MemoryAccessNoAliasIntelmaskShift = 0x11,
        [NativeName("Name", "SpvMemoryAccessMax")]
        MemoryAccessMax = 0x7FFFFFFF,
    }
}
