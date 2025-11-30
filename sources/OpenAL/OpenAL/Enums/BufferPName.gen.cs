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

[NativeName("BufferPName")]
[Transformed]
public enum BufferPName : uint
{
    [NativeName("AL_FREQUENCY")]
    Frequency = unchecked((uint)0x2001),

    [NativeName("AL_SIZE")]
    Size = unchecked((uint)0x2004),

    [NativeName("AL_BITS")]
    Bits = unchecked((uint)0x2002),

    [NativeName("AL_CHANNELS")]
    Channels = unchecked((uint)0x2003),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_LOOP_POINTS_SOFT")]
    LoopPointssoft = unchecked((uint)0x2015),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_INTERNAL_FORMAT_SOFT")]
    InternalFormatsoft = unchecked((uint)0x2008),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_BYTE_LENGTH_SOFT")]
    ByteLengthsoft = unchecked((uint)0x2009),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_SAMPLE_LENGTH_SOFT")]
    SampleLengthsoft = unchecked((uint)0x200A),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_SEC_LENGTH_SOFT")]
    SecLengthsoft = unchecked((uint)0x200B),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_UNPACK_BLOCK_ALIGNMENT_SOFT")]
    UnpackBlockAlignmentsoft = unchecked((uint)0x200C),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_PACK_BLOCK_ALIGNMENT_SOFT")]
    PackBlockAlignmentsoft = unchecked((uint)0x200D),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_AMBISONIC_LAYOUT_SOFT")]
    AmbisonicLayoutsoft = unchecked((uint)0x1997),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_AMBISONIC_SCALING_SOFT")]
    AmbisonicScalingsoft = unchecked((uint)0x1998),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_BUFFER_CALLBACK_FUNCTION_SOFT")]
    BufferCallbackFunctionsoft = unchecked((uint)0x19A0),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_BUFFER_CALLBACK_USER_PARAM_SOFT")]
    BufferCallbackUserParamsoft = unchecked((uint)0x19A1),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_UNPACK_AMBISONIC_ORDER_SOFT")]
    UnpackAmbisonicOrdersoft = unchecked((uint)0x199D),
}
