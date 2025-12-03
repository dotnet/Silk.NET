// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

[NativeName("SampleTypeSOFT")]
public enum SampleTypeSOFT : uint
{
    [NativeName("AL_BYTE_SOFT")]
    Byte = unchecked((uint)0x1400),

    [NativeName("AL_UNSIGNED_BYTE_SOFT")]
    UnsignedByte = unchecked((uint)0x1401),

    [NativeName("AL_SHORT_SOFT")]
    Short = unchecked((uint)0x1402),

    [NativeName("AL_UNSIGNED_SHORT_SOFT")]
    UnsignedShort = unchecked((uint)0x1403),

    [NativeName("AL_INT_SOFT")]
    Int = unchecked((uint)0x1404),

    [NativeName("AL_UNSIGNED_INT_SOFT")]
    UnsignedInt = unchecked((uint)0x1405),

    [NativeName("AL_FLOAT_SOFT")]
    Float = unchecked((uint)0x1406),

    [NativeName("AL_DOUBLE_SOFT")]
    Double = unchecked((uint)0x1407),

    [NativeName("AL_BYTE3_SOFT")]
    Byte3 = unchecked((uint)0x1408),

    [NativeName("AL_UNSIGNED_BYTE3_SOFT")]
    UnsignedByte3 = unchecked((uint)0x1409),
}
