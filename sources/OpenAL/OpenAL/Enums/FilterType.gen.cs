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

[NativeName("FilterType")]
public enum FilterType : uint
{
    [NativeName("AL_FILTER_NULL")]
    Null = 0,

    [NativeName("AL_FILTER_LOWPASS")]
    Lowpass = 1,

    [NativeName("AL_FILTER_HIGHPASS")]
    Highpass = 2,

    [NativeName("AL_FILTER_BANDPASS")]
    Bandpass = 3,
}
