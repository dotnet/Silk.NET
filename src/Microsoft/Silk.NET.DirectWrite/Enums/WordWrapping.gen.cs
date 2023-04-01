// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_WORD_WRAPPING")]
    public enum WordWrapping : int
    {
        [NativeName("Name", "DWRITE_WORD_WRAPPING_WRAP")]
        Wrap = 0x0,
        [NativeName("Name", "DWRITE_WORD_WRAPPING_NO_WRAP")]
        NoWrap = 0x1,
        [NativeName("Name", "DWRITE_WORD_WRAPPING_EMERGENCY_BREAK")]
        EmergencyBreak = 0x2,
        [NativeName("Name", "DWRITE_WORD_WRAPPING_WHOLE_WORD")]
        WholeWord = 0x3,
        [NativeName("Name", "DWRITE_WORD_WRAPPING_CHARACTER")]
        Character = 0x4,
    }
}
