// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [Flags]
    [NativeName("Name", "DSTORAGE_PRIORITY")]
    public enum Priority : byte
    {
        [NativeName("Name", "DSTORAGE_PRIORITY_LOW")]
        PriorityLow = unchecked((byte) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DSTORAGE_PRIORITY_NORMAL")]
        PriorityNormal = 0x0,
        [NativeName("Name", "DSTORAGE_PRIORITY_HIGH")]
        PriorityHigh = 0x1,
        [NativeName("Name", "DSTORAGE_PRIORITY_REALTIME")]
        PriorityRealtime = 0x2,
        [NativeName("Name", "DSTORAGE_PRIORITY_FIRST")]
        PriorityFirst = unchecked((byte) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DSTORAGE_PRIORITY_LAST")]
        PriorityLast = 0x2,
        [NativeName("Name", "DSTORAGE_PRIORITY_COUNT")]
        PriorityCount = 0x4,
    }
}
