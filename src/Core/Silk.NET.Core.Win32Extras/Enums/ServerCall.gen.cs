// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagSERVERCALL")]
    public enum ServerCall : int
    {
        [Obsolete("Deprecated in favour of \"Ishandled\"")]
        [NativeName("Name", "SERVERCALL_ISHANDLED")]
        ServercallIshandled = 0x0,
        [Obsolete("Deprecated in favour of \"Rejected\"")]
        [NativeName("Name", "SERVERCALL_REJECTED")]
        ServercallRejected = 0x1,
        [Obsolete("Deprecated in favour of \"Retrylater\"")]
        [NativeName("Name", "SERVERCALL_RETRYLATER")]
        ServercallRetrylater = 0x2,
        [NativeName("Name", "SERVERCALL_ISHANDLED")]
        Ishandled = 0x0,
        [NativeName("Name", "SERVERCALL_REJECTED")]
        Rejected = 0x1,
        [NativeName("Name", "SERVERCALL_RETRYLATER")]
        Retrylater = 0x2,
    }
}
