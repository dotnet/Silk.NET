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

[NameAffix("Suffix", "SOFT", 0, -1)]
[NativeName("EventTypeSOFT")]
public enum EventTypeSOFT : uint
{
    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("AL_EVENT_TYPE_BUFFER_COMPLETED_SOFT")]
    EventTypeBufferCompleted = unchecked((uint)0x19A4),

    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("AL_EVENT_TYPE_SOURCE_STATE_CHANGED_SOFT")]
    EventTypeSourceStateChanged = unchecked((uint)0x19A5),

    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("AL_EVENT_TYPE_DISCONNECTED_SOFT")]
    EventTypeDisconnected = unchecked((uint)0x19A6),

    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("ALC_EVENT_TYPE_DEFAULT_DEVICE_CHANGED_SOFT")]
    CEventTypeDefaultDeviceChanged = unchecked((uint)0x19D6),

    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("ALC_EVENT_TYPE_DEVICE_ADDED_SOFT")]
    CEventTypeDeviceAdded = unchecked((uint)0x19D7),

    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("ALC_EVENT_TYPE_DEVICE_REMOVED_SOFT")]
    CEventTypeDeviceRemoved = unchecked((uint)0x19D8),
}
