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
public enum DistanceModel : uint
{
    None = unchecked((uint)0),
    InverseDistance = unchecked((uint)0xD001),
    InverseDistanceClamped = unchecked((uint)0xD002),
    LinearDistance = unchecked((uint)0xD003),
    LinearDistanceClamped = unchecked((uint)0xD004),
    ExponentDistance = unchecked((uint)0xD005),
    ExponentDistanceClamped = unchecked((uint)0xD006),
}
