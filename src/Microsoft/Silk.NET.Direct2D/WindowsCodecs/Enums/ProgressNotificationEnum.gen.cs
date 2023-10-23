// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICProgressNotification")]
    public enum ProgressNotificationEnum : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "WICProgressNotificationBegin")]
        ProgressNotificationBegin = 0x10000,
        [NativeName("Name", "WICProgressNotificationEnd")]
        ProgressNotificationEnd = 0x20000,
        [NativeName("Name", "WICProgressNotificationFrequent")]
        ProgressNotificationFrequent = 0x40000,
        [NativeName("Name", "WICProgressNotificationAll")]
        ProgressNotificationAll = unchecked((int) 0xFFFFFFFFFFFF0000),
        [NativeName("Name", "WICPROGRESSNOTIFICATION_FORCE_DWORD")]
        RogressnotificationForceDword = 0x7FFFFFFF,
    }
}
