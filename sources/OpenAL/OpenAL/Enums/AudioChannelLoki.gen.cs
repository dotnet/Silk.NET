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

[NameAffix("Suffix", "LOKI", 0)]
[NativeName("AudioChannelLOKI")]
[Transformed]
public enum AudioChannelLoki : uint
{
    [NameAffix("Suffix", "LOKI", 0)]
    [NativeName("ALC_CHAN_MAIN_LOKI")]
    Mainloki = unchecked((uint)0x500001),

    [NameAffix("Suffix", "LOKI", 0)]
    [NativeName("ALC_CHAN_PCM_LOKI")]
    Pcmloki = unchecked((uint)0x500002),

    [NameAffix("Suffix", "LOKI", 0)]
    [NativeName("ALC_CHAN_CD_LOKI")]
    Cdloki = unchecked((uint)0x500003),
}
