// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvMemoryAccessShift_")]
    public enum MemoryAccessShift : int
    {
        [NativeName("Name", "SpvMemoryAccessVolatileShift")]
        VolatileShift = 0x0,
        [NativeName("Name", "SpvMemoryAccessAlignedShift")]
        AlignedShift = 0x1,
        [NativeName("Name", "SpvMemoryAccessNontemporalShift")]
        NontemporalShift = 0x2,
        [NativeName("Name", "SpvMemoryAccessMakePointerAvailableShift")]
        MakePointerAvailableShift = 0x3,
        [NativeName("Name", "SpvMemoryAccessMakePointerAvailableKHRShift")]
        MakePointerAvailableKhrShift = 0x3,
        [NativeName("Name", "SpvMemoryAccessMakePointerVisibleShift")]
        MakePointerVisibleShift = 0x4,
        [NativeName("Name", "SpvMemoryAccessMakePointerVisibleKHRShift")]
        MakePointerVisibleKhrShift = 0x4,
        [NativeName("Name", "SpvMemoryAccessNonPrivatePointerShift")]
        NonPrivatePointerShift = 0x5,
        [NativeName("Name", "SpvMemoryAccessNonPrivatePointerKHRShift")]
        NonPrivatePointerKhrShift = 0x5,
        [NativeName("Name", "SpvMemoryAccessAliasScopeINTELMaskShift")]
        AliasScopeIntelMaskShift = 0x10,
        [NativeName("Name", "SpvMemoryAccessNoAliasINTELMaskShift")]
        NoAliasIntelMaskShift = 0x11,
        [NativeName("Name", "SpvMemoryAccessMax")]
        Max = 0x7FFFFFFF,
    }
}
