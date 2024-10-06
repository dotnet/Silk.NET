// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum GLcontextFlag : uint
{
    DebugFlag = 0x0001,
    ForwardCompatibleFlag = 0x0002,
    RobustAccessFlag = 0x0004,
    ResetIsolationFlag = 0x0008,
}
