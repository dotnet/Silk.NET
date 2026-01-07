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

[NativeName("EventTypeSOFT")]
public enum EventTypeSOFT : uint
{
    [NativeName("AL_EVENT_TYPE_BUFFER_COMPLETED_SOFT")]
    BufferCompleted = 6564,

    [NativeName("AL_EVENT_TYPE_SOURCE_STATE_CHANGED_SOFT")]
    SourceStateChanged = 6565,

    [NativeName("AL_EVENT_TYPE_DISCONNECTED_SOFT")]
    Disconnected = 6566,
}
