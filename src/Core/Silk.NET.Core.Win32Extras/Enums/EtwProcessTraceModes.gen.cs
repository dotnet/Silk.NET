// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "ETW_PROCESS_TRACE_MODES")]
    public enum EtwProcessTraceModes : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "ETW_PROCESS_TRACE_MODE_NONE")]
        EtwProcessTraceModeNone = 0x0,
        [Obsolete("Deprecated in favour of \"RawTimestamp\"")]
        [NativeName("Name", "ETW_PROCESS_TRACE_MODE_RAW_TIMESTAMP")]
        EtwProcessTraceModeRawTimestamp = 0x1,
        [NativeName("Name", "ETW_PROCESS_TRACE_MODE_NONE")]
        None = 0x0,
        [NativeName("Name", "ETW_PROCESS_TRACE_MODE_RAW_TIMESTAMP")]
        RawTimestamp = 0x1,
    }
}
