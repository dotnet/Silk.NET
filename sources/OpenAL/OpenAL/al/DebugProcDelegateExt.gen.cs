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

[NameAffix("Suffix", "Delegate", 1, -1)]
[NativeName("ALDEBUGPROCEXT")]
public unsafe delegate void DebugProcDelegateExt(
    int arg0,
    int arg1,
    uint arg2,
    int arg3,
    int arg4,
    sbyte* arg5,
    void* arg6
);
