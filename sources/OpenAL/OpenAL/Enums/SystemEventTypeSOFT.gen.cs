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

[NativeName("SystemEventTypeSOFT")]
public enum SystemEventTypeSOFT : uint
{
    [NativeName("ALC_EVENT_TYPE_DEFAULT_DEVICE_CHANGED_SOFT")]
    DefaultDeviceChanged = 6614,

    [NativeName("ALC_EVENT_TYPE_DEVICE_ADDED_SOFT")]
    DeviceAdded = 6615,

    [NativeName("ALC_EVENT_TYPE_DEVICE_REMOVED_SOFT")]
    DeviceRemoved = 6616,
}
