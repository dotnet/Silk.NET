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
public enum GetPName : uint
{
    Vendor = unchecked((uint)0xB001),
    Version = unchecked((uint)0xB002),
    Renderer = unchecked((uint)0xB003),
    Extensions = unchecked((uint)0xB004),
    DopplerFactor = unchecked((uint)0xC000),
    DopplerVelocity = unchecked((uint)0xC001),
    DistanceModel = unchecked((uint)0xD000),
    SpeedOfSound = unchecked((uint)0xC003),
    DeferredUpdatesSOFT = unchecked((uint)0xC002),
    GainLimitSOFT = unchecked((uint)0x200E),
    NumResamplersSOFT = unchecked((uint)0x1210),
    DefaultResamplerSOFT = unchecked((uint)0x1211),
    ResamplerNameSOFT = unchecked((uint)0x1213),
    EventCallbackFunctionSOFT = unchecked((uint)0x19A2),
    EventCallbackUserParamSOFT = unchecked((uint)0x19A3),
    DebugLoggedMessagesEXT = unchecked((uint)0x19C7),
    DebugNextLoggedMessageLengthEXT = unchecked((uint)0x19C8),
    MaxDebugMessageLengthEXT = unchecked((uint)0x19C9),
    MaxDebugLoggedMessagesEXT = unchecked((uint)0x19CA),
    MaxDebugGroupStackDepthEXT = unchecked((uint)0x19CB),
    MaxLabelLengthEXT = unchecked((uint)0x19CC),
    ContextFlagsEXT = unchecked((uint)0x19CF),
}
