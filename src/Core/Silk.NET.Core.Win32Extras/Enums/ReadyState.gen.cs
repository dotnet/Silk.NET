// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagREADYSTATE")]
    public enum ReadyState : int
    {
        [Obsolete("Deprecated in favour of \"Uninitialized\"")]
        [NativeName("Name", "READYSTATE_UNINITIALIZED")]
        ReadystateUninitialized = 0x0,
        [Obsolete("Deprecated in favour of \"Loading\"")]
        [NativeName("Name", "READYSTATE_LOADING")]
        ReadystateLoading = 0x1,
        [Obsolete("Deprecated in favour of \"Loaded\"")]
        [NativeName("Name", "READYSTATE_LOADED")]
        ReadystateLoaded = 0x2,
        [Obsolete("Deprecated in favour of \"Interactive\"")]
        [NativeName("Name", "READYSTATE_INTERACTIVE")]
        ReadystateInteractive = 0x3,
        [Obsolete("Deprecated in favour of \"Complete\"")]
        [NativeName("Name", "READYSTATE_COMPLETE")]
        ReadystateComplete = 0x4,
        [NativeName("Name", "READYSTATE_UNINITIALIZED")]
        Uninitialized = 0x0,
        [NativeName("Name", "READYSTATE_LOADING")]
        Loading = 0x1,
        [NativeName("Name", "READYSTATE_LOADED")]
        Loaded = 0x2,
        [NativeName("Name", "READYSTATE_INTERACTIVE")]
        Interactive = 0x3,
        [NativeName("Name", "READYSTATE_COMPLETE")]
        Complete = 0x4,
    }
}
