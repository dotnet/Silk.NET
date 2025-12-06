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
    [NativeName("AL_BUFFER_EXT")]
    BufferEXT = 4105,

    [NativeName("AL_SOURCE_EXT")]
    SourceEXT = 6608,

    [NativeName("AL_FILTER_EXT")]
    FilterEXT = 6609,

    [NativeName("AL_EFFECT_EXT")]
    EffectEXT = 6610,

    [NativeName("AL_AUXILIARY_EFFECT_SLOT_EXT")]
    AuxiliaryEffectSlotEXT = 6611,
}
