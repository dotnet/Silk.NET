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

[NativeName("ObjectIdentifier")]
public enum ObjectIdentifier : uint
{
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_BUFFER_EXT")]
    BufferEXT = unchecked((uint)0x1009),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_SOURCE_EXT")]
    SourceEXT = unchecked((uint)0x19D0),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_FILTER_EXT")]
    FilterEXT = unchecked((uint)0x19D1),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_EFFECT_EXT")]
    EffectEXT = unchecked((uint)0x19D2),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_AUXILIARY_EFFECT_SLOT_EXT")]
    AuxiliaryEffectSlotEXT = unchecked((uint)0x19D3),
}
