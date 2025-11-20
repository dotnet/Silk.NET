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
public enum BufferChannelsSOFT : uint
{
    Mono = unchecked((uint)0x1500),
    Stereo = unchecked((uint)0x1501),
    Rear = unchecked((uint)0x1502),
    Quad = unchecked((uint)0x1503),
    X5Point1 = unchecked((uint)0x1504),
    X6Point1 = unchecked((uint)0x1505),
    X7Point1 = unchecked((uint)0x1506),
}
