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
    NoError = 0,

    [NativeName("AL_INVALID_NAME")]
    InvalidName = 40961,

    [NativeName("AL_INVALID_ENUM")]
    InvalidEnum = 40962,

    [NativeName("AL_INVALID_VALUE")]
    InvalidValue = 40963,

    [NativeName("AL_INVALID_OPERATION")]
    InvalidOperation = 40964,

    [NativeName("AL_OUT_OF_MEMORY")]
    OutOfMemory = 40965,

    [NativeName("AL_STACK_OVERFLOW_EXT")]
    StackOverflowEXT = 6605,

    [NativeName("AL_STACK_UNDERFLOW_EXT")]
    StackUnderflowEXT = 6606,
}
