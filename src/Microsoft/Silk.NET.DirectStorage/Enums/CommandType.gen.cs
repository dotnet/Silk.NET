// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_COMMAND_TYPE")]
    public enum CommandType : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_NONE")]
        CommandTypeNone = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Request\"")]
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_REQUEST")]
        CommandTypeRequest = 0x0,
        [Obsolete("Deprecated in favour of \"Status\"")]
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_STATUS")]
        CommandTypeStatus = 0x1,
        [Obsolete("Deprecated in favour of \"Signal\"")]
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_SIGNAL")]
        CommandTypeSignal = 0x2,
        [Obsolete("Deprecated in favour of \"Event\"")]
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_EVENT")]
        CommandTypeEvent = 0x3,
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_NONE")]
        None = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_REQUEST")]
        Request = 0x0,
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_STATUS")]
        Status = 0x1,
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_SIGNAL")]
        Signal = 0x2,
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_EVENT")]
        Event = 0x3,
    }
}
