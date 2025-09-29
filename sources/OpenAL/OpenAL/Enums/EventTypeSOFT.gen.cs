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
public enum EventTypeSOFT : uint
{
    EventTypeBufferCompleted = unchecked((uint)0x19A4),
    EventTypeSourceStateChanged = unchecked((uint)0x19A5),
    EventTypeDisconnected = unchecked((uint)0x19A6),
    CEventTypeDefaultDeviceChanged = unchecked((uint)0x19D6),
    CEventTypeDeviceAdded = unchecked((uint)0x19D7),
    CEventTypeDeviceRemoved = unchecked((uint)0x19D8),
}
