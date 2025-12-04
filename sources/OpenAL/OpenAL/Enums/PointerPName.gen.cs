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

[NativeName("PointerPName")]
public enum PointerPName : uint
{
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_EVENT_CALLBACK_FUNCTION_SOFT")]
    EventCallbackFunctionSOFT = unchecked((uint)0x19A2),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_EVENT_CALLBACK_USER_PARAM_SOFT")]
    EventCallbackUserParamSOFT = unchecked((uint)0x19A3),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_DEBUG_CALLBACK_FUNCTION_EXT")]
    DebugCallbackFunctionEXT = unchecked((uint)0x19B3),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_DEBUG_CALLBACK_USER_PARAM_EXT")]
    DebugCallbackUserParamEXT = unchecked((uint)0x19B4),
}
