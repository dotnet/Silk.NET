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
    Byte = 5120,

    [NativeName("AL_UNSIGNED_BYTE_SOFT")]
    UnsignedByte = 5121,

    [NativeName("AL_SHORT_SOFT")]
    Short = 5122,

    [NativeName("AL_UNSIGNED_SHORT_SOFT")]
    UnsignedShort = 5123,

    [NativeName("AL_INT_SOFT")]
    Int = 5124,

    [NativeName("AL_UNSIGNED_INT_SOFT")]
    UnsignedInt = 5125,

    [NativeName("AL_FLOAT_SOFT")]
    Float = 5126,

    [NativeName("AL_DOUBLE_SOFT")]
    Double = 5127,

    [NativeName("AL_BYTE3_SOFT")]
    Byte3 = 5128,

    [NativeName("AL_UNSIGNED_BYTE3_SOFT")]
    UnsignedByte3 = 5129,
}
