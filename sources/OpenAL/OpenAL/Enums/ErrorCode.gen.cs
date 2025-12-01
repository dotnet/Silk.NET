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

[NativeName("ErrorCode")]
public enum ErrorCode : uint
{
    [NativeName("AL_NO_ERROR")]
    NoError = unchecked((uint)0),

    [NativeName("AL_INVALID_NAME")]
    InvalidName = unchecked((uint)0xA001),

    [NativeName("AL_INVALID_ENUM")]
    InvalidEnum = unchecked((uint)0xA002),

    [NativeName("AL_INVALID_VALUE")]
    InvalidValue = unchecked((uint)0xA003),

    [NativeName("AL_INVALID_OPERATION")]
    InvalidOperation = unchecked((uint)0xA004),

    [NativeName("AL_OUT_OF_MEMORY")]
    OutOfMemory = unchecked((uint)0xA005),

    [NativeName("AL_STACK_OVERFLOW_EXT")]
    StackOverflowEXT = unchecked((uint)0x19CD),

    [NativeName("AL_STACK_UNDERFLOW_EXT")]
    StackUnderflowEXT = unchecked((uint)0x19CE),

    [NativeName("ALC_NO_ERROR")]
    CNoError = unchecked((uint)0),

    [NativeName("ALC_INVALID_DEVICE")]
    CInvalidDevice = unchecked((uint)0xA001),

    [NativeName("ALC_INVALID_CONTEXT")]
    CInvalidContEXT = unchecked((uint)0xA002),

    [NativeName("ALC_INVALID_ENUM")]
    CInvalidEnum = unchecked((uint)0xA003),

    [NativeName("ALC_INVALID_VALUE")]
    CInvalidValue = unchecked((uint)0xA004),

    [NativeName("ALC_OUT_OF_MEMORY")]
    COutOfMemory = unchecked((uint)0xA005),
}
