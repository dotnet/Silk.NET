// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectStorage
{
    [Flags]
    [NativeName("Name", "DSTORAGE_COMMAND_TYPE")]
    public enum CommandType : int
    {
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_NONE")]
        CommandTypeNone = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_REQUEST")]
        CommandTypeRequest = 0x0,
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_STATUS")]
        CommandTypeStatus = 0x1,
        [NativeName("Name", "DSTORAGE_COMMAND_TYPE_SIGNAL")]
        CommandTypeSignal = 0x2,
    }
}
