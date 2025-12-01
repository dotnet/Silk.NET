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

[NativeName("SourceBoolean")]
public enum SourceBoolean : uint
{
    [NativeName("AL_SOURCE_RELATIVE")]
    SourceRelative = unchecked((uint)0x202),

    [NativeName("AL_LOOPING")]
    Looping = unchecked((uint)0x1007),

    [NativeName("AL_DIRECT_FILTER_GAINHF_AUTO")]
    DirectFilterGainhfAuto = unchecked((uint)0x2000A),

    [NativeName("AL_AUXILIARY_SEND_FILTER_GAIN_AUTO")]
    AuxiliarySendFilterGainAuto = unchecked((uint)0x2000B),

    [NativeName("AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO")]
    AuxiliarySendFilterGainhfAuto = unchecked((uint)0x2000C),
}
