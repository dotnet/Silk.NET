// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagPENDINGMSG")]
    public enum PendingMsg : int
    {
        [Obsolete("Deprecated in favour of \"Cancelcall\"")]
        [NativeName("Name", "PENDINGMSG_CANCELCALL")]
        PendingmsgCancelcall = 0x0,
        [Obsolete("Deprecated in favour of \"Waitnoprocess\"")]
        [NativeName("Name", "PENDINGMSG_WAITNOPROCESS")]
        PendingmsgWaitnoprocess = 0x1,
        [Obsolete("Deprecated in favour of \"Waitdefprocess\"")]
        [NativeName("Name", "PENDINGMSG_WAITDEFPROCESS")]
        PendingmsgWaitdefprocess = 0x2,
        [NativeName("Name", "PENDINGMSG_CANCELCALL")]
        Cancelcall = 0x0,
        [NativeName("Name", "PENDINGMSG_WAITNOPROCESS")]
        Waitnoprocess = 0x1,
        [NativeName("Name", "PENDINGMSG_WAITDEFPROCESS")]
        Waitdefprocess = 0x2,
    }
}
