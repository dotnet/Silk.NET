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

[Transformed]
public enum BufferPName : uint
{
    Frequency = unchecked((uint)0x2001),
    Size = unchecked((uint)0x2004),
    Bits = unchecked((uint)0x2002),
    Channels = unchecked((uint)0x2003),
    LoopPointsSOFT = unchecked((uint)0x2015),
    InternalFormatSOFT = unchecked((uint)0x2008),
    ByteLengthSOFT = unchecked((uint)0x2009),
    SampleLengthSOFT = unchecked((uint)0x200A),
    SecLengthSOFT = unchecked((uint)0x200B),
    UnpackBlockAlignmentSOFT = unchecked((uint)0x200C),
    PackBlockAlignmentSOFT = unchecked((uint)0x200D),
    AmbisonicLayoutSOFT = unchecked((uint)0x1997),
    AmbisonicScalingSOFT = unchecked((uint)0x1998),
    BufferCallbackFunctionSOFT = unchecked((uint)0x19A0),
    BufferCallbackUserParamSOFT = unchecked((uint)0x19A1),
    UnpackAmbisonicOrderSOFT = unchecked((uint)0x199D),
}
