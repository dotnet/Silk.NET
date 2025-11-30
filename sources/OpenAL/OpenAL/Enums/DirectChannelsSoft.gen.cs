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

[NameAffix("Suffix", "SOFT", 0)]
[NativeName("DirectChannelsSOFT")]
[Transformed]
public enum DirectChannelsSoft : uint
{
    [NativeName("AL_FALSE")]
    False = unchecked((uint)0),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_DROP_UNMATCHED_SOFT")]
    DropUnmatchedsoft = unchecked((uint)0x0001),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_REMIX_UNMATCHED_SOFT")]
    RemixUnmatchedsoft = unchecked((uint)0x0002),
}
