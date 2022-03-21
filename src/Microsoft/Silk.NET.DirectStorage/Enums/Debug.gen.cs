// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [Flags]
    [NativeName("Name", "DSTORAGE_DEBUG")]
    public enum Debug : int
    {
        [NativeName("Name", "DSTORAGE_DEBUG_NONE")]
        DebugNone = 0x0,
        [NativeName("Name", "DSTORAGE_DEBUG_SHOW_ERRORS")]
        DebugShowErrors = 0x1,
        [NativeName("Name", "DSTORAGE_DEBUG_BREAK_ON_ERROR")]
        DebugBreakOnError = 0x2,
        [NativeName("Name", "DSTORAGE_DEBUG_RECORD_OBJECT_NAMES")]
        DebugRecordObjectNames = 0x4,
    }
}
